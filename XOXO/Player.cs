using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOXO
{
    abstract class Player
    {
        Boolean winner = false;
        Piece p;

        public Piece P
        {
            get
            {
                return p;
            }

            set
            {
                this.p = value;
            }
        }

        public bool Winner
        {
            get
            {
                return winner;
            }

            set
            {
                this.winner = value;
            }
        }

        public abstract void move(int posX, int posY);
    }
}
