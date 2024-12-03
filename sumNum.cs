using System;
namespace oop1
{
  class Program
  {
    static void Main(string[] args)
    {
      //calling method to print values
      calculationOfNumbers();
    }

    //static method to add hard coded numbers together
    public static void calculationOfNumbers()
    {
      int val1 = 22;
      int val2 = 12;
      int val3 = 2;
      int val4 = 24;
      int sum = val1 + val2 + val3 + val4;
      //printing sum
      Console.WriteLine("Varaible 1: " + val1 + "\nVariable 2: " + val2 +
      "\nVaraible 3: " + val3 + "\nVaraible 4: " + val4 + "\nThe sum of these varaibles is: "
      + sum);
    }
  }
}
