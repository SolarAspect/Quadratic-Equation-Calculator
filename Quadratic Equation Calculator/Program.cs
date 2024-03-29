using System;

public class Program
{
    // Quadratic Equation Calculation
    public static string CalculateQuadratic(double a, double b, double c)
    {
        double discriminant = Math.Pow(b, 2) - (4 * a * c);
        
        // Solving for real solutions, test - 4ac area 
        if (discriminant >= 0)
            return $"x = {(-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a)}, {(-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a)}";
            
        else
        {
            if (Math.Sqrt(discriminant) % 1 == 0)
                return $"x = ({-b} + {Math.Sqrt(-(Math.Pow(b, 2) - 4 * a * c))}i) / {2 * a}, ({-b} - {Math.Sqrt(-(Math.Pow(b, 2) - 4 * a * c))}i) / {2 * a}";
            
            else
                return $"{-b} + i * sqrt({-(Math.Pow(b, 2) - 4 * a * c)}) / {2 * a}, {-b} - i * sqrt({-(Math.Pow(b, 2) - 4 * a * c)}) / {2 * a}";
        }
    }
    
    public static void Main(string[] args)
    {
        // Setup
        bool calcContinue = true;
        double aVer;
        double bVer;
        double cVer;

        // Title and Instructions
        Console.WriteLine(@"
   ____                 _           _   _          __                 _   _             
  /___ \_   _  __ _  __| |_ __ __ _| |_(_) ___    /__\_ _ _   _  __ _| |_(_) ___  _ __  
 //  / / | | |/ _` |/ _` | '__/ _` | __| |/ __|  /_\/ _` | | | |/ _` | __| |/ _ \| '_ \ 
/ \_/ /| |_| | (_| | (_| | | | (_| | |_| | (__  //_| (_| | |_| | (_| | |_| | (_) | | | |
\___,_\ \__,_|\__,_|\__,_|_|  \__,_|\__|_|\___| \__/\__, |\__,_|\__,_|\__|_|\___/|_| |_|
                                                       |_|                              
   ___      _            _       _                     _____                            
  / __\__ _| | ___ _   _| | __ _| |_ ___  _ __  /\   /\___ /                            
 / /  / _` | |/ __| | | | |/ _` | __/ _ \| '__| \ \ / / |_ \                            
/ /__| (_| | | (__| |_| | | (_| | || (_) | |     \ V / ___) |                           
\____/\__,_|_|\___|\__,_|_|\__,_|\__\___/|_|      \_/ |____/                            
        ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Welcome to version 3 of the Quadratic Equation Calculator console app. This version is more focused on making the code more easily readable and reusable.");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Instructions:\nThe following values for the quadratic function will be based on the function ax^2 + bx + c. \nEnter the values for a, b, and c as prompted.\nYou may need to simplify some fractional solutions as necesssary.");


        // Calculator loop
        while (calcContinue)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter value a:");
                Console.ForegroundColor = ConsoleColor.White;
                if (double.TryParse(Console.ReadLine(), out aVer))
                    break;
                Console.WriteLine("Enter a valid number for a.");
            }

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter value b:");
                Console.ForegroundColor = ConsoleColor.White;
                if (double.TryParse(Console.ReadLine(), out bVer))
                    break;
                Console.WriteLine("Enter a valid number for b.");
            }

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter value c:");
                Console.ForegroundColor = ConsoleColor.White;
                if (double.TryParse(Console.ReadLine(), out cVer))
                    break;
                Console.WriteLine("Enter a valid number for c.");
            }

            Console.WriteLine($"The values of x are: {CalculateQuadratic(aVer, bVer, cVer)}");

            // Confirm resubmission
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Do you want to enter another set of values? Y/N");
            if (Console.ReadLine().ToUpper() == "Y")
                continue;
            else
                calcContinue = false;
        }
    }
}