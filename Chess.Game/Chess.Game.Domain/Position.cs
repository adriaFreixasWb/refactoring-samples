using Chess.Game.Domain.Boards;

namespace Chess.Game.Domain;
public record Position(Column Column, int Row)
{
    public bool IsInFrontOf(Position pos) =>
        Column == pos.Column && pos.Row > Row;

    public bool IsBehind(Position pos) =>
        Column == pos.Column && pos.Row < Row;

    public int DeltaRow(int otherRow) =>
        otherRow - Row;
}
