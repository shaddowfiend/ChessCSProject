using System;

namespace ChessCS
{
    public class ChessTable
    {

        Figures[,] table = new Figures[8, 8] {
            {new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty) },
            {new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty) },
            {new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty) },
            {new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty) },
            {new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty) },
            {new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty) },
            {new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty) },
            {new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty),new Figures(Figures.Empty) }
        };
        public void TableShow()
        {
            for (int row = 0; row < table.GetLength(0); row++) 
            {
                for (int col = 0; col < table.GetLength(1); col++) 
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(table[row, col]?.ToString() ?? Figures.Empty);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}