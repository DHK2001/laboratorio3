using Chess.Core.App;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.Moves
{
    public class MovesFactory : IMovesFactory
    {
        public Move GetPieceMove(ChessPiece chessPiece, ILogger logger)
        {
            try
            {
                var type = Type.GetType($"Chess.Core.Moves.{chessPiece.Name}M");

                return (Move)Activator.CreateInstance(type, logger);
            }
            catch (Exception ex)
            {
                return new UnknownPiece(logger);
            }
        }
    }
}
