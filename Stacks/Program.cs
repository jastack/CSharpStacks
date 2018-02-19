using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            var newStack = new Stack();
            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);
            Console.WriteLine(newStack.Pop());
            Console.WriteLine(newStack.Pop());
            newStack.Clear();
            newStack.Push("hi");
            newStack.Push(null);
            Console.WriteLine(newStack.Pop());
            Console.WriteLine(newStack.Pop());
        }
    }
}
