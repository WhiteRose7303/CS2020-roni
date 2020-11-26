namespace X_O
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
            this.Exit = new System.Windows.Forms.Button();
            this.Player = new System.Windows.Forms.TextBox();
            this.BR = new System.Windows.Forms.PictureBox();
            this.BL = new System.Windows.Forms.PictureBox();
            this.BM = new System.Windows.Forms.PictureBox();
            this.MR = new System.Windows.Forms.PictureBox();
            this.ML = new System.Windows.Forms.PictureBox();
            this.TR = new System.Windows.Forms.PictureBox();
            this.TM = new System.Windows.Forms.PictureBox();
            this.MM = new System.Windows.Forms.PictureBox();
            this.TL = new System.Windows.Forms.PictureBox();
            this.Board = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 377);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(320, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Player
            // 
            this.Player.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player.Enabled = false;
            this.Player.Location = new System.Drawing.Point(85, 12);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(177, 20);
            this.Player.TabIndex = 11;
            // 
            // BR
            // 
            this.BR.Location = new System.Drawing.Point(239, 267);
            this.BR.Name = "BR";
            this.BR.Size = new System.Drawing.Size(75, 76);
            this.BR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BR.TabIndex = 10;
            this.BR.TabStop = false;
            this.BR.Click += new System.EventHandler(this.P_Click);
            // 
            // BL
            // 
            this.BL.Location = new System.Drawing.Point(33, 267);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(75, 76);
            this.BL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BL.TabIndex = 9;
            this.BL.TabStop = false;
            this.BL.Click += new System.EventHandler(this.P_Click);
            // 
            // BM
            // 
            this.BM.Location = new System.Drawing.Point(136, 267);
            this.BM.Name = "BM";
            this.BM.Size = new System.Drawing.Size(75, 76);
            this.BM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BM.TabIndex = 8;
            this.BM.TabStop = false;
            this.BM.Click += new System.EventHandler(this.P_Click);
            // 
            // MR
            // 
            this.MR.Location = new System.Drawing.Point(239, 168);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(75, 76);
            this.MR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MR.TabIndex = 7;
            this.MR.TabStop = false;
            this.MR.Click += new System.EventHandler(this.P_Click);
            // 
            // ML
            // 
            this.ML.Location = new System.Drawing.Point(33, 168);
            this.ML.Name = "ML";
            this.ML.Size = new System.Drawing.Size(75, 76);
            this.ML.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ML.TabIndex = 6;
            this.ML.TabStop = false;
            this.ML.Click += new System.EventHandler(this.P_Click);
            // 
            // TR
            // 
            this.TR.Location = new System.Drawing.Point(239, 61);
            this.TR.Name = "TR";
            this.TR.Size = new System.Drawing.Size(75, 76);
            this.TR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TR.TabIndex = 5;
            this.TR.TabStop = false;
            this.TR.Click += new System.EventHandler(this.P_Click);
            // 
            // TM
            // 
            this.TM.Location = new System.Drawing.Point(136, 61);
            this.TM.Name = "TM";
            this.TM.Size = new System.Drawing.Size(75, 76);
            this.TM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TM.TabIndex = 4;
            this.TM.TabStop = false;
            this.TM.Click += new System.EventHandler(this.P_Click);
            // 
            // MM
            // 
            this.MM.Location = new System.Drawing.Point(136, 168);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(75, 76);
            this.MM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MM.TabIndex = 3;
            this.MM.TabStop = false;
            this.MM.Click += new System.EventHandler(this.P_Click);
            // 
            // TL
            // 
            this.TL.Location = new System.Drawing.Point(33, 61);
            this.TL.Name = "TL";
            this.TL.Size = new System.Drawing.Size(75, 76);
            this.TL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TL.TabIndex = 2;
            this.TL.TabStop = false;
            this.TL.Click += new System.EventHandler(this.P_Click);
            // 
            // Board
            // 
            this.Board.Image = global::X_O.Properties.Resources.Board;
            this.Board.Location = new System.Drawing.Point(12, 44);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(320, 320);
            this.Board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Board.TabIndex = 0;
            this.Board.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 412);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.BR);
            this.Controls.Add(this.BL);
            this.Controls.Add(this.BM);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.ML);
            this.Controls.Add(this.TR);
            this.Controls.Add(this.TM);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.TL);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Board);
            this.Name = "Form1";
            this.Text = "Hadar , Ron";
            ((System.ComponentModel.ISupportInitialize)(this.BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Board;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox TL;
        private System.Windows.Forms.PictureBox MM;
        private System.Windows.Forms.PictureBox TM;
        private System.Windows.Forms.PictureBox TR;
        private System.Windows.Forms.PictureBox ML;
        private System.Windows.Forms.PictureBox MR;
        private System.Windows.Forms.PictureBox BM;
        private System.Windows.Forms.PictureBox BL;
        private System.Windows.Forms.PictureBox BR;
        private System.Windows.Forms.TextBox Player;
    }
}

