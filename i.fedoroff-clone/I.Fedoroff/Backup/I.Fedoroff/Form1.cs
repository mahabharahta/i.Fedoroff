using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GongSolutions.Shell;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace I.Fedoroff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int i = 0;
        
        private string device;

        SerialPort COM1 = new SerialPort("COM1");
       

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            try { }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DriveInfo.GetDrives().Length < 3)
            {
                panel2.Visible = false;
                shellView1.Visible = false;
                shellView1.CurrentFolder = new ShellItem(Environment.SpecialFolder.MyComputer);
                panel1.Visible = true;
            }
            else
            {
                try
                {
                    foreach (var i in DriveInfo.GetDrives())

                        if (i.DriveType == DriveType.Removable)
                            device = i.Name.ToString();

                    shellView1.CurrentFolder = new ShellItem(device);
                    panel2.Visible = true;
                    shellView1.Visible = true;
                    panel1.Visible = false;
                }
                catch { timer1_Tick(sender,e); }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo("");
                info.Verb = "Print";
                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(info);
            }
            catch { MessageBox.Show("Test"); }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            i+=1;
            string text1 = "Друкувати лаби тепер простіше      ";
            string text2 = "разом з Іваном Федоровим       ";
            string text3 =  "    Швидко     Просто    Якісно       ";
            try
            {
                try
                {
                    try
                    {
                        label1.Text = text1.Substring(0, i);
                    }
                    catch
                    {
                        label2.Text = text2.Substring(0, i - text1.Length);
                    }
                }
                catch
                {
                    try
                    {
                        label2.Text = null;
                        label1.Text = text3.Substring(0, i - text1.Length - text2.Length);
                    }
                    catch
                    {
                            label1.Text = text3.Substring(0, i - text1.Length - text2.Length);
                    }
                }
            }
            catch
            {
                i = 0;
                label2.Text = "";
                label1.Text = "";
            }

        }




    }
}
