using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOXO
{
    class Board : ICloneable
    {
        public int width=3;
        public int height = 3;
        public Piece[,] game;
        public Board(Piece[,] game,int i, int j, Piece piece)
        {
            this.game = game;
            this.game[i,j] = piece;
        }

        public Board(int w, int h, List<Piece> config)
        {
            int k = 0;
            this.width = w;
            this.height = h;
            game = new Piece[w, h];
            for (int i=0;i<width;i++)
            {
                for(int j=0;j< height;j++)
                {
                    game[i,j] = config.ElementAt(k);
                    k++;
                }
            }
        }

        public Board(int w, int h)
        {
            this.width = w;
            this.height = h;
            game = new Piece[w,h];
        }

        public int evalConfig()
        {
            int comput = 0, play = 0;
            int[] X= new int[width * height];
            int[] O= new int [width*height];
           
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (game[i,j] == Piece.O)
                    {
                        O[i]++;
                        O[j + height]++;
                        if (i == j)
                        {
                            O[height*width-3]++;
                        }
                        if ((i +j)==(width-1))
                        {
                            O[height * width - 2]++;
                        }
                    }
                    else if (game[i, j] == Piece.X)
                    {
                        X[i]++;
                        X[j + height]++;
                        if (i == j)
                        {
                            X[height * width - 3]++;
                        }
                        if ((i + j) == (width-1))
                        {
                            X[height * width - 2]++;
                        }
                    }
                }
            }

            for(int i=0;i<width* height-1; i++)
            {
                Console.WriteLine("O[" + i + "]= " + O[i] + "  X[" + i + "]= " + X[i]);
                if (O[i] == 0) play++;
                if (X[i] == 0) comput++;
            }
            Console.WriteLine("Play= " + play + " Comput=" + comput);
            return comput-play;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
