using System;
namespace AdditionOp
{
    class Program
    {
        static void Main(String[] args)
        {
            AdditionOp Obj1 = new AdditionOp();
            int result = Obj1.Add(1,2);
            Console.WriteLine($"Result is {result}");
        }
    }
}