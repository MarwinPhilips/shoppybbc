using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Net.Sockets;

namespace Shoppy
{
    /// <summary>
    /// Diese Klasse (sie ist ein ganz normales Panel) zeigt das Bild einer Webcam. 
    /// Bitte setzen Sie die Eigenschaften Url, User und Password. Sobald diese gesetzt sind, 
    /// wird die Verbindung zur Webcam hergestellt.
    /// </summary>
    class CamViewer : UserControl, System.ComponentModel.ISupportInitialize
    {
        private Cam.CamViewerPicture m_picture;
        private System.Windows.Forms.Button butTop;
        private System.Windows.Forms.Button butRight;
        private System.Windows.Forms.Button butLeft;
        private System.Windows.Forms.Button butVertical;
        private System.Windows.Forms.Button butHorizontal;
        private System.Windows.Forms.Button butCenter;
        private System.Windows.Forms.Button butBottom;
        private string m_url;
        private string m_user;
        private string m_password;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;

        private string m_command;

        public string Url
        {
            get
            {
                return m_url;
            }

            set
            {
                m_url = value;
            }

        }

        public string User
        {
            get
            {
                return m_user;
            }
            set
            {
                m_user = value;
            }
        }

        public string Password
        {
            get
            {
                return m_password;
            }
            set
            {
                m_password = value;
            }
        }

        public void BeginInit()
        {
            
            
            InitializeComponent();

        }

        public void EndInit()
        {
            m_picture.Url = this.Url;
            m_picture.User = this.User;
            m_picture.Password = this.Password;
        }

        public void but_Click(object sender, EventArgs ae)
        {
            if (sender == butLeft)
            {
                Turn("http://" + m_url + "/nphControlCamera?Direction=PanLeft&Resolution=320x240&Quality=Standard&RPeriod=0&Size=STD&PresetOperation=Move&Language=0");
            }
            else if (sender == butRight)
            {
                Turn("http://" + m_url + "/nphControlCamera?Direction=PanRight&Resolution=320x240&Quality=Standard&RPeriod=0&Size=STD&PresetOperation=Move&Language=0");
            }
            else if (sender == butTop)
            {
                Turn("http://" + m_url + "/nphControlCamera?Direction=TiltUp&Resolution=320x240&Quality=Standard&RPeriod=0&Size=STD&PresetOperation=Move&Language=0");
            }
            else if (sender == butBottom)
            {
                Turn("http://" + m_url + "/nphControlCamera?Direction=TiltDown&Resolution=320x240&Quality=Standard&RPeriod=0&Size=STD&PresetOperation=Move&Language=0");
            }
            else if (sender == butCenter)
            {
                Turn("http://" + m_url + "/nphControlCamera?Direction=HomePosition&Resolution=320x240&Quality=Standard&RPeriod=0&Size=STD&PresetOperation=Move&Language=0");
            }
            else if (sender == butHorizontal)
            {
                Turn("http://" + m_url + "/nphControlCamera?Direction=PanScan&Resolution=320x240&Quality=Standard&RPeriod=0&Size=STD&PresetOperation=Move&Language=0");
            }
            else if (sender == butVertical)
            {
                Turn("http://" + m_url + "/nphControlCamera?Direction=TiltScan&Resolution=320x240&Quality=Standard&RPeriod=0&Size=STD&PresetOperation=Move&Language=0");
            }
        }

        private void Turn(string command)
        {

            m_command = command;

            Thread t = new Thread(new ThreadStart(this.SendCommand));
            t.Start();
        }

        private void SendCommand()
        {
            HttpWebRequest req = null;
            WebResponse resp = null;
            Stream stream = null;
            StreamReader tr = null;
            try
            {

                Uri uri = new Uri(m_command);

                //Console.WriteLine("http://" + m_url
                //            + "/nphMotionJpeg?Resolution=320x240&Quality=Standard");

                // Angefordertes Objekt erstellen
                req = (HttpWebRequest)HttpWebRequest.Create(uri);

                req.Headers.Add("Authorization", "Basic " + m_picture.m_receiver.m_encoding);

                //Console.WriteLine("Basic " + m_encoding);

                resp = req.GetResponse();
                stream = resp.GetResponseStream();
                tr = new StreamReader(stream);

                tr.ReadToEnd();
            }
            catch (WebException wE)
            {
                MessageBox.Show("Fehler beim Drehen der Webcam '" + m_url + "': " +
                    wE.Message, Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Console.WriteLine(wE.Status + ": " + wE.Response);
            }
            finally
            {
                if (tr != null) { tr.Close(); }
                if (stream != null) { stream.Close(); }
                if (resp != null) { resp.Close(); }
                
            }
        }

        private void InitializeComponent()
        {
            this.m_picture = new Cam.CamViewerPicture();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.butLeft = new System.Windows.Forms.Button();
            this.butRight = new System.Windows.Forms.Button();
            this.butVertical = new System.Windows.Forms.Button();
            this.butTop = new System.Windows.Forms.Button();
            this.butHorizontal = new System.Windows.Forms.Button();
            this.butBottom = new System.Windows.Forms.Button();
            this.butCenter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_picture)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_picture
            // 
            this.m_picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_picture.Location = new System.Drawing.Point(3, 3);
            this.m_picture.Name = "m_picture";
            this.m_picture.Password = null;
            this.m_picture.Size = new System.Drawing.Size(314, 227);
            this.m_picture.TabIndex = 100;
            this.m_picture.TabStop = false;
            this.m_picture.Url = null;
            this.m_picture.User = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.m_picture, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(320, 280);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.42857F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 280);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Controls.Add(this.butLeft, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.butRight, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.butVertical, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.butTop, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.butHorizontal, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.butBottom, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.butCenter, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 236);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(314, 41);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // butLeft
            // 
            this.butLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butLeft.Location = new System.Drawing.Point(3, 3);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(38, 35);
            this.butLeft.TabIndex = 0;
            this.butLeft.Text = " < ";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.but_Click);
            // 
            // butRight
            // 
            this.butRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butRight.Location = new System.Drawing.Point(47, 3);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(38, 35);
            this.butRight.TabIndex = 1;
            this.butRight.Text = " > ";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.but_Click);
            // 
            // butVertical
            // 
            this.butVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butVertical.Location = new System.Drawing.Point(267, 3);
            this.butVertical.Name = "butVertical";
            this.butVertical.Size = new System.Drawing.Size(44, 35);
            this.butVertical.TabIndex = 6;
            this.butVertical.Text = "^v";
            this.butVertical.UseVisualStyleBackColor = true;
            this.butVertical.Click += new System.EventHandler(this.but_Click);
            // 
            // butTop
            // 
            this.butTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butTop.Location = new System.Drawing.Point(91, 3);
            this.butTop.Name = "butTop";
            this.butTop.Size = new System.Drawing.Size(38, 35);
            this.butTop.TabIndex = 2;
            this.butTop.Text = " ^ ";
            this.butTop.UseVisualStyleBackColor = true;
            this.butTop.Click += new System.EventHandler(this.but_Click);
            // 
            // butHorizontal
            // 
            this.butHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butHorizontal.Location = new System.Drawing.Point(223, 3);
            this.butHorizontal.Name = "butHorizontal";
            this.butHorizontal.Size = new System.Drawing.Size(38, 35);
            this.butHorizontal.TabIndex = 5;
            this.butHorizontal.Text = "<>";
            this.butHorizontal.UseVisualStyleBackColor = true;
            this.butHorizontal.Click += new System.EventHandler(this.but_Click);
            // 
            // butBottom
            // 
            this.butBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBottom.Location = new System.Drawing.Point(135, 3);
            this.butBottom.Name = "butBottom";
            this.butBottom.Size = new System.Drawing.Size(38, 35);
            this.butBottom.TabIndex = 3;
            this.butBottom.Text = " v ";
            this.butBottom.UseVisualStyleBackColor = true;
            this.butBottom.Click += new System.EventHandler(this.but_Click);
            // 
            // butCenter
            // 
            this.butCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butCenter.Location = new System.Drawing.Point(179, 3);
            this.butCenter.Name = "butCenter";
            this.butCenter.Size = new System.Drawing.Size(38, 35);
            this.butCenter.TabIndex = 4;
            this.butCenter.Text = "|";
            this.butCenter.UseVisualStyleBackColor = true;
            this.butCenter.Click += new System.EventHandler(this.but_Click);
            // 
            // CamViewer
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CamViewer";
            this.Size = new System.Drawing.Size(320, 280);
            ((System.ComponentModel.ISupportInitialize)(this.m_picture)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }



    }


}


