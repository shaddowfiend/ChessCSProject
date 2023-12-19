using System.Collections.Generic;

namespace ChessCS
{
    class Control
    {
        public Control(string move)
        {
            System.Console.WriteLine(move);
        }
        public static void Convert()
        {
            Dictionary<string, int> convert = new Dictionary<string, int>()
            {
                {"1",0 },
                {"2",1 },
                {"3",2 },
                {"4",3 },
                {"5",4 },
                {"6",5 },
                {"7",6 },
                {"8",7 },
            };
            Dictionary<string, int> convertL = new Dictionary<string, int>()
            {
                {"a",0},
                {"b",1},
                {"c",2 },
                {"d",3 },
                {"e",4 },
                {"f",5 },
                {"g",6 },
                {"h",7 },
            };
        }
    }
}