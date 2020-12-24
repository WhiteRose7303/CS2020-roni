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
            Brnd();
        }
        int Pmount = 1;
        int last = 0;
        private static void Brnd()
        {
            Random rnd = new Random();
            int[] rndArray = new int[1000];
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
            Game.Start();
        }

        private void Game_Tick(object sender, EventArgs e)
        {

        }
    }
}

