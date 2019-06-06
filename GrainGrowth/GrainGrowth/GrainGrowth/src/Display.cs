using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace GrainGrowth.src
{
    class Display
    {
        private Bitmap bitmap;
        private Graphics graphics;
        private PictureBox pictureBox;
        private Data data;

        public Display(PictureBox pictureBox, Data data)
        {
            this.pictureBox = pictureBox;
            this.data = data;

            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
        }

        public void Clear()
        {
            graphics.Clear(Color.White);
            pictureBox.Image = bitmap;
        }

        public void PrintCells()
        {
            Clear();
            
            for (int i = 0; i < data.SizeY; i++)
            {
                for (int j = 0; j < data.SizeX; j++)
                {
                        Rectangle rect = new Rectangle(
                            j * data.CellSize,
                            i * data.CellSize,
                            data.CellSize,
                            data.CellSize);
                        graphics.FillRectangle(data.Colors[data.GridValues[i,j]], rect);
                    
                }
            }
            pictureBox.Image = bitmap;
        }

        public void PrintEnergy()
        {
            Clear();

            for (int i = 0; i < data.SizeY; i++)
            {
                for (int j = 0; j < data.SizeX; j++)
                {
                    Rectangle rect = new Rectangle(
                        j * data.CellSize,
                        i * data.CellSize,
                        data.CellSize,
                        data.CellSize);
                    graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 255 / data.MaxEnergy * data.GridEnergy[i, j])), rect);
                }
            }

            pictureBox.Image = bitmap;
        }
    }
}
