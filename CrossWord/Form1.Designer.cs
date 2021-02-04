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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.WordSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // WordSearch
            // 
            this.WordSearch.Image = global::CrossWord.Properties.Resources.Crossword;
            this.WordSearch.Location = new System.Drawing.Point(1192, 0);
            this.WordSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.WordSearch.Name = "WordSearch";
            this.WordSearch.Size = new System.Drawing.Size(1916, 1171);
            this.WordSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WordSearch.TabIndex = 0;
            this.WordSearch.TabStop = false;
            // 
            // Found
            // 
            this.Found.FormattingEnabled = true;
            this.Found.ItemHeight = 25;
            this.Found.Location = new System.Drawing.Point(0, 0);
            this.Found.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Found.Name = "Found";
            this.Found.Size = new System.Drawing.Size(548, 1579);
            this.Found.TabIndex = 1;
            // 
            // Word
            // 
            this.Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.Location = new System.Drawing.Point(682, 704);
            this.Word.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(398, 80);
            this.Word.TabIndex = 2;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(618, 906);
            this.Close.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(150, 44);
            this.Close.TabIndex = 3;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(806, 906);
            this.Start.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(150, 44);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(992, 906);
            this.Reset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(150, 44);
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
            this.HighScores.ItemHeight = 25;
            this.HighScores.Location = new System.Drawing.Point(594, 140);
            this.HighScores.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HighScores.Name = "HighScores";
            this.HighScores.Size = new System.Drawing.Size(548, 354);
            this.HighScores.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(682, 23);
            this.Name.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(398, 80);
            this.Name.TabIndex = 2;
            this.Name.Text = "Name";
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(682, 822);
            this.Enter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(402, 44);
            this.Enter.TabIndex = 3;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // TimeBox
            // 
            this.TimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBox.Location = new System.Drawing.Point(594, 542);
            this.TimeBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(548, 80);
            this.TimeBox.TabIndex = 2;
            this.TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Timesetbox
            // 
            this.Timesetbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timesetbox.Location = new System.Drawing.Point(806, 1021);
            this.Timesetbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Timesetbox.Name = "Timesetbox";
            this.Timesetbox.Size = new System.Drawing.Size(144, 80);
            this.Timesetbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(849, 980);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(849, 658);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Word:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(813, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time Elapsed";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBox1.Location = new System.Drawing.Point(639, 1157);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(475, 325);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2590, 1630);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

