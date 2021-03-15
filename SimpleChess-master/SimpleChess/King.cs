using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleChess
{
    class King : Piece
    {
        public King() : base("KNG") { }

        public override bool Move(string fromPosition, string toPosition)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
            if ((Math.Abs(diffRow) == Math.Abs(diffCol)) || (Math.Abs(diffRow) + 1 == Math.Abs(diffCol)) ||
                Math.Abs(diffRow) == Math.Abs(diffCol) + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
    }
}
