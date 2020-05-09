using CardsGenerator.Properties;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardsGenerator
{
    public partial class Form1 : Form
    {
        private Point RectStartPoint;
        private Rectangle Rect = new Rectangle();
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));
        private Bitmap logo;
        private Bitmap InitQRCode;
        private Rectangle RealRect;
        int Hr, Wr;
        private string path { get { return Path.Combine(Settings.Default.FolderName , "Cards Generator Result"); } }
        public Form1()
        {
            try
            {
                InitializeComponent();
                logo = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("CardsGenerator.Images.pngiconred.png"));
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(Guid.NewGuid().ToString(), QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                InitQRCode = qrCode.GetGraphic(20, Color.Black, Color.White, logo);

            }
            catch
            {

            }
          
            
        }



        private void PickBackgroundBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();

                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    BackgroundPic.Image = Image.FromFile(dlg.FileName);
                    Hr = Math.Abs(BackgroundPic.Image.Height / BackgroundPic.Height);
                    Wr = Math.Abs(BackgroundPic.Image.Width / BackgroundPic.Width);
                }

                dlg.Dispose();
            }
            catch
            {

            }
          

        }
        protected Point TranslateZoomMousePosition(Point coordinates)
        {
            if (BackgroundPic.Image == null) return coordinates;

            if (BackgroundPic.Width == 0 || BackgroundPic.Height == 0 || BackgroundPic.Image.Width == 0 || BackgroundPic.Image.Height == 0)
                return coordinates;

            float imageAspect = (float)BackgroundPic.Image.Width / BackgroundPic.Image.Height;
            float controlAspect = (float)BackgroundPic.Width / BackgroundPic.Height;
            float newX = coordinates.X;
            float newY = coordinates.Y;
            try
            {
                if (imageAspect > controlAspect)
                {
                    // This means that we are limited by width, 
                    // meaning the image fills up the entire control from left to right
                    float ratioWidth = (float)BackgroundPic.Image.Width / BackgroundPic.Width;
                    newX *= ratioWidth;
                    float scale = (float)BackgroundPic.Width / BackgroundPic.Image.Width;
                    float displayHeight = scale * BackgroundPic.Image.Height;
                    float diffHeight = BackgroundPic.Height - displayHeight;
                    diffHeight /= 2;
                    newY -= diffHeight;
                    newY /= scale;
                }
                else
                {
                    // This means that we are limited by height, 
                    // meaning the image fills up the entire control from top to bottom
                    float ratioHeight = (float)BackgroundPic.Image.Height / Height;
                    newY *= ratioHeight;
                    float scale = (float)BackgroundPic.Height / BackgroundPic.Image.Height;
                    float displayWidth = scale * BackgroundPic.Image.Width;
                    float diffWidth = BackgroundPic.Width - displayWidth;
                    diffWidth /= 2;
                    newX -= diffWidth;
                    newX /= scale;
                }
            }
            catch
            {

            }
           
        
            return new Point((int)newX, (int)newY);
        }
        public void AddStampAndSave()
        {
            try
            {
                Bitmap bitmap = new Bitmap(BackgroundPic.Image);
                Graphics gr = Graphics.FromImage(bitmap);
                gr.DrawImage(QRCodePic.Image, RealRect);
                bitmap.Save(Path.Combine(path,DateTime.Now.ToString("yyyyMMddHHmmss") + ".png"),ImageFormat.Png);
                ResultPic.Image = bitmap;
            }
            catch
            {

            }
           
        }
        private  void GenerateBtn_Click(object sender, EventArgs e)
        {
            Generate();
        }
        public async void Generate()
        {
            GenerateBtn.Enabled = false;
            PickBackgroundBtn.Enabled = false;

            try
            {

                if (string.IsNullOrEmpty(Settings.Default.FolderName)|| !Directory.Exists(path))
                {
                    using (var fbd = new FolderBrowserDialog())
                    {
                        DialogResult result = fbd.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            Settings.Default.FolderName = fbd.SelectedPath;
                            Settings.Default.Save();
                            if (!Directory.Exists(path))
                                Directory.CreateDirectory(path);
                            Generate();
                        }
                    }
                }
                else
                {
                    if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
                    {
                        var count = Convert.ToInt32(GenerateCountBox.SelectedItem ?? 1);
                        await Task.Run(async () =>
                        {
                            for (int i = 0; i < count; i++)
                            {
                                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                                QRCodeData qrCodeData = qrGenerator.CreateQrCode(Guid.NewGuid().ToString(), QRCodeGenerator.ECCLevel.Q);
                                QRCode qrCode = new QRCode(qrCodeData);
                                Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.Black, Color.White, logo);
                                QRCodePic.Image = qrCodeImage;
                                await Task.Delay(900);
                                AddStampAndSave();

                            }
                        });
                    }
                    else
                    {
                        MessageBox.Show("please select your QR Code location");
                    }
                }

            }
            catch
            {

            }

            GenerateBtn.Enabled = true;
            PickBackgroundBtn.Enabled = true;
        }
       
        private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                RectStartPoint = e.Location;
                Invalidate();
            }
            catch
            {

            }
           
        }
        private void pictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                if (e.Button != MouseButtons.Left)
                    return;
                Point tempEndPoint = e.Location;
                Rect.Location = new Point(
                    Math.Min(RectStartPoint.X, tempEndPoint.X),
                    Math.Min(RectStartPoint.Y, tempEndPoint.Y));
                Rect.Size = new Size(
                    Math.Abs(RectStartPoint.X - tempEndPoint.X),
                    Math.Abs(RectStartPoint.Y - tempEndPoint.Y));

                RealRect.Location = new Point(
                     Math.Min(TranslateZoomMousePosition(RectStartPoint).X, TranslateZoomMousePosition(tempEndPoint).X),
                     Math.Min(TranslateZoomMousePosition(RectStartPoint).Y, TranslateZoomMousePosition(tempEndPoint).Y));
                RealRect.Size = new Size(
                    Math.Abs(TranslateZoomMousePosition(RectStartPoint).X - TranslateZoomMousePosition(tempEndPoint).X),
                    Math.Abs(TranslateZoomMousePosition(RectStartPoint).Y - TranslateZoomMousePosition(tempEndPoint).Y));

                BackgroundPic.Invalidate();
            }
            catch
            {

            }
          
            
        }

      
        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            try
            {
                if (BackgroundPic.Image != null)
                {
                    if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
                    {
                        e.Graphics.DrawImage(InitQRCode, Rect);
                    }
                }
            }
            catch
            {

            }
           
        }

       
    }
}
