using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;
using System;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    //static or instance method? static for now so we don't have to worry about instantiation
    [TestMethod]
    // Test if Equilateral: All sides are equal;
    public void TriangleType_IsEquilateral_Equilateral()
    {
      Assert.AreEqual("equilateral", TriangleTracker.TriangleType(1,1,1));
    }
  [TestMethod]
    public void TriangleType_IsEquilateral_NotEquilateral()
    {
      Console.WriteLine($"testing not equilateral");
      
      Assert.AreNotEqual("equilateral", TriangleTracker.TriangleType(1,1,2));
    }
    // Test if Isosceles: Exactly 2 sides are equal;
     [TestMethod]
     public void TriangleType_IsIsosceles_Isosceles()
     {
       Assert.AreEqual("isosceles", TriangleTracker.TriangleType(1,1,2));
     }
     [TestMethod]
     public void TriangleType_IsIsosceles_NotIsosceles()
     {
       Assert.AreNotEqual("isosceles", TriangleTracker.TriangleType(1,3,2));
     }
    // Test if Scalene: No sides are equal.
    [TestMethod]
     public void TriangleType_IsScalene_Scalene()
     {
       Assert.AreEqual("scalene", TriangleTracker.TriangleType(4,3,2));
     }
    [TestMethod]
     public void TriangleType_IsScalene_NotScalene()
     {
       Assert.AreNotEqual("scalene", TriangleTracker.TriangleType(3,3,2));
     }
    // Test if it's not a triangle
    // edge cases? input: not an int, 
  }
}