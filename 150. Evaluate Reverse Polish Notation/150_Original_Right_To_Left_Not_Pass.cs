public class Solution {
    public int EvalRPN(string[] tokens)
        {
            // solution 2: from right to left (more complex)
            // reference: https://en.wikipedia.org/wiki/Reverse_Polish_notation
            var stOperator = new Stack();
            var stOperand = new Stack();
            var pendingOperand = false;
            int iout, left, right;
            string opt = string.Empty;
            for (var i = tokens.Length - 1; i >= 0; i--)
            {
                if (int.TryParse(tokens[i], out iout))
                { //operand
                    if (pendingOperand)
                    {
                        left = iout;
                        right = (int)stOperand.Pop();
                        opt = (string)stOperator.Pop();
                        stOperand.Push(Calculate(left, right, opt));
                    }
                    else
                        stOperand.Push(int.Parse(tokens[i]));
                    pendingOperand = true;
                }
                else
                { //operator
                    pendingOperand = false;
                    stOperator.Push(tokens[i]);
                }
            }

            while(stOperand.Count > 1)
            {
                left = (int)stOperand.Pop();
                right = (int)stOperand.Pop();
                opt = (string)stOperator.Pop();
                stOperand.Push(Calculate(left, right, opt));
            }
            return (int)stOperand.Pop();
        }

        private int Calculate(int left, int right, string opt)
        {
            int result = 0;
            switch (opt)
            {
                case "+":
                    result = left + right;
                    break;
                case "-":
                    result = left - right;
                    break;
                case "*":
                    result = left * right;
                    break;
                case "/":
                    result = left / right;
                    break;
                default:
                    break;
            }
            return result;
        }
}