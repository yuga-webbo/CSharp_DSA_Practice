using System;
using System.Collections.Generic;

class ReverseStack
{
    public static void InsertAtBottom(Stack<int> stack, int item)
    {
        if (stack.Count == 0)
        {
            stack.Push(item);
        }
        else
        {
            int temp = stack.Pop();
            InsertAtBottom(stack, item);
            stack.Push(temp);
        }
    }

    public static void ReverseStackRecursive(Stack<int> stack)
    {
        if (stack.Count <= 1)
        {
            return;
        }
        int temp = stack.Pop();
        ReverseStackRecursive(stack);
        InsertAtBottom(stack, temp);
    }

    public static void Main(string[] args)
    {
        Stack<int> St = new Stack<int>();
        St.Push(3);
        St.Push(2);
        St.Push(1);
        St.Push(7);
        St.Push(6);

        ReverseStackRecursive(St);

        foreach (int item in St)
        {
            Console.Write(item + " "); // Output: 6 7 1 2 3
        }
    }
}

