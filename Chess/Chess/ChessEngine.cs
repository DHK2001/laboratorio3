using Chess.Core.App;

namespace Chess.App
{
    public class ChessEngine
    {
        public decimal Rating { get; set; }
        private readonly ILogger _logger;
        private readonly IMovesReader _movesReader;
        private readonly IMovesSerializer _movesSerializer;
        private readonly IMovesFactory _movesFactory;
        private readonly ChessPiece[,] _chessBoard;

        public ChessEngine(ILogger logger, IMovesReader movesReader, IMovesSerializer movesSerializer, IMovesFactory iMovesFactory)
        {
            _logger = logger;
            _movesReader = movesReader;
            _movesSerializer = movesSerializer;
            _movesFactory = iMovesFactory;
            _chessBoard = new ChessPiece[8, 8];
        }

        public void Validate()
        {
            _logger.Log("Starting validation.");

            _logger.Log("\nLoading pieces.\n");

            string movementsJson = _movesReader.Read();
            var pieces = _movesSerializer.Deserialize(movementsJson);

            foreach (var piece in pieces)
            {
                var ejemplo = _movesFactory.GetPieceMove(piece, _logger);

                bool esValido = ejemplo.Validate(piece, _chessBoard);

                if (esValido)
                {
                    _chessBoard[piece.DestinationRow, piece.DestinationColumn] = piece;
                    _logger.Log("El movimiento es valido.\n");
                }else
                    _logger.Log("El movimiento no es valido.\n");
            }

            _logger.Log("\nValdiacion completed.\n");
        }
    }
}
