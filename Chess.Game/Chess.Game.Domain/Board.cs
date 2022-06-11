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
            if (!_pieces.Any(p => p.IsAt(start)))
            {
                return new EmptyPiece();
            }
            var piece = _pieces.First(p => p.IsAt(start));
                _pieces.Remove(piece);
                _pieces.Add(piece.Move(end));
                return _pieces.Last();
        }
    }
}