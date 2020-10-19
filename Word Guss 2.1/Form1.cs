using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Guss_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int m_CurrentLabelLetter = 1;

        private void button_Letter_Click(object sender, EventArgs e)
        {
            string buttonText = (sender as Button).Text;
            switch (m_CurrentLabelLetter)
            {
                case 1:
                    {
                        label_Letter1.Text = buttonText;
                        break;
                    }
                case 2:
                    {
                        label_Letter2.Text = buttonText;
                        break;
                    }
                case 3:
                    {
                        label_Letter3.Text = buttonText;
                        break;
                    }
                case 4:
                    {
                        label_Letter4.Text = buttonText;
                        break;
                    }
                case 5:
                    {
                        label_Letter5.Text = buttonText;
                        break;
                    }

            }
            m_CurrentLabelLetter++;
        }

    }


}
