using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrainGrowth.src;
using System.Threading;

namespace GrainGrowth
{
    public partial class Form1 : Form
    {
        private Display display;
        private Execute execute;
        private Data data;
        private Neighbor neighbor;
        public Form1()
        {
            InitializeComponent();

            data = new Data();
            display = new Display(pictureBox, data);
            execute = new Execute(display, data);
            neighbor = new Neighbor(data, execute);

            Set_Limits();
        }

        private void Set_Limits()
        {

            sizeXUpDown.Minimum = 1;
            sizeXUpDown.Maximum = pictureBox.Width / data.CellSize;
            sizeXUpDown.Value = sizeXUpDown.Maximum;

            sizeYUpDown.Minimum = 1;
            sizeYUpDown.Maximum = pictureBox.Height / data.CellSize;
            sizeYUpDown.Value = sizeYUpDown.Maximum;

            speedUpDown.Minimum = 0;
            speedUpDown.Maximum = 100;

            randomNumUpDown.Minimum = 1;
            randomNumUpDown.Maximum = 100;
            randomNumUpDown.Value = 10;

            xNumUpDown.Minimum = 1;
            xNumUpDown.Value = 10;

            yNumUpDown.Minimum = 1;
            yNumUpDown.Value = 10;

            radiousUpDown.Minimum = 1;
            radiousUpDown.Value = 5;
            radiousUpDown.Maximum = 15;

            radiousNumUpDown.Minimum = 1;
            radiousNumUpDown.Value = 5;
            radiousNumUpDown.Maximum = 20; 

            neighborhoodUpDown.Minimum = 1;

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void randomNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.RandomNum = decimal.ToInt32(randomNumUpDown.Value);
        }

        private void xNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.XHomogenousNum = decimal.ToInt32(xNumUpDown.Value);
        }

        private void yNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.YHomogenousNum = decimal.ToInt32(yNumUpDown.Value);
        }

        private void radiousNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.RadiousNum = decimal.ToInt32(radiousNumUpDown.Value);
        }

        private void radiousUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.Radious = decimal.ToInt32(radiousUpDown.Value);
        }

        private void sizeXUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.SizeX = decimal.ToInt32(sizeXUpDown.Value);
        }

        private void sizeYUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.SizeY = decimal.ToInt32(sizeYUpDown.Value);
        }

        private void speedUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.Speed = decimal.ToInt32(speedUpDown.Value);
        }

        private void SingleStep_Click(object sender, EventArgs e)
        {
            neighbor.OwnNeighbor();
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            data.Initialize();
            display.Clear();
        }

        //periodic
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                data.IsPeriodic = true;
            }
            else
            {
                data.IsPeriodic = false;
            }
        }

        private void Random_Click(object sender, EventArgs e)
        {
            neighbor.RandomNeighbor();
        }

        private void Homogeneous_Click(object sender, EventArgs e)
        {
            neighbor.HomogenousNeighbor();
        }

        private void Radious_Click(object sender, EventArgs e)
        {
            neighbor.RadiousNeighbor();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coords = me.Location;

            neighbor.OwnNeighborClick(coords, display);
        }

        private void neighborhoodUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.NeighborhoodRadious = decimal.ToInt32(neighborhoodUpDown.Value);
        }

        private void submitNeighbor_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Contains("VonNeumann"))
            {
                data.NameOfNeighbor = "VonNeumann";
            }
            if (checkedListBox1.CheckedItems.Contains("Moore"))
            {
                data.NameOfNeighbor = "Moore";
            }
            if (checkedListBox1.CheckedItems.Contains("RandomPenta"))
            {
                data.NameOfNeighbor = "RandomPenta";
            }
            if (checkedListBox1.CheckedItems.Contains("LeftHex"))
            {
                data.NameOfNeighbor = "LeftHex";
            }
            if (checkedListBox1.CheckedItems.Contains("RightHex"))
            {
                data.NameOfNeighbor = "RightHex";
            }
            if (checkedListBox1.CheckedItems.Contains("RandomHex"))
            {
                data.NameOfNeighbor = "RandomHex";
            }
            if (checkedListBox1.CheckedItems.Contains("Radious"))
            {
                data.NameOfNeighbor = "Radious";
            }
        }

        private void ktUpDown_ValueChanged(object sender, EventArgs e)
        {
            data.Kt = decimal.ToDouble(ktUpDown.Value);
            if (data.Kt == 0)
                data.Kt = -6;
        }

        private void MCButton_Click(object sender, EventArgs e)
        {
            data.Kt = decimal.ToInt32(ktUpDown.Value);
            //neighbor itd
        }

        private void MCStep_Click(object sender, EventArgs e)
        {

        }

        private void showEnergyBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showEnergyBox.Checked)
            {
                data.ShowEnergy = true;

                if (data.GridPoints != null)
                    display.PrintEnergy();
            }
            else
            {
                data.ShowEnergy = false;

                if (data.GridEnergy != null)
                    display.PrintCells();
            }
        }
    }
}

