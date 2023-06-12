using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core.App
{
    public class ChessPiece
    {
        public ChessType Type { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int CurrentRow { get; set; }
        public int DestinationRow { get; set; }
        public int CurrentColumn { get; set; }
        public int DestinationColumn { get; set; }
        
    }
}
