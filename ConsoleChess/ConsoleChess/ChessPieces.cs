namespace ConsoleChess
{
    public class Rook : ChessPiece
    {
        public Rook(bool isWhite, (int, int) position) : base(isWhite, position, isWhite ? '♖' : '♜')
        {
            CalculateRelativeMovement();
        }

        public sealed override void CalculateRelativeMovement()
        {
            if (IsWhite)
            {
                if (Position.Item2 == 1)
                    RelativeMovement = new (int, int)[]
                    {
                        (Position.Item1, Position.Item2 + 1),
                        (Position.Item1, Position.Item2 + 2)
                    };
                else
                    RelativeMovement = new (int, int)[]
                    {
                        (Position.Item1, Position.Item2 + 1)
                    };
            }
            else
            {
                if (Position.Item2 == 6)
                    RelativeMovement = new (int, int)[]
                    {
                        (Position.Item1, Position.Item2 - 1),
                        (Position.Item1, Position.Item2 - 2)
                    };
                else
                    RelativeMovement = new (int, int)[]
                    {
                        (Position.Item1, Position.Item2 - 1)
                    };
            }
        }
    }
}