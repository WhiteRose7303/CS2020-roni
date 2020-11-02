﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word_Guss_2.Properties;

namespace Word_Guss_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetImagesArray();
        }

        private int m_CurrentLabelLetter = 1;
        private string m_WordToGuess = "";
        private Image[] m_Images = new Image[6];
        private int m_CountError = 0;
        private bool m_IsFirstPlayer = true;

        public void SetImagesArray()
        {
            //מציבה תמונות בכל תאי מערך התמונות 
            m_Images[0] = Resources.p1;
            m_Images[1] = Resources.p2;
            m_Images[2] = Resources.p3;
            m_Images[3] = Resources.p4;
            m_Images[4] = Resources.p5;
            m_Images[5] = Resources.p6;
        }

        private void button_Letter_Click(object sender, EventArgs e)
        {
            string buttonText = (sender as Button).Text;
            if (m_IsFirstPlayer)
            {
                groupBox2.Controls["label_Letter" + m_CurrentLabelLetter].Text = buttonText;

                m_CurrentLabelLetter++;
                if (m_CurrentLabelLetter == 6)
                    button_OK.Enabled = true;
            }
            else
            {
                if (m_WordToGuess.Contains(buttonText))
                {
                    for (int i = 0; i < m_WordToGuess.Length; i++)
                        if (m_WordToGuess[i].ToString() == buttonText)
                            groupBox2.Controls["label_Letter" + (i + 1)].Text = buttonText;
                }
                else
                {
                    pictureBox1.Visible = true;
                    //הצגת תמונת שגיאה  
                    m_CountError++;
                    pictureBox1.Image = m_Images[m_CountError - 1];
                }
                (sender as Button).Enabled = false;
                if (m_CountError == 6)
                {
                    DialogResult dialogResult = MessageBox.Show("Would you like to reset?", "Reset?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        reset();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Close();
                    }
                }

            }



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
            m_IsFirstPlayer = false;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void reset()
        {
            m_CountError = 0;
            m_IsFirstPlayer = true;
            pictureBox1.Visible = false;
            m_CurrentLabelLetter = 1;
            button_OK.Enabled = true;
            button_OK.Visible = true;
            button27.Enabled = true;
            button27.Visible = true;
            SetImagesArray();
            for (int i = 1; i <= 5; i++)
            {
                groupBox2.Controls["label_Letter" + (i)].Text = "_";
            }
            for (int i = 1; i<= 26; i++)
            {
                groupBox1.Controls["button" + (i)].Enabled = true;
            }
            
        }
    }
    

}
