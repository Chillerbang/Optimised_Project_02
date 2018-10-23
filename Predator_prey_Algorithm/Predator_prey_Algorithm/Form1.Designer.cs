namespace Predator_prey_Algorithm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtiteration = new System.Windows.Forms.TextBox();
            this.lblIterations = new System.Windows.Forms.Label();
            this.lblFitness = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblnopred = new System.Windows.Forms.Label();
            this.numpreditors = new System.Windows.Forms.NumericUpDown();
            this.rbtGbest = new System.Windows.Forms.RadioButton();
            this.rbtLbest = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.nudSeed = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numpreditors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 595);
            this.panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 627);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(235, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Generate Image";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtiteration
            // 
            this.txtiteration.Enabled = false;
            this.txtiteration.Location = new System.Drawing.Point(608, 630);
            this.txtiteration.Name = "txtiteration";
            this.txtiteration.Size = new System.Drawing.Size(120, 20);
            this.txtiteration.TabIndex = 2;
            // 
            // lblIterations
            // 
            this.lblIterations.AutoSize = true;
            this.lblIterations.Location = new System.Drawing.Point(552, 632);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(50, 13);
            this.lblIterations.TabIndex = 3;
            this.lblIterations.Text = "Iterations";
            // 
            // lblFitness
            // 
            this.lblFitness.AutoSize = true;
            this.lblFitness.Location = new System.Drawing.Point(752, 633);
            this.lblFitness.Name = "lblFitness";
            this.lblFitness.Size = new System.Drawing.Size(40, 13);
            this.lblFitness.TabIndex = 5;
            this.lblFitness.Text = "Fitness";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(808, 631);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 4;
            // 
            // lblnopred
            // 
            this.lblnopred.AutoSize = true;
            this.lblnopred.Location = new System.Drawing.Point(409, 671);
            this.lblnopred.Name = "lblnopred";
            this.lblnopred.Size = new System.Drawing.Size(103, 13);
            this.lblnopred.TabIndex = 6;
            this.lblnopred.Text = "Number of predators";
            // 
            // numpreditors
            // 
            this.numpreditors.Location = new System.Drawing.Point(518, 669);
            this.numpreditors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numpreditors.Name = "numpreditors";
            this.numpreditors.Size = new System.Drawing.Size(120, 20);
            this.numpreditors.TabIndex = 7;
            this.numpreditors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbtGbest
            // 
            this.rbtGbest.AutoSize = true;
            this.rbtGbest.Location = new System.Drawing.Point(960, 634);
            this.rbtGbest.Name = "rbtGbest";
            this.rbtGbest.Size = new System.Drawing.Size(78, 17);
            this.rbtGbest.TabIndex = 8;
            this.rbtGbest.Text = "Global best";
            this.rbtGbest.UseVisualStyleBackColor = true;
            // 
            // rbtLbest
            // 
            this.rbtLbest.AutoSize = true;
            this.rbtLbest.Checked = true;
            this.rbtLbest.Location = new System.Drawing.Point(1044, 634);
            this.rbtLbest.Name = "rbtLbest";
            this.rbtLbest.Size = new System.Drawing.Size(75, 17);
            this.rbtLbest.TabIndex = 9;
            this.rbtLbest.TabStop = true;
            this.rbtLbest.Text = "Local Best";
            this.rbtLbest.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 670);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 671);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Grid Size";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(284, 669);
            this.nudSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(120, 20);
            this.nudSize.TabIndex = 14;
            this.nudSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSeed
            // 
            this.nudSeed.Location = new System.Drawing.Point(80, 668);
            this.nudSeed.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudSeed.Name = "nudSeed";
            this.nudSeed.Size = new System.Drawing.Size(120, 20);
            this.nudSeed.TabIndex = 15;
            this.nudSeed.Value = new decimal(new int[] {
            541,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Run Algorithms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.runPreditor);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 714);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudSeed);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtLbest);
            this.Controls.Add(this.rbtGbest);
            this.Controls.Add(this.numpreditors);
            this.Controls.Add(this.lblnopred);
            this.Controls.Add(this.lblFitness);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblIterations);
            this.Controls.Add(this.txtiteration);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Predator Prey";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numpreditors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtiteration;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.Label lblFitness;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblnopred;
        private System.Windows.Forms.NumericUpDown numpreditors;
        private System.Windows.Forms.RadioButton rbtGbest;
        private System.Windows.Forms.RadioButton rbtLbest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.NumericUpDown nudSeed;
        private System.Windows.Forms.Button button1;
    }
}

