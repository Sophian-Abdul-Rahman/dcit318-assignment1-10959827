/* Name: Sophian Abdul Rahman
   Student ID: 10959827
   Course: DCIT318
*/
using System;

class GradeCalculator
{
    static void Main()
    {
        Console.Write("Enter a numerical grade (0-100): ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Grade: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Grade: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }
    }
}
