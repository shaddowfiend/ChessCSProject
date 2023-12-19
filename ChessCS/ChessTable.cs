using System;

namespace ChessCS
{
    public class ChessTable
    {

        Figures[,] table = new Figures[8, 8] {
            {new Figures(Figures.Empty,0,0),new Figures(Figures.Empty,0,1),new Figures(Figures.Empty,0,2),new Figures(Figures.Empty,0,3),new Figures(Figures.Empty,0,4),new Figures(Figures.Empty,0,5),new Figures(Figures.Empty,0,6),new Figures(Figures.Empty,0,7) },
            {new Figures(Figures.Empty,1,0),new Figures(Figures.Empty,1,1),new Figures(Figures.Empty,1,2),new Figures(Figures.Empty,1,3),new Figures(Figures.Empty,1,4),new Figures(Figures.Empty,1,5),new Figures(Figures.Empty,1,6),new Figures(Figures.Empty,1,7) },
            {new Figures(Figures.Empty,2,0),new Figures(Figures.Empty,2,1),new Figures(Figures.Empty,2,2),new Figures(Figures.Empty,2,3),new Figures(Figures.Empty,2,4),new Figures(Figures.Empty,2,5),new Figures(Figures.Empty,2,6),new Figures(Figures.Empty,2,7) },
            {new Figures(Figures.Empty,3,0),new Figures(Figures.Empty,3,1),new Figures(Figures.Empty,3,2),new Figures(Figures.Empty,3,3),new Figures(Figures.Empty,3,4),new Figures(Figures.Empty,3,5),new Figures(Figures.Empty,3,6),new Figures(Figures.Empty,3,7) },
            {new Figures(Figures.Empty,4,0),new Figures(Figures.Empty,4,1),new Figures(Figures.Empty,4,2),new Figures(Figures.Empty,4,3),new Figures(Figures.Empty,4,4),new Figures(Figures.Empty,4,5),new Figures(Figures.Empty,4,6),new Figures(Figures.Empty,4,7) },
            {new Figures(Figures.Empty,5,0),new Figures(Figures.Empty,5,1),new Figures(Figures.Empty,5,2),new Figures(Figures.Empty,5,3),new Figures(Figures.Empty,5,4),new Figures(Figures.Empty,5,5),new Figures(Figures.Empty,5,6),new Figures(Figures.Empty,5,7) },
            {new Figures(Figures.Empty,6,0),new Figures(Figures.Empty,6,1),new Figures(Figures.Empty,6,2),new Figures(Figures.Empty,6,3),new Figures(Figures.Empty,6,4),new Figures(Figures.Empty,6,5),new Figures(Figures.Empty,6,6),new Figures(Figures.Empty,6,7) },
            {new Figures(Figures.Empty,7,0),new Figures(Figures.Empty,7,1),new Figures(Figures.Empty,7,2),new Figures(Figures.Empty,7,3),new Figures(Figures.Empty,7,4),new Figures(Figures.Empty,7,5),new Figures(Figures.Empty,7,6),new Figures(Figures.Empty,7,7) }
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