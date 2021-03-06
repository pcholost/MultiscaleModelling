﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GrainGrowth.src
{
    class Data
    {
        private int sizeX;
        private int sizeY;
        private int cellSize;
        private bool isPeriodic;
        private int speed;
        private int currentIndex;

        private List<Brush> colors;
        private List<int> cells;
        private int[,] gridValues;
        private Point[,] gridPoints;
        private List<Point> randomPoints;

        private Random random;

        private int randomNum;
        private int xHomogenousNum;
        private int yHomogenousNum;
        private int radious;
        private int radiousNum;

        private int neighborhoodRadious;
        private string nameOfNeighbor;

        private double kt;
        private int[,] gridEnergy;
        private bool showEnergy;
        private int maxEnergy = 1;

        //
        private double a;
        private double b;
        private double deltaRo;
        private double dislocation;
        private double criticalDislocation;
        private double temperature;
        private double strainRate;
        private double sigma;
        //

        //gettery i settery
        public int SizeX { get => sizeX; set => sizeX = value; }
        public int SizeY { get => sizeY; set => sizeY = value; }
        public int CellSize { get => cellSize; set => cellSize = value; }
        public bool IsPeriodic { get => isPeriodic; set => isPeriodic = value; }
        public int Speed { get => speed; set => speed = value; }
        public int CurrentIndex { get => currentIndex; set => currentIndex = value; }

        public List<int> Cells { get => cells; set => cells = value; }
        public List<Brush> Colors { get => colors; set => colors = value; }
        public int[,] GridValues { get => gridValues; set => gridValues = value; }
        public Point[,] GridPoints { get => gridPoints; set => gridPoints = value; }
        public List<Point> RandomPoints { get => randomPoints; set => randomPoints = value; }

        public int RandomNum { get => randomNum; set => randomNum = value; }
        public int XHomogenousNum { get => xHomogenousNum; set => xHomogenousNum = value; }
        public int YHomogenousNum { get => yHomogenousNum; set => yHomogenousNum = value; }
        public int Radious { get => radious; set => radious = value; }
        public int RadiousNum { get => radiousNum; set => radiousNum = value; }
        public int NeighborhoodRadious { get => neighborhoodRadious; set => neighborhoodRadious = value; }
        public string NameOfNeighbor { get => nameOfNeighbor; set => nameOfNeighbor = value; }

        public double Kt { get => kt; set => kt = value; }
        public int[,] GridEnergy { get => gridEnergy; set => gridEnergy = value; }
        public bool ShowEnergy { get => showEnergy; set => showEnergy = value; }
        public int MaxEnergy { get => maxEnergy; set => maxEnergy = value; }

        //
        public double DeltaRo { get => deltaRo; set => deltaRo = value; }
        public double Dislocation { get => dislocation; set => dislocation = value; }
        public double CriticalDislocation { get => criticalDislocation; set => criticalDislocation = value; }
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double StrainRate { get => strainRate; set => strainRate = value; }
        public double Temperature { get => temperature; set => temperature = value; }
        public double Sigma { get => sigma; set => sigma = value; }
        //
        public Data()
        {
            random = new Random();

            isPeriodic = false;
            currentIndex = 0;
            CellSize = 10;
            A = 86710969050178.5;
            B = 9.41268203527779;
            Temperature = 900;
            StrainRate = 1;
            CriticalDislocation = 46842668.25;
        }

        public void Initialize()
        {
            Colors = new List<Brush>
            {
                new SolidBrush(Color.FromArgb(255, 255, 255))
            };

            cells = new List<int>
            {
                new int()
            };

            currentIndex = 0;
            gridValues = new int[sizeY, sizeX];
            gridPoints = new Point[sizeY, sizeX];
            gridEnergy = new int[sizeY, sizeX];
            for(int i=0; i<sizeY; i++)
            {
                for(int j=0; j<sizeX; j++)
                {
                    gridPoints[i, j] = new Point(random.Next(i * cellSize, (i + 1) * cellSize), random.Next(j * cellSize, (j + 1) * cellSize));
                }
            }
        }

        public void AddNewColor()
        {
            cells.Add(1);
            colors.Add(new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256))));
        }
    }
}
