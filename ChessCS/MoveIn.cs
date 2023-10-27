using System;
using System.Text.RegularExpressions;

namespace ChessCS
{
    class MoveIn
    {
        public static int End = 0; // 0 = not check | 1 = check | 2 = check + mate
        public MoveIn(string move)
        {
            string patternPawn = @"m p.*";
            string[] moves = Regex.Split(move, patternPawn);

            Regex regex = new Regex(patternPawn);
            Match matchpawn = regex.Match(move);

            if (matchpawn.Success)
            {
                Console.WriteLine("Correct pattern " + matchpawn.Value);
            }
            string moved = matchpawn.Value;
        }
    }
}
