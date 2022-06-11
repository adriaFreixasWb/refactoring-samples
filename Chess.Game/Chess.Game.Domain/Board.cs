namespace Chess.Game.Domain
{
    public class Board
    {
        private readonly List<Piece> _pieces = new List<Piece>
        {
            new Piece("Pawn","White","A",2)
        };
        public void Move(string startColumn, int startRow, string endColumn, int endRow)
        {
            if(TryFindPiece(startColumn, startRow, out Piece piece))
            {
                _pieces.Remove(piece);
                _pieces.Add(piece.Move(endColumn, endRow));
                
            }
        }

        private bool TryFindPiece(string startColumn, int startRow, out Piece piece)
        {
            if(!_pieces.Any(p=>p.Column == startColumn && p.Row == startRow))
            {
                piece = default(Piece);
                return false;
            }
            piece = _pieces.First(p => p.Column == startColumn && p.Row == startRow);
            return false;
        }
    }
}