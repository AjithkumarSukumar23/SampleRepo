using System;
using System.Diagnostics;

namespace Project01_Introduction
{
    // All organizing structures use { and } to define their boundaries
    class L1_Program
    {
        // All .NET programs begin with the main method
        // It looks like this main
        static void Main(string[] args)
        {
            // example 0 - first program
            Console.WriteLine("Hello World!");
            // Console.ReadKey();
            // Debug.WriteLine("Hello World!");

            // obtaining user input
            Console.WriteLine("Please provide your input");
            string userInput = Console.ReadLine();

            // parsing to specific data types
            int inputNumber = Convert.ToInt32(userInput);

            // parsing with error handling
            Console.WriteLine("Please provide your input");
            string userInputToCheck = Console.ReadLine();

            try
            {
                int inputNumberChecked = Convert.ToInt32(userInputToCheck);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // example 1 - simple computation
            // M disambiguates between double and decimal
            decimal income = 10000000.45M;
            decimal taxRate = 0.1M;
            decimal taxLiability = income * taxRate;
            Debug.WriteLine("Tax liability is " + taxLiability);

            // example 2 - API usage
            double rate = 0.06;
            double doublingTime = Math.Log(2) / Math.Log(1 + rate);

            Debug.WriteLine("Doubling time is " + doublingTime + " years");



            // Exercise 1
            // Calculate the area of a triangle using Heron's formula
            // Area = SquareRoot(s * (s-a) * (s-b) * (s-c)) where s=(a+b+c)/2 and a,b,c are the sides of the triangle
            // Eg. a=3, b=4, c=5. Area = 6

            //Write your code here



            // Input the lengths of the sides of the triangle
            Console.WriteLine("Enter the lengths of the sides of the triangle:");

            Console.Write("Length of side a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Length of side b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Length of side c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Calculate the semi-perimeter
            double s = (a + b + c) / 2;

            // Calculate the area using Heron's formula
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            // Display the area of the triangle
            Console.WriteLine($"The area of the triangle is: {area}");

        }
    }
}


