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
            setimagearray();
        }
        
        private bool m_IsFirst = true;
        private PictureBox m_FirstPictureBox;
        private PictureBox m_SecondPictureBox;
        
        private const int Card_Number = 6;
        private Image[] m_Images = new Image[Card_Number];

        public void setimagearray()
        {
            m_Images[0] = (Resources.supra_1);
            m_Images[1] = (Resources.supra_2);
            m_Images[2] = (Resources.divo_1);
            m_Images[3] = (Resources.divo_2);
            m_Images[4] = (Resources.Phantom_1);
            m_Images[5] = (Resources.Phantom_2);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            m_FirstPictureBox.Image = Resources.Back;
            m_SecondPictureBox.Image = Resources.Back;
            timer1.Stop();
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

       
    }
}
