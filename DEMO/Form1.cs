using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Red)
            {
                button1.Text = " ";
                this.BackColor = Color.White;
                textBox1.Text = " ";

            }
            else
            {
                button1.Text = "Now yore dead";
                this.BackColor = Color.Red;
                textBox1.Text = "hey there";
            }
            
             
        }
    }
}
