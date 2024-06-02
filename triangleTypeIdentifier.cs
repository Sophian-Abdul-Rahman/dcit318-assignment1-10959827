/* Name: Sophian Abdul Rahman
   Student ID: 10959827
   Course: DCIT318 */

using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.Write("Enter side 1 of the triangle: ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("Enter side 2 of the triangle: ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("Enter side 3 of the triangle: ");
        int side3 = int.Parse(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is Equilateral.");
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            Console.WriteLine("The triangle is Isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is Scalene.");
        }
    }
}
