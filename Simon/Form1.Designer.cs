namespace Simon
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
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Game = new System.Windows.Forms.Timer(this.components);
            this.P4 = new System.Windows.Forms.PictureBox();
            this.P3 = new System.Windows.Forms.PictureBox();
            this.P2 = new System.Windows.Forms.PictureBox();
            this.P1 = new System.Windows.Forms.PictureBox();
            this.Delay = new System.Windows.Forms.Timer(this.components);
            this.Stage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.P4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(258, 202);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start ";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(258, 234);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Game
            // 
            this.Game.Interval = 500;
            this.Game.Tick += new System.EventHandler(this.Game_Tick);
            // 
            // P4
            // 
            this.P4.Image = global::Simon.Properties.Resources.karnaf;
            this.P4.Location = new System.Drawing.Point(344, 265);
            this.P4.Name = "P4";
            this.P4.Size = new System.Drawing.Size(234, 189);
            this.P4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P4.TabIndex = 5;
            this.P4.TabStop = false;
            this.P4.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // P3
            // 
            this.P3.Image = global::Simon.Properties.Resources.lion;
            this.P3.Location = new System.Drawing.Point(12, 265);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(234, 189);
            this.P3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P3.TabIndex = 4;
            this.P3.TabStop = false;
            this.P3.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // P2
            // 
            this.P2.Image = global::Simon.Properties.Resources.zebra;
            this.P2.Location = new System.Drawing.Point(12, 12);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(234, 189);
            this.P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P2.TabIndex = 3;
            this.P2.TabStop = false;
            this.P2.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // P1
            // 
            this.P1.Image = global::Simon.Properties.Resources.fish;
            this.P1.Location = new System.Drawing.Point(344, 12);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(234, 189);
            this.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P1.TabIndex = 2;
            this.P1.TabStop = false;
            this.P1.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // Delay
            // 
            this.Delay.Interval = 350;
            this.Delay.Tick += new System.EventHandler(this.Delay_Tick);
            // 
            // Stage
            // 
            this.Stage.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Stage.Location = new System.Drawing.Point(248, 129);
            this.Stage.Name = "Stage";
            this.Stage.Size = new System.Drawing.Size(94, 20);
            this.Stage.TabIndex = 6;
            this.Stage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(590, 466);
            this.Controls.Add(this.Stage);
            this.Controls.Add(this.P4);
            this.Controls.Add(this.P3);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.P4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox P1;
        private System.Windows.Forms.PictureBox P2;
        private System.Windows.Forms.PictureBox P3;
        private System.Windows.Forms.PictureBox P4;
        private System.Windows.Forms.Timer Game;
        private System.Windows.Forms.Timer Delay;
        private System.Windows.Forms.TextBox Stage;
    }
}

