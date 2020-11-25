using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using X_O.Properties;

namespace X_O
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Player.Visible = false;
        }
        private static bool Isfirst = true;
        private int[,] Matboard = new int[3, 3];
        private bool[] filled = new bool[9];
 
        //Exit
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //player click
        private void P_Click(object sender, EventArgs e)
        {
            PictureBox pic = (sender as PictureBox);
            if (Isfirst)
            {
                Player.Text = "Player - 1";
                first(pic);  
            }
            else
            {
                Player.Text = "Player - 2";
                secconed(pic);
            }
          
        }

        private void first(PictureBox pic)
        {
            string name = 'I' + pic.Name;
            int num = 0;
            if (name == "ITL")
            {
                num = 0;
            }
            else if (name == "ITM")
            {
                num = 1;
            }
            else if (name == "ITR")
            {
                num = 2;
            }
            else if (name == "IML")
            {
                num = 3;
            }
            else if (name == "IMM")
            {
                num = 4;
            }
            else if (name == "IMR")
            {
                num = 5;
            }
            else if (name == "IBL")
            {
                num = 6;
            }
            else if (name == "IBM")
            {
                num = 7;
            }
            else if (name == "IBR")
            {
                num = 8;
            }

            if (filled[num] == true)
            { }
            else
            {
                pic.Image = Resources.X;
                Isfirst = false;
                if (pic.Name == "TL")
                {
                    Matboard[0, 0] = 1;
                    filled[0] = true;
                }
                else if (pic.Name == "TM")
                {
                    Matboard[0, 1] = 1;
                    filled[1] = true;
                }
                else if (pic.Name == "TR")
                {
                    Matboard[0, 2] = 1;
                    filled[2] = true;
                }

                else if (pic.Name == "ML")
                {
                    Matboard[1, 0] = 1;
                    filled[3] = true;
                }

                else if (pic.Name == "MM")
                {
                    Matboard[1, 1] = 1;
                    filled[4] = true;
                }

                else if (pic.Name == "MR")
                {
                    Matboard[1, 2] = 1;
                    filled[5] = true;
                }

                else if (pic.Name == "BL")
                {
                    Matboard[2, 0] = 1;
                    filled[6] = true;
                }

                else if (pic.Name == "BM")
                {
                    Matboard[2, 1] = 1;
                    filled[7] = true;
                }

                else if (pic.Name == "BR")
                {
                    Matboard[2, 2] = 1;
                    filled[8] = true;
                }

                checkwin();
            }

        }

        private void secconed(PictureBox pic)
        {
            string name = 'I' + pic.Name;
            int num = 0;
            if (name == "ITL")
            {
                num = 0;
            }
            else if (name == "ITM")
            {
                num = 1;
            }
            else if (name == "ITR")
            {
                num = 2;
            }
            else if (name == "IML")
            {
                num = 3;
            }
            else if (name == "IMM")
            {
                num = 4;
            }
            else if (name == "IMR")
            {
                num = 5;
            }
            else if (name == "IBL")
            {
                num = 6;
            }
            else if (name == "IBM")
            {
                num = 7;
            }
            else if (name == "IBR")
            {
                num = 8;
            }

            if (filled[num] == true)
            { }
            else
            {


                pic.Image = Resources.Circle;
                Isfirst = true;
                if (pic.Name == "TL")
                {
                    Matboard[0, 0] = 2;
                    filled[0] = true;
                }
                else if (pic.Name == "TM")
                {
                    Matboard[0, 1] = 2;
                    filled[1] = true;
                }
                else if (pic.Name == "TR")
                {
                    Matboard[0, 2] = 2;
                    filled[2] = true;
                }

                else if (pic.Name == "ML")
                {
                    Matboard[1, 0] = 2;
                    filled[3] = true;
                }

                else if (pic.Name == "MM")
                {
                    Matboard[1, 1] = 2;
                    filled[4] = true;
                }

                else if (pic.Name == "MR")
                {
                    Matboard[1, 2] = 2;
                    filled[5] = true;
                }

                else if (pic.Name == "BL")
                {
                    Matboard[2, 0] = 2;
                    filled[6] = true;
                }

                else if (pic.Name == "BM")
                {
                    Matboard[2, 1] = 2;
                    filled[7] = true;
                }

                else if (pic.Name == "BR")
                {
                    Matboard[2, 2] = 2;
                    filled[8] = true;
                }
                checkwin();
            }
        }

        private void checkwin()
        {
            //for 1
            //hori
            if((Matboard[0,0]==1)&& (Matboard[0, 1] == 1)&& (Matboard[0, 2] == 1))
            {
                won1();
            }
            if ((Matboard[1, 0] == 1) && (Matboard[1, 1] == 1) && (Matboard[1, 2] == 1))
            {
                won1();
            }
            if ((Matboard[2, 0] == 1) && (Matboard[2, 1] == 1) && (Matboard[2, 2] == 1))
            {
                won1();
            }
            //verti
            if ((Matboard[0, 0] == 1) && (Matboard[1, 0] == 1) && (Matboard[2, 0] == 1))
            {
                won1();
            }
            if ((Matboard[0, 1] == 1) && (Matboard[1, 1] == 1) && (Matboard[2, 1] == 1))
            {
                won1();
            }
            if ((Matboard[0, 2] == 1) && (Matboard[1, 2] == 1) && (Matboard[2, 2] == 1))
            {
                won1();
            }
            //diag
            if ((Matboard[0, 0] == 1) && (Matboard[1, 1] == 1) && (Matboard[2, 2] == 1))
            {
                won1();
            }
            if ((Matboard[2, 1] == 1) && (Matboard[1, 1] == 1) && (Matboard[0, 2] == 1))
            {
                won1();
            }

            //for 2
            //hori
            if ((Matboard[0, 0] == 2) && (Matboard[0, 1] == 2) && (Matboard[0, 2] == 2))
            {
                won2();
            }
            if ((Matboard[1, 0] == 2) && (Matboard[1, 1] == 2) && (Matboard[1, 2] == 2))
            {
                won2();
            }
            if ((Matboard[2, 0] == 2) && (Matboard[2, 1] == 2) && (Matboard[2, 2] == 2))
            {
                won2();
            }
            //verti
            if ((Matboard[0, 0] == 2) && (Matboard[1, 0] == 2) && (Matboard[2, 0] == 2))
            {
                won2();
            }
            if ((Matboard[0, 1] == 2) && (Matboard[1, 1] == 2) && (Matboard[2, 1] == 2))
            {
                won2();
            }
            if ((Matboard[0, 2] == 2) && (Matboard[1, 2] == 2) && (Matboard[2, 2] == 2))
            {
                won2();
            }
            //diag
            if ((Matboard[0, 0] == 2) && (Matboard[1, 1] == 2) && (Matboard[2, 2] == 2))
            {
                won2();
            }
            if ((Matboard[2, 1] == 2) && (Matboard[1, 1] == 2) && (Matboard[0, 2] == 2))
            {
                won2();
            }

        }
    
        private void won1()
        {
            form_win1 form_win1 = new form_win1();
            form_win1.ShowDialog();
            this.Close();
        }
        private void won2()
        {
            form_win2 form_win2 = new form_win2();
            form_win2.ShowDialog();
            this.Close();
        }

    }
}
