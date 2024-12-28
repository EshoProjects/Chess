using System.Windows.Media;
using System.Windows.Media.Imaging;
using ChessLogic;

namespace ChessUI
{
    public static class Images
    {
        private static readonly Dictionary<PieceType, ImageSource> whiteSources = new()
        {
            { PieceType.Pawn, LoadImage("ChessPieces/PawnW.png") },
            { PieceType.Bishop, LoadImage("ChessPieces/BishopW.png") },
            { PieceType.Knight, LoadImage("ChessPieces/KnightW.png") },
            { PieceType.Rook, LoadImage("ChessPieces/RookW.png") },
            { PieceType.Queen, LoadImage("ChessPieces/QueenW.png") },
            { PieceType.King, LoadImage("ChessPieces/KingW.png") }
        };

        private static readonly Dictionary<PieceType, ImageSource> blackSources = new()
        {
            { PieceType.Pawn, LoadImage("ChessPieces/PawnB.png") },
            { PieceType.Bishop, LoadImage("ChessPieces/BishopB.png") },
            { PieceType.Knight, LoadImage("ChessPieces/KnightB.png") },
            { PieceType.Rook, LoadImage("ChessPieces/RookB.png") },
            { PieceType.Queen, LoadImage("ChessPieces/QueenB.png") },
            { PieceType.King, LoadImage("ChessPieces/KingB.png") }
        };

        private static ImageSource LoadImage(string filePath)
        {
            return new BitmapImage(new Uri(filePath, UriKind.Relative));
        }

        public static ImageSource GetImage(Player color, PieceType type)
        {
            return color switch
            {
                Player.White => whiteSources[type],
                Player.Black => blackSources[type],
                _ => null
            };
        }

        public static ImageSource GetImage(Piece piece)
        {
            if (piece == null)
            {
                return null;
            }

            return GetImage(piece.Color, piece.Type);
        }
    }
}
