using System;

namespace StudentGradingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // First, I'm asking the user to type in the student's name
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            // Setting up an array to hold the 3 marks and a variable for the sum
            double[] marks = new double[3];
            double totalMarks = 0;

            // Using a loop to get all 3 marks so I don't have to repeat code
            for (int i = 0; i < 3; i++)
            {
                bool isValid = false;
                // Using a while loop to keep asking if they type something that isn't a number
                while (!isValid)
                {
                    Console.Write($"Enter mark for Subject {i + 1}: ");
                    string input = Console.ReadLine();

                    // TryParse helps prevent the app from crashing if the user enters letters
                    if (double.TryParse(input, out marks[i]))
                    {
                        totalMarks += marks[i]; // Adding the mark to our running total
                        isValid = true; // Input is good, so we can move to the next subject
                    }
                    else
                    {
                        // Error message for when the user puts in invalid data
                        Console.WriteLine("Invalid input. Please enter a numeric value.");
                    }
                }
            }

            // Doing the math: total divided by 3 for the average
            double averageMarks = totalMarks / 3;

            // Checking if they passed (50 or more) or failed (less than 50)
            string result = averageMarks >= 50 ? "PASS" : "FAIL";

            // Now printing everything out to match the layout in the screenshot
            Console.WriteLine("\n===== STUDENT RESULTS =====");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Total Marks: {totalMarks}");

            // The screenshot shows a comma for the decimal, so I'm replacing the dot
            Console.WriteLine($"Average Marks: {averageMarks:N1}".Replace('.', ','));

            Console.WriteLine($"Result: {result}");

            // Adding the timestamp and formatting it exactly like the requirements
            Console.WriteLine($"Result Issued At: {DateTime.Now:dd MMM yyyy HH:mm:ss}");

            // Keeping the console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}