using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Diagnostics;
using System.IO;


namespace FaceDetectionApp
{
    public partial class FaceDetectionForm : Form
    {
        public FaceDetectionForm()
        {
            InitializeComponent();
        }

        private Bitmap m_Image;
        private string m_ImagePath = string.Empty;
        private CascadeClassifier m_Model;


        private CascadeClassifier LoadModel()
        {
            CascadeClassifier oRet = null;
            string tmpPath = Path.GetTempFileName();
            using (StreamWriter sw = File.CreateText(tmpPath))
            {
                sw.Write(Properties.Resources.haarcascade_frontalface_default);
                sw.Close();
                oRet = new CascadeClassifier(tmpPath);
                File.Delete(tmpPath);
            }
            return oRet;
        }

        private Rectangle[] DetectFace(Bitmap source, double scale_factor, int min_neighbour)
        {
            using (Image<Bgr, byte> picture = new Image<Bgr, byte>(source))
            {
                return m_Model.DetectMultiScale(picture, scale_factor, min_neighbour);
            }
        }

        private void ResetDetectFound()
        {
            foreach (Control ctl in this.tlpFound.Controls)
            {
                if (!(ctl is PictureBox && ctl.Name.StartsWith("pbDetect")))
                {
                    continue;
                }
                PictureBox pb = (PictureBox)ctl;
                if (pb.Image == null)
                {
                    pb.Image = new Bitmap(pb.Size.Width, pb.Size.Height);
                }
                else
                {
                    using (Graphics g = Graphics.FromImage(pb.Image))
                    {

                        g.FillRectangle(new SolidBrush(pb.BackColor), 0, 0, pb.Size.Width, pb.Size.Height);
                    }
                    pb.Refresh();
                }
            }

        }

        private void CopyToDetectFound(Bitmap img, Rectangle[] rects)
        {
            int i = 1;
            var orders = rects.OrderByDescending(r => r.Size.Height * r.Size.Width);
            foreach (var rect in orders)
            {
                PictureBox pb = (PictureBox)tlpFound.Controls[string.Format("pbDetect{0}", i)];
                if (pb != null)
                {
                    using (Graphics g = Graphics.FromImage(pb.Image))
                    {
                        int x = Convert.ToInt32(rect.X - rect.Width * 0.25);
                        int y = Convert.ToInt32(rect.Y - rect.Height * 0.4);
                        x = x < 0 ? 0 : x;
                        y = y < 0 ? 0 : y;
                        g.DrawImage(img,
                            pbDetect2.DisplayRectangle,
                            new Rectangle(
                                x,
                                y,
                                Convert.ToInt32(rect.Width * 1.5),
                                Convert.ToInt32(rect.Height * 1.5)
                            ),
                            GraphicsUnit.Pixel);
                    }
                    pb.Refresh();
                }
                i++;
            }
        }

        private void DrawRectangles(Bitmap source, Rectangle[] rects)
        {
            foreach (var rect in rects)
            {
                using (Graphics g = Graphics.FromImage(source))
                {
                    g.DrawRectangle(Pens.Red, rect);
                    g.DrawRectangle(Pens.Pink,
                            Convert.ToInt32(rect.X - rect.Width * 0.25),
                            Convert.ToInt32(rect.Y - rect.Height * 0.4),
                            Convert.ToInt32(rect.Width * 1.5),
                            Convert.ToInt32(rect.Height * 1.5));
                }
            }
            pictureBox1.Refresh();

        }

        private void FaceDetectionForm_Load(object sender, EventArgs e)
        {
            m_Model = LoadModel();
            nupMinNeighbour.ValueChanged += ParameterValueChanged;
            nupScale.ValueChanged += ParameterValueChanged;
        }

        private void btnDectect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All images|*.jpg;*.jpeg;*.png;*.gif|All files|*.*";

            if(dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            m_ImagePath = dlg.FileName;
            txtImagePath.Text = m_ImagePath;
            m_Image = (Bitmap)Image.FromFile(m_ImagePath);
            pictureBox1.Image = (Image)m_Image.Clone();

            ResetDetectFound();

            var rects = DetectFace(m_Image, Convert.ToDouble(nupScale.Value), Convert.ToInt32(nupMinNeighbour.Value));

            CopyToDetectFound((Bitmap)pictureBox1.Image, rects);
            DrawRectangles((Bitmap)pictureBox1.Image, rects);
        }

        private void ParameterValueChanged(object sender, EventArgs e)
        {
            if(m_Image !=null)
            {
                ResetDetectFound();
                pictureBox1.Image = (Image)m_Image.Clone();
                var rects = DetectFace(m_Image, Convert.ToDouble(nupScale.Value), Convert.ToInt32(nupMinNeighbour.Value));
                CopyToDetectFound((Bitmap)pictureBox1.Image, rects);
                DrawRectangles((Bitmap)pictureBox1.Image, rects);
            }
        }
    }
}
