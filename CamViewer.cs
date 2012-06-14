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
    class CamViewer : Panel, System.ComponentModel.ISupportInitialize
    {
        private CamViewerPicture m_picture;
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
            
            m_picture = new CamViewerPicture();

            this.butVertical = new System.Windows.Forms.Button();
            this.butHorizontal = new System.Windows.Forms.Button();
            this.butCenter = new System.Windows.Forms.Button();
            this.butBottom = new System.Windows.Forms.Button();
            this.butTop = new System.Windows.Forms.Button();
            this.butRight = new System.Windows.Forms.Button();
            this.butLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // this panel
            // 
            //this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(this.m_picture);
            this.Controls.Add(this.butVertical);
            this.Controls.Add(this.butHorizontal);
            this.Controls.Add(this.butCenter);
            this.Controls.Add(this.butBottom);
            this.Controls.Add(this.butTop);
            this.Controls.Add(this.butRight);
            this.Controls.Add(this.butLeft);
            this.Size = new System.Drawing.Size(320, 275);


            //m_picture
            this.m_picture.Location = new System.Drawing.Point(0, 0);
            this.m_picture.Name = "picture";
            this.m_picture.Size = new System.Drawing.Size(320, 240);
            this.m_picture.TabIndex = 100;
            this.m_picture.Text = "";

            // 
            // butVertical
            // 
            this.butVertical.Location = new System.Drawing.Point(278, 245);
            this.butVertical.Name = "butVertical";
            this.butVertical.Size = new System.Drawing.Size(39, 25);
            this.butVertical.TabIndex = 6;
            this.butVertical.Text = "^v";
            this.butVertical.UseVisualStyleBackColor = true;
            this.butVertical.Click += new System.EventHandler(this.but_Click);
            // 
            // butHorizontal
            // 
            this.butHorizontal.Location = new System.Drawing.Point(234, 245);
            this.butHorizontal.Name = "butHorizontal";
            this.butHorizontal.Size = new System.Drawing.Size(37, 25);
            this.butHorizontal.TabIndex = 5;
            this.butHorizontal.Text = "<>";
            this.butHorizontal.UseVisualStyleBackColor = true;
            this.butHorizontal.Click += new System.EventHandler(this.but_Click);
            // 
            // butCenter
            // 
            this.butCenter.Location = new System.Drawing.Point(190, 245);
            this.butCenter.Name = "butCenter";
            this.butCenter.Size = new System.Drawing.Size(38, 25);
            this.butCenter.TabIndex = 4;
            this.butCenter.Text = "|";
            this.butCenter.UseVisualStyleBackColor = true;
            this.butCenter.Click += new System.EventHandler(this.but_Click);
            // 
            // butBottom
            // 
            this.butBottom.Location = new System.Drawing.Point(143, 245);
            this.butBottom.Name = "butBottom";
            this.butBottom.Size = new System.Drawing.Size(41, 25);
            this.butBottom.TabIndex = 3;
            this.butBottom.Text = " v ";
            this.butBottom.UseVisualStyleBackColor = true;
            this.butBottom.Click += new System.EventHandler(this.but_Click);
            // 
            // butTop
            // 
            this.butTop.Location = new System.Drawing.Point(96, 245);
            this.butTop.Name = "butTop";
            this.butTop.Size = new System.Drawing.Size(41, 25);
            this.butTop.TabIndex = 2;
            this.butTop.Text = " ^ ";
            this.butTop.UseVisualStyleBackColor = true;
            this.butTop.Click += new System.EventHandler(this.but_Click);
            // 
            // butRight
            // 
            this.butRight.Location = new System.Drawing.Point(50, 245);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(40, 25);
            this.butRight.TabIndex = 1;
            this.butRight.Text = " > ";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.but_Click);
            // 
            // butLeft
            // 
            this.butLeft.Location = new System.Drawing.Point(3, 245);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(41, 25);
            this.butLeft.TabIndex = 0;
            this.butLeft.Text = " < ";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.but_Click);
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
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

    }


}


