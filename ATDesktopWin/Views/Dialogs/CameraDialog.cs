using OpenCvSharp;
using OpenCvSharp.Extensions;
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

namespace ATDesktopWin.Views.Dialogs
{
    public partial class CameraDialog : Form
    {
        public Bitmap image;

        private VideoCapture capture;
        private Mat frame;
        private Thread cameraThread;
        private bool isCameraRunning = false;

        public CameraDialog()
        {
            InitializeComponent();
        }

        private void CaptureCamera()
        {
            cameraThread = new Thread(new ThreadStart(CaptureCameraCallback));
            cameraThread.Start();
        }

        private void CaptureCameraCallback()
        {
            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);

            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {
                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);
                    if (pbFrame.Image != null)
                    {
                        pbFrame.Image.Dispose();
                    }
                    pbFrame.Image = image;
                }
                capture.Release();
            }
        }

        private void CameraDialog_Shown(object sender, EventArgs e)
        {
            btnCapture.PerformClick();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (btnCapture.Text.Equals("Retry"))
            {
                CaptureCamera();
                btnCapture.Text = "Capture";
                btnSelect.Enabled = false;
                isCameraRunning = true;
            }
            else
            {
                btnCapture.Text = "Retry";
                btnSelect.Enabled = true;
                isCameraRunning = false;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CameraDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            isCameraRunning = false;
        }
    }
}
