using System.Collections;

namespace ConsoleChess
{
    public class King : ChessPiece
    {
        public King(bool isWhite, (int, int) position) : base(isWhite, position, isWhite ? '♔' : '♚')
        {
            CalculateRelativeMovement();
        }

        public sealed override void CalculateRelativeMovement()
        {
            var possibleMoves = new ArrayList();
            
            if (ChessBoard.CheckBounds(Position.Item1 + 1, Position.Item2))
                possibleMoves.Add((Position.Item1 + 1, Position.Item2));
            if (ChessBoard.CheckBounds(Position.Item1, Position.Item2 + 1))
                possibleMoves.Add((Position.Item1, Position.Item2 + 1));
            
            if (ChessBoard.CheckBounds(Position.Item1 - 1, Position.Item2))
                possibleMoves.Add((Position.Item1 - 1, Position.Item2));
            if (ChessBoard.CheckBounds(Position.Item1, Position.Item2 - 1))
                possibleMoves.Add((Position.Item1, Position.Item2 - 1));
            
            if (ChessBoard.CheckBounds(Position.Item1 + 1, Position.Item2 + 1))
                possibleMoves.Add((Position.Item1 + 1, Position.Item2 + 1));
            if (ChessBoard.CheckBounds(Position.Item1 - 1, Position.Item2 - 1))
                possibleMoves.Add((Position.Item1 - 1, Position.Item2 - 1));
            
            if (ChessBoard.CheckBounds(Position.Item1 + 1, Position.Item2 - 1))
                possibleMoves.Add((Position.Item1 + 1, Position.Item2 - 1));
            if (ChessBoard.CheckBounds(Position.Item1 - 1, Position.Item2 + 1))
                possibleMoves.Add((Position.Item1 - 1, Position.Item2 + 1));

            RelativeMovement = new (int, int)[possibleMoves.Count];
            var i = 0;
            foreach ((int, int) move in possibleMoves)
            {
                RelativeMovement[i] = move;
                i++;
            }    
        }
    }

    public class Rook : ChessPiece
    {
        public Rook(bool isWhite, (int, int) position) : base(isWhite, position, isWhite ? '♖' : '♜')
        {
            CalculateRelativeMovement();
        }

        public sealed override void CalculateRelativeMovement()
        {
            var hasMoved = HasMoved();
            RelativeMovement = new (int, int)[hasMoved ? 1 : 2];
            RelativeMovement[0] = (Position.Item1, IsWhite ? Position.Item2 + 1 : Position.Item2 - 1);
            if (!hasMoved)
            {
                RelativeMovement[1] = (Position.Item1, IsWhite ? Position.Item2 + 2 : Position.Item2 - 2);
            }
        }

        private bool HasMoved()
        {
            return IsWhite ? Position.Item2 == 1 : Position.Item2 == 6;
        }
    }
}