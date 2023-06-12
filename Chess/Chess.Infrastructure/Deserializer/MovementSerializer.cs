using Chess.Core.App;
using Newtonsoft.Json;

public class MovementSerializer : IMovesSerializer
{
    public List<ChessPiece> Deserialize(string source)
    {
        var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(source);
        var movements = jsonObject["movimientos"];

        var chessPiecesList = new List<ChessPiece>();
        var color = "blanco";

        foreach (var movement in movements)
        {
            var chessPiece = new ChessPiece();
            chessPiece.Color = color;

            var pieceCode = movement[0].ToString();
            if (Enum.TryParse(pieceCode, out ChessType chessType))
            {
                chessPiece.Type = chessType;
            }
            else
            {
                chessPiece.Type = ChessType.Unknown;
            }

            chessPiece.Name = PieceNamesDictionary.pieceNames[chessPiece.Type];

            chessPiece.CurrentColumn = ColumnDictionary.GetColumnIndex(movement[1].ToString());
            chessPiece.CurrentRow = RowDictionary.GetRowIndex(movement[2].ToString());
            chessPiece.DestinationColumn = ColumnDictionary.GetColumnIndex(movement[4].ToString());
            chessPiece.DestinationRow = RowDictionary.GetRowIndex(movement[5].ToString());

            chessPiecesList.Add(chessPiece);

            color = color == "blanco" ? "negro" : "blanco";
        }

        return chessPiecesList;
    }
}

