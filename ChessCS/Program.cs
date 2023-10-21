using System;
using System.Text;

namespace ChessCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ChessTable ctable = new ChessTable();
            ctable.TableShow();

            string MoveIn; 
            while(ChessCS.MoveIn.End == 0 || ChessCS.MoveIn.End == 1)
            {
                MoveIn move = new MoveIn(MoveIn = Console.ReadLine());
            }




          /*  if (stop1 == "move")
            {
                ctable.table[1, 3] = ChessTable.Empty;
                ctable.table[3, 3] = ChessTable.Pawn;
                Console.Clear();
                ctable.TableShow();
            }  */  
        }
    }
}