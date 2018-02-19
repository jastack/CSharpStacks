using System;
using System.Collections.Generic;

namespace Stacks
{
    public class Stack
    {
        private List<object> MyStack { get; set; }

        public Stack()
        {
            MyStack = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
                Console.WriteLine("Can't add null to stack");
            else
                MyStack.Add(obj);
        }

        public object Pop()
        {
            var index = MyStack.Count - 1;
            try
            {
                var LastElement = MyStack[index];
                MyStack.RemoveAt(index);
                return LastElement;
            }
            catch (Exception)
            {
                var message = "Stack is empty!";
                Console.WriteLine(message);
                return message;
            }
                
        }

        public void Clear()
        {
            MyStack = new List<object>();
        }
    }
}
