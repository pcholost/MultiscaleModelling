using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using GrainGrowth.src;

namespace GrainGrowth.src
{
    class Neighbor
    {
        private Data data;
        private Execute execute;

        public Neighbor(Data data, Execute execute)
        {
            this.data = data;
            this.execute = execute;
        }

        public void OwnNeighborClick(Point coords, Display display)
        {
            int x = coords.X / data.CellSize;
            int y = coords.Y / data.CellSize;
            int value;

            if (data.Colors == null)
                return;
            try
            {
                value = data.GridValues[y, x];
            }
            catch(IndexOutOfRangeException)
            {
                return;
            }
            if(value==0)
            {
                data.GridValues[y, x] = ++data.CurrentIndex; ;
                data.AddNewColor();
            }
            display.PrintCells();
        }

        public void OwnNeighbor()
        {
            if(data.CurrentIndex>0)
            {
                execute.Calculate();
            }
        }

        public void RandomNeighbor()
        {
            data.Initialize();
            Random random = new Random();
            for(int i=0; i<data.RandomNum; i++)
            {
                data.AddNewColor();
                data.GridValues[random.Next(0, data.SizeY), random.Next(0, data.SizeX)] = ++data.CurrentIndex;
            }
            execute.Calculate();
        }

        public void HomogenousNeighbor()
        {
            data.Initialize();

            int ySpace = data.SizeY / data.YHomogenousNum;
            int xSpace = data.SizeX / data.XHomogenousNum;

            for(int i=0; i<data.YHomogenousNum; i++)
            {
                for(int j=0; j<data.XHomogenousNum; j++)
                {
                    data.AddNewColor();
                    data.GridValues[i * ySpace, j * xSpace] = ++data.CurrentIndex;
                }
            }
            if(data.CurrentIndex>1)
            {
                execute.Calculate();
            }
        }

        public void RadiousNeighbor()
        {
            data.Initialize();
            Random random = new Random();

            int limit = 15;

            for(int i=0; i<data.RadiousNum;i++)
            {
                bool generated = false;
                int iter = 0;
                while(!generated && iter < limit)
                {
                    iter++;

                    int x = random.Next(0, data.SizeY);
                    int y = random.Next(0, data.SizeX);

                    if(checkRadious(x,y))
                    {
                        data.AddNewColor();
                        data.GridValues[x, y] = ++data.CurrentIndex;
                        generated = true;
                    }
                }
            }

            if(data.CurrentIndex > 1)
            {
                execute.Calculate();
            }
        }

        private bool checkRadious(int x, int y)
        {
            for(int i = x - data.Radious; i<= x+data.Radious;i++)
            {
                for(int j = y - data.Radious; j<= y+data.Radious; j++)
                {
                    try
                    {
                        if (data.GridValues[i, j] != 0)
                            return false;
                    }
                    catch(IndexOutOfRangeException)
                    {
                        continue;
                    }
                }
            }

            return true;
        }
    }
}
