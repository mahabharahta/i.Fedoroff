
/// <summary>
/// This code powered by Denis Plugatar, Ukraine, Kyiv
/// email: denisplugatar@gmail.com 
/// for SmartSolutions .co
/// "I.Fedoroff" 
/// All rights reserved 
/// 2015-2016
/// </summary>
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System;
using System.Reflection;
using System.Drawing.Printing;
using Microsoft.Office.Interop.Word;


namespace I.Fedoroff
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        #region Global variables
        private string FileName = null;
        private static Microsoft.Office.Interop.Word.Application WordApp;
        private Microsoft.Office.Interop.Word.Document aDoc;
        private int PagesCount = 0;
        private int counter = 0;
        private bool FlashIsIn = false;
        private static SerialPort COM = new SerialPort();
        private static int StorageDevicesCount = 0;
        private static int Money = 0;
        private static bool ConnectionIsExist;
        private string text1 = "Друкувати лаби тепер простіше      ";
        private string text2 = "разом з Іваном Федоровим       ";
        private string text3 = "   Швидко     Просто    Якісно       ";
        private Thread DeviceSearchThread;
        private Thread BackgroundThread;
        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            COM.PortName = ports[ports.Length - 1];
            COM.BaudRate = 9600;
            COM.DataBits = 8;
            COM.DataReceived += COM_DataReceived;
            foreach (var item in DriveInfo.GetDrives())
                if (item.DriveType != DriveType.Removable)
                    StorageDevicesCount++;
            DeviceSearchThread = new Thread(new ThreadStart(TryDevice));
            BackgroundThread = new Thread(new ThreadStart(WaitingAnimation));
     
            BackgroundThread.Start();
            DeviceSearchThread.Start();
        }

        private void COM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Money=Convert.ToInt32(lblPayed.Text) + Convert.ToInt32(COM.ReadLine());
            this.Invoke(new Action<string>((s) => lblPayed.Text = s), Money.ToString());
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            COM.Open();
            FileName = Viewer.SelectedItemName;
            lblTime.Text = "60";
            if (FileName != null)
            try
            {
                CountDocPages(FileName);
                lblFileName.Invoke(new Action<string>((s) => lblFileName.Text = s), FileName);
                lblPrice.Invoke(new Action<string>((s) => lblPrice.Text = s), Convert.ToString(PagesCount));
                pnlPayment.Visible = true;
                WaitingTimer.Start();
            }
            catch (TimeoutException)
            {
                 
            }
            else
                MessageBox.Show("Оберіть документ!");

        }
        private void WaitingTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = Convert.ToString(Convert.ToInt32(lblTime.Text)-1);
            if (lblTime.Text == "0")
            {
                WaitingTimer.Stop();
                pnlPayment.Hide();
            }
            else
            {
                try
                {
                    if (PagesCount <= Money)
                    {
                        aDoc.PrintOut();
                        aDoc = null;
                        PagesCount = 0;
                        Money = 0;
                        lblPayed.Invoke(new Action<string>((s) => lblPayed.Text = s), "0");
                        pnlPayment.Hide();
                        WaitingTimer.Stop();
                        COM.Close();
                        
                    }
                    
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Файл не знайдено або пошкоджено");
                }
                Thread.Sleep(50);
            }
        }     
        private void CountDocPages(string FileName)
        {
            try
            {
                if (Viewer.SelectedItemName.EndsWith(".doc") || Viewer.SelectedItemName.EndsWith(".docx"))
                {
                    WordApp = new Microsoft.Office.Interop.Word.Application();
                    aDoc = WordApp.Documents.Open(FileName, ReadOnly: true, Visible: false);
                    Microsoft.Office.Interop.Word.WdStatistic stat = Microsoft.Office.Interop.Word.WdStatistic.wdStatisticPages;
                    PagesCount = aDoc.ComputeStatistics(stat);

                    aDoc.Activate();
                }
            }
            catch
            {
                MessageBox.Show("Виникла помилка під час підрахунку кількості сторінок.");
            }
           
        }
      
        private void TryDevice()
        {
            while (true)
            {
                if (DriveInfo.GetDrives().Length > StorageDevicesCount && FlashIsIn == false)
                {
                    try
                    {
                        foreach (var i in DriveInfo.GetDrives())
                            if (i.DriveType == DriveType.Removable)
                            {
                                Viewer.History.Clear();
                                Viewer.Invoke(new Action<string>((s) => Viewer.ChangeFolderTo(s)), i.RootDirectory.ToString());
                            }
                        FlashIsIn = true;
                        MainPanel.Invoke(new Action<bool>((s) => MainPanel.Visible = s), false);
                        
                    }
                    catch (DriveNotFoundException)
                    {
                        MessageBox.Show("Носій не знайдено або пошкоджено.");
                    }
                }
                else if (DriveInfo.GetDrives().Length > StorageDevicesCount && FlashIsIn == true)
                {
                    FlashIsIn = true;
                }
                else
                {
                    try
                    {
                        Process[] procs = Process.GetProcessesByName("winword");
                        foreach (Process proc in procs)
                            proc.Kill();
                    
                    }
                    catch (Win32Exception)
                    {
                        
                    }
                    Viewer.History.Clear();
                    FlashIsIn = false;
                    lblPayed.Invoke(new Action<string>((s) => lblPayed.Text += s), "0");
                    lblPrice.Invoke(new Action<string>((s) => lblPrice.Text += s), "0");
                    MainPanel.Invoke(new Action<bool>((s) => MainPanel.Visible = s), true);
                    pnlPayment.Invoke(new Action<bool>((s) => pnlPayment.Visible = s), false);
                }
                Thread.Sleep(10);
            }
        }
        private void WaitingAnimation()
        {
            while (true)
            {
                while (!FlashIsIn)
                {
                    Thread.Sleep(10);
                    if (counter < text1.Length)
                  
                        lblTextHigher.Invoke(new Action<string>((s) => lblTextHigher.Text = s), text1.Substring(0, counter));
                    
                    else if (counter < text1.Length + text2.Length)
                 
                        lblTextLower.Invoke(new Action<string>((s) => lblTextLower.Text = s), text2.Substring(0, counter - text1.Length));
                   
                    else if (counter < text1.Length + text2.Length + text3.Length)
                    {
                        lblTextHigher.Invoke(new Action<string>((s) => lblTextHigher.Text = s), text3.Substring(0, counter - text1.Length - text2.Length));
                        lblTextLower.Invoke(new Action<string>((s) => lblTextLower.Text = s), "");
                    }
                    else counter = 0;
                    counter++;
                    Thread.Sleep(50);
                }
                Thread.Sleep(10);
            }
        }
        private void btnChangeFile_Click(object sender, EventArgs e)
        {
            WaitingTimer.Stop();
            pnlPayment.Hide();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Viewer.BackToPreviousFolder();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        
    }
}