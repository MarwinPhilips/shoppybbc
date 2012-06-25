using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace Shoppy.Cam
{
    // Die Klasse stellt die Grundfunktionalitäten des Camviewers zur Verfügung.
    public partial class CamViewer : UserControl, System.ComponentModel.ISupportInitialize
    {

        private string m_command;
        public CamViewer()
        {
            InitializeComponent();
        }
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

            this.m_command = command;

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
    }
}
