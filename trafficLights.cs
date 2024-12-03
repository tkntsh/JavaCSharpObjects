using System;
namespace oop1
{
  class Program
  {
    static void Main(string[] args)
    {
      trafficLightCode();
    }

    //method to print traffic light codes
    public static void trafficLightCode()
    {
      string light = "red";

      //conditions to check what user should do when the robot is different colours
      if(light == "red")
      {
        Console.WriteLine("Stop at the robot");
      }
      else if(light == "amber")
      {
        Console.WriteLine("Approach robot with caution");
      }
      else if (light == "green")
      {
        Console.WriteLine("Pass the robot");
      }
    }
  }
}
