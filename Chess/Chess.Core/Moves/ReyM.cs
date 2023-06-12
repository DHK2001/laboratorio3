using Chess.Core.App;
using Chess.Core.Moves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Moves
{
    internal class ReyM : Move
    {
        public ReyM(ILogger logger) : base(logger)
        {
        }

        public override bool Validate(ChessPiece piece, ChessPiece[,] chessboard)
        {

            Logger.Log($"Validando Rey {piece.Color}");

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
            int columnDiff = Math.Abs(destinationColumn - currentColumn);

            if ((rowDiff == 1 && columnDiff <= 1) || (columnDiff == 1 && rowDiff <= 1))
            {
             
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
