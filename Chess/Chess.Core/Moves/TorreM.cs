using Chess.Core.App;
using Chess.Core.Moves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Moves
{
    internal class TorreM : Move
    {
        public TorreM(ILogger logger) : base(logger)
        {
        }

        public override bool Validate(ChessPiece piece, ChessPiece[,] chessboard)
        {

            Logger.Log($"Validando Torre {piece.Color}");

            int currentRow = piece.CurrentRow;
            int currentColumn = piece.CurrentColumn;
            int destinationRow = piece.DestinationRow;
            int destinationColumn = piece.DestinationColumn;

            if (currentRow < 0 || currentRow > 7 || currentColumn < 0 || currentColumn > 7 ||
                destinationRow < 0 || destinationRow > 7 || destinationColumn < 0 || destinationColumn > 7)
            {
                return false;
            }

            if (currentRow != destinationRow && currentColumn != destinationColumn)
            {
                return false;
            }

            if (currentRow == destinationRow)
            {

                int start = Math.Min(currentColumn, destinationColumn);
                int end = Math.Max(currentColumn, destinationColumn);

                for (int col = start + 1; col < end; col++)
                {
                    if (chessboard[currentRow, col] != null)
                    {
                        return false;
                    }
                }
            }
            else
            {

                int start = Math.Min(currentRow, destinationRow);
                int end = Math.Max(currentRow, destinationRow);

                for (int row = start + 1; row < end; row++)
                {
                    if (chessboard[row, currentColumn] != null)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

    }
}
