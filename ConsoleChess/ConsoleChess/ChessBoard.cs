namespace ConsoleChess
{
    public class ChessBoard
    {
        public bool CheckBounds(int x, int y)
        {
            return x >= 0 && x <= 7 && y >= 0 && y <= 7;
        }
    }
}