namespace WordBulding
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
            this.Player1 = new System.Windows.Forms.TextBox();
            this.Player2 = new System.Windows.Forms.TextBox();
            this.Player1List = new System.Windows.Forms.ListBox();
            this.Player2List = new System.Windows.Forms.ListBox();
            this.Play1 = new System.Windows.Forms.TextBox();
            this.Play2 = new System.Windows.Forms.TextBox();
            this.Enter1 = new System.Windows.Forms.Button();
            this.Enter2 = new System.Windows.Forms.Button();
            this.Letters1 = new System.Windows.Forms.Label();
            this.Letter2 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.Enabled = false;
            this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Player1.Location = new System.Drawing.Point(197, 75);
            this.Player1.Name = "Player1";
            this.Player1.ReadOnly = true;
            this.Player1.Size = new System.Drawing.Size(218, 44);
            this.Player1.TabIndex = 0;
            this.Player1.Text = "Player 1";
            this.Player1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player2
            // 
            this.Player2.Enabled = false;
            this.Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Player2.Location = new System.Drawing.Point(799, 75);
            this.Player2.Name = "Player2";
            this.Player2.ReadOnly = true;
            this.Player2.Size = new System.Drawing.Size(218, 44);
            this.Player2.TabIndex = 0;
            this.Player2.Text = "Player 2";
            this.Player2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Player1List
            // 
            this.Player1List.FormattingEnabled = true;
            this.Player1List.Location = new System.Drawing.Point(175, 166);
            this.Player1List.Name = "Player1List";
            this.Player1List.Size = new System.Drawing.Size(266, 329);
            this.Player1List.TabIndex = 1;
            // 
            // Player2List
            // 
            this.Player2List.FormattingEnabled = true;
            this.Player2List.Location = new System.Drawing.Point(780, 166);
            this.Player2List.Name = "Player2List";
            this.Player2List.Size = new System.Drawing.Size(266, 329);
            this.Player2List.TabIndex = 1;
            // 
            // Play1
            // 
            this.Play1.Location = new System.Drawing.Point(187, 523);
            this.Play1.Name = "Play1";
            this.Play1.Size = new System.Drawing.Size(242, 20);
            this.Play1.TabIndex = 2;
            this.Play1.Text = "Word...";
            // 
            // Play2
            // 
            this.Play2.Location = new System.Drawing.Point(799, 523);
            this.Play2.Name = "Play2";
            this.Play2.Size = new System.Drawing.Size(231, 20);
            this.Play2.TabIndex = 3;
            this.Play2.Text = "Word...";
            // 
            // Enter1
            // 
            this.Enter1.Location = new System.Drawing.Point(244, 565);
            this.Enter1.Name = "Enter1";
            this.Enter1.Size = new System.Drawing.Size(130, 23);
            this.Enter1.TabIndex = 4;
            this.Enter1.Text = "Enter";
            this.Enter1.UseVisualStyleBackColor = true;
            // 
            // Enter2
            // 
            this.Enter2.Location = new System.Drawing.Point(862, 565);
            this.Enter2.Name = "Enter2";
            this.Enter2.Size = new System.Drawing.Size(130, 23);
            this.Enter2.TabIndex = 4;
            this.Enter2.Text = "Enter";
            this.Enter2.UseVisualStyleBackColor = true;
            // 
            // Letters1
            // 
            this.Letters1.AutoSize = true;
            this.Letters1.Location = new System.Drawing.Point(279, 136);
            this.Letters1.Name = "Letters1";
            this.Letters1.Size = new System.Drawing.Size(0, 13);
            this.Letters1.TabIndex = 5;
            // 
            // Letter2
            // 
            this.Letter2.AutoSize = true;
            this.Letter2.Location = new System.Drawing.Point(896, 136);
            this.Letter2.Name = "Letter2";
            this.Letter2.Size = new System.Drawing.Size(0, 13);
            this.Letter2.TabIndex = 5;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(508, 166);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(210, 113);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 619);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Letter2);
            this.Controls.Add(this.Letters1);
            this.Controls.Add(this.Enter2);
            this.Controls.Add(this.Enter1);
            this.Controls.Add(this.Play2);
            this.Controls.Add(this.Play1);
            this.Controls.Add(this.Player2List);
            this.Controls.Add(this.Player1List);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Player1;
        private System.Windows.Forms.TextBox Player2;
        private System.Windows.Forms.ListBox Player1List;
        private System.Windows.Forms.ListBox Player2List;
        private System.Windows.Forms.TextBox Play1;
        private System.Windows.Forms.TextBox Play2;
        private System.Windows.Forms.Button Enter1;
        private System.Windows.Forms.Button Enter2;
        private System.Windows.Forms.Label Letters1;
        private System.Windows.Forms.Label Letter2;
        private System.Windows.Forms.Button Start;
    }
}

