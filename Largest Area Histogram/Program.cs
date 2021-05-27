using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Area_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 1 };
            Solution S = new Solution();
            S.LargestRectangleArea(input);
        }
        public class Solution
        {
            Stack<int> stack = new Stack<int>();
            int[] output;
            public int LargestRectangleArea(int[] heights)
            {

                int[] right_index = NSR_Index(heights);
                stack.Clear();
                output = null;
                int[] left_index = NSL_Index(heights);
                int Max_Area = 0;
                int length = 0;
                for (int i = 0; i < right_index.Length; i++)
                {
                    length = right_index[i] - left_index[i] - 1;
                    Max_Area = Math.Max(Max_Area, (length * heights[i]));
                }
                return Max_Area;

            }
            private int[] NSR_Index(int[] input)
            {
                output = new int[input.Length];
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (i == input.Length - 1)
                    {
                        stack.Push(i);
                        output[i] = input.Length;
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
            private int[] NSL_Index(int[] input)
            {

                for (int i = 0; i <= input.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        stack.Push(i);
                        output[i] = -1;
                    }
                    else if (input[stack.Peek()] >= input[i])
                    {
                        while (stack.Count > 0 && input[stack.Peek()] >= input[i])
                        {
                            stack.Pop();
                        }
                        if (stack.Count == 0)
                            output[i] = -1;
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
}
