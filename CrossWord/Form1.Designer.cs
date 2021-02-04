namespace CrossWord
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
            this.WordSearch = new System.Windows.Forms.PictureBox();
            this.Found = new System.Windows.Forms.ListBox();
            this.Word = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.ResetTime = new System.Windows.Forms.Timer(this.components);
            this.HighScores = new System.Windows.Forms.ListBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.Timesetbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.WordSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // WordSearch
            // 
            this.WordSearch.Image = global::CrossWord.Properties.Resources.Crossword;
            this.WordSearch.Location = new System.Drawing.Point(596, 0);
            this.WordSearch.Name = "WordSearch";
            this.WordSearch.Size = new System.Drawing.Size(958, 609);
            this.WordSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WordSearch.TabIndex = 0;
            this.WordSearch.TabStop = false;
            // 
            // Found
            // 
            this.Found.FormattingEnabled = true;
            this.Found.Location = new System.Drawing.Point(0, 0);
            this.Found.Name = "Found";
            this.Found.Size = new System.Drawing.Size(276, 823);
            this.Found.TabIndex = 1;
            // 
            // Word
            // 
            this.Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.Location = new System.Drawing.Point(341, 366);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(201, 44);
            this.Word.TabIndex = 2;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(309, 471);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(403, 471);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(496, 471);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ResetTime
            // 
            this.ResetTime.Interval = 1000;
            this.ResetTime.Tick += new System.EventHandler(this.ResetTime_Tick);
            // 
            // HighScores
            // 
            this.HighScores.FormattingEnabled = true;
            this.HighScores.Location = new System.Drawing.Point(297, 73);
            this.HighScores.Name = "HighScores";
            this.HighScores.Size = new System.Drawing.Size(276, 186);
            this.HighScores.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(341, 12);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(201, 44);
            this.Name.TabIndex = 2;
            this.Name.Text = "Name";
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(341, 427);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(201, 23);
            this.Enter.TabIndex = 3;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // TimeBox
            // 
            this.TimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBox.Location = new System.Drawing.Point(297, 282);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(276, 44);
            this.TimeBox.TabIndex = 2;
            this.TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Timesetbox
            // 
            this.Timesetbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timesetbox.Location = new System.Drawing.Point(341, 531);
            this.Timesetbox.Name = "Timesetbox";
            this.Timesetbox.Size = new System.Drawing.Size(201, 44);
            this.Timesetbox.TabIndex = 4;
            this.Timesetbox.Text = "Insert time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 817);
            this.Controls.Add(this.Timesetbox);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.HighScores);
            this.Controls.Add(this.Found);
            this.Controls.Add(this.WordSearch);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WordSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WordSearch;
        private System.Windows.Forms.ListBox Found;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Timer ResetTime;
        private System.Windows.Forms.ListBox HighScores;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.TextBox Timesetbox;
    }
}

