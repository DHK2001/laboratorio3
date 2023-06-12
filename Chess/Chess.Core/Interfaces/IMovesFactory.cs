using Chess.Core.App;
using Chess.Core.Moves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.App
{
    public interface IMovesFactory
    {
        Move GetPieceMove(ChessPiece chessPiece, ILogger logger);
    }
}
