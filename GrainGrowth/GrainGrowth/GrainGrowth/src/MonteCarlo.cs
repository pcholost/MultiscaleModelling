using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrainGrowth.src
{
    class MonteCarlo
    {
        private Display display;
        private Data data;
        private Random random;

        public MonteCarlo(Display display, Data data)
        {
            this.display = display;
            this.data = data;
            random = new Random();
        }

        public void NextStep()
        {
            if (data.GridValues == null)
                return;

            for(int i=0; i<data.SizeY; i++)
            {
                for(int j=0; j<data.SizeX; j++)
                {
                    if (data.GridValues[i, j] == 0)
                        return;
                }
            }
            Calculate();
        }

        private void Calculate()
        {
            for(int k=0; k<data.Speed;k++)
            {
                RandomOrder();

                for(int i=0; i<data.RandomPoints.Count;i++)
                {
                    int actualCell = data.GridValues[data.RandomPoints[i].X, data.RandomPoints[i].Y];

                    if(data.NameOfNeighbor =="VonNeumann")
                    {
                        data.MaxEnergy = 4;
                        VonNeumann(data.RandomPoints[i].X, data.RandomPoints[i].Y);
                    }
                    if(data.NameOfNeighbor =="Moore")
                    {
                        data.MaxEnergy = 8;
                        Moore(data.RandomPoints[i].X, data.RandomPoints[i].Y);
                    }
                }

                if (!data.ShowEnergy)
                    display.PrintCells();
                else
                    display.PrintEnergy();
            }
        }

        private void RandomOrder()
        {
            data.RandomPoints = new List<Point>();

            for(int i=0; i < data.SizeY; i++)
            {
                for(int j=0; j< data.SizeX; j++)
                {
                    Point point;
                    do
                    {
                        int indexY = random.Next(data.SizeY);
                        int indexX = random.Next(data.SizeX);
                        point = new Point(indexY, indexX);
                    }
                    while (data.RandomPoints.Contains(point));
                    data.RandomPoints.Add(point);
                }
            }
        }

        private void VonNeumann(int i, int j)
        {
            Point[] neighbours = { new Point(-1, -1), new Point(-1, -1), new Point(-1, -1), new Point(-1, -1) };
            
            if(i>0)
            {
                neighbours[0] = new Point(i - 1, j);
            }
            if(i<data.GridValues.GetLength(0) -1)
            {
                neighbours[1] = new Point(i + 1, j);
            }
            if(j>0)
            {
                neighbours[2] = new Point(i, j - 1);
            }
            if(j<data.GridValues.GetLength(1)-1)
            {
                neighbours[3] = new Point(i, j + 1);
            }

            if(data.IsPeriodic)
            {
                if(i==0)
                {
                    neighbours[0] = new Point(data.GridValues.GetLength(0) - 1, j);
                }
                if(i==data.GridValues.GetLength(0) -1)
                {
                    neighbours[1] = new Point(0,j);
                }
                if(j==0)
                {
                    neighbours[2] = new Point(i, data.GridValues.GetLength(1) - 1);
                }
                if(j==data.GridValues.GetLength(1)-1)
                {
                    neighbours[3] = new Point(i, 0);
                }
            }

            selectNeighbour(neighbours, new Point(i, j));
        }

        private void Moore(int i, int j)
        {
            Point[] neighbours = new Point[8];
            for(int k=0; k<8; k++)
            {
                neighbours[k] = new Point(-1, -1);
            }

            if(i > 0)
            {
                neighbours[0] = new Point(i - 1, j);
            }
            if(i < data.GridValues.GetLength(0)-1)
            {
                neighbours[1] = new Point(i + 1, j);
            }
            if(j > 0)
            {
                neighbours[2] = new Point(i, j - 1);
            }
            if(j < data.GridValues.GetLength(1)-1)
            {
                neighbours[3] = new Point(i, j + 1);
            }

            if(i > 0 && j > 0)
            {
                neighbours[4] = new Point(i - 1, j - 1);
            }
            if(i < data.GridValues.GetLength(0) -1 && j>0)
            {
                neighbours[5] = new Point(i + 1, j - 1);
            }
            if(i > 0 && j<data.GridValues.GetLength(1)-1)
            {
                neighbours[6] = new Point(i - 1, j + 1);
            }
            if(i < data.GridValues.GetLength(0) -1 && j < data.GridValues.GetLength(1)-1)
            {
                neighbours[7] = new Point(i + 1, j + 1);
            }

            if(data.IsPeriodic)
            {
                if(i ==0)
                {
                    neighbours[0] = new Point(data.GridValues.GetLength(0) - 1, j);
                    neighbours[4] = new Point(data.GridValues.GetLength(0) - 1, j - 1);
                    neighbours[6] = new Point(data.GridValues.GetLength(0) - 1, j + 1);
                }
                if(i == data.GridValues.GetLength(0) -1)
                {
                    neighbours[1] = new Point(0, j);
                    neighbours[5] = new Point(0, j - 1);
                    neighbours[7] = new Point(0, j + 1);
                }
                if(j==0)
                {
                    neighbours[2] = new Point(i, data.GridValues.GetLength(1) - 1);
                    neighbours[4] = new Point(i - 1, data.GridValues.GetLength(1) - 1);
                    neighbours[5] = new Point(i + 1, data.GridValues.GetLength(1) - 1);
                }
                if(j == data.GridValues.GetLength(1) -1)
                {
                    neighbours[3] = new Point(i, 0);
                    neighbours[6] = new Point(i - 1, 0);
                    neighbours[7] = new Point(i + 1, 0);
                }

                if(i==0 && j==0)
                {
                    neighbours[4] = new Point(data.GridValues.GetLength(0) - 1, data.GridValues.GetLength(1) - 1);
                }
                if(i==data.GridValues.GetLength(0) -1 && j==0)
                {
                    neighbours[5] = new Point(0, data.GridValues.GetLength(1) - 1);
                }
                if (i == 0 && j == data.GridValues.GetLength(1) - 1)
                {
                    neighbours[6] = new Point(data.GridValues.GetLength(0) - 1, 0);
                }
                if(i==data.GridValues.GetLength(0) -1 && j == data.GridValues.GetLength(1)-1)
                {
                    neighbours[7] = new Point(0, 0);
                }
            }
            selectNeighbour(neighbours, new Point(i, j));
        }

        private void selectNeighbour(Point[] neighbours, Point actual)
        {
            int index;
            if(data.IsPeriodic)
            {
                index = random.Next(neighbours.Length);
            }
            else
            {
                do
                {
                    index = random.Next(neighbours.Length);
                }
                while (neighbours[index].X == -1 || neighbours[index].Y == -1);
            }

            int actualValue = data.GridValues[actual.X, actual.Y];
            int neighbourValue = data.GridValues[neighbours[index].X, neighbours[index].Y];

            int previousEnergy = countEnergy(neighbours, actualValue);
            int nextEnergy = countEnergy(neighbours, neighbourValue);
            int diffEnergy = nextEnergy - previousEnergy;
            data.GridEnergy[actual.X, actual.Y] = previousEnergy;
            if(diffEnergy <=0)
            {
                data.GridValues[actual.X, actual.Y] = neighbourValue;
                data.GridEnergy[actual.X, actual.Y] = nextEnergy;
            }
            else
            {
                double value = random.NextDouble();
                if(Math.Exp(-1*diffEnergy/data.Kt) < value)
                {
                    data.GridValues[actual.X, actual.Y] = neighbourValue;
                    data.GridEnergy[actual.X, actual.Y] = nextEnergy;
                }
            }
        }

        private int countEnergy(Point[] neighbours, int value)
        {
            int energy = 0;
            for (int i = 0; i < neighbours.Length; i++)
            {
                if (neighbours[i].X == -1 || neighbours[i].Y == -1)
                    continue;

                if (value != data.GridValues[neighbours[i].X, neighbours[i].Y])
                    energy++;
            }

            return energy;
        }
    }
}
