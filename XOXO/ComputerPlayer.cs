using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOXO
{
    class ComputerPlayer : Player
    {

        public override void move(int posX, int posY)
        {
            
        }
        public int minMax(Board board, int nbposs)
        {
            int pos=0;
            Board config1level, config2levl;
            double besteval = double.PositiveInfinity;
            double e = double.NegativeInfinity;
            double evalutionBoard = 0;

            for (int i = 0; i < nbposs; i++)
            {
                config1level = new Board(board.game, i, i, this.P); // generation d'un fils
                e = double.NegativeInfinity;
                for(int j = 0; j < nbposs - 1; j++)
                {
                    config2levl = new Board(board.game,i,j,this.P);
                    evalutionBoard = board.evalConfig();
                    if (evalutionBoard < e)
                    {
                        e = evalutionBoard;
                    }
                }
                if( e > besteval)
                {
                    besteval = e;
                }
            }

            return pos;
        }
        public int positionToChange(Piece[,] game,int indexbegin,int height,int width)
        {
            int i = 0, j = 0,pos=0;
            while(game[i,j] != Piece.E && (i < indexbegin / height)){
                j = 0;
                while (game[i, j] != Piece.E && (j < indexbegin % width))
                {
                    pos++;
                    j++;
                }
                i++;
            }
            return pos;
        }
    }
}
