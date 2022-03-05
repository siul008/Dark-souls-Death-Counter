﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        
        int counter = 0;
        int todayCounter = 0;
        Bitmap captureBitmap;
        TesseractEngine engine;
        Rectangle captureRectangle;
        Graphics captureGraphics;
       readonly string capturePath = @"D:\DeathCounter\Capture.bmp";
       readonly string filename = @"D:\DeathCounter\Deaths.txt";
       readonly string filenameTodayDeath = @"D:\DeathCounter\TodayDeaths.txt";
        static int runs = 0;


        private static BackgroundWorker worker;

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
            if(!File.Exists(filename))
            {
                using StreamWriter sw = File.CreateText(filename);
                sw.WriteLine("0");
            }
            if (!File.Exists(filenameTodayDeath))
            {
                using StreamWriter sw = File.CreateText(filename);
                sw.WriteLine("0");
            }
                counter = int.Parse(File.ReadAllText(filename));
                todayCounter = 0;
                File.WriteAllText(filenameTodayDeath, todayCounter.ToString());
        }
        private void CaptureScreen()
        {
            try
            {
                captureBitmap = new Bitmap(719, 105, PixelFormat.Format48bppRgb);
                engine = new TesseractEngine("./tessdata", "fra", EngineMode.Default);
                captureRectangle = Screen.AllScreens[0].Bounds;
                captureGraphics = Graphics.FromImage(captureBitmap);
                
                captureGraphics.CopyFromScreen(captureRectangle.Left + left, captureRectangle.Top + up, 0, 0, captureRectangle.Size);
                captureBitmap.Save(@"D:\DeathCounter\Capture.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

                var image = Pix.LoadFromFile(capturePath);
                Page page = engine.Process(image, PageSegMode.Auto);
                result = page.GetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Screenshot
        private void Button1_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            if(result.Contains("VOUS") || result.Contains("AVEZ") || result.Contains("PÉRI"))
            {
                MessageBox.Show(result);
            }
        }
        //DisplayValue
        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        //LancerProgramme
        private void Button1_Click_1(object sender, EventArgs e)
        {
            LancerProgrammeButton.Enabled = false;
            worker = new BackgroundWorker();
            worker.DoWork += LaunchProgram;
            worker.RunWorkerCompleted += WorkerLoopCompleted;
            worker.RunWorkerAsync();
        }
        public void AddToCounter()
        {
            todayCounter++;
            counter++;
            File.WriteAllText(filename, counter.ToString());
            File.WriteAllText(filenameTodayDeath, todayCounter.ToString());
        }
        public void LaunchProgram(object sender, DoWorkEventArgs e)
        {
            CaptureScreen();
            GC.Collect();
            if (result.Contains("VOUS") || result.Contains("AVEZ") || result.Contains("PÉRI"))
              {
                 AddToCounter();
                 Debug.WriteLine("Trouvé à  " + DateTime.Now);
                 Thread.Sleep(15000);
                 result = "";
              }
            else
              {
               Thread.Sleep(50);
              }
        }
        static void WorkerLoopCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            worker.RunWorkerAsync();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            todayCounter = 0;
            File.WriteAllText(filenameTodayDeath, todayCounter.ToString());
        }
    }
}
