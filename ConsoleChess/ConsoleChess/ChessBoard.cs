using System;
using static System.Linq.Enumerable;
using Range = System.Range;

namespace ConsoleChess
{
    public class ChessBoard
    {
        public int CellWidth { get; set; } = 5;
        public int BoardWidth { get; set; } = 8;
        public int BoardHeight { get; set; } = 8;
        public int[,] Board { get; private set; }

        public void DisplayBoard()
        {
            foreach (var i in Range(1, BoardHeight))
            {
                PrintHeader();
                Console.WriteLine();
                PrintPlaceholder();
                Console.WriteLine();
            }
            PrintHeader();
        }

        private void PrintPlaceholder(char linePrefix, ChessPiece[] pieces)
        {
            
            // Prefixed whitespaces
            foreach (var i in Range(1, 3))
                Console.Write(' ');
            // Placeholder line
            foreach (var i in Range(1, 8))
            {
                Console.Write('|');
                foreach (var j in Range(1,5))
                {
                    Console.Write(' ');
                }
            }
            Console.Write('|');
        }

        private void PrintHeader()
        {
            // Prefixed whitespaces
            foreach (var i in Range(1, 3))
                Console.Write(' ');
            // Header line
            foreach (var i in Range(1, BoardWidth))
            {
                Console.Write('+');
                foreach (var j in Range(1, CellWidth))
                    Console.Write('-');
            }
            Console.Write('+');
        }

        public static bool CheckBounds(int x, int y)
        {
            return x >= 0 && x <= 7 && y >= 0 && y <= 7;
        }
    }
}