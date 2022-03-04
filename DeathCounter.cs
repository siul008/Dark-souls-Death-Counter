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
        int memorySaver = 0;

        public DeathCounter()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if(!Directory.Exists(@"D:\DeathCounter"))
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
                }
            }
        }
        private void CaptureScreen()
        {
            try
            {
                Bitmap captureBitmap = new Bitmap(719, 105, PixelFormat.Format64bppArgb);;
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                captureGraphics.CopyFromScreen(captureRectangle.Left + left, captureRectangle.Top + up, 0, 0, captureRectangle.Size);
                captureBitmap.Save(@"D:\DeathCounter\Capture.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                //MessageBox.Show("Screen Done");

                var testImagePath = @"D:\DeathCounter\Capture.jpg";
                var image = Pix.LoadFromFile(testImagePath);
                TesseractEngine engine = new TesseractEngine("./tessdata", "fra", EngineMode.Default);
                Page page = engine.Process(image, PageSegMode.Auto);
                result = page.GetText();


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
            counter++;
            File.WriteAllText(filename, counter.ToString());
        }
        public void LaunchProgram()
        {
            while (true)
            {
                if (memorySaver >= 30)
                {
                    GC.Collect();
                    memorySaver = 0;
                }
                    CaptureScreen();
                    if (result.Contains("VOUS AVEZ PÉRI"))
                    {
                        AddToCounter();
                    memorySaver++;
                        Thread.Sleep(30000);
                        result = "";
                    }
                    else
                    {
                        memorySaver++;

                        Thread.Sleep(100);
                    }
                }
            
        }

    }
}
