
using Chess.Core.App;

namespace Chess.Infrastructure.Readers;
public class FileMovesReader : IMovesReader
{
    public string Read()=> File.ReadAllText("input.json");
}