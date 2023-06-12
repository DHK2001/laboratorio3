using Chess.Core.App;

namespace Chess.Core.Moves
{
    public abstract class Move
    {
        public ILogger Logger { get; set; }

        public Move(ILogger logger) { 
            Logger = logger;
        }
        public abstract bool Validate(ChessPiece piece, ChessPiece[,] chessboard);

    }
}
