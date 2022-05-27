using ChessMVC.Models;
using ChessMVC.Views;

namespace ChessMVC.Controllers
{
    class PieceController
    {
        private static int uniqueId = 0;

        private static List<PieceModel> pieces = new List<PieceModel>();

        public static void GeneratePieces()
        {
            pieces.Add(new PieceModel() { Id = uniqueId++, Name = "Pawn", IsWhitePiece = true });
            pieces.Add(new PieceModel() { Id = uniqueId++, Name = "Pawn", IsWhitePiece = true });
            pieces.Add(new PieceModel() { Id = uniqueId++, Name = "Pawn", IsWhitePiece = true });
            pieces.Add(new PieceModel() { Id = uniqueId++, Name = "Pawn", IsWhitePiece = false });
            pieces.Add(new PieceModel() { Id = uniqueId++, Name = "Pawn", IsWhitePiece = false });
            PieceView.DisplayPieces(pieces);
        }
    }
}
