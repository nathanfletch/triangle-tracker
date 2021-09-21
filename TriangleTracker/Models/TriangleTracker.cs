namespace TriangleTracker
{
  public class TriangleTracker
  {
    public static bool IsTriangle(int sideOne, int sideTwo, int sideThree)
    {
      return sideOne == sideTwo && sideTwo == sideThree;
    }
  }
}