using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace Dark_souls_Death_Counter
{
    public partial class DeathCounter : Form
    {
        int left = 610;
        int up = 470;
        string result = "";
        string filename = @"D:\DeathCounter\Deaths.txt";
        int counter = 0;
        Bitmap captureBitmap;
        TesseractEngine engine;
        Rectangle captureRectangle;
        Graphics captureGraphics;
        string testImagePath = @"D:\DeathCounter\Capture.jpg";

        public DeathCounter()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"D:\DeathCounter"))
            {
                Directory.CreateDirectory(@"D:\DeathCounter");
            }
            if(File.Exists(filename))
            {
                counter = int.Parse(File.ReadAllText(filename));
            }
           else
            {
                using(StreamWriter sw = File.CreateText(filename))
                {
                    sw.WriteLine("0");
                    counter = int.Parse(File.ReadAllText(filename));
                }
            }
        }
        private void CaptureScreen()
        {
            try
            {
                captureBitmap = new Bitmap(719, 105, PixelFormat.Format64bppArgb);
                captureRectangle = Screen.AllScreens[0].Bounds;
                captureGraphics = Graphics.FromImage(captureBitmap);
                engine = new TesseractEngine("./tessdata", "fra", EngineMode.Default);
                captureGraphics.CopyFromScreen(captureRectangle.Left + left, captureRectangle.Top + up, 0, 0, captureRectangle.Size);
                captureBitmap.Save(@"D:\DeathCounter\Capture.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

                var image = Pix.LoadFromFile(testImagePath);
                Page page = engine.Process(image, PageSegMode.Auto);
                result = page.GetText();
                captureBitmap = null;
                engine = null;
                image = null;
                page = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Screenshot
        private void button1_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            if(result.Contains("VOUS AVEZ PÉRI"))
            {
                MessageBox.Show("Trouvé");
            }
        }
        //AddLeft
        private void button2_Click_1(object sender, EventArgs e)
        {
            left += 10;
        }
        //AddTop
        private void buttonTest_Click(object sender, EventArgs e)
        {
            up += 10;
        }
        //DisplayValue
        private void DisplayValueButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(left + " , " + up);
        }
        //LancerProgramme
        private void button1_Click_1(object sender, EventArgs e)
        {
            LaunchProgram();
        }
        public void AddToCounter()
        {
            counter = int.Parse(File.ReadAllText(filename));
            counter++;
            File.WriteAllText(filename, counter.ToString());
        }
        public void LaunchProgram()
        {
            while (true)
            {
                    CaptureScreen();
                    GC.Collect();
                if (result.Contains("VOUS AVEZ PÉRI"))
                    {
                        AddToCounter();
                        Thread.Sleep(10000);
                        result = "";
                    }
                    else
                    {
                        Thread.Sleep(50);
                    }
                }
        }
    }
}
