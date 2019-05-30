namespace GrainGrowth
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.sizeXUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeYUpDown = new System.Windows.Forms.NumericUpDown();
            this.Speed = new System.Windows.Forms.Label();
            this.speedUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.randomNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.xNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.yNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.radiousNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.radiousUpDown = new System.Windows.Forms.NumericUpDown();
            this.SingleStep = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ClearAll = new System.Windows.Forms.Button();
            this.Random = new System.Windows.Forms.Button();
            this.Homogeneous = new System.Windows.Forms.Button();
            this.Radious = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.neighborhoodUpDown = new System.Windows.Forms.NumericUpDown();
            this.submitNeighbor = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MCButton = new System.Windows.Forms.Button();
            this.showEnergyBox = new System.Windows.Forms.CheckBox();
            this.ktUpDown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.MCStep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sizeXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiousNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiousUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neighborhoodUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ktUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // sizeXUpDown
            // 
            this.sizeXUpDown.Location = new System.Drawing.Point(842, 7);
            this.sizeXUpDown.Name = "sizeXUpDown";
            this.sizeXUpDown.Size = new System.Drawing.Size(65, 20);
            this.sizeXUpDown.TabIndex = 1;
            this.sizeXUpDown.ValueChanged += new System.EventHandler(this.sizeXUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "sizeX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(791, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "sizeY";
            // 
            // sizeYUpDown
            // 
            this.sizeYUpDown.Location = new System.Drawing.Point(842, 43);
            this.sizeYUpDown.Name = "sizeYUpDown";
            this.sizeYUpDown.Size = new System.Drawing.Size(65, 20);
            this.sizeYUpDown.TabIndex = 4;
            this.sizeYUpDown.ValueChanged += new System.EventHandler(this.sizeYUpDown_ValueChanged);
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(787, 79);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(36, 13);
            this.Speed.TabIndex = 5;
            this.Speed.Text = "speed";
            // 
            // speedUpDown
            // 
            this.speedUpDown.Location = new System.Drawing.Point(842, 77);
            this.speedUpDown.Name = "speedUpDown";
            this.speedUpDown.Size = new System.Drawing.Size(65, 20);
            this.speedUpDown.TabIndex = 6;
            this.speedUpDown.ValueChanged += new System.EventHandler(this.speedUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(780, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "BCs";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(812, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "periodic/absorbing";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // randomNumUpDown
            // 
            this.randomNumUpDown.Location = new System.Drawing.Point(62, 451);
            this.randomNumUpDown.Name = "randomNumUpDown";
            this.randomNumUpDown.Size = new System.Drawing.Size(88, 20);
            this.randomNumUpDown.TabIndex = 12;
            this.randomNumUpDown.ValueChanged += new System.EventHandler(this.randomNumUpDown_ValueChanged);
            // 
            // xNumUpDown
            // 
            this.xNumUpDown.Location = new System.Drawing.Point(225, 451);
            this.xNumUpDown.Name = "xNumUpDown";
            this.xNumUpDown.Size = new System.Drawing.Size(88, 20);
            this.xNumUpDown.TabIndex = 13;
            this.xNumUpDown.ValueChanged += new System.EventHandler(this.xNumUpDown_ValueChanged);
            // 
            // yNumUpDown
            // 
            this.yNumUpDown.Location = new System.Drawing.Point(225, 485);
            this.yNumUpDown.Name = "yNumUpDown";
            this.yNumUpDown.Size = new System.Drawing.Size(88, 20);
            this.yNumUpDown.TabIndex = 14;
            this.yNumUpDown.ValueChanged += new System.EventHandler(this.yNumUpDown_ValueChanged);
            // 
            // radiousNumUpDown
            // 
            this.radiousNumUpDown.Location = new System.Drawing.Point(383, 451);
            this.radiousNumUpDown.Name = "radiousNumUpDown";
            this.radiousNumUpDown.Size = new System.Drawing.Size(88, 20);
            this.radiousNumUpDown.TabIndex = 15;
            this.radiousNumUpDown.ValueChanged += new System.EventHandler(this.radiousNumUpDown_ValueChanged);
            // 
            // radiousUpDown
            // 
            this.radiousUpDown.Location = new System.Drawing.Point(383, 485);
            this.radiousUpDown.Name = "radiousUpDown";
            this.radiousUpDown.Size = new System.Drawing.Size(88, 20);
            this.radiousUpDown.TabIndex = 16;
            this.radiousUpDown.ValueChanged += new System.EventHandler(this.radiousUpDown_ValueChanged);
            // 
            // SingleStep
            // 
            this.SingleStep.Location = new System.Drawing.Point(499, 496);
            this.SingleStep.Name = "SingleStep";
            this.SingleStep.Size = new System.Drawing.Size(80, 23);
            this.SingleStep.TabIndex = 17;
            this.SingleStep.Text = "Single Step";
            this.SingleStep.UseVisualStyleBackColor = true;
            this.SingleStep.Click += new System.EventHandler(this.SingleStep_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "NumberX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "NumberY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(331, 487);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Radious";
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(499, 467);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(80, 23);
            this.ClearAll.TabIndex = 24;
            this.ClearAll.Text = "Clear All";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(62, 514);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(88, 23);
            this.Random.TabIndex = 25;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // Homogeneous
            // 
            this.Homogeneous.Location = new System.Drawing.Point(225, 514);
            this.Homogeneous.Name = "Homogeneous";
            this.Homogeneous.Size = new System.Drawing.Size(88, 23);
            this.Homogeneous.TabIndex = 26;
            this.Homogeneous.Text = "Homogeneous";
            this.Homogeneous.UseVisualStyleBackColor = true;
            this.Homogeneous.Click += new System.EventHandler(this.Homogeneous_Click);
            // 
            // Radious
            // 
            this.Radious.Location = new System.Drawing.Point(383, 514);
            this.Radious.Name = "Radious";
            this.Radious.Size = new System.Drawing.Size(88, 23);
            this.Radious.TabIndex = 27;
            this.Radious.Text = "Radious";
            this.Radious.UseVisualStyleBackColor = true;
            this.Radious.Click += new System.EventHandler(this.Radious_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "VonNeumann",
            "Moore",
            "RandomPenta",
            "LeftHex",
            "RightHex",
            "RandomHex",
            "Radious"});
            this.checkedListBox1.Location = new System.Drawing.Point(794, 154);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(125, 109);
            this.checkedListBox1.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(818, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Neighborhood";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(798, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Neighborhood Radious";
            // 
            // neighborhoodUpDown
            // 
            this.neighborhoodUpDown.Location = new System.Drawing.Point(799, 287);
            this.neighborhoodUpDown.Name = "neighborhoodUpDown";
            this.neighborhoodUpDown.Size = new System.Drawing.Size(120, 20);
            this.neighborhoodUpDown.TabIndex = 31;
            this.neighborhoodUpDown.ValueChanged += new System.EventHandler(this.neighborhoodUpDown_ValueChanged);
            // 
            // submitNeighbor
            // 
            this.submitNeighbor.Location = new System.Drawing.Point(812, 313);
            this.submitNeighbor.Name = "submitNeighbor";
            this.submitNeighbor.Size = new System.Drawing.Size(95, 23);
            this.submitNeighbor.TabIndex = 32;
            this.submitNeighbor.Text = "Submit Neighbor";
            this.submitNeighbor.UseVisualStyleBackColor = true;
            this.submitNeighbor.Click += new System.EventHandler(this.submitNeighbor_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(5, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(767, 428);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(827, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "MonteCarlo";
            // 
            // MCButton
            // 
            this.MCButton.Location = new System.Drawing.Point(817, 412);
            this.MCButton.Name = "MCButton";
            this.MCButton.Size = new System.Drawing.Size(75, 23);
            this.MCButton.TabIndex = 34;
            this.MCButton.Text = "MC";
            this.MCButton.UseVisualStyleBackColor = true;
            this.MCButton.Click += new System.EventHandler(this.MCButton_Click);
            // 
            // showEnergyBox
            // 
            this.showEnergyBox.AutoSize = true;
            this.showEnergyBox.Location = new System.Drawing.Point(817, 451);
            this.showEnergyBox.Name = "showEnergyBox";
            this.showEnergyBox.Size = new System.Drawing.Size(84, 17);
            this.showEnergyBox.TabIndex = 35;
            this.showEnergyBox.Text = "showEnergy";
            this.showEnergyBox.UseVisualStyleBackColor = true;
            this.showEnergyBox.CheckedChanged += new System.EventHandler(this.showEnergyBox_CheckedChanged);
            // 
            // ktUpDown
            // 
            this.ktUpDown.Location = new System.Drawing.Point(826, 474);
            this.ktUpDown.Name = "ktUpDown";
            this.ktUpDown.Size = new System.Drawing.Size(75, 20);
            this.ktUpDown.TabIndex = 36;
            this.ktUpDown.ValueChanged += new System.EventHandler(this.ktUpDown_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(805, 476);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "kt:";
            // 
            // MCStep
            // 
            this.MCStep.Location = new System.Drawing.Point(817, 500);
            this.MCStep.Name = "MCStep";
            this.MCStep.Size = new System.Drawing.Size(75, 23);
            this.MCStep.TabIndex = 38;
            this.MCStep.Text = "MCStep";
            this.MCStep.UseVisualStyleBackColor = true;
            this.MCStep.Click += new System.EventHandler(this.MCStep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 559);
            this.Controls.Add(this.MCStep);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ktUpDown);
            this.Controls.Add(this.showEnergyBox);
            this.Controls.Add(this.MCButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.submitNeighbor);
            this.Controls.Add(this.neighborhoodUpDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Radious);
            this.Controls.Add(this.Homogeneous);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SingleStep);
            this.Controls.Add(this.radiousUpDown);
            this.Controls.Add(this.radiousNumUpDown);
            this.Controls.Add(this.yNumUpDown);
            this.Controls.Add(this.xNumUpDown);
            this.Controls.Add(this.randomNumUpDown);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.speedUpDown);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.sizeYUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeXUpDown);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sizeXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiousNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiousUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neighborhoodUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ktUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown sizeXUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sizeYUpDown;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.NumericUpDown speedUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown randomNumUpDown;
        private System.Windows.Forms.NumericUpDown xNumUpDown;
        private System.Windows.Forms.NumericUpDown yNumUpDown;
        private System.Windows.Forms.NumericUpDown radiousNumUpDown;
        private System.Windows.Forms.NumericUpDown radiousUpDown;
        private System.Windows.Forms.Button SingleStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Button Homogeneous;
        private System.Windows.Forms.Button Radious;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown neighborhoodUpDown;
        private System.Windows.Forms.Button submitNeighbor;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button MCButton;
        private System.Windows.Forms.CheckBox showEnergyBox;
        private System.Windows.Forms.NumericUpDown ktUpDown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button MCStep;
    }
}

