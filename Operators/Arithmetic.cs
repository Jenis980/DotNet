using System;
namespace Operators
{
    public class OperatorTypes
    { 
      public void ToAdd(double a, double b)
      {
        double result = a + b;
        Console.WriteLine($"{a}+{b} = {result}");
      }
      public void ToSub(double a, double b)
      {
        double result  =  a - b;
        Console.WriteLine($"{a} - {b} = {result}");
      }
    }
}