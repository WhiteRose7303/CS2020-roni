using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace CrossWord
{
    public partial class Form1 : Form
    {
        private DispatcherTimer inter = new DispatcherTimer();
        private string[] Words1 = new string[2];
        private bool running = false;
        public Form1()
        {
            InitializeComponent();
            initalizetimer();
            inwords();
        }
        private int time = 1;
        private void inwords()
        {
            Words1[0] = "Hello";
            Words1[1] = "World";
        }
        
        private void initalizetimer()
        {
            inter.Tick += new EventHandler(UpdateTimer_Tick);
            inter.Interval = new TimeSpan(0, 0, 1);
        }
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (time <= 59)
            {
                TimeBox.Text = time.ToString();
                time++;
                inter.Stop();
                inter.Start();
            }
            else
            {
                TimeBox.Text = "Out Of Time";
                inter.Stop();
                running = false;
            }
        }


        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            GameTime.Start();
            inter.Start();
            running = true;

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (running == true)
            {
                for (int index = 0; index < Words1.Length; index++)
                {
                    if (Word.Text == Words1[index])
                    {
                        Found.Items.Add(Words1[index]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Press Start Before Entering Words");
            }
        }
    }
}
