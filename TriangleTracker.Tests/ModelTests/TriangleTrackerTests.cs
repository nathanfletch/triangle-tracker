using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    //static or instance method? static for now so we don't have to worry about instantiation
    [TestMethod]
    // Test if Equilateral: All sides are equal;
    public void IsTriangle_IsEquilateral_True()
    {
      Assert.AreEqual(true, TriangleTracker.IsTriangle(1,1,1));
    }
    // Test if Isosceles: Exactly 2 sides are equal;
    // Test if Scalene: No sides are equal.
    // Test if it's not a triangle
    // edge cases? input: not an int, 
  }
}