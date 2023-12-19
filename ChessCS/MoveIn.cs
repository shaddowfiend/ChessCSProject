using System;
using System.Text.RegularExpressions;

namespace ChessCS
{
    class MoveIn
    {
        public static int End = 0; // 0 = not check | 1 = check | 2 = check + mate
        public MoveIn(string move)
        {
            string[] patterns = { @"m p.*", @"m N.*", @"m B.*", @"m R.*", @"m Q.*", @"m K.*" };

            Regex regexPawn = new Regex(patterns[0]);
            Regex regexKnight = new Regex(patterns[1]);
            Regex regexBishop = new Regex(patterns[2]);
            Regex regexRook = new Regex(patterns[3]);
            Regex regexQueen = new Regex(patterns[4]);
            Regex regexKing = new Regex(patterns[5]);

           /* string[] varPawn = Regex.Split(Convert.ToString(move), patterns[0]);
            string[] varKnight = Regex.Split(move, patterns[1]);
            string[] varBishop = Regex.Split(move, patterns[2]);
            string[] varRook = Regex.Split(move, patterns[3]);
            string[] varQueen = Regex.Split(move, patterns[4]);
            string[] varKing = Regex.Split(move, patterns[5]);*/
           
            Match matchPawn = regexPawn.Match(Convert.ToString(move));
            Match matchKnight = regexKnight.Match(Convert.ToString(move));
            Match matchBishop = regexBishop.Match(Convert.ToString(move));
            Match matchRook = regexRook.Match(Convert.ToString(move));
            Match matchQueen = regexQueen.Match(Convert.ToString(move));
            Match matchKing = regexKing.Match(Convert.ToString(move));
            /*while (true)
            {
                if (matchPawn.Success)
                {
                    Control control = new Control(matchPawn.Value);
                }
                if (matchKnight.Success)
                {
                    Control control = new Control(matchKnight.Value);
                }
                if (matchBishop.Success)
                {
                    Control control = new Control(matchBishop.Value);
                }
                if (matchRook.Success)
                {
                    Control control = new Control(matchRook.Value);
                }
                if (matchQueen.Success)
                {
                    Control control = new Control(matchQueen.Value);
                }
                if (matchKing.Success)
                {
                    Control control = new Control(matchKing.Value);
                }
            }*/
        }
    }
}