using OpenCvSharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;
using Size = System.Drawing.Size;

namespace AI_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCV.GetInstance().image_Open();
            string image_file = OpenCV.GetInstance().return_img();

            //PictureBox 컨트롤에 선택한 이미지를 넣습니다.
            pictureBox1.Image = Bitmap.FromFile(image_file);
            //pictureBox1.Load("");
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            imgSize.GetInstance().img_Plus();
            pictureBox1.Image = imgSize.GetInstance().img_source;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            imgSize.GetInstance().img_Minus();
            pictureBox1.Image = imgSize.GetInstance().img_source;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Gray")
            {
                Mat dst = OpenCV.GetInstance().ToGray();
                Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);

                pictureBox1.Image = bitmap;
            }
            if (comboBox1.SelectedItem.ToString() == "YCrCb")
            {
                Mat dst = OpenCV.GetInstance().ToYCrCb();
                Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);

                pictureBox1.Image = bitmap;
            }
            if (comboBox1.SelectedItem.ToString() == "RGB")
            {
                Mat dst = OpenCV.GetInstance().ToRGB();
                Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);

                pictureBox1.Image = bitmap;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mat dst = OpenCV.GetInstance().return_BGR();
            Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);

            pictureBox1.Image = bitmap;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mat dst = OpenCV.GetInstance().rotate_clock();
            Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);

            pictureBox1.Image = bitmap;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mat dst = OpenCV.GetInstance().rotate_Interclock();
            Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);

            pictureBox1.Image = bitmap;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat dst = OpenCV.GetInstance().Add_calc();
            Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);

            pictureBox1.Image = bitmap;
        }

        private void equalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat dst = OpenCV.GetInstance().Hist_calc();
            Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);

            pictureBox1.Image = bitmap;
        }

        private void subToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat dst = OpenCV.GetInstance().Sub_calc();
            Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);

            pictureBox1.Image = bitmap;
        }

        private void mulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat dst = OpenCV.GetInstance().Mul_calc();
            Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);

            pictureBox1.Image = bitmap;
        }

        private void divToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat dst = OpenCV.GetInstance().Div_calc();
            Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);

            pictureBox1.Image = bitmap;
        }

        private void viewHistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCV.GetInstance().Hist_view();
        }

        private void gaussianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat dst = OpenCV.GetInstance().Gaus_Filter();
            Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);

            pictureBox1.Image = bitmap;
        }

        private void meddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat dst = OpenCV.GetInstance().Median_Filter();
            Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);

            pictureBox1.Image = bitmap;
        }


        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCV.GetInstance().Sobel();
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCV.GetInstance().Laplacian();
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCV.GetInstance().Canny();
        }

        private void 가우시안필터사용ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat dst = OpenCV.GetInstance().Unsharp_Filter();
            Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);

            pictureBox1.Image = bitmap;
        }

        private void 평균필터사용ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mat dst = OpenCV.GetInstance().Unsharp_Filter_median();
            Bitmap bitmap = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(dst);

            pictureBox1.Image = bitmap;
        }
    }
}