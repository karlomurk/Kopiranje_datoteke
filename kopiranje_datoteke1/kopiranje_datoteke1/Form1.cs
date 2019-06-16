using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kopiranje_datoteke1
{
    public partial class Form1 : Form
    {

        private BackgroundWorker radnik1 = new BackgroundWorker();

        public object Filestream { get; private set; }
        Thread t, t2, t3;

        public Form1()


        {
            InitializeComponent();


            radnik1.WorkerReportsProgress = true;
            radnik1.WorkerSupportsCancellation = true;

            radnik1.DoWork += new DoWorkEventHandler(radnik_DoWork);
            radnik1.ProgressChanged += new ProgressChangedEventHandler(radnik_ProgressChanged);
            radnik1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(radnik_RunWorkerCompleted);
        }

        private void pokreniTipka_Click(object sender, EventArgs e)
        {
            if (radnik1.IsBusy != true)
            {
                // Metodom RunWorkerAsync se pokreće izvođenje operacije u pozadini
                radnik1.RunWorkerAsync();
            }
        }

       


        void kopiranjeDatoteke(string source, string des)
        {

            FileStream fsOut = new FileStream(des, FileMode.Create);
            FileStream fsIn = new FileStream(source, FileMode.Open);

            byte[] bit = new byte[1048756];
            int readByte;
            while ((readByte = fsIn.Read(bit, 0, bit.Length)) > 0)
            {

                fsOut.Write(bit, 0, readByte);
                radnik1.ReportProgress((int)(fsIn.Position * 100 / fsIn.Length));


            }

            fsIn.Close();
            fsOut.Close();

        }


        /* DoWork
        /* https://msdn.microsoft.com/en-us/library/system.componentmodel.backgroundworker.dowork.aspx 
         * -->
         * Your code in the DoWork event handler should periodically check the CancellationPending 
         * property value and abort the operation if it is true. When this occurs, you can set the 
         * Cancel flag of System.ComponentModel.DoWorkEventArgs to true, and the Cancelled flag of 
         * System.ComponentModel.RunWorkerCompletedEventArgs in your RunWorkerCompleted event handler 
         * will be set to true.
         */

        private void posaoZaRadnika()
        {
            System.Threading.Thread.Sleep(50);



        }


        private void radnik_DoWork(object sender, DoWorkEventArgs e)
        {
            


            kopiranjeDatoteke(tekst.Text, tekst1.Text);
        }

        private void radnik_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // this.tbProgress.Text = (e.ProgressPercentage.ToString() + "%");

            napredakTekst.Text = e.ProgressPercentage.ToString();
            napredakTraka.Value = e.ProgressPercentage;
        }

        private void radnik_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if ((e.Cancelled == true))
            {
                napredakTekst.Text = "Otkazano!";
            }

            else if (!(e.Error == null))
            {
                napredakTekst.Text = ("Greška: " + e.Error.Message);
            }
            else
            {
                napredakTekst.Text = "Gotovo!";
            }
        }

        private void zaustaviTipka_Click(object sender, EventArgs e)
        {
            radnik1.CancelAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                tekst.Text = o.FileName;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog o = new FolderBrowserDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                tekst1.Text = Path.Combine(o.SelectedPath, Path.GetFileName(tekst.Text));

            }
        }

        /* https://msdn.microsoft.com/en-us/library/system.componentmodel.backgroundworker.cancelasync.aspx
         *
         * CancelAsync submits a request to terminate the pending background operation and sets the CancellationPending 
         *
         * property to true. When you call CancelAsync, your worker method has an opportunity to stop its execution and exit. 
         * The worker code should periodically check the CancellationPending property to see if it has been set to true.
         */
    }
}
