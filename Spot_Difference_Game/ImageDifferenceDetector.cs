using System;
using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;

namespace Spot_Difference_Game
{
    internal class ImageDifferenceDetector
    {
        public List<Rectangle> DifferenceAreas { get; private set; } = new List<Rectangle>();

        public void DetectDifferences(Mat img1, Mat img2)
        {
            Mat diff = new Mat();
            CvInvoke.AbsDiff(img1, img2, diff);

            Mat gray = new Mat();
            CvInvoke.CvtColor(diff, gray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

            Mat thresh = new Mat();
            CvInvoke.Threshold(gray, thresh, 50, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

            CvInvoke.Dilate(thresh, thresh, null, new Point(-1, -1), 2, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar());//لتوسيع الفروق مشان موضوع اكتر من بكسل

            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                //عم دور على الحواف
                CvInvoke.FindContours(thresh, contours, null, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
                DifferenceAreas.Clear();
                for (int i = 0; i < contours.Size; i++)
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                    if (rect.Width > 10 && rect.Height > 10)
                    {
                        DifferenceAreas.Add(rect);
                    }
                }
            }
        }
    }
}

    