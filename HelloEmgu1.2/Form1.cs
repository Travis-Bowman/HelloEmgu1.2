using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HelloEmgu1._2
{
    public partial class Form1 : Form
    {

        private VideoCapture _capture;
        private Thread _captureThread;
        private int _threshold = 150;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _capture = new VideoCapture(0);// changing the arg to a different number will change the video signal. 
            _captureThread = new Thread(Displaywebcam);
            _captureThread.Start();

          ThresholdTrackbar.Value = _threshold;
        }

        private void Displaywebcam()
        {
            while (_capture.IsOpened)
            {
                //frame maint
                Mat frame = _capture.QueryFrame();

                //resize
                int newHeight = (frame.Size.Height * emguPictureBox.Size.Width) / frame.Size.Width;
                Size newSize = new Size(emguPictureBox.Size.Width, newHeight);
                CvInvoke.Resize(frame, frame, newSize);

                //display the image in the pichtureBox
                emguPictureBox.Image = frame.ToBitmap();


                //convert to gray
                CvInvoke.CvtColor(frame, frame, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);

                //binary threhold
                CvInvoke.Threshold(frame, frame, _threshold, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

                //output the binary threshold image to second pichure box:
                binaryPictureBox.Image = frame.ToBitmap();

                //count the number of white pixels
                int whitePixelsExtendedOutterLeft = 0;
                int whitePixelsExtendedInnerLeft = 0;
                int whitePixelsExtendedCent = 0;
                int whitePixelsExtendedInnerRight = 0;
                int whitePixelsExtendedOutterRight = 0;

                Image<Gray, byte> img = frame.ToImage<Gray, byte>();

                //Calculates the outter left slice
                for(int x = 0; x < (frame.Width/5); x++)
                {
                    for(int y = 0; y <frame.Height; y++)
                    {
                        if (img.Data[y, x, 0] == 255) whitePixelsExtendedOutterLeft++;
                    }
                }
                //Calculates the inner left slice
                for (int x = (frame.Width / 5); x < (frame.Width / 5)*2; x++)
                {
                    for (int y = 0; y < frame.Height; y++)
                    {
                        if (img.Data[y, x, 0] == 255) whitePixelsExtendedInnerLeft++;
                    }
                }
                //Calculates the center slice
                for (int x = (frame.Width / 5)*2; x < (frame.Width / 5) * 3; x++)
                {
                    for (int y = 0; y < frame.Height; y++)
                    {
                        if (img.Data[y, x, 0] == 255) whitePixelsExtendedCent++;
                    }
                }
                //Calculates the inner right slice
                for (int x = (frame.Width / 5) * 3; x < (frame.Width / 5) * 4; x++)
                {
                    for (int y = 0; y < frame.Height; y++)
                    {
                        if (img.Data[y, x, 0] == 255) whitePixelsExtendedInnerRight++;
                    }
                }
                //Calculates the outter right slice
                for (int x = (frame.Width / 5) * 4; x < (frame.Width / 5) * 5; x++)
                {
                    for (int y = 0; y < frame.Height; y++)
                    {
                        if (img.Data[y, x, 0] == 255) whitePixelsExtendedOutterRight++;
                    }
                }

                //displays their respective white pixel count to form1
                Invoke(new Action(() =>
                {
                    whitePixelsExtendedOutputLOL.Text = $"{whitePixelsExtendedOutterLeft} Outter Left ";
                    whitePixelsExtendedOutputLIL.Text = $"{whitePixelsExtendedInnerLeft} Inner Left ";
                    whitePixelsExtendedOutputLCent.Text = $"{whitePixelsExtendedCent} Center ";
                    whitePixelsExtendedOutputLIR.Text = $"{whitePixelsExtendedInnerRight} Inner Right ";
                    whitePixelsExtendedOutputLOR.Text = $"{whitePixelsExtendedOutterRight} Outter Right ";
                }));
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _captureThread.Abort();
        }
        private void ThresholdTrackbar_ValueChanged(object sender, EventArgs e)
        {
            _threshold = ThresholdTrackbar.Value;
        }


    }
}
