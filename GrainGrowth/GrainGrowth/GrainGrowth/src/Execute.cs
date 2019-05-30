using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GrainGrowth.src
{
    class Execute
    {
        private Display display;
        private Data data;
        private Random random;

        public Execute(Display display, Data data)
        {
            this.display = display;
            this.data = data;
            random = new Random();
        }

        public void Calculate()
        {
            display.PrintCells();

            for (int i = 0; i < data.Speed; i++)
            {
                int[,] nextStepGrid = new int[data.SizeX, data.SizeX];

                for (int y = 0; y < data.SizeY; y++)
                {
                    for (int x = 0; x < data.SizeX; x++)
                    {
                        int actualCell = data.GridValues[y, x];
                        nextStepGrid[y, x] = actualCell;

                        if (actualCell != 0)
                        {
                            continue;
                        }
                        int value = 0;
                        if (data.NameOfNeighbor == "VonNeumann")
                        {
                            value = VonNeumann(y, x);
                        }
                        if (data.NameOfNeighbor == "Moore")
                        {
                            value = Moore(y, x);
                        }
                        if (data.NameOfNeighbor == "RandomPenta")
                        {
                            value = RandomPenta(y, x);
                        }
                        if (data.NameOfNeighbor == "LeftHex")
                        {
                            value = LeftHex(y, x);
                        }
                        if (data.NameOfNeighbor == "RightHex")
                        {
                            value = RightHex(y, x);
                        }
                        if (data.NameOfNeighbor == "RandomHex")
                        {
                            value = RandomHex(y, x);
                        }
                        if (data.NameOfNeighbor == "Radious")
                        {
                            value = Radious(y, x);
                        }

                        if (value != 0)
                        {
                            nextStepGrid[y, x] = value;
                            data.Cells[value]++;
                        }
                    }
                }
                data.GridValues = nextStepGrid;
                display.PrintCells();

            }
        }

        private int VonNeumann(int i, int j)
        {
            int[] tabNeighbours = { 0, 0, 0, 0 };

            if (i > 0)
            {
                tabNeighbours[0] = data.GridValues[i - 1, j];
            }
            if (i < data.GridValues.GetLength(0) - 1)
            {
                tabNeighbours[1] = data.GridValues[i + 1, j];
            }
            if (j > 0)
            {
                tabNeighbours[2] = data.GridValues[i, j - 1];
            }
            if (j < data.GridValues.GetLength(1) - 1)
            {
                tabNeighbours[3] = data.GridValues[i, j + 1];
            }

            if (data.IsPeriodic)
            {
                if (i == 0)
                {
                    tabNeighbours[0] = data.GridValues[data.GridValues.GetLength(0) - 1, j];
                }
                if (i == data.GridValues.GetLength(0) - 1)
                {
                    tabNeighbours[1] = data.GridValues[0, j];
                }
                if (j == 0)
                {
                    tabNeighbours[2] = data.GridValues[i, data.GridValues.GetLength(1) - 1];
                }
                if (j == data.GridValues.GetLength(1) - 1)
                {
                    tabNeighbours[3] = data.GridValues[i, 0];
                }
            }

            return selectNeighbour(tabNeighbours);
        }

        private int Moore(int i, int j)
        {
            int[] tabNeighbours = new int[8];
            if (i > 0)
            {
                tabNeighbours[0] = data.GridValues[i - 1, j];
            }
            if (i < data.GridValues.GetLength(0) - 1)
            {
                tabNeighbours[1] = data.GridValues[i + 1, j];
            }
            if (j > 0)
            {
                tabNeighbours[2] = data.GridValues[i, j - 1];
            }
            if (j < data.GridValues.GetLength(1) - 1)
            {
                tabNeighbours[3] = data.GridValues[i, j + 1];
            }
            if (i > 0 && j > 0)
            {
                tabNeighbours[4] = data.GridValues[i - 1, j - 1];
            }
            if (i < data.GridValues.GetLength(0) - 1 && j > 0)
            {
                tabNeighbours[5] = data.GridValues[i + 1, j - 1];
            }
            if (i > 0 && j < data.GridValues.GetLength(1) - 1)
            {
                tabNeighbours[6] = data.GridValues[i - 1, j + 1];
            }
            if (i < data.GridValues.GetLength(0) - 1 && j < data.GridValues.GetLength(1) - 1)
            {
                tabNeighbours[7] = data.GridValues[i + 1, j + 1];
            }

            if (data.IsPeriodic)
            {
                if (i == 0)
                {
                    tabNeighbours[0] = data.GridValues[data.GridValues.GetLength(0) - 1, j];
                }
                if (i == data.GridValues.GetLength(0) - 1)
                {
                    tabNeighbours[1] = data.GridValues[0, j];
                }
                if (j == 0)
                {
                    tabNeighbours[2] = data.GridValues[i, data.GridValues.GetLength(1) - 1];
                }
                if (j == data.GridValues.GetLength(1) - 1)
                {
                    tabNeighbours[3] = data.GridValues[i, 0];
                }

                if (i == 0 && j == 0)
                {
                    tabNeighbours[4] = data.GridValues[data.GridValues.GetLength(0) - 1, data.GridValues.GetLength(1) - 1];
                }
                if (i == data.GridValues.GetLength(0) - 1 && j == 0)
                {
                    tabNeighbours[5] = data.GridValues[0, data.GridValues.GetLength(1) - 1];
                }
                if (i == 0 && j == data.GridValues.GetLength(1) - 1)
                {
                    tabNeighbours[6] = data.GridValues[data.GridValues.GetLength(0) - 1, 0];
                }
                if (i == data.GridValues.GetLength(0) - 1 && j == data.GridValues.GetLength(1) - 1)
                {
                    tabNeighbours[7] = data.GridValues[data.GridValues.GetLength(0) - 1, data.GridValues.GetLength(1) - 1];
                }
            }

            return selectNeighbour(tabNeighbours);
        }

        private int RandomPenta(int i, int j)
        {
            int[] tabNeighbours = new int[8];
            int option = random.Next(1, 4);

            if (i > 0 && (option == 1 || option == 3 || option == 4))
            {
                tabNeighbours[0] = data.GridValues[i - 1, j];
            }
            if (i < data.GridValues.GetLength(0) - 1 && (option == 2 || option == 3 || option == 4))
            {
                tabNeighbours[1] = data.GridValues[i + 1, j];
            }
            if (j > 0 && (option == 1 || option == 2 || option == 4))
            {
                tabNeighbours[2] = data.GridValues[i, j - 1];
            }
            if (j < data.GridValues.GetLength(1) - 1 && (option == 1 ||option==2||option==3))
            {
                tabNeighbours[3] = data.GridValues[i, j + 1];
            }
            if(i>0 && j>0 && (option==1||option==4))
            {
                tabNeighbours[4] = data.GridValues[i - 1, j - 1];
            }
            if(i<data.GridValues.GetLength(0)-1 && j>0 && (option==2 ||option==4))
            {
                tabNeighbours[5] = data.GridValues[i + 1, j - 1];
            }
            if(i>0 && j < data.GridValues.GetLength(1) - 1 && (option == 1 || option == 3))
            {
                tabNeighbours[6] = data.GridValues[i - 1, j + 1];
            }
            if(i< data.GridValues.GetLength(0) - 1 && j<data.GridValues.GetLength(1)-1 && (option==2 || option ==3))
            {
                tabNeighbours[7] = data.GridValues[i + 1, j + 1];
            }

            if(data.IsPeriodic)
            {
                if(i==0 && (option==1 || option==3 || option==4))
                {
                    tabNeighbours[0] = data.GridValues[data.GridValues.GetLength(0) - 1, j];
                }
                if(i==data.GridValues.GetLength(0) - 1 && (option ==2 || option ==3|| option==4))
                {
                    tabNeighbours[1] = data.GridValues[0, j];
                }
                if(j==0 && (option ==1 || option ==2 ||option ==4))
                {
                    tabNeighbours[2] = data.GridValues[i, data.GridValues.GetLength(1) - 1];
                }
                if(j==data.GridValues.GetLength(1)-1 && (option==1||option ==2||option==3))
                {
                    tabNeighbours[3] = data.GridValues[i, 0];
                }
                if(i==0 && j==0 && (option==1||option==4))
                {
                    tabNeighbours[4] = data.GridValues[data.GridValues.GetLength(0) - 1, data.GridValues.GetLength(1) - 1];
                }
                if(i==data.GridValues.GetLength(0)-1 && j==0 && (option==2 ||option==4))
                {
                    tabNeighbours[5] = data.GridValues[0, data.GridValues.GetLength(1) - 1];
                }
                if(i==0 && j==data.GridValues.GetLength(1) - 1 && (option == 1 || option == 3))
                {
                    tabNeighbours[6] = data.GridValues[data.GridValues.GetLength(0) - 1, 0];
                }
                if (i == data.GridValues.GetLength(0) - 1 && j == data.GridValues.GetLength(1) - 1 && (option == 2 || option == 3))
                {
                    tabNeighbours[7] = data.GridValues[data.GridValues.GetLength(0) - 1, data.GridValues.GetLength(1) - 1];
                }
            }
            return selectNeighbour(tabNeighbours);
        }

        private int LeftHex(int i, int j)
        {
            int[] tabNeighbours = new int[6];

            if(i>0)
            {
                tabNeighbours[0] = data.GridValues[i - 1, j];
            }
            if(i<data.GridValues.GetLength(0) -1)
            {
                tabNeighbours[1] = data.GridValues[i + 1, j];
            }
            if(j>0)
            {
                tabNeighbours[2] = data.GridValues[i, j - 1];
            }
            if(j<data.GridValues.GetLength(1) - 1)
            {
                tabNeighbours[3] = data.GridValues[i, j + 1];
            }
            if(i<data.GridValues.GetLength(0) - 1 && j>0)
            {
                tabNeighbours[4] = data.GridValues[i + 1, j - 1];
            }
            if(i>0 && j<data.GridValues.GetLength(1)-1)
            {
                tabNeighbours[5] = data.GridValues[i - 1, j + 1];
            }

            if(data.IsPeriodic)
            {
                if(i==0)
                {
                    tabNeighbours[0] = data.GridValues[data.GridValues.GetLength(0) - 1, j];
                }
                if(i==data.GridValues.GetLength(0)-1)
                {
                    tabNeighbours[1] = data.GridValues[0, j];
                }
                if(j==0)
                {
                    tabNeighbours[2] = data.GridValues[i, data.GridValues.GetLength(1) - 1];
                }
                if(j==data.GridValues.GetLength(1) - 1)
                {
                    tabNeighbours[3] = data.GridValues[i, 0];
                }
                if(i==data.GridValues.GetLength(0) -1 && j==0)
                {
                    tabNeighbours[4] = data.GridValues[0, data.GridValues.GetLength(1) - 1];
                }
                if(i==0 && j==data.GridValues.GetLength(1) - 1)
                {
                    tabNeighbours[5] = data.GridValues[data.GridValues.GetLength(0) - 1, 0];
                }
            }

            return selectNeighbour(tabNeighbours);
        }

        private int RightHex(int i, int j)
        {
            int[] tabNeighbours = new int[6];

            if(i>0)
            {
                tabNeighbours[0] = data.GridValues[i - 1, j];
            }
            if(i<data.GridValues.GetLength(0) -1)
            {
                tabNeighbours[1] = data.GridValues[i + 1, j];
            }
            if(j>0)
            {
                tabNeighbours[2] = data.GridValues[i, j - 1];
            }
            if(j<data.GridValues.GetLength(1)-1)
            {
                tabNeighbours[3] = data.GridValues[i, j + 1];
            }
            if(i>0 && j>0)
            {
                tabNeighbours[4] = data.GridValues[i - 1, j - 1];
            }
            if(i<data.GridValues.GetLength(0) - 1 && j<data.GridValues.GetLength(1)-1)
            {
                tabNeighbours[5] = data.GridValues[i + 1, j + 1];
            }

            if(data.IsPeriodic)
            {
                if(i==0)
                {
                    tabNeighbours[0] = data.GridValues[data.GridValues.GetLength(0) - 1, j];
                }
                if(i == data.GridValues.GetLength(0)-1)
                {
                    tabNeighbours[1] = data.GridValues[0, j];
                }
                if(j==0)
                {
                    tabNeighbours[2] = data.GridValues[i, data.GridValues.GetLength(1) - 1];
                }
                if(j==data.GridValues.GetLength(1)-1)
                {
                    tabNeighbours[3] = data.GridValues[i, 0];
                }
                if(i==0 && j==0)
                {
                    tabNeighbours[4] = data.GridValues[data.GridValues.GetLength(0) - 1, data.GridValues.GetLength(1) - 1];
                }
                if(i==data.GridValues.GetLength(0) -1 && j==data.GridValues.GetLength(1)-1)
                {
                    tabNeighbours[5] = data.GridValues[data.GridValues.GetLength(0) - 1, data.GridValues.GetLength(1) - 1];
                }
            }

            return selectNeighbour(tabNeighbours);
        }

        private int RandomHex(int i, int j)
        {
            int var = random.Next(2);

            if(var==0)
            {
                return LeftHex(i, j);
            }
            else
            {
                return RightHex(i, j);
            }
        }

        private int Radious(int i, int j)
        {
            int[] tabNeighbours = new int[(int)Math.Pow(2 * data.NeighborhoodRadious, 2)];
            int index = 0;

            for(int k=i-data.NeighborhoodRadious; k<i+data.NeighborhoodRadious;k++)
            {
                if(k<0 || k> data.GridValues.GetLength(0) -1)
                {
                    continue;
                }

                for(int l=j-data.NeighborhoodRadious; l<j+data.NeighborhoodRadious; l++)
                {
                    if(l<0 || l>data.GridValues.GetLength(1)-1)
                    {
                        continue;
                    }

                    double length = Math.Sqrt(Math.Pow(data.GridPoints[i, j].X - data.GridPoints[k, l].X, 2) + Math.Pow(data.GridPoints[i, j].Y - data.GridPoints[k, l].Y, 2));
                    if(length <= data.NeighborhoodRadious*data.CellSize)
                    {
                        tabNeighbours[index] = data.GridValues[k, l];
                        index++;
                    }
                }
            }
            return selectNeighbour(tabNeighbours);
        }

        private int selectNeighbour(int[] neighbours)
        {
            int index = 0;
            for(int i=1; i<neighbours.Length; i++)
            {
                if(data.Cells[neighbours[i]]>data.Cells[neighbours[index]])
                {
                    index = i;
                }
            }
            return neighbours[index];
        }
    }
}
