using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] {1,0,1,0,0};
            solution S = new solution();
            S.NSR_Index(input);


        }
        class solution
        {
            public int[] NGR(int[] input)
            {
                Stack<int> stack = new Stack<int>();
                int[] output = new int[input.Length];
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (i == input.Length - 1)
                    {
                        stack.Push(input[i]);
                        output[i] = -1;
                    }
                    else if (stack.Peek() < input[i])
                    {
                        while (stack.Count > 0 && stack.Peek() < input[i])
                        {
                            stack.Pop();
                        }
                        output[i] = stack.Peek();
                        stack.Push(input[i]);
                    }
                    else
                    {
                        output[i] = stack.Peek();
                        stack.Push(input[i]);
                    }
                }

                return output;
            }
            public int[] NSR(int[] input)
            {
                Stack<int> stack = new Stack<int>();
                int[] output = new int[input.Length];
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (i == input.Length - 1)
                    {
                        stack.Push(input[i]);
                        output[i] = -1;
                    }
                    else if (stack.Peek() > input[i])
                    {
                        while (stack.Count > 0 && stack.Peek() > input[i])
                        {
                            stack.Pop();
                        }
                        if (stack.Count == 0)
                            output[i] = -1;
                        else
                            output[i] = stack.Peek();
                        stack.Push(input[i]);
                    }
                    else
                    {
                        output[i] = stack.Peek();
                        stack.Push(input[i]);
                    }
                }

                return output;
            }

            public int[] NGL(int[] input)
            {
                Stack<int> stack = new Stack<int>();
                int[] output = new int[input.Length];
                for (int i =0; i <= input.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        stack.Push(input[i]);
                        output[i] = -1;
                    }
                    else if (stack.Peek() < input[i])
                    {
                        while (stack.Count > 0 && stack.Peek() < input[i])
                        {
                            stack.Pop();
                        }
                        if (stack.Count == 0)
                            output[i] = -1;
                        else
                            output[i] = stack.Peek();
                            stack.Push(input[i]);
                    }
                    else
                    {
                        output[i] = stack.Peek();
                        stack.Push(input[i]);
                    }
                }

                return output;
            }

            public int[] NSL(int[] input)
            {
                Stack<int> stack = new Stack<int>();
                int[] output = new int[input.Length];
                for (int i = 0; i <= input.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        stack.Push(input[i]);
                        output[i] = -1;
                    }
                    else if (stack.Peek() > input[i])
                    {
                        while (stack.Count > 0 && stack.Peek() > input[i])
                        {
                            stack.Pop();
                        }
                        if (stack.Count == 0)
                            output[i] = -1;
                        else
                            output[i] = stack.Peek();
                        stack.Push(input[i]);
                    }
                    else
                    {
                        output[i] = stack.Peek();
                        stack.Push(input[i]);
                    }
                }

                return output;
            }

            public int[] NSR_Index(int[] input)
            {
         

                Stack<int> stack = new Stack<int>();
                int[] output = new int[input.Length];
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (i == input.Length - 1)
                    {
                        stack.Push(i);
                        output[i] =input.Length;
                    }
                    else if (input[stack.Peek()] >= input[i])
                    {
                        while (stack.Count > 0 && input[stack.Peek()] >= input[i])
                        {
                            stack.Pop();
                        }
                        if (stack.Count == 0)
                            output[i] = input.Length;
                        else
                            output[i] = stack.Peek();
                           stack.Push(i);
                    }
                    else
                    {
                        output[i] = stack.Peek();
                        stack.Push(i);
                    }
                }

                return output;
            }


        }
       
    }

    internal interface IList<T1, T2>
    {
    }

    internal class retun
    {
    }
}
