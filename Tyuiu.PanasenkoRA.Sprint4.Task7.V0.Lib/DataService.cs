using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PanasenkoRA.Sprint4.Task7.V0.Lib
{
    public class DataService : ISprint4Task7V0
    {
        public int Calculate(int rows, int columns, string value)
        {
            int[,] mtrx = new int[rows, columns];

            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * columns + j, 1));
                }

            }
            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (mtrx[i, j] % 2 == 1)
                    {
                        count += mtrx[i, j];
                    }
                }
            }
            return count;
        }

    }
}
