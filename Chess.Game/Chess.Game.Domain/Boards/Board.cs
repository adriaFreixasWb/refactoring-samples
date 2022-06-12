using Chess.Game.Domain.Boards;
using Chess.Game.Domain.Pieces;

namespace Chess.Game.Domain
{
    public class Board
    {
        private readonly List<Piece> _pieces = new List<Piece>
        {
            new Piece(PieceType.Pawn, Color.White, new Position(Column.A,2)),
            new Piece(PieceType.King, Color.White, new Position(Column.E,1)),
            new Piece(PieceType.Pawn, Color.White, new Position(Column.A,2)),
            new Piece(PieceType.King, Color.White, new Position(Column.E,8))
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