namespace ChessCS
{
    public class Figures
    {
        public static string Pawn = " |p| ";
        public static string Knight = " |N| ";
        public static string Bishop = " |B| ";
        public static string Rook = " |R| ";
        public static string Queen = " |Q| ";
        public static string King = " |K| ";
        public static string Empty = "  0  ";
        
        public int Row { get; set; }
        public int Col { get; set; }
        public string Name { get; private set; }

        public Figures(string name, int row, int col)
        {
            Name = name;
            Row = row;
            Col = col;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}