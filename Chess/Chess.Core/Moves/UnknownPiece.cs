using Chess.Core.App;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Moves
{
    public class UnknownPiece : Move
    {
        public UnknownPiece(ILogger logger) : base(logger)
        {

        }

        public override bool Validate(ChessPiece piece, ChessPiece[,] chessboard)
        {
            Logger.Log("Unknown chessPiece or position");
            return false;
        }
    }
}
