using ChessMVC.Models;

namespace ChessMVC.Views
{
    internal class PieceView
    {
        public static void DisplayPieces(List<PieceModel> pieces)
        {
            foreach (PieceModel piece in pieces)
            {
                Console.WriteLine($"ID: {piece.Id}, NAME {piece.Name}, COLOR: {(piece.IsWhitePiece ? "White" : "Black")}");
            }
        }
    }
}
