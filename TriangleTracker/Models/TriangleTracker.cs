using System;

namespace TriangleTracker
{
  public class TriangleTracker
  {
    public static string TriangleType(int sideOne, int sideTwo, int sideThree)
    {
      if (sideOne == sideTwo && sideTwo == sideThree)
      {
        return "equilateral";
      } 
      else if (sideOne == sideTwo || sideOne == sideThree || sideTwo == sideThree)
      {
        return "isosceles";
      } else {
         return "not a triangle";
      }
    }
  }
}