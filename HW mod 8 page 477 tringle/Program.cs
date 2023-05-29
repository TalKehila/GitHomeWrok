using System;

class RightAlignedTriangle
{
    static void Main()
    {
        // Get input from user
        Console.Write("Enter number of rows: ");
        int numRows = int.Parse(Console.ReadLine());

        // Loop through rows
        for (int i = 1; i <= numRows; i++)
        {
            // Print spaces to right-align
            for (int j = 1; j <= numRows - i; j++)
            {
                Console.Write(" ");
            }

            // Print asterisks for this row
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }

            // Start a new line
            Console.WriteLine();
        }

        // Wait for user input before closing
        Console.ReadLine();
    }
}