namespace I.Fedoroff
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblTextLower = new System.Windows.Forms.Label();
            this.lblTextHigher = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.btnChangeFile = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPayed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.WaitingTimer = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.Viewer = new FileViewerLib.ViewPanel();
            this.lblPrintButton = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTextLower
            // 
            this.lblTextLower.AutoSize = true;
            this.lblTextLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextLower.Location = new System.Drawing.Point(30, 643);
            this.lblTextLower.Name = "lblTextLower";
            this.lblTextLower.Size = new System.Drawing.Size(0, 73);
            this.lblTextLower.TabIndex = 1;
            // 
            // lblTextHigher
            // 
            this.lblTextHigher.AutoSize = true;
            this.lblTextHigher.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextHigher.Location = new System.Drawing.Point(19, 64);
            this.lblTextHigher.Name = "lblTextHigher";
            this.lblTextHigher.Size = new System.Drawing.Size(0, 73);
            this.lblTextHigher.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainPanel.Controls.Add(this.lblTextHigher);
            this.MainPanel.Controls.Add(this.lblTextLower);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1266, 793);
            this.MainPanel.TabIndex = 3;
            // 
            // pnlPayment
            // 
            this.pnlPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPayment.Controls.Add(this.btnChangeFile);
            this.pnlPayment.Controls.Add(this.lblFileName);
            this.pnlPayment.Controls.Add(this.lbl7);
            this.pnlPayment.Controls.Add(this.lblTime);
            this.pnlPayment.Controls.Add(this.lbl5);
            this.pnlPayment.Controls.Add(this.lbl4);
            this.pnlPayment.Controls.Add(this.lbl6);
            this.pnlPayment.Controls.Add(this.lblPrice);
            this.pnlPayment.Controls.Add(this.lblPayed);
            this.pnlPayment.Controls.Add(this.label3);
            this.pnlPayment.Location = new System.Drawing.Point(12, 12);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(979, 678);
            this.pnlPayment.TabIndex = 5;
            this.pnlPayment.Visible = false;
            // 
            // btnChangeFile
            // 
            this.btnChangeFile.BackColor = System.Drawing.Color.Turquoise;
            this.btnChangeFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeFile.Location = new System.Drawing.Point(688, 535);
            this.btnChangeFile.Name = "btnChangeFile";
            this.btnChangeFile.Size = new System.Drawing.Size(268, 100);
            this.btnChangeFile.TabIndex = 18;
            this.btnChangeFile.Text = "Обрати інший файл";
            this.btnChangeFile.UseVisualStyleBackColor = false;
            this.btnChangeFile.Click += new System.EventHandler(this.btnChangeFile_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFileName.Location = new System.Drawing.Point(266, 165);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(175, 44);
            this.lblFileName.TabIndex = 17;
            this.lblFileName.Text = "sampletext";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl7.Location = new System.Drawing.Point(41, 165);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(219, 44);
            this.lbl7.TabIndex = 16;
            this.lbl7.Text = "Назва файлу:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(510, 531);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(101, 86);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "60";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(24, 29);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(973, 38);
            this.lbl5.TabIndex = 14;
            this.lbl5.Text = "Сплатіть, будь-ласка, вартість друку до закінчення терміну очікування.";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(42, 80);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(887, 38);
            this.lbl4.TabIndex = 12;
            this.lbl4.Text = "Увага! Пристрій решти не видає! Перепрошуємо за незручності.";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl6.Location = new System.Drawing.Point(34, 229);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(272, 64);
            this.lbl6.TabIndex = 11;
            this.lbl6.Text = "До сплати:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(311, 229);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(262, 64);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "sampletext";
            // 
            // lblPayed
            // 
            this.lblPayed.AutoSize = true;
            this.lblPayed.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPayed.Location = new System.Drawing.Point(311, 404);
            this.lblPayed.Name = "lblPayed";
            this.lblPayed.Size = new System.Drawing.Size(52, 64);
            this.lblPayed.TabIndex = 9;
            this.lblPayed.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 64);
            this.label3.TabIndex = 8;
            this.label3.Text = "Внесено:";
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_print.Location = new System.Drawing.Point(12, 225);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(370, 191);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "Друк\r\n";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // WaitingTimer
            // 
            this.WaitingTimer.Interval = 1000;
            this.WaitingTimer.Tick += new System.EventHandler(this.WaitingTimer_Tick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(287, 26);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 84);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Повернутися до папки ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Viewer
            // 
            this.Viewer.AutoScroll = true;
            this.Viewer.Location = new System.Drawing.Point(431, 26);
            this.Viewer.Name = "Viewer";
            this.Viewer.Size = new System.Drawing.Size(595, 702);
            this.Viewer.TabIndex = 2;
            // 
            // lblPrintButton
            // 
            this.lblPrintButton.AutoSize = true;
            this.lblPrintButton.Location = new System.Drawing.Point(9, 192);
            this.lblPrintButton.Name = "lblPrintButton";
            this.lblPrintButton.Size = new System.Drawing.Size(373, 13);
            this.lblPrintButton.TabIndex = 2;
            this.lblPrintButton.Text = "Оберіть документ формату \".doc\" чи \".docx\" та натисніть кнопку \"Друк\"";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1027, 737);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.pnlPayment);
            this.Controls.Add(this.lblPrintButton);
            this.Controls.Add(this.Viewer);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btnBack);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

   



        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel pnlPayment;
  
        private System.Windows.Forms.Timer WaitingTimer;
  
        private FileViewerLib.ViewPanel Viewer;
     
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnChangeFile;
        private System.Windows.Forms.Button btn_print;

        private System.Windows.Forms.Label lblTextLower;
        private System.Windows.Forms.Label lblTextHigher;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPayed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrintButton;
    }
}

