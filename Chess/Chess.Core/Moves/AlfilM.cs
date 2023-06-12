using Chess.Core.App;
using System;

namespace Chess.Core.Moves
{
    public class AlfilM : Move
    {
        public AlfilM(ILogger logger) : base(logger)
        {
        }

        public override bool Validate(ChessPiece piece, ChessPiece[,] chessboard)
        {
            Logger.Log($"Validando Alfil {piece.Color}");
            int currentRow = piece.CurrentRow;
            int currentColumn = piece.CurrentColumn;
            int destinationRow = piece.DestinationRow;
            int destinationColumn = piece.DestinationColumn;

            if (currentRow < 0 || currentRow > 7 || currentColumn < 0 || currentColumn > 7 ||
                destinationRow < 0 || destinationRow > 7 || destinationColumn < 0 || destinationColumn > 7)
            {
                return false;
            }

            int rowDiff = Math.Abs(destinationRow - currentRow);
            int colDiff = Math.Abs(destinationColumn - currentColumn);

            if (rowDiff == colDiff)
            {
                int rowDirection = (destinationRow > currentRow) ? 1 : -1;
                int colDirection = (destinationColumn > currentColumn) ? 1 : -1;

                int checkRow = currentRow + rowDirection;
                int checkCol = currentColumn + colDirection;

                while (checkRow != destinationRow && checkCol != destinationColumn)
                {
                    if (chessboard[checkRow, checkCol] != null)
                    {
                        return false;
                    }

                    checkRow += rowDirection;
                    checkCol += colDirection;
                }

                if (chessboard[destinationRow, destinationColumn] != null)
                {
                    return false;
                }

                return true;
            }

            return false;
        }
    }
}
