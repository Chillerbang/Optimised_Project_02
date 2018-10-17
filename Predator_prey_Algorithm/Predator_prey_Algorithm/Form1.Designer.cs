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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblIterations = new System.Windows.Forms.Label();
            this.lblFitness = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblnopred = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rbtGbest = new System.Windows.Forms.RadioButton();
            this.rbtLbest = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 518);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(500, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(68, 558);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblIterations
            // 
            this.lblIterations.AutoSize = true;
            this.lblIterations.Location = new System.Drawing.Point(12, 560);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(50, 13);
            this.lblIterations.TabIndex = 3;
            this.lblIterations.Text = "Iterations";
            // 
            // lblFitness
            // 
            this.lblFitness.AutoSize = true;
            this.lblFitness.Location = new System.Drawing.Point(12, 593);
            this.lblFitness.Name = "lblFitness";
            this.lblFitness.Size = new System.Drawing.Size(40, 13);
            this.lblFitness.TabIndex = 5;
            this.lblFitness.Text = "Fitness";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(68, 591);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // lblnopred
            // 
            this.lblnopred.AutoSize = true;
            this.lblnopred.Location = new System.Drawing.Point(242, 565);
            this.lblnopred.Name = "lblnopred";
            this.lblnopred.Size = new System.Drawing.Size(103, 13);
            this.lblnopred.TabIndex = 6;
            this.lblnopred.Text = "Number of predators";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(362, 559);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // rbtGbest
            // 
            this.rbtGbest.AutoSize = true;
            this.rbtGbest.Location = new System.Drawing.Point(254, 594);
            this.rbtGbest.Name = "rbtGbest";
            this.rbtGbest.Size = new System.Drawing.Size(78, 17);
            this.rbtGbest.TabIndex = 8;
            this.rbtGbest.TabStop = true;
            this.rbtGbest.Text = "Global best";
            this.rbtGbest.UseVisualStyleBackColor = true;
            // 
            // rbtLbest
            // 
            this.rbtLbest.AutoSize = true;
            this.rbtLbest.Location = new System.Drawing.Point(338, 594);
            this.rbtLbest.Name = "rbtLbest";
            this.rbtLbest.Size = new System.Drawing.Size(75, 17);
            this.rbtLbest.TabIndex = 9;
            this.rbtLbest.TabStop = true;
            this.rbtLbest.Text = "Local Best";
            this.rbtLbest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 632);
            this.Controls.Add(this.rbtLbest);
            this.Controls.Add(this.rbtGbest);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblnopred);
            this.Controls.Add(this.lblFitness);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblIterations);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.Label lblFitness;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblnopred;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton rbtGbest;
        private System.Windows.Forms.RadioButton rbtLbest;
    }
}

