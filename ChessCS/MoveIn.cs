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
            string patternKnight = @"m N.*";
            string patternBishop = @"m B.*";
            string patternRook = @"m R.*";
            string patternQueen = @"m Q.*";
            string patternKing = @"m K.*";
            
            Regex regexPawn = new Regex(patternPawn);
            Regex regexKnight = new Regex(patternKnight);
            Regex regexBishop = new Regex(patternBishop);
            Regex regexRook = new Regex(patternRook);
            Regex regexQueen = new Regex(patternQueen);
            Regex regexKing = new Regex(patternKing);

            /*string[] varPawn = Regex.Split(move, patternPawn);
            string[] varKnight = Regex.Split(move, patternKnight);
            string[] varBishop = Regex.Split(move, patternBishop);
            string[] varRook = Regex.Split(move, patternRook);
            string[] varQueen = Regex.Split(move, patternQueen);
            string[] varKing = Regex.Split(move, patternKing);*/

            Match matchPawn = regexPawn.Match(move);
            Match matchKnight = regexKnight.Match(move);
            Match matchBishop = regexBishop.Match(move);
            Match matchRook = regexRook.Match(move);
            Match matchQueen = regexQueen.Match(move);
            Match matchKing = regexKing.Match(move);

            
        }
    }
}