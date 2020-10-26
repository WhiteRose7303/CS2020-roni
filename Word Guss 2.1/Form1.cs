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
        private string m_WordToGuess = "";

        private void button_Letter_Click(object sender, EventArgs e)
        {
            string buttonText = (sender as Button).Text;
            groupBox2.Controls["label_Letter" + m_CurrentLabelLetter].Text = buttonText;
           
            m_CurrentLabelLetter++;
            if (m_CurrentLabelLetter == 6)
                button_OK.Enabled = true;
           
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (m_CurrentLabelLetter > 1)
                groupBox2.Controls["label_Letter" + (m_CurrentLabelLetter - 1)].Text = "_";
            m_CurrentLabelLetter--;
            button_OK.Enabled = false;

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Label curLabel;

            for (int i = 1; i <= 5; i++)
            {
                curLabel = groupBox2.Controls["label_Letter" + i] as Label; m_WordToGuess += curLabel.Text;
                curLabel.Text = "_";
            }

            button27.Visible = false;
            button_OK.Visible = false;



        }
    }


}
