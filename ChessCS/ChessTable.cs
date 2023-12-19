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
        public void TableChange()  //Changing table while status is not checkmate
        {
            
        }
        public void TableShow()
        {
            for (int i = 0; i < table.GetLength(0); i++) 
            {
                for (int j = 0; j < table.GetLength(1); j++) 
                {
                    Console.Write(table[i,j]);
                }
                Console.WriteLine();
            }
        }
        /*private void DrawChessboard()
        {
            int rows = table.GetLength(0);
            int cols = table.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    string cellValue = table[row, col];
                    if ((row + col) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.Write(cellValue.PadRight(8));
                }

                Console.ResetColor();
                Console.WriteLine(); 
            }
        }*/
    }
}