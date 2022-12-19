using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Client
{
    internal class imgTrans
    {
        private static imgTrans instance_ = new imgTrans();

        public Image img_Old; //이전 사진 저장
        public Image img_new; //변환 시킨 사진 저장

        public static imgTrans GetInstance()
        {
            return instance_;
        }


     
    }
}
