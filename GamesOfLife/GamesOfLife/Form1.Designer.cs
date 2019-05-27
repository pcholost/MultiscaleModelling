namespace GamesOfLife
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sizeX_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeY_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.speed_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.startCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeX_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeY_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(5, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(784, 486);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Unchanged",
            "Glider",
            "Oscillator",
            "Block",
            "Loaf",
            "Random"});
            this.checkedListBox1.Location = new System.Drawing.Point(795, 108);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sizeX_numericUpDown
            // 
            this.sizeX_numericUpDown.Location = new System.Drawing.Point(833, 7);
            this.sizeX_numericUpDown.Name = "sizeX_numericUpDown";
            this.sizeX_numericUpDown.Size = new System.Drawing.Size(59, 20);
            this.sizeX_numericUpDown.TabIndex = 4;
            this.sizeX_numericUpDown.ValueChanged += new System.EventHandler(this.sizeX_numericUpDown_ValueChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(795, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "sizeX";
            // 
            // sizeY_numericUpDown
            // 
            this.sizeY_numericUpDown.Location = new System.Drawing.Point(833, 35);
            this.sizeY_numericUpDown.Name = "sizeY_numericUpDown";
            this.sizeY_numericUpDown.Size = new System.Drawing.Size(59, 20);
            this.sizeY_numericUpDown.TabIndex = 7;
            this.sizeY_numericUpDown.ValueChanged += new System.EventHandler(this.sizeY_numericUpDown_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(795, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "sizeY";
            // 
            // speed_numericUpDown
            // 
            this.speed_numericUpDown.Location = new System.Drawing.Point(833, 61);
            this.speed_numericUpDown.Name = "speed_numericUpDown";
            this.speed_numericUpDown.Size = new System.Drawing.Size(59, 20);
            this.speed_numericUpDown.TabIndex = 10;
            this.speed_numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "speed";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // startCheckBox
            // 
            this.startCheckBox.AutoSize = true;
            this.startCheckBox.Location = new System.Drawing.Point(817, 238);
            this.startCheckBox.Name = "startCheckBox";
            this.startCheckBox.Size = new System.Drawing.Size(66, 17);
            this.startCheckBox.TabIndex = 12;
            this.startCheckBox.Text = "StartBox";
            this.startCheckBox.UseVisualStyleBackColor = true;
            this.startCheckBox.CheckedChanged += new System.EventHandler(this.startCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 492);
            this.Controls.Add(this.startCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.speed_numericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeY_numericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeX_numericUpDown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeX_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeY_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown sizeX_numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sizeY_numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown speed_numericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox startCheckBox;
    }
}

