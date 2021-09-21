using System;

namespace TriangleTracker
{
  public class TriangleTracker
  {
    public static string TriangleType(int sideOne, int sideTwo, int sideThree)
    {
      if (sideOne == sideTwo && sideTwo == sideThree)
      {
        Console.WriteLine($"is eq");
        return "equilateral";
      } 
      else 
      {
        Console.WriteLine($"not eq");
        
        return "not a triangle";
      }
    }
  }
}