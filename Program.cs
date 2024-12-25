using System;
class Program
{
    static void Main()
    {

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("Enter the number of rows: ");
        var rows = int.TryParse(Console.ReadLine(), out int numberofrows);
        if (!rows)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" the input cannot be converted to intiger ");
            return;
        }
        Console.Beep();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("Enter the number of columns: ");
        Console.Beep();
        var cols = int.TryParse(Console.ReadLine(), out int numberofcols);
        if (!cols)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" the input cannot be converted to intiger ");
            return;
        }
        int[,] matrix = new int[numberofrows, numberofcols];
        Random rand = new Random();
        for (int A = 0; A < numberofrows; A++)
        {
            for (int B = 0; B < numberofcols; B++)
            {
                matrix[A, B] = rand.Next(0, 100);
            }
        }
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("The randomly generated matrix is:");
        for (int A = 0; A < numberofrows; A++)
        {
            for (int B = 0; B < numberofcols; B++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(matrix[A, B] + "\t");
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.Beep();
            Console.Beep();
        }
    }
}