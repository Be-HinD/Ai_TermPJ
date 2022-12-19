using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Point = OpenCvSharp.Point;
using Size = OpenCvSharp.Size;

namespace AI_Client
{
    internal class OpenCV
    {
        private static OpenCV instance_ = new OpenCV();
        //img 경로 저장
        public string image_file = string.Empty;
        public Mat src; //읽어온 사진을 BGR형식으로 저장, 모든 연산의 기반은 src
        public Mat src_Origin;
        Mat rotate;
        public Mat src_filter;

        public static OpenCV GetInstance()
        {
            return instance_;
        }

        public string return_img()
        {
            return image_file;
        }

        public void image_Open()
        {
            //이미지를 선택하기 위한 다이얼로그를 생성합니다.
            OpenFileDialog dialog = new OpenFileDialog();

            //다이얼로그를 열었을때 보여줄 초기 위치를 설정합니다.
            dialog.InitialDirectory = @"D:\";

            //다이얼로그의 결과값에 따라 처리를 해줍니다.
            //OK : 선택한 이미지의 값을 image_file 변수에 대입합니다.
            //Cencel: 해당 이벤트를 종료합니다.
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image_file = dialog.FileName;
                src = Cv2.ImRead(dialog.FileName); //BGR로 읽어오기
                src_Origin = Cv2.ImRead(dialog.FileName); //원본 사진 보관
                imgSize.GetInstance().img_source = Image.FromFile(image_file); //image형식으로 저장
            }
            else if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
        }

        public Mat ToGray()
        {
            Mat dst = new Mat(src.Size(), MatType.CV_8UC1);

            Cv2.CvtColor(src_Origin, dst, ColorConversionCodes.BGR2GRAY);
            src = dst;
            return dst;
        }

        public Mat ToYCrCb()
        {
            Mat dst = new Mat(src.Size(), MatType.CV_8UC1);

            Cv2.CvtColor(src_Origin, dst, ColorConversionCodes.BGR2YCrCb);
            src = dst;
            return dst;
        }

        public Mat ToRGB()
        {
            Mat dst = new Mat(src.Size(), MatType.CV_8UC1);

            Cv2.CvtColor(src_Origin, dst, ColorConversionCodes.BGR2RGB);
            src = dst;
            return dst;
        }

        public Mat return_BGR()
        {
            src = src_Origin;
            return src_Origin;
        }

        public Mat rotate_clock()
        {
            rotate = new Mat(src.Size(), MatType.CV_8UC3);
            Mat matrix = Cv2.GetRotationMatrix2D(new Point2f(src.Width / 2, src.Height / 2), 90, 1);
            Cv2.WarpAffine(src, rotate, matrix, src.Size(), InterpolationFlags.Linear);
            src = rotate;
            return rotate;
        }

        public Mat rotate_Interclock()
        {
            rotate = new Mat(src.Size(), MatType.CV_8UC3);
            Mat matrix = Cv2.GetRotationMatrix2D(new Point2f(src.Width / 2, src.Height / 2), -90, 1);
            Cv2.WarpAffine(src, rotate, matrix, src.Size(), InterpolationFlags.Linear);
            src = rotate;
            return rotate;
        }


        public Mat Add_calc()
        {
            //Mat src = new Mat(image_file, ImreadModes.ReducedColor2);
            Mat val = new Mat(src.Size(), MatType.CV_8UC3, new Scalar(0, 0, 30));
            Mat add = new Mat();
            Cv2.Add(src, val, add);
            return add;
        }

        public Mat Sub_calc()
        {
            //Mat src = new Mat(image_file, ImreadModes.ReducedColor2);
            Mat val = new Mat(src.Size(), MatType.CV_8UC3, new Scalar(0, 0, 30));
            Mat sub = new Mat();
            Cv2.Subtract(src, val, sub);
            return sub;
        }

        public Mat Mul_calc()
        {
            //Mat src = new Mat(image_file, ImreadModes.ReducedColor2);
            Mat val = new Mat(src.Size(), MatType.CV_8UC3, new Scalar(0, 0, 30));
            Mat mul = new Mat();
            Cv2.Multiply(src, val, mul);
            return mul;
        }

        public Mat Div_calc()
        {
            //Mat src = new Mat(image_file, ImreadModes.ReducedColor2);
            Mat val = new Mat(src.Size(), MatType.CV_8UC3, new Scalar(0, 0, 30));
            Mat div = new Mat();
            Cv2.Divide(src, val, div);
            return div;
        }

        public Mat Hist_calc()
        {
            Mat src_Ycrcb = new Mat(src_Origin.Size(), MatType.CV_8UC1);

            Cv2.CvtColor(src_Origin, src_Ycrcb, ColorConversionCodes.BGR2YCrCb);
            Mat[] ycrcb_planes = Cv2.Split(src_Ycrcb);
            
            Cv2.EqualizeHist(ycrcb_planes[0], ycrcb_planes[0]);

            Mat dst = new Mat();
            Cv2.Merge(ycrcb_planes, dst);
            Cv2.CvtColor(dst, dst, ColorConversionCodes.YCrCb2BGR);
            src = dst;
            return dst;
        }

        public void Hist_view()
        {
            Mat color = new Mat();
            Mat histB = new Mat();
            Mat histG = new Mat();
            Mat histR = new Mat();
            Mat resultB = Mat.Ones(new Size(256, src.Height), MatType.CV_8UC3);
            Mat resultG = Mat.Ones(new Size(256, src.Height), MatType.CV_8UC3);
            Mat resultR = Mat.Ones(new Size(256, src.Height), MatType.CV_8UC3);

            Cv2.CvtColor(src, color, ColorConversionCodes.BGR2BGRA);

            Cv2.CalcHist(new Mat[] { color }, new int[] { 0 }, null, histB, 1, new int[] { 256 }, new Rangef[] { new Rangef(0, 256) });
            Cv2.Normalize(histB, histB, 0, 255, NormTypes.MinMax);

            Cv2.CalcHist(new Mat[] { color }, new int[] { 1 }, null, histG, 1, new int[] { 256 }, new Rangef[] { new Rangef(0, 256) });
            Cv2.Normalize(histG, histG, 0, 255, NormTypes.MinMax);

            Cv2.CalcHist(new Mat[] { color }, new int[] { 2 }, null, histR, 1, new int[] { 256 }, new Rangef[] { new Rangef(0, 256) });
            Cv2.Normalize(histR, histR, 0, 255, NormTypes.MinMax);

            for (int i = 0; i < histB.Rows; i++)
            {
                Cv2.Line(resultB, new Point(i, src.Height), new Point(i, src.Height - histB.Get<float>(i)), Scalar.Blue);
            }
            for (int i = 0; i < histG.Rows; i++)
            {
                Cv2.Line(resultG, new Point(i, src.Height), new Point(i, src.Height - histG.Get<float>(i)), Scalar.Green);
            }
            for (int i = 0; i < histR.Rows; i++)
            {
                Cv2.Line(resultR, new Point(i, src.Height), new Point(i, src.Height - histR.Get<float>(i)), Scalar.Red);
            }

            Cv2.ImShow("Blue", resultB);
            Cv2.ImShow("Green", resultG);
            Cv2.ImShow("Red", resultR);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }

        public Mat Gaus_Filter()
        {
            Mat gaussian_blur = new Mat();
            Cv2.GaussianBlur(src_Origin, gaussian_blur, new Size(5, 5), 1, 1, BorderTypes.Default);
            src_filter = gaussian_blur;
            return gaussian_blur;
        }

        public Mat Median_Filter()
        {
            Mat median_blur = new Mat();
            Cv2.MedianBlur(src, median_blur, 5);
            
            return median_blur;
        }

        public Mat Unsharp_Filter()
        {
            if(src_filter != null)
            {
                Mat src_Ycrcb = new Mat(src_Origin.Size(), MatType.CV_8UC1);

                Cv2.CvtColor(src_Origin, src_Ycrcb, ColorConversionCodes.BGR2YCrCb);
                Mat[] ycrcb_planes = Cv2.Split(src_Ycrcb);

                Mat gaussian_blur = new Mat();
                Mat edge_img = new Mat();

                Cv2.GaussianBlur(ycrcb_planes[0], gaussian_blur, new Size(9, 9), 1, 1, BorderTypes.Default);
                Cv2.AddWeighted(ycrcb_planes[0], 1.0, gaussian_blur, -1.0, 0, edge_img);
                Cv2.AddWeighted(ycrcb_planes[0], 1.0, edge_img, 3.0, 0, ycrcb_planes[0]);
                Mat dst = new Mat();
                Cv2.Merge(ycrcb_planes, dst);
                Cv2.CvtColor(dst, dst, ColorConversionCodes.YCrCb2BGR);

                Cv2.ImShow("edge", edge_img);
                Cv2.ImShow("Gaussian Apply", dst);
                Cv2.WaitKey(0);

                return dst;
            }
            else { return src_Origin; }
        }


        public Mat Unsharp_Filter_median()
        {
            Mat src_Ycrcb = new Mat(src_Origin.Size(), MatType.CV_8UC1);

            Cv2.CvtColor(src_Origin, src_Ycrcb, ColorConversionCodes.BGR2YCrCb);
            Mat[] ycrcb_planes = Cv2.Split(src_Ycrcb);

            Mat median_blur = new Mat();
            Mat edge_img = new Mat();

            Cv2.MedianBlur(ycrcb_planes[0], median_blur, 9);
            Cv2.AddWeighted(ycrcb_planes[0], 1.0, median_blur, -1.0, 0, edge_img);
            Cv2.AddWeighted(ycrcb_planes[0], 1.0, edge_img, 3.0, 0, ycrcb_planes[0]);

            Mat dst = new Mat();
            Cv2.Merge(ycrcb_planes, dst);
            Cv2.CvtColor(dst, dst, ColorConversionCodes.YCrCb2BGR);
            Cv2.ImShow("edge", edge_img);
            Cv2.ImShow("Median Apply", dst);
            Cv2.WaitKey(0);

            return dst;
        }

        public void Sobel()
        {
            Mat sobel = new Mat();

            Cv2.Sobel(src_Origin, sobel, MatType.CV_32F, 1, 0, ksize: 3, scale: 1, delta: 0, BorderTypes.Default);
            sobel.ConvertTo(sobel, MatType.CV_8UC1);

            Cv2.ImShow("sobel", sobel);
            Cv2.WaitKey(0);
        }

        public void Laplacian()
        {
            Mat laplacian = new Mat();

            Cv2.Laplacian(src_Origin, laplacian, MatType.CV_32F, ksize: 3, scale: 1, delta: 0, BorderTypes.Default);
            laplacian.ConvertTo(laplacian, MatType.CV_8UC1);

            Cv2.ImShow("Laplacian", laplacian);
            Cv2.WaitKey(0);
        }

        public void Canny()
        {
            Mat canny = new Mat();

            Cv2.Canny(src_Origin, canny, 100, 200, 3, true);

            Cv2.ImShow("Canny", canny);
            Cv2.WaitKey(0);
        }

    }
}
