using Chess.Core.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Moves
{
    internal class PeonM : Move
    {
        public PeonM(ILogger logger) : base(logger)
        {
        }

        public override bool Validate(ChessPiece piece, ChessPiece[,] chessboard)
        {

            Logger.Log($"Validando Peon {piece.Color}");

            int currentRow = piece.CurrentRow;
            int currentColumn = piece.CurrentColumn;
            int destinationRow = piece.DestinationRow;
            int destinationColumn = piece.DestinationColumn;

            if (currentRow < 0 || currentRow > 7 || currentColumn < 0 || currentColumn > 7 ||
                destinationRow < 0 || destinationRow > 7 || destinationColumn < 0 || destinationColumn > 7)
            {
                return false;
            }

            if (piece.Color == "blanco")
            {
                if (piece.CurrentRow == 1)
                {
                    if (piece.DestinationRow == piece.CurrentRow + 1 || piece.DestinationRow == piece.CurrentRow + 2)
                    {
                        if (chessboard[piece.DestinationRow, piece.DestinationColumn] == null)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (piece.DestinationRow == piece.CurrentRow + 1)
                    {
                        if (chessboard[piece.DestinationRow, piece.DestinationColumn] == null)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (piece.CurrentRow == 6)
                {
                    if (piece.DestinationRow == piece.CurrentRow - 1 || piece.DestinationRow == piece.CurrentRow - 2)
                    {
                        if (chessboard[piece.DestinationRow, piece.DestinationColumn] == null)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (piece.DestinationRow == piece.CurrentRow - 1)
                    {
                        if (chessboard[piece.DestinationRow, piece.DestinationColumn] == null)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }           

        }
    }
}
