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
            

            string MoveIn;
            while (ChessCS.MoveIn.End == 0 || ChessCS.MoveIn.End == 1)
            {
                ctable.TableShow();
                MoveIn move = new MoveIn(MoveIn = Console.ReadLine());
                Console.Clear();
            }
        }
    }
}