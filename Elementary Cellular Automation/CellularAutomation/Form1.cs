using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellularAutomation
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        private Graphics graphics;
        const int cellSize = 7;
        private int sizeX;
        private int sizeY;
        private int iterations;

        bool[,] status;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
            Limits();
        }

        private void Limits()
        {
            sizeX_numericUpDown.Minimum = 1;
            sizeX_numericUpDown.Maximum = (pictureBox.Width / cellSize) -1;

            sizeY_numericUpDown.Minimum = 1;
            sizeY_numericUpDown.Maximum = (pictureBox.Height / cellSize) -1;

            iterations_numericUpDown.Minimum = 1;
            iterations_numericUpDown.Maximum = (pictureBox.Height / cellSize) - 1;
        }

        private void printGrid()
        {
            Pen blackPen = new Pen(Color.Black);

            for(int i=0; i<sizeX+1; i++)
            {
                graphics.DrawLine(blackPen, new Point(i * cellSize, 0), new Point(i* cellSize, sizeY * cellSize));
            }
            
            for (int i=0; i<sizeY+1; i++)
            {
                graphics.DrawLine(blackPen, new Point(0, i * cellSize), new Point(sizeX* cellSize, i* cellSize));
            }
        }

        public void setRule(int rule)
        {
            int previousValue;
            int actualValue;
            int nextValue;
            int combination;
            int shift;

            int startingIndex = (sizeX / 2);
            status[0, startingIndex] = true;

            for(int i=1; i<sizeY; i++)
            {
                for(int j=0; j<sizeX; j++)
                {
                    if(j==0)
                    {
                        previousValue = Convert.ToInt32(status[i - 1, sizeX - 1]);
                        actualValue = Convert.ToInt32(status[i - 1, j]);
                        nextValue = Convert.ToInt32(status[i - 1, j + 1]);
                    }
                    else if(j==sizeX -1)
                    {
                        previousValue = Convert.ToInt32(status[i - 1, j - 1]);
                        actualValue = Convert.ToInt32(status[i - 1, j]);
                        nextValue = Convert.ToInt32(status[i - 1, 0]);  
                    }
                    else
                    {
                        previousValue = Convert.ToInt32(status[i - 1, j - 1]);
                        actualValue = Convert.ToInt32(status[i - 1, j]);
                        nextValue = Convert.ToInt32(status[i - 1, j + 1]);   
                    }

                    combination = previousValue << 2 | actualValue << 1 | nextValue;
                    shift = 1 << combination;
                    

                    if ((rule & shift) != 0) //rule bitowo np30 [1 1 1 1 0]
                    {
                        status[i, j] = true;
                    }
                }

            }
        }

        private void printCells()
        {
            Brush blueBrush = new SolidBrush(Color.Blue);
            for(int i=0; i< iterations; i++)  
            {
                for(int j=0; j<sizeX; j++)
                {
                    if (status[i, j])
                    {
                        Rectangle rect = new Rectangle(
                            j * cellSize,
                            i * cellSize,
                            cellSize,
                            cellSize);
                        graphics.FillRectangle(blueBrush, rect);
                    }
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            status = new bool[sizeY, sizeX];

            printGrid();

            if (checkedListBox2.CheckedItems.Contains("Rule 30"))
            {
                setRule(30);
                printCells();
            }
            if (checkedListBox2.CheckedItems.Contains("Rule 60"))
            {
                setRule(60);
                printCells();
            }
            if (checkedListBox2.CheckedItems.Contains("Rule 90"))
            {
                setRule(90);
                printCells();
            }
            if (checkedListBox2.CheckedItems.Contains("Rule 120"))
            {
                setRule(120);
                printCells();
            }
            if (checkedListBox2.CheckedItems.Contains("Rule 225"))
            {
                setRule(225);
                printCells();
            }

            pictureBox.Image = bitmap;
        }

        private void sizeX_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            sizeX = decimal.ToInt32(sizeX_numericUpDown.Value);
        }

        private void sizeY_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            sizeY = decimal.ToInt32(sizeY_numericUpDown.Value);
        }

        private void iterations_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            iterations = decimal.ToInt32(iterations_numericUpDown.Value);
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
