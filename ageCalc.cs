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
      //asking user to enter current year and store value
      Console.WriteLine("Enter the current year: ");
      int currentYear = Convert.ToInt32(Console.ReadLine());
      //asking user to enter DOB and store value
      Console.WriteLine("Enter your year of birth: ");
      int yearOfBirth = Convert.ToInt32(Console.ReadLine());
      //calc age
      int age = currentYear - yearOfBirth;

      //printing out their age
      Console.WriteLine("Your age is: " + age);
    }
  }
}
