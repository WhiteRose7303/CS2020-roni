using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Please type the amount of stages you want in the text box...");

        }
        //the Amount in this turn
        int AmountToPlay = 1;
        //the last posion in the array
        int lastPos = 0;
        int played = 0;
        int[] rndArray;
        string[] playarr;
        int turn = 0;
        int turns;
        
        private int calcstage(int n)
        {
            int fact = 0;
            for (int i = 0; i<=n; i++)
            {
                fact += i;
            }
            return fact;
        }

        private void Brnd()
        {
            Random rnd = new Random();
            for (int i = 0; i< rndArray.Length; i++)
            {
                rndArray[i] = rnd.Next(1, 4);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (Stage.Text == "")
            {
                MessageBox.Show("Please type the amount of stages you want in the text box...");
            }
            else
            {
                turns = int.Parse(Stage.Text);
                rndArray = new int[calcstage(turns)];
                Stage.Enabled = false;
                Brnd();
                Game.Start();
                playarr = new string[AmountToPlay];
            }
        }

        private void Game_Tick(object sender, EventArgs e)
        {
            if (turn != turns)
            {
                if (played != AmountToPlay)
                {
                    switch (rndArray[lastPos])
                    {
                        case 1:
                            P1.Image = Properties.Resources.fishO;
                            Delay.Start();
                            lastPos++;
                            played++;
                            playarr[played - 1] = "P1";
                            break;
                        case 2:
                            P2.Image = Properties.Resources.zebraO;
                            Delay.Start();
                            lastPos++;
                            played++;
                            playarr[played - 1] = "P2";
                            break;
                        case 3:
                            P3.Image = Properties.Resources.lionO;
                            Delay.Start();
                            lastPos++;
                            played++;
                            playarr[played - 1] = "P3";
                            break;
                        case 4:
                            P4.Image = Properties.Resources.karnafO;
                            Delay.Start();
                            lastPos++;
                            played++;
                            playarr[played - 1] = "P4";
                            break;
                    }
                }
                else
                {
                    Game.Stop();
                    now();
                }
            }
            else
            {
                Game.Stop();
                MessageBox.Show("You Won!");
                this.Close();
            }
        }
        private void now()
        {
            AmountToPlay++;
            played = 0;
        }

        private void Delay_Tick(object sender, EventArgs e)
        {
            P1.Image = Properties.Resources.fish;
            P2.Image = Properties.Resources.zebra;
            P3.Image = Properties.Resources.lion;
            P4.Image = Properties.Resources.karnaf;
            Delay.Stop();
        }

        int haveclicked = 0;

        private void pictureBox_Click(object sender, EventArgs e)
        {
            string Clicked = (sender as PictureBox).Name;
            if (haveclicked != playarr.Length)
            {
                if (Clicked != playarr[haveclicked])
                {
                    MessageBox.Show("Looser!");
                    this.Close();
                }
                else
                {
                    haveclicked++;
                    if (haveclicked == playarr.Length)
                    {
                        haveclicked = 0;
                        Game.Start();
                        playarr = new string[AmountToPlay];
                        turn++;
                    }
                }
            }
            else
            {
                haveclicked = 0;
                Game.Start();
                playarr = new string[AmountToPlay];
                turn++;
            }
        }
    }
}

