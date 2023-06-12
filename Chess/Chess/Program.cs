
using Chess.App;
using Chess.Core.Moves;
using Chess.infrastructure.Loggers;
using Chess.Infrastructure.Readers;

Console.WriteLine("Chess System Starting...");

var engine = new ChessEngine(
    new ConsoleLogger(),
    new FileMovesReader(),
    new MovementSerializer(),
    new MovesFactory()
);

engine.Validate();