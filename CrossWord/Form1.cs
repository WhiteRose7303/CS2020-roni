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
using System.Linq.Expressions;

namespace CrossWord
{
    public partial class Form1 : Form
    {
        private int player = 0;
        private DispatcherTimer inter = new DispatcherTimer();
        private string[] Words1 = new string[23];
        private bool running = false;
        private int score = 0;
        private string tempname = "";
        private string[] High = new string[1000];
        private int total = 59;
        private int time = 1;

        public Form1()
        {
            InitializeComponent();
            initalizetimer();
            iniliatizeWords();
            HighScores.Sorted = false;
        }

        private void initalizetimer()
        {
            inter.Tick += new EventHandler(UpdateTimer_Tick);
            inter.Interval = new TimeSpan(0, 0, 1);
        }
        private void iniliatizeWords()
        {
            Words1[0] = "basket";
            Words1[1] = "bath";
            Words1[2] = "bathroom";
            Words1[3] = "broom";
            Words1[4] = "crayons";
            Words1[5] = "doormat";
            Words1[6] = "fart";
            Words1[7] = "flowers";
            Words1[8] = "flush";
            Words1[9] = "kitchen";
            Words1[10] = "laught";
            Words1[11] = "laundry";
            Words1[12] = "live";
            Words1[13] = "magazine";
            Words1[14] = "newspaper";
            Words1[15] = "paper";
            Words1[16] = "paperclip";
            Words1[17] = "poop";
            Words1[18] = "shower";
            Words1[19] = "sweater";
            Words1[20] = "toilet";
            Words1[21] = "wash";
            Words1[22] = "zone";
        }
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (time <= total)
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
                Name.Text = "Name";
                High[player + 1] = score + " " + tempname;
                Array.Sort(High);
                Array.Reverse(High);
                HighScores.Items.Clear();
                for (int i = 0; i < High.Length; i++)
                {
                    if (High[i] != null)
                    {
                        HighScores.Items.Add(High[i]);
                    }
                }
                ResetTime.Start();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            inter.Start();
            running = true;
            tempname = Name.Text;
            player++;
            int value;
            if (int.TryParse(Timesetbox.Text, out value))
            {
                total = Convert.ToInt32(this.Timesetbox.Text);
            }
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
                        score++;
                        Word.Text = "";

                    }
                }
            }


            else
            {
                MessageBox.Show("Please Press Start Before Entering Words");
            }
            
        }
        
    

        private void ResetTime_Tick(object sender, EventArgs e)
        {
            TimeBox.Text = "";
            time = 1;
            Found.Items.Clear();
            score = 0;
            ResetTime.Stop();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Found.Items.Clear();
            score = 0;
            HighScores.Items.Clear();
            for (int i = 0; i< High.Length; i++)
            {
                High[i] = null; 
            }
            time = 1;
            Timesetbox.Text = "Insert time";
            total = 59;
        }
    }

}
