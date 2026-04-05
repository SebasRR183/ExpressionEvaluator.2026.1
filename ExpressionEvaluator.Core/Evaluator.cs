namespace ExpressionEvaluator.Core;

public class Evaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = InfixToPostfix(infix);
        return EvaluatePostfix(postfix);
    }

    private static string InfixToPostfix(string infix)
    {
        var postFix = string.Empty;
        var stack = new Stack<char>();
        for (int i = 0; i < infix.Length; i++)
        {
            char item = infix[i];
            if (char.IsDigit(item) || item == '.')
            {
                postFix += item;
                if (i + 1 == infix.Length || (!char.IsDigit(infix[i + 1]) && infix[i + 1] != '.'))
                    postFix += " ";
            }
            else if (IsOperator(item))
            {
                if (stack.Count == 0 || item == '(')
                {
                    stack.Push(item);
                }
                else
                {
                    if (item == ')')
                    {
                        while (stack.Count > 0 && stack.Peek() != '(') postFix += stack.Pop() + " ";
                        if (stack.Count > 0) stack.Pop();
                    }
                    else
                    {
                        // EL ERROR ESTABA AQUÍ: Se debe usar WHILE para limpiar la pila 
                        // y validar que no esté vacía ni sea un '(' antes de pedir la prioridad.
                        while (stack.Count > 0 && stack.Peek() != '(' && PriorityStack(stack.Peek()) >= PriorityInfix(item))
                        {
                            postFix += stack.Pop() + " ";
                        }
                        stack.Push(item);
                    }
                }
            }
        }
        while (stack.Count > 0) postFix += stack.Pop() + " ";
        return postFix;
    }

    private static int PriorityStack(char item) => item switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Sintax error.")
    };

    private static int PriorityInfix(char item) => item switch
    {
        '^' => 4,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 5,
        _ => throw new Exception("Sintax error.")
    };

    private static double EvaluatePostfix(string postfix)
    {
        var stack = new Stack<double>();
        var tokens = postfix.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (var token in tokens)
        {
            if (token.Length == 1 && IsOperator(token[0]))
            {
                var b = stack.Pop();
                var a = stack.Pop();
                stack.Push(token[0] switch
                {
                    '+' => a + b,
                    '-' => a - b,
                    '*' => a * b,
                    '/' => a / b,
                    '^' => Math.Pow(a, b),
                    _ => throw new Exception("Sintax error.")
                });
            }
            else
            {
                stack.Push(double.Parse(token, System.Globalization.CultureInfo.InvariantCulture));
            }
        }
        return stack.Pop();
    }

    private static bool IsOperator(char item) => "+-*/^()".Contains(item);
}