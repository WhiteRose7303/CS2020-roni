using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_Memo.Properties;

namespace Form_Memo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool m_IsBack1 = true;
        private bool m_IsBack2 = true;
        private bool m_IsBack3 = true;
        private bool m_IsBack4 = true;
        private bool m_IsBack5 = true;
        private bool m_IsBack6 = true;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!m_IsBack1)
            {
                pictureBox1.Image = Resources.Back;
                m_IsBack1 = true;
            }
            else
            {

                pictureBox1.Image = Resources.supra_1;
                m_IsBack1 = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!m_IsBack2)
            {
                pictureBox2.Image = Resources.Back;
                m_IsBack2 = true;
            }
            else
            {

                pictureBox2.Image = Resources.supra_2;
                m_IsBack2 = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!m_IsBack3)
            {
                pictureBox3.Image = Resources.Back;
                m_IsBack3 = true;
            }
            else
            {

                pictureBox3.Image = Resources.Phantom_1;
                m_IsBack3 = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!m_IsBack4)
            {
                pictureBox4.Image = Resources.Back;
                m_IsBack4 = true;
            }
            else
            {

                pictureBox4.Image = Resources.Phantom_2;
                m_IsBack4 = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!m_IsBack5)
            {
                pictureBox5.Image = Resources.Back;
                m_IsBack5 = true;
            }
            else
            {

                pictureBox5.Image = Resources.divo_1;
                m_IsBack5 = false;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (!m_IsBack6)
            {
                pictureBox6.Image = Resources.Back;
                m_IsBack6 = true;
            }
            else
            {

                pictureBox6.Image = Resources.divo_2;
                m_IsBack6 = false;
            }
        }
    }
}
