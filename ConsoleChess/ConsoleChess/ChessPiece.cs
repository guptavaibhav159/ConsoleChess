namespace ConsoleChess
{
    public abstract class ChessPiece
    {
        public bool IsWhite { get; }
        public (int, int) Position { get; }
        public int[] RelativeMovement { get; set; }
        public char Symbol { get; }

        public ChessPiece(bool isWhite, (int, int) position, char symbol)
        {
            IsWhite = isWhite;
            Position = position;
            Symbol = symbol;
        }

        public abstract void CalculateRelativeMovement();
    }
}