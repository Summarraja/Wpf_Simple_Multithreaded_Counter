using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Multi_Threated_Counter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BackgroundWorker bgWorker = new BackgroundWorker();
        int counterMax = 100;
        int counterMin = 0;

        bool pause, decrement = false;
        bool increment = true;
        public MainWindow()
        {
            InitializeComponent();
            bgWorker.DoWork += BgWorker_DoWork;
            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;

            bgWorker.WorkerSupportsCancellation = true;
            bgWorker.WorkerReportsProgress = true;
           

            this.progressBar.Maximum = this.counterMax;
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                this.label.Content = "0";
                progressBar.Value = 0;
            }

            this.startBtn.Content = "Start";
            pauseBtn.IsEnabled = false;
            pauseBtn.Content = "Pause";
            pause = false;
            increment = true;
            decrement = false;

        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > -1)
            {
                this.label.Content = e.ProgressPercentage;
                this.progressBar.Value = e.ProgressPercentage;
            }
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("yes");
            int i = 0;
            while ((i <= this.counterMax && increment)|| (i>=this.counterMin && decrement))
            {

                if (!pause)
                {
                    bgWorker.ReportProgress(i);
                    System.Threading.Thread.Sleep(100);
                    if(increment)
                    i++;
                    if (decrement)
                        i--;
                }

                if (bgWorker.CancellationPending)
                {
                    Console.WriteLine("Thread is exiting....");
                    e.Cancel = true;
                    break;
                }
            }
          
        }

        private void decrementBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!decrement)
            {
                decrement = true;
                increment = false;
            }
        }

        private void pauseBtn_Click(object sender, RoutedEventArgs e)
        {
            if (pause)
            {
                pause = false;
                pauseBtn.Content = "Pause";
            }

            else
            {
                pause = true;
                pauseBtn.Content = "Resume";
            }
                
        }

        private void incrementBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!increment)
            {
                increment = true;
                decrement = false;
            }
                
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!bgWorker.IsBusy)
            {
                bgWorker.RunWorkerAsync();
                startBtn.Content = "Stop";
                pauseBtn.IsEnabled = true;
                incrementBtn.IsEnabled = true;
                decrementBtn.IsEnabled = true;
            }
            else
            {
                bgWorker.CancelAsync();
               // progressBar.Value = 0;
                startBtn.Content = "Start";
                pauseBtn.IsEnabled = false;
                incrementBtn.IsEnabled = false;
                decrementBtn.IsEnabled = false;
            }
        }
    }
}
