using Chess.Core.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Moves
{
    internal class DamaM : Move
    {
        public DamaM(ILogger logger) : base(logger)
        {
        }

        public override bool Validate(ChessPiece piece, ChessPiece[,] chessboard)
        {

            Logger.Log($"Validando Dama {piece.Color}");

            int currentRow = piece.CurrentRow;
            int currentColumn = piece.CurrentColumn;
            int destinationRow = piece.DestinationRow;
            int destinationColumn = piece.DestinationColumn;

            if (currentRow < 0 || currentRow > 7 || currentColumn < 0 || currentColumn > 7 ||
                destinationRow < 0 || destinationRow > 7 || destinationColumn < 0 || destinationColumn > 7)
            {
                return false;
            }

           
            if (currentRow != destinationRow && currentColumn != destinationColumn && Math.Abs(currentRow - destinationRow) != Math.Abs(currentColumn - destinationColumn))
            {
                return false;
            }

            
            int rowDirection = Math.Sign(destinationRow - currentRow);
            int colDirection = Math.Sign(destinationColumn - currentColumn);

            int row = currentRow + rowDirection;
            int col = currentColumn + colDirection;

            while (row != destinationRow || col != destinationColumn)
            {
                if (chessboard[row, col] != null)
                {
                    return false;
                }

                row += rowDirection;
                col += colDirection;
            }

            return true;
        }

    }
}
