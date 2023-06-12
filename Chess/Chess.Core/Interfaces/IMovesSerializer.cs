using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.App
{
    public interface IMovesSerializer
    {
        List<ChessPiece> Deserialize(string source);
    }
}
