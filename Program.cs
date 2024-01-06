using System;

class Program
{
    static void Main()
    {
        int numRows;

        // Prompt user for the number of rows with validation
        do
        {
            Console.Write("Enter the number of rows for Pascal's Triangle (a positive integer): ");
        } while (!int.TryParse(Console.ReadLine(), out numRows) || numRows <= 0);

        PrintPascalsTriangle(numRows);
    }

    static void PrintPascalsTriangle(int numRows)
    {
        for (int i = 0; i < numRows; i++)
        {
            int number = 1;
            for (int j = 0; j < numRows - i; j++)
            {
                Console.Write("   "); // Print spaces for better alignment
            }

            for (int k = 0; k <= i; k++)
            {
                Console.Write($"   {number,3}");
                number = number * (i - k) / (k + 1);
            }

            Console.WriteLine();
        }
    }
}
