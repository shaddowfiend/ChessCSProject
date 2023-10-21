using System;
using System.Text.RegularExpressions;

namespace ChessCS
{
    class MoveIn
    {
        public static int End = 0; // 0 = not check | 1 = check | 2 = check + mate
        public MoveIn(string move)
        {
            string pattern = @"m\. ";
            string[] moves = Regex.Split(move, pattern);

        }
    }
}