using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bib
{
public enum GameLevel { Beginner = 10, Intervalle = 20, Advanced= 40}
    public class Demineur
    {
        #region Attributs
        public int Line { get; }
        public int Column { get; }
        public int Bombs { get; }

        public int[,] Grid { get; }

        #endregion

        #region Constructeurs
        public Demineur(GameLevel level = GameLevel.Beginner)
        {
            Bombs = (int)level;
            switch (level)
            {
                case GameLevel.Beginner:
                    Line = 9;
                    Column = 9;
                    break;
                case GameLevel.Intervalle:
                    Line = 12;
                    Column = 12;
                    break;
                case GameLevel.Advanced:
                    Line = 12;
                    Column = 16;
                    break;

            }
            Grid = new int[Line, Column];
            setBombs();
            SetNumbers();
        }
        public Demineur(GameLevel level, int bombs):this(level)
        {
            Bombs = bombs;
        }
        #endregion

        #region Methodes
        private void setBombs()
        {

            int i = 0;
            while( i < Bombs)
            {
                Random r = new Random();
                int x = r.Next(0,Line);
                int y = r.Next(0, Column);

                if (Grid[x,y] != 9)
                {
                    Grid[x, y] = 9;
                    i++;
                }

            }
        }

        private void SetNumbers()
        {
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    if (Grid[i,j] == 9)
                    {
                        SetCountour(i, j);
                    }
                }
            }

        }

        private void SetCountour(int i, int j)
        {
            for (int x = i -1; x <= i + 1; x++)
            {
                if (x >= 0 && x < Grid.GetLength(0)) 
                for (int y = j-1;y <= j + 1; y++)
                {
                        if (y >= 0 && y <Grid.GetLength(1))
                          if (Grid[x,y] != 9)
                          {
                             Grid[x, y] += 1;
                          }
                }
            }

        }

        #endregion
    }
}
