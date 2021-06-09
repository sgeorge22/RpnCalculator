using System;
using System.Collections.Generic;

namespace RpnCalculator
{
    class Program
    {
            static int op1 = 0;
            static int op2 = 0;
            static int ans = 0;
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            foreach(var arg in args)
            {
                switch(arg.Substring(0, 1))//this is saying to just get the first char of the string 0 is the index , 1 is when to stop
                {
                        //process the operator
                    case "+":
                        var op1 = stack.Pop();
                        var op2 = stack.Pop();
                        var ans = op1 + op2;
                        stack.Push(ans);
                        break;
                    case "-":
                        op1 = stack.Pop();
                        op2 = stack.Pop();
                        ans = op1 - op2;
                        stack.Push(ans);
                        break;
                    case "*":
                        op1 = stack.Pop();
                        op2 = stack.Pop();
                        ans = op1 * op2;
                        stack.Push(ans);
                        break;
                    case "/":
                        op1 = stack.Pop();
                        op2 = stack.Pop();
                        ans = op1 / op2;
                        stack.Push(ans);
                        break;
                        //Convert to integer
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        int i;
                        var converted = int.TryParse(arg, out i);
                        if (!converted) continue;
                        stack.Push(i);
                        break;
                    default:
                        //throw it away
                        break;
                }
                
                
            }
                ans = stack.Pop();
                Console.WriteLine($"{ans}");
            
        }
    }
}
