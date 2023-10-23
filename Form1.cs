using System.IO;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Bitmap ScaleImage(Bitmap bmp, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / bmp.Width;
            var ratioY = (double)maxHeight / bmp.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(bmp.Width * ratio);
            var newHeight = (int)(bmp.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(bmp, 200, 0, newWidth, newHeight);

            return newImage;
        }

        private static double PictureRatio(Bitmap btm, PictureBox pb)
        {
            double widthRatio = Convert.ToDouble(pb.Width) / Convert.ToDouble(btm.Width);
            double heightRatio = Convert.ToDouble(pb.Height) / Convert.ToDouble(btm.Height);

            return widthRatio < heightRatio ? widthRatio : heightRatio;
        }
        private static void ScalePicture(Bitmap btm, PictureBox pb)
        {
            double ratio = PictureRatio(btm, pb);

            int newWidth = Convert.ToInt32(btm.Width * ratio);
            int newHeight = Convert.ToInt32(btm.Height * ratio);

            Bitmap canvas = new Bitmap(pb.Width, pb.Height);
            int a = ((canvas.Width / 2) - (newWidth / 2));

            using (Graphics graphics = Graphics.FromImage(canvas))
            {
                graphics.DrawImage(btm, a, 0, newWidth, newHeight);
            }

            pb.Image = canvas;
        }

        /**
        * Show the Open File dialog. If the user clicks OK, load the picture that the user chose.
        */
        private void ShowPictureBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //pictureBox1.Load(openFileDialog1.FileName);
                Bitmap a = new Bitmap(openFileDialog1.FileName);
                ScalePicture(a, pictureBox1);
            }

        }

        /**
         * Clear the picture
         */
        private void ClearPictureBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        /**
         * Show the color dialog box. If the user clicks OK, change the PictureBox control's background to the color the user chose.
         */
        private void SetColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        /**
         * Close this form
         */
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * If the user selects the Stretch check box, change the PictureBox's SizeMode property to "Stretch". If the user clears the check box, change it to "Normal".
         */
        private void StreachImageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (StreachImageCheckBox.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}