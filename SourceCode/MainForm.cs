using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraMonitor
{
    public partial class MainForm : Form
    {
        public FilterInfoCollection WebCAMs = null;
        public VideoCaptureDevice SelectCAM = null;

        public MainForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.CAM;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WebCAMs = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            ddlVideoDevice.Items.Clear();
            if (WebCAMs.Count <= 0)
                ddlVideoDevice.Items.Add("- 查無影像擷取裝置 -");
            else
            {
                foreach (FilterInfo tmpObj in WebCAMs)
                {
                    ddlVideoDevice.Items.Add(tmpObj.Name);
                }
            }

            ddlVideoDevice.SelectedIndex = 0;
        }

        private void btnPlayStop_Click(object sender, EventArgs e)
        {
            if (SelectCAM == null)
            {
                foreach (FilterInfo tmpObj in WebCAMs)
                {
                    if (tmpObj.Name == ddlVideoDevice.Text)
                    {
                        SelectCAM = new VideoCaptureDevice(tmpObj.MonikerString);
                        SelectCAM.NewFrame += SelectCAM_NewFrame;
                        btnPlayStop.BackgroundImage = Properties.Resources.STOP;

                        SelectCAM.Start();
                        ddlVideoDevice.Enabled = false;
                        break;
                    }
                }

                if (SelectCAM == null)
                {
                    MessageBox.Show("請先選取要使用的影像擷取裝置!!");
                    return;
                }
            }
            else
            {
                if (SelectCAM.IsRunning) SelectCAM.Stop();
                btnPlayStop.BackgroundImage = Properties.Resources.PLAY;
                RealTimeMonitor.Image = null;
                ddlVideoDevice.Enabled = true;
                SelectCAM = null;
            }
        }

        private void SelectCAM_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            RealTimeMonitor.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SelectCAM != null && SelectCAM.IsRunning) SelectCAM.Stop();
        }

        private void btnSnapshot_Click(object sender, EventArgs e)
        {
            Image saveImage = RealTimeMonitor.Image;
            try
            {
                DirectoryInfo infoDir = new DirectoryInfo(System.Reflection.Assembly.GetExecutingAssembly().Location.Replace(System.Reflection.Assembly.GetExecutingAssembly().ManifestModule.Name, ""));

                string pathName = string.Format("{0}ScreenShot\\", (infoDir.FullName.EndsWith("\\") ? infoDir.FullName : (infoDir.FullName + "\\")));
                if (!Directory.Exists(pathName)) Directory.CreateDirectory(pathName);
                string FileName = string.Format("{0}{1}.jpg", pathName, DateTime.Now.ToString("yyyyMMdd-HHmmss"));
                labStatus.Text = FileName;
                byte[] byeFileContent = new byte[0];
                using (FileStream tmpFS = new FileStream(FileName, FileMode.Create, FileAccess.ReadWrite))
                {
                    saveImage.Save(tmpFS, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tmpFS.Position = 0;
                }
            }
            catch { }

        }

        private void chkTopMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkTopMost.Checked;
        }
    }
}
