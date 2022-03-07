using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace Dark_souls_Death_Counter
{
    public partial class DeathCounter : Form
    {
       readonly int left = 610;
       readonly int up = 470;
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
       readonly string folderPath = @"D:\DeathCounter";

        static bool cancelWork = false;

        private static BackgroundWorker worker;

        public DeathCounter()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += LaunchProgram;
            worker.RunWorkerCompleted += WorkerLoopCompleted;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayValueButton.Enabled = false;
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
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
            MortsAtmLabel.Text = "Morts Actuelles  = 0";
            MortsTotalsLabel.Text = "Morts Totales = " + counter.ToString();
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
        public void LaunchProgram(object sender, DoWorkEventArgs e)
        {
            if(cancelWork == true)
            {
                e.Cancel = true;
                return;
            }
                CaptureScreen();
                GC.Collect();
            if (result.Contains("VOUS") || result.Contains("AVEZ") || result.Contains("PÉRI"))
            {
                AddToCounter();
                Debug.WriteLine("Trouvé à  " + DateTime.Now);
                Thread.Sleep(6000);
                result = "";
            }
           #if DEBUG
                if (Regex.IsMatch(result, "[A-Z]"))
                {
                    Debug.WriteLine(result);
                File.AppendAllText(@"D:\DeathCounter\Logs.txt", result + "à " + DateTime.Now);
                }
           #endif
            else
                {
                    Thread.Sleep(50);
                }
        }
        public void AddToCounter()
        {
            
            todayCounter++;
            counter++;
            File.WriteAllText(filename, counter.ToString());
            File.WriteAllText(filenameTodayDeath, todayCounter.ToString());
            UpdateUI(MortsAtmLabel, MortsTotalsLabel);
        }

        static void WorkerLoopCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(!e.Cancelled)
            {
                worker.RunWorkerAsync();
            }
            else
            {
                Debug.WriteLine("Cancelled");
            }
        }


        //LancerProgramme
        private void LaunchProgram_Click_1(object sender, EventArgs e)
        {
            if (worker.IsBusy != true)
            {
                LancerProgrammeButton.Enabled = false;
                DisplayValueButton.Enabled = true;
                cancelWork = false;
                worker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Veuillez attendre quelques secondes puis réessayer");
            }
        }

        //ArreterProgramme
        private void StopButton_Click(object sender, EventArgs e)
        {
            cancelWork = true;
            LancerProgrammeButton.Enabled = true; ;
            DisplayValueButton.Enabled = false;
        }

        //Screenshot
        private void Screenshot_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            if (result.Contains("VOUS") || result.Contains("AVEZ") || result.Contains("PÉRI"))
            {
                MessageBox.Show(result);
            }
        }

        //Reset Mort Du Jour Bouton
        private void ResetButton_Click(object sender, EventArgs e)
        {
            todayCounter = 0;
            File.WriteAllText(filenameTodayDeath, todayCounter.ToString());
        }

        //Ouvrir Dossier Bouton
        private void OpenFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", folderPath);
            UpdateUI(MortsAtmLabel, MortsTotalsLabel);
        }

        //Quitter Bouton
        private void TerminateButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void UpdateUI(System.Windows.Forms.Label atmLab, System.Windows.Forms.Label totalLab)
        {
            if (atmLab.InvokeRequired)
            {
                atmLab.BeginInvoke(new MethodInvoker(() => UpdateUI(atmLab, totalLab)));
            }
            else
            {
                counter = int.Parse(File.ReadAllText(filename));
                atmLab.Text = "Morts Actuelles  = " + todayCounter.ToString();
                totalLab.Text = "Morts Totales = " + counter.ToString(); ;
            }
        }

        private void totalDeathButtonMinus_Click(object sender, EventArgs e)
        {
            counter--;
            File.WriteAllText(filename, counter.ToString());
            UpdateUI(MortsAtmLabel, MortsTotalsLabel);
        }

        private void totalDeathButtonPlus_Click(object sender, EventArgs e)
        {
            counter++;
            File.WriteAllText(filename, counter.ToString());
            UpdateUI(MortsAtmLabel, MortsTotalsLabel);
        }

        private void atmDeathButtonPlus_Click(object sender, EventArgs e)
        {
            todayCounter++;
            File.WriteAllText(filenameTodayDeath, todayCounter.ToString());
            UpdateUI(MortsAtmLabel, MortsTotalsLabel);
        }

        private void atmDeathButtonMinus_Click(object sender, EventArgs e)
        {
            todayCounter--;
            File.WriteAllText(filenameTodayDeath, todayCounter.ToString());
            UpdateUI(MortsAtmLabel, MortsTotalsLabel);
        }
    }
}
