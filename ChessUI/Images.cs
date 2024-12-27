using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using ChessLogic;

namespace ChessUI
{
    public static class Images
    {
        private static readonly Dictionary<PieceType, ImageSource> whiteSources = new()
        {
            {PieceType.Pawn, LoadImage("ChessPieces/PawnW.png") },
            {PieceType.Bishop, LoadImage("ChessPieces/BiahopW.png")},
            {PieceType.Knight, LoadImage("ChessPieces/KnigtW.png")},
            {PieceType.Rook, LoadImage("ChessPieces/RookW.png")},
            {PieceType.Queen, LoadImage("ChessPieces/QueenW.png")},
            {PieceType.King, LoadImage("ChessPieces/KingW.png")}
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

        private static ImageSource LoadImage(string filepath)
        {
            return new BitmapImage(new Uri(filepath, UriKind.Relative));
        }
    }
}
