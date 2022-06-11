namespace Chess.Game.Domain
{
    public class Board
    {
        private readonly List<Piece> _pieces = new List<Piece>
        {
            new Piece("Pawn","White", new Position("A",2))
        };
        public Piece Move(Position start, Position end)
        {
            if (TryFindPiece(start, out Piece piece))
            {
                _pieces.Remove(piece);
                _pieces.Add(piece.Move(end));
                return _pieces.Last();
            }
            return piece;
        }

        private bool TryFindPiece(Position position, out Piece piece)
        {
            if (!_pieces.Any(p => p.Position.Equals(position)))
            {
                piece = default(Piece);
                return false;
            }
            piece = _pieces.First(p => p.Position.Equals(position));
            return true;
        }
    }
}