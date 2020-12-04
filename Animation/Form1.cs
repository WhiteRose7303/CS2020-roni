using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            assing();
            Star.Visible = false;
            END.Start();
            santa.Visible = false;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            santa.BackColor = Color.Transparent;
        }
      

        //gives the christmess theme
        private void Backround_tick_Tick(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Red)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }
        Label[] REDS = new Label[8];
        Label[] Yellows = new Label[6];
        void assing()
        {
            //reds
            REDS[0] = OR2;
            REDS[1] = OR4;
            REDS[2] = OR3;
            REDS[3] = OR7;
            REDS[4] = OR8;
            REDS[5] = OR11;
            REDS[6] = OR13;
            REDS[7] = OR14;
            //yellow
            Yellows[0] = OR1;
            Yellows[1] = OR5;
            Yellows[2] = OR6;
            Yellows[3] = OR9;
            Yellows[4] = OR12;
            Yellows[5] = OR10;
        }

        private void Red_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < REDS.Length; i++)
            {
                REDS[i].Visible = false;
            }
            Waitr.Start();
        }
        private void Yellow_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Yellows.Length; i++)
            {
                Yellows[i].Visible = false;
            }
            Waity.Start();
        }

        private void Waitr_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < REDS.Length; i++)
            {
                REDS[i].Visible = true;
            }
            Waitr.Stop();
        }

        private void Waity_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Yellows.Length; i++)
            {
                Yellows[i].Visible = true;
            }
            Waity.Stop();
        }

        private void END_Tick(object sender, EventArgs e)
        {
            Star.Visible = true;
        }

        private void santat_Tick(object sender, EventArgs e)
        {
            santa.Left += 1;
            //santa.Top += 9;
            santa.Visible = true;
           
        }

        private void waits_Tick(object sender, EventArgs e)
        {
            santa.Visible = false;
            waits.Stop();
        }

        private void Final_Tick(object sender, EventArgs e)
        {
            santa.Visible = false;
            label11.Visible = true;
            this.Close();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.Visible = false;
            label11.Visible = false;
            santat.Start();
            Final.Start();
            Backround_tick.Start();
            Red.Start();
            Yellow.Start();
            meida.URL = txt.Text;
            meida.Ctlcontrols.play();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag1 = new OpenFileDialog();

            if (diag1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txt.Text = diag1.FileName; 
            }
        }
    }
}
