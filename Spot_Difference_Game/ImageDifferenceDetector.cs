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
        public VectorOfVectorOfPoint Contours { get; private set; } = new VectorOfVectorOfPoint();
        public List<CircleF> DifferenceCircles { get; private set; } = new List<CircleF>();
        public Mat BinaryImage { get; private set; }

        public void DetectDifferences(Mat img1, Mat img2)
        {
            // Subtract the images
            Mat subimage = new Mat();
            CvInvoke.AbsDiff(img1, img2, subimage);

            // Convert to grayscale
            Mat gray = new Mat();
            CvInvoke.CvtColor(subimage, gray, ColorConversion.Bgr2Gray);

            // Threshold to binary
            Mat binary = new Mat();
            CvInvoke.Threshold(gray, binary, 30, 255, ThresholdType.Binary);

            BinaryImage = binary;

            // Save binary for debugging
            BinaryImage.Save("C:\\Users\\Touqa2003\\source\\repos\\Spot_Difference_Game\\Spot_Difference_Game\\pictures\\debug_binary.jpg");

            // Find contours
            Contours.Clear();
            CvInvoke.FindContours(binary, Contours, null, RetrType.External, ChainApproxMethod.ChainApproxSimple);

            // Filter and merge contours
            List<CircleF> rawCircles = new List<CircleF>();

            for (int i = 0; i < Contours.Size; i++)
            {
                double area = CvInvoke.ContourArea(Contours[i]);

                if (area < 50) continue; // 🧹 Skip small noise

                CircleF circle = CvInvoke.MinEnclosingCircle(Contours[i]);
                rawCircles.Add(circle);
            }

            // 🧠 Merge close circles
            DifferenceCircles = MergeCloseCircles(rawCircles, mergeDistance: 40f);
        }

        private List<CircleF> MergeCloseCircles(List<CircleF> circles, float mergeDistance)
        {
            var merged = new List<CircleF>();

            foreach (var circle in circles)
            {
                bool isMerged = false;

                for (int i = 0; i < merged.Count; i++)
                {
                    float dx = merged[i].Center.X - circle.Center.X;
                    float dy = merged[i].Center.Y - circle.Center.Y;
                    float distance = (float)Math.Sqrt(dx * dx + dy * dy);

                    if (distance < mergeDistance)
                    {
                        // Merge by averaging centers and using the larger radius
                        var avgCenter = new PointF(
                            (merged[i].Center.X + circle.Center.X) / 2,
                            (merged[i].Center.Y + circle.Center.Y) / 2
                        );
                        float maxRadius = Math.Max(merged[i].Radius, circle.Radius);

                        merged[i] = new CircleF(avgCenter, maxRadius);
                        isMerged = true;
                        break;
                    }
                }

                if (!isMerged)
                {
                    merged.Add(circle);
                }
            }

            return merged;
        }

    }
}
          