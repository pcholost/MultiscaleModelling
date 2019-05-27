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

namespace GamesOfLife
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        private Graphics graphics;
        private int sizeX;
        private int sizeY;
        private const int cellSize = 6;
        private int speedValue;
        bool[,] status;

        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);

            setLimits();
        }

        private void setLimits()
        {
            sizeX_numericUpDown.Minimum = 5;
            sizeX_numericUpDown.Maximum = (pictureBox.Width / cellSize) - 1;
            sizeX_numericUpDown.Value = 5;

            sizeY_numericUpDown.Minimum = 5;
            sizeY_numericUpDown.Maximum = (pictureBox.Height / cellSize) - 1;
            sizeY_numericUpDown.Value = 5;

            speed_numericUpDown.Minimum = 1;
            speed_numericUpDown.Maximum = 10;
            speed_numericUpDown.Value = 5;

            status = new bool[sizeY, sizeX];

            setPattern();
            print();
        }

        private void printGrid()
        {
            Pen blackPen = new Pen(Color.Black);

            for (int i = 0; i < sizeX + 1; i++)
            {
                graphics.DrawLine(blackPen, new Point(i * cellSize, 0), new Point(i * cellSize, sizeY * cellSize));
            }

            for (int i = 0; i < sizeY + 1; i++)
            {
                graphics.DrawLine(blackPen, new Point(0, i * cellSize), new Point(sizeX * cellSize, i * cellSize));
            }
            pictureBox.Image = bitmap;
        }

        private void printCells()
        {
            Brush blueBrush = new SolidBrush(Color.Blue);
            for (int i = 0; i < sizeY; i++)
            {
                for (int j = 0; j < sizeX; j++)
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

        private void setPattern()
        {
            if(checkedListBox1.CheckedItems.Contains("Unchanged"))
            {
                status[sizeY / 2, sizeX / 2 + 1] = true;
                status[sizeY / 2 - 1, sizeX / 2] = true;
                status[sizeY / 2 - 1, sizeX / 2 - 1] = true;
                status[sizeY / 2, sizeX / 2 - 2] = true;
                status[sizeY / 2 + 1, sizeX / 2] = true;
                status[sizeY / 2 + 1, sizeX / 2 - 1] = true;
            }
            else if(checkedListBox1.CheckedItems.Contains("Glider"))
            {
                status[sizeY / 2, sizeX / 2] = true;
                status[sizeY / 2 - 1, sizeX / 2 - 1] = true;
                status[sizeY / 2, sizeX / 2 + 1] = true;
                status[sizeY / 2 + 1, sizeX / 2] = true;
                status[sizeY / 2 + 1, sizeX / 2 - 1] = true;
            }
          
            else if(checkedListBox1.CheckedItems.Contains("Oscillator"))
            {
                status[sizeY / 2 + 1, sizeX/2] = true;
                status[sizeY / 2, sizeX/2] = true;
                status[sizeY / 2 - 1, sizeX/2] = true;
            }
            else if(checkedListBox1.CheckedItems.Contains("Loaf"))
            {
                status[sizeY / 2 - 1, sizeX / 2] = true;
                status[sizeY / 2 - 1, sizeX / 2 - 1] = true;
                status[sizeY / 2, sizeX / 2 + 1] = true;
                status[sizeY / 2 + 1, sizeX / 2 + 1] = true;
                status[sizeY / 2 + 2, sizeX / 2] = true;
                status[sizeY / 2 + 1, sizeX / 2 - 1] = true;
                status[sizeY / 2, sizeX / 2 - 2] = true;
            }
            else if(checkedListBox1.CheckedItems.Contains("Block"))
            {
                status[sizeY / 2 - 1, sizeX / 2] = true;
                status[sizeY / 2, sizeX / 2] = true;
                status[sizeY / 2 - 1, sizeX / 2 + 1] = true;
                status[sizeY / 2, sizeX / 2 + 1] = true;
            }
            else if(checkedListBox1.CheckedItems.Contains("Random"))
            {
                Random rand = new Random();
                for (int i = 0; i < sizeY; i++)
                {
                    for (int j = 0; j < sizeX; j++)
                    {
                        status[i, j] = rand.NextDouble() >= 0.5;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);

            status = new bool[sizeY, sizeX];

            startCheckBox.Checked = false;

            if (checkedListBox1.CheckedItems.Contains("Unchanged"))
            {
                setPattern();
            }
            if (checkedListBox1.CheckedItems.Contains("Glider"))
            {
                setPattern();
            }
            if (checkedListBox1.CheckedItems.Contains("Oscillator"))
            {
                setPattern();
            }
            if (checkedListBox1.CheckedItems.Contains("Loaf"))
            {
                setPattern();
            }
            if (checkedListBox1.CheckedItems.Contains("Block"))
            {
                setPattern();
            }
            if (checkedListBox1.CheckedItems.Contains("Random"))
            {
                setPattern();
            }

            print();
            pictureBox.Image = bitmap;
        }

        private void Start_Game()
        {
            while (startCheckBox.Checked)
            {
                Check_conditions();
                print();
                Thread.Sleep(speedValue * 100);
            }
        }

        private void Check_conditions()
        {
            bool[,] nextStepStatus = new bool[sizeY, sizeX];

            for (int i = 0; i < sizeY; i++)
            {
                for (int j = 0; j < sizeX; j++)
                {
                    int neighboursCounter = countNeighbours(i, j);
                    bool isAlive = status[i, j];

                    if (isAlive)
                    {
                        if (neighboursCounter < 2)
                        {
                            nextStepStatus[i, j] = false;
                        }
                        else if (neighboursCounter > 3)
                        {
                            nextStepStatus[i, j] = false;
                        }
                        else
                        {
                            nextStepStatus[i, j] = true;
                        }
                    }
                    else
                    {
                        if (neighboursCounter == 3)
                        {
                            nextStepStatus[i, j] = true;
                        }
                        else
                        {
                            nextStepStatus[i, j] = false;
                        }
                    }
                }
            }

            status = nextStepStatus;
        }

        private int countNeighbours(int x, int y)
        {
            int count = 0;

            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i == x && j == y)
                    {
                        continue;
                    }

                    int index_x = i;
                    int index_y = j;

                    if (i == -1)
                    {
                        index_x = sizeY - 1;
                    }
                    else if (i == sizeY)
                    {
                        index_x = 0;
                    }

                    if (j == -1)
                    {
                        index_y = sizeX - 1;
                    }
                    else if (j == sizeX)
                    {
                        index_y = 0;
                    }

                    if (status[index_x, index_y])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private void print()
        {
            lock (graphics)
            {
                graphics.Clear(Color.White);
                printCells();
                printGrid();
            }
        }

        private void sizeX_numericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            startCheckBox.Checked = false;
            sizeX = decimal.ToInt32(sizeX_numericUpDown.Value);
        }

        private void sizeY_numericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            startCheckBox.Checked = false;
            sizeY = decimal.ToInt32(sizeY_numericUpDown.Value);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            int y = coordinates.Y / cellSize;
            int x = coordinates.X / cellSize;

            bool coordinateStatus = status[y, x];

            if (coordinateStatus)
            { 
                status[y, x] = false;
            }
            else
            {
                status[y, x] = true;
            }

            print();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            speedValue = decimal.ToInt32(speed_numericUpDown.Value); ;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void startCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (startCheckBox.Checked)
            {
                Thread thr = new Thread(Start_Game);
                thr.IsBackground = true;
                thr.Start();
            }
        }
    }
}
