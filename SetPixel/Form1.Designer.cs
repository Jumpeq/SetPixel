namespace SetPixel
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.textBoxY2B = new System.Windows.Forms.TextBox();
            this.textBoxX2B = new System.Windows.Forms.TextBox();
            this.textBoxX1B = new System.Windows.Forms.TextBox();
            this.textBoxY1B = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBoxBresenham = new System.Windows.Forms.PictureBox();
            this.DrawBresenham = new System.Windows.Forms.Button();
            this.ClearBresenham = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBresenham)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(437, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wyczyść";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Wheat;
            this.pictureBox1.Location = new System.Drawing.Point(12, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(144, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Algorytm przyrostowy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y1:";
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(125, 56);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(36, 20);
            this.textBoxY1.TabIndex = 6;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(46, 82);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(36, 20);
            this.textBoxX2.TabIndex = 6;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(125, 82);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(36, 20);
            this.textBoxY2.TabIndex = 6;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(46, 56);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(36, 20);
            this.textBoxX1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "X2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Y2:";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDraw.Location = new System.Drawing.Point(186, 79);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Rysuj";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // textBoxY2B
            // 
            this.textBoxY2B.Location = new System.Drawing.Point(689, 82);
            this.textBoxY2B.Name = "textBoxY2B";
            this.textBoxY2B.Size = new System.Drawing.Size(36, 20);
            this.textBoxY2B.TabIndex = 15;
            // 
            // textBoxX2B
            // 
            this.textBoxX2B.Location = new System.Drawing.Point(610, 82);
            this.textBoxX2B.Name = "textBoxX2B";
            this.textBoxX2B.Size = new System.Drawing.Size(36, 20);
            this.textBoxX2B.TabIndex = 16;
            // 
            // textBoxX1B
            // 
            this.textBoxX1B.Location = new System.Drawing.Point(610, 56);
            this.textBoxX1B.Name = "textBoxX1B";
            this.textBoxX1B.Size = new System.Drawing.Size(36, 20);
            this.textBoxX1B.TabIndex = 17;
            // 
            // textBoxY1B
            // 
            this.textBoxY1B.Location = new System.Drawing.Point(689, 56);
            this.textBoxY1B.Name = "textBoxY1B";
            this.textBoxY1B.Size = new System.Drawing.Size(36, 20);
            this.textBoxY1B.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Y2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(656, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Y1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(581, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "X2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(581, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "X1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(708, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Algorytm Bresenhama";
            // 
            // pictureBoxBresenham
            // 
            this.pictureBoxBresenham.BackColor = System.Drawing.Color.Wheat;
            this.pictureBoxBresenham.Location = new System.Drawing.Point(576, 114);
            this.pictureBoxBresenham.Name = "pictureBoxBresenham";
            this.pictureBoxBresenham.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxBresenham.TabIndex = 9;
            this.pictureBoxBresenham.TabStop = false;
            this.pictureBoxBresenham.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBresenham_MouseClick);
            // 
            // DrawBresenham
            // 
            this.DrawBresenham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DrawBresenham.Location = new System.Drawing.Point(750, 79);
            this.DrawBresenham.Name = "DrawBresenham";
            this.DrawBresenham.Size = new System.Drawing.Size(75, 23);
            this.DrawBresenham.TabIndex = 7;
            this.DrawBresenham.Text = "Rysuj";
            this.DrawBresenham.UseVisualStyleBackColor = true;
            this.DrawBresenham.Click += new System.EventHandler(this.DrawBresenham_Click);
            // 
            // ClearBresenham
            // 
            this.ClearBresenham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearBresenham.Location = new System.Drawing.Point(1001, 79);
            this.ClearBresenham.Name = "ClearBresenham";
            this.ClearBresenham.Size = new System.Drawing.Size(75, 23);
            this.ClearBresenham.TabIndex = 8;
            this.ClearBresenham.Text = "Wyczyść";
            this.ClearBresenham.UseVisualStyleBackColor = true;
            this.ClearBresenham.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 627);
            this.Controls.Add(this.textBoxY2B);
            this.Controls.Add(this.textBoxX2B);
            this.Controls.Add(this.textBoxX1B);
            this.Controls.Add(this.textBoxY1B);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBoxBresenham);
            this.Controls.Add(this.DrawBresenham);
            this.Controls.Add(this.ClearBresenham);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Rysuj odcinek";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBresenham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TextBox textBoxY2B;
        private System.Windows.Forms.TextBox textBoxX2B;
        private System.Windows.Forms.TextBox textBoxX1B;
        private System.Windows.Forms.TextBox textBoxY1B;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBoxBresenham;
        private System.Windows.Forms.Button DrawBresenham;
        private System.Windows.Forms.Button ClearBresenham;
    }
}

