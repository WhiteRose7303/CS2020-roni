using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_Memo.Properties;
using WMPLib;

namespace Form_Memo
{
    public partial class Form1 : Form
    {
        private static int m_CountTrue = 0;
        public Form1()
        {
            InitializeComponent();
            SetImagesArray();
            this.BackColor = Color.White;
            player.URL = "mariowav.wav";
            player.controls.stop();
        }
        
        private bool m_IsFirst = true;
        private PictureBox m_FirstPictureBox;
        private PictureBox m_SecondPictureBox;
        
        private const int CARD_NUMBER = 8;
        private Image[] m_Images = new Image[CARD_NUMBER];
        private void Swap(int i, int j)
        {
            //מחליפה ערכים בין שני מקומות במערך התמונות  
            Image image = m_Images[i];
            m_Images[i] = m_Images[j];
            m_Images[j] = image;
        }
        private void reset()
        {
            this.BackColor = Color.White;
            //make them apper
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            //back them
            pictureBox1.Image = Resources.Back;
            pictureBox2.Image = Resources.Back;
            pictureBox3.Image = Resources.Back;
            pictureBox4.Image = Resources.Back;
            pictureBox5.Image = Resources.Back;
            pictureBox6.Image = Resources.Back;
            pictureBox7.Image = Resources.Back;
            pictureBox8.Image = Resources.Back;
            SetImagesArray();
            player.controls.previous();

        }

        private void SetImagesArray()
        {
            m_Images[0] = (Resources.supra_1);
            m_Images[1] = (Resources.supra_1);
            m_Images[2] = (Resources.divo_1);
            m_Images[3] = (Resources.divo_1);
            m_Images[4] = (Resources.Phantom_1);
            m_Images[5] = (Resources.Phantom_1);
            m_Images[6] = (Resources.PO);
            m_Images[7] = (Resources.PO);
            Random rnd = new Random();
            for (int i = 0; i < CARD_NUMBER; i++)
            {
                Swap(i, rnd.Next(CARD_NUMBER));
            }
        }
        
        private void pictureBox_Card_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            string picName = pictureBox.Name;
            int k = int.Parse(picName.Substring(picName.Length - 1));
            k--;
            if (!IsImagesMatch(pictureBox.Image, Resources.Back))
                pictureBox.Image = Resources.Back;
            else
                pictureBox.Image = m_Images[k];


            if (!m_IsFirst)
            {
                m_SecondPictureBox = pictureBox;
                
            }
            else
            {
                m_FirstPictureBox = pictureBox;
                timer1.Start();
            }
            m_IsFirst = !m_IsFirst;

        }

        public bool IsImagesMatch(Image image1, Image image2)
        {
            try
            {
                //create instance or System.Drawing.ImageConverter to convert
                //each image to a byte array
                ImageConverter converter = new ImageConverter();
                //create 2 byte arrays, one for each image
                byte[] imgBytes1 = new byte[1];
                byte[] imgBytes2 = new byte[1];

                //convert images to byte array
                imgBytes1 = (byte[])converter.ConvertTo(image1, imgBytes2.GetType());
                imgBytes2 = (byte[])converter.ConvertTo(image2, imgBytes1.GetType());

                //now compute a hash for each image from the byte arrays
                System.Security.Cryptography.SHA256Managed sha = new System.Security.Cryptography.SHA256Managed();
                byte[] imgHash1 = sha.ComputeHash(imgBytes1);
                byte[] imgHash2 = sha.ComputeHash(imgBytes2);

                //now let's compare the hashes
                for (int i = 0; i < imgHash1.Length && i < imgHash2.Length; i++)
                {
                    //whoops, found a non-match, exit the loop
                    //with a false value
                    if (!(imgHash1[i] == imgHash2[i]))
                        return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            //we made it this far so the images must match
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsImagesMatch(m_FirstPictureBox.Image, m_SecondPictureBox.Image))
            {
                //הקלפים זהים - נוציא אותם מהמשחק )לא יהיו מאופשרים( 
                m_FirstPictureBox.Visible = false;
                m_SecondPictureBox.Visible = false; 
                m_CountTrue += 2;
            }
            else
            {
                //הקלפים אינם זהים - נהפוך אותם חזרה  
                m_FirstPictureBox.Image = Resources.Back;
                m_SecondPictureBox.Image = Resources.Back;
            }
            timer1.Stop();

            if (m_CountTrue == CARD_NUMBER)
            {
                //win
                this.BackColor = Color.Green;
                player.controls.play();
                MessageBox.Show("you won!");
                reset();


            }
        }

        WindowsMediaPlayer player = new WindowsMediaPlayer();
    }
}
