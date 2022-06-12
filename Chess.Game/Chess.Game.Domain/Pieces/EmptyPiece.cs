namespace Chess.Game.Domain.Pieces;

public record EmptyPiece : Piece
{
    public EmptyPiece() : base(string.Empty, string.Empty, new EmptyPosition())
    {
    }
}
