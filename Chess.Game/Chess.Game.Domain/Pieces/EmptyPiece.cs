namespace Chess.Game.Domain.Pieces;

public record EmptyPiece : Piece
{
    public EmptyPiece() : base(string.Empty, Colors.None, new EmptyPosition())
    {
    }
}
