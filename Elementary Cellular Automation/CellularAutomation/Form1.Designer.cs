namespace CellularAutomation
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sizeX_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sizeY_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.iterations_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeX_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeY_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterations_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(4, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(705, 480);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(716, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "sizeX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(716, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "sizeY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(716, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Rules";
            // 
            // sizeX_numericUpDown
            // 
            this.sizeX_numericUpDown.Location = new System.Drawing.Point(771, 7);
            this.sizeX_numericUpDown.Name = "sizeX_numericUpDown";
            this.sizeX_numericUpDown.Size = new System.Drawing.Size(73, 20);
            this.sizeX_numericUpDown.TabIndex = 4;
            this.sizeX_numericUpDown.ValueChanged += new System.EventHandler(this.sizeX_numericUpDown_ValueChanged);
            // 
            // sizeY_numericUpDown
            // 
            this.sizeY_numericUpDown.Location = new System.Drawing.Point(771, 43);
            this.sizeY_numericUpDown.Name = "sizeY_numericUpDown";
            this.sizeY_numericUpDown.Size = new System.Drawing.Size(73, 20);
            this.sizeY_numericUpDown.TabIndex = 5;
            this.sizeY_numericUpDown.ValueChanged += new System.EventHandler(this.sizeY_numericUpDown_ValueChanged);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Rule 30",
            "Rule 60",
            "Rule 90",
            "Rule 120",
            "Rule 225"});
            this.checkedListBox2.Location = new System.Drawing.Point(719, 190);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(108, 94);
            this.checkedListBox2.TabIndex = 7;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(775, 337);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(73, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // iterations_numericUpDown
            // 
            this.iterations_numericUpDown.Location = new System.Drawing.Point(771, 79);
            this.iterations_numericUpDown.Name = "iterations_numericUpDown";
            this.iterations_numericUpDown.Size = new System.Drawing.Size(73, 20);
            this.iterations_numericUpDown.TabIndex = 9;
            this.iterations_numericUpDown.ValueChanged += new System.EventHandler(this.iterations_numericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(715, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "iterations";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(860, 485);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.iterations_numericUpDown);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.sizeY_numericUpDown);
            this.Controls.Add(this.sizeX_numericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Cellular Automation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeX_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeY_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterations_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown sizeX_numericUpDown;
        private System.Windows.Forms.NumericUpDown sizeY_numericUpDown;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.NumericUpDown iterations_numericUpDown;
        private System.Windows.Forms.Label label7;
    }
}

