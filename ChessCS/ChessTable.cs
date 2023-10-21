using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessCS
{
    public class ChessTable
    {
        public static string Pawn = "  |p|  ";
        public static string Knight = "  |N|  ";
        public static string Bishop = "  |B|  ";
        public static string Rook = "  |R|  ";
        public static string Queen = "  |Q|  ";
        public static string King = "  |K|  ";
        public static string Empty = "   0   ";
        public string[,] table = {
            {Rook,Knight,Bishop,Queen,King,Bishop,Knight,Rook},
            {Pawn,Pawn,Pawn,Pawn,Pawn,Pawn,Pawn,Pawn},
            {Empty,Empty,Empty,Empty,Empty,Empty,Empty,Empty},
            {Empty,Empty,Empty,Empty,Empty,Empty,Empty,Empty},
            {Empty,Empty,Empty,Empty,Empty,Empty,Empty,Empty},
            {Empty,Empty,Empty,Empty,Empty,Empty,Empty,Empty},
            {Pawn,Pawn,Pawn,Pawn,Pawn,Pawn,Pawn,Pawn},
            {Rook,Knight,Bishop,Queen,King,Bishop,Knight,Rook},
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
    }
}