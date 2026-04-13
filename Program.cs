using System;

namespace ArchitectArithmetic
{
  class Program
  {
      // Task 1: Rectangles
      static double React(double length, double width)
      {
        return length * width;
      }

      // Task 2: Circle
      static double Circle(double radius)
      {
        return Math.PI * Math.Pow(radius, 2);
      }

      // Task 3: Triangle
      static double Triangle(double bottom, double height)
      {
        return 0.5 * bottom * height;
      }

    public static void Main(string[] args)
    {
      // Simple tests from Task 4
      Console.WriteLine(React(4, 5)); // 20
      Console.WriteLine(Circle(4)); // ~50.265...
      Console.WriteLine(Triangle(10, 9)); // 45
    }
  }
}

