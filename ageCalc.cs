using System;
namespace oop1
{
  class Program
  {
    static void Main(string[] args)
    {
      calculatedAge();
    }
    public static void calculatedAge()
    {
      Console.WriteLine("Enter the current year: ");
      int currentYear = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter your year of birth: ");
      int yearOfBirth = Convert.ToInt32(Console.ReadLine());
      int age = currentYear - yearOfBirth;
      
      Console.WriteLine("Your age is: " + age);
    }
  }
}
