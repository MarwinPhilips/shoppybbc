using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;

namespace CamView
{
    class CamViewerPicture : PictureBox, System.ComponentModel.ISupportInitialize
    {
        public static int FETCH_INTERVAL = 100;

        private string m_url;
        private string m_user;
        private string m_password;

        private bool m_inited;

	    private Bitmap m_image;
	    private bool m_imageOk;

	    private PictureBytesHolder m_bytesHolder;
        public BytesReceiver m_receiver;

        public CamViewerPicture()
        {
            m_inited = false;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public string Url
        {
            get 
            {
                return m_url;
            }

            set {
                m_url = value; 
                InitConnection();
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
                InitConnection();
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
                InitConnection();
            }
        }

        public void BeginInit()
        {

        }

        public void EndInit()
        {

        }

        private void InitConnection()
        {
            if (m_url == null || m_user == null || m_password == null || m_inited == true)
            {
                return;
            }

            m_inited = true;

            m_bytesHolder = new PictureBytesHolder();
            m_receiver = new BytesReceiver(m_url, m_user, m_password, m_bytesHolder);

            m_imageOk = false;

            Thread t = new Thread(new ThreadStart(this.FetchBytes));
            t.Start();

        }

        public void FetchBytes()
        {
            while (true)
            {
                byte[] bytes = m_bytesHolder.GetBytes();

                if (bytes != null)
                {
                    m_imageOk = SetImage(bytes);
                    if (m_imageOk == true)
                    {
                        this.Refresh();
                    }
                }

                Thread.Sleep(FETCH_INTERVAL);
 
            }
        }

        public bool SetImage(byte[] bytes)
        {
            try
            {
                MemoryStream imageStream = new MemoryStream(bytes);
                imageStream.Position = 0;
                m_image = new Bitmap(imageStream, true);
                imageStream.Close();

            }
            catch (ArgumentException ae)
            {
                ArgumentException a = ae;
                //Console.WriteLine(ae.Message);
                return false;
            }
            catch (ExternalException ee)
            {
                ExternalException e = ee;
                //Console.WriteLine(ee.Message);
                return false;
            }

            return true;

        }

        protected override void OnPaint(PaintEventArgs pe) {


            if (m_image != null)
            {
                Graphics g = pe.Graphics;
                g.DrawImage(m_image, 0, 0, this.Width, this.Height);


            }
            
        }
    }




}
