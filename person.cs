using System;
namespace oop1
{
  class Program
  {
    static void Main(string[] args)
    {
      Person man = new Person();
      string newName = man.GetName();
      int newAge = man.GetAge();
      man.PrintMessage(newName, newAge);
    }
  }
  
  //create a person with age and name details
  class Person
  {
    int age = 0;
    string name = "";
    
    public Person()
    {
      //PrintMessage();
    }
    
    //prints out details of the person
    public void PrintMessage(string name, int age)
    {
      Console.WriteLine("Name is: " + name + " Age is: " + age);
    }
    
    public string GetName()
    {
      Console.WriteLine("Enter your name: ");
      
      name = Console.ReadLine();
      return name;
    }
    
    public int GetAge()
    {
      Console.WriteLine("Enter your age: ");
      
      try
      {
        age = Convert.ToInt32(Console.ReadLine());
        return age;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      finally
      {
        Console.WriteLine("Error!");
      }
      return -1;
    }
  }
}
