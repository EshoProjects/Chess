using ChessLogic;

public abstract class Piece
{
    public abstract PieceType Type { get; }
    public abstract Player Color { get; }
    public bool HasMoved { get; set; }

    public abstract Piece Copy();
}

internal class Pawn : Piece
{
    public override PieceType Type => PieceType.Pawn;
    public override Player Color { get; }

    public Pawn(Player color)
    {
        Color = color;
    }

    public override Piece Copy()
    {
        Pawn copy = new Pawn(Color)
        {
            HasMoved = HasMoved
        };
        return copy;
    }
}