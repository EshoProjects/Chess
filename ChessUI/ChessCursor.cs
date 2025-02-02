﻿using System.IO;
using System.Windows;
using System.Windows.Input;

namespace ChessUI
{
    public static class ChessCursor
    {
        public static readonly Cursor WhiteCursor = LoadCursor("ChessPieces/CursorW.cur");
        public static readonly Cursor BlackCursor = LoadCursor("ChessPieces/CursorB.cur");

        private static Cursor LoadCursor(string filePath)
        {
            Stream stream = Application.GetResourceStream(new Uri(filePath, UriKind.Relative)).Stream;
            return new Cursor(stream, true);
        }
    }
}
