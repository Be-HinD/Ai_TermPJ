using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Client
{
    internal class imgSize
    {
        private static imgSize instance_ = new imgSize();
        //현재 이미지 정보 저장
        public Image img_source;
        Size size;
        public static imgSize GetInstance()
        {
            return instance_;
        }

        private static Image resize_image(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public void img_Plus()
        {
            Bitmap imgbitmap = new Bitmap(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(OpenCV.GetInstance().src));
            int width_size = (int)((int)img_source.Width * 1.2);
            int height_size = (int)((int)img_source.Height * 1.2);
            img_source = resize_image(imgbitmap, new Size(width_size, height_size));
            OpenCV.GetInstance().src = OpenCvSharp.Extensions.BitmapConverter.ToMat((Bitmap)img_source);
        }

        public void img_Minus()
        {
            Bitmap imgbitmap = new Bitmap(OpenCvSharp.Extensions.BitmapConverter.ToBitmap(OpenCV.GetInstance().src));
            int width_size = (int)((int)img_source.Width * 0.8);
            int height_size = (int)((int)img_source.Height * 0.8);
            img_source = resize_image(imgbitmap, new Size(width_size, height_size));
            OpenCV.GetInstance().src = OpenCvSharp.Extensions.BitmapConverter.ToMat((Bitmap)img_source);
        }

    }
}
