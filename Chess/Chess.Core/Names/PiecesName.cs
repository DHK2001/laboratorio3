using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.App
{
    public static class PieceNamesDictionary
    {
        public static readonly Dictionary<ChessType, string> pieceNames = new Dictionary<ChessType, string>
        {
            { ChessType.P, "Peon" },
            { ChessType.C, "Caballo" },
            { ChessType.R, "Rey" },
            { ChessType.T, "Torre" },
            { ChessType.A, "Alfil" },
            { ChessType.D, "Dama" },
            { ChessType.Unknown, "Desconocido" }
        };
    }
}

