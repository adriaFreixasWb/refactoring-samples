namespace Chess.Game.Domain
{
    public record EmptyPiece:Piece
    {
        public EmptyPiece():base(string.Empty, string.Empty, new Position(string.Empty, 0))
        {
        }
    }
}
