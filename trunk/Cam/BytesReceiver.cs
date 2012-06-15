using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Shoppy
{
    class BytesReceiver
    {
        public static int FETCH_INTERVAL = 50;

	    private string m_url;

	    private string m_user;

	    private string m_password;

	    private PictureBytesHolder m_bytesHolder;

	    public string m_encoding;

	    public BytesReceiver(string url, string user, string password,
			    PictureBytesHolder bytesHolder) {
		    m_url = url;
		    m_user = user;
		    m_password = password;
		    m_bytesHolder = bytesHolder;

		    Init();

            Thread t = new Thread(new ThreadStart(this.Receive));
            t.Start();

	    }

	    private void Init() {
		    string userPassword = m_user + ":" + m_password;

            byte[] userPassArray = Encoding.ASCII.GetBytes(userPassword);
            m_encoding = Convert.ToBase64String(userPassArray);

	    }

	    public void Receive() {

            HttpWebRequest req = null;
            WebResponse resp = null;
            Stream stream = null;
            BinaryReader content = null;
            MemoryStream output = null;

            try
            {

                Uri uri = new Uri("http://" + m_url
                            + "/nphMotionJpeg?Resolution=320x240&Quality=Standard");

                Console.WriteLine("http://" + m_url
                            + "/nphMotionJpeg?Resolution=320x240&Quality=Standard");

                // Angefordertes Objekt erstellen
                req = (HttpWebRequest)HttpWebRequest.Create(uri);

                req.Headers.Add("Authorization", "Basic " + m_encoding);
                resp = req.GetResponse();
                
                stream = resp.GetResponseStream();
                content = new BinaryReader(stream);


                output = new MemoryStream();

                byte[] bytes = new byte[2048];
                int i;
                bool sync = false;
                // Solange die TCP Verbindung besteht....
                while ((content.Read(bytes, 0, bytes.Length)) > 0)
                {
                    if (sync == false)
                    {
                        // Empfang synchronisieren

                        // System.out.println("warte auf sync");
                        i = CheckForStartBytes(bytes);
                        if (i > -1)
                        {
                            //output.reset();
                            output.Position = 0;
                            output.Write(bytes, i, bytes.Length - i);
                            sync = true;
                        }
                    }
                    else
                    {
                        // Bild Daten empfangen

                        // Abschliessen?
                        i = CheckForFFD9(bytes);
                        if (i > -1)
                        {
                            // System.out.println("abschliessen");
                            output.Write(bytes, 0, i + 2);

                            m_bytesHolder.SetBytes(output.ToArray());

                            // wieder nach FFD8 (Startbytes) suchen
                            i = CheckForStartBytes(bytes);
                            if (i > -1)
                            {
                                //output.reset();
                                output.Position = 0;
                                output.Write(bytes, i, bytes.Length - i);
                                sync = true;
                            }
                            else
                            {
                                sync = false;
                            }

                        }
                        else
                        {
                            // Volles Byte empfangen
                            // System.out.println("empfangen");
                            output.Write(bytes, 0, bytes.Length);
                        }

                    }

                    Thread.Sleep(FETCH_INTERVAL);
                }

               
            }
            catch (WebException wE)
            {
              /*MessageBox.Show("Fehler beim Verbinden zur Webcam '" + m_url + "': " +
                    wE.Message, Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);*/
                Console.WriteLine(wE.Message);

            }
            finally
            {
                if (content != null) { content.Close(); }
                if (output != null)
                {
                    output.Flush();
                    output.Close();
                }
            }

	    }

	    /**
	     * Start des JPEG Bildes: Startbytes FFD8 -1;-40
	     * 
	     * @param bytes
	     * @return startByte
	     */
	    public int CheckForStartBytes(byte[] bytes) {

		    for (int i = 0; i < bytes.Length; i++) {

			    // first FF
			    if (bytes[i] == 255) {
				    // check for following D8
				    if (i + 1 < bytes.Length && bytes[i + 1] == 216) {
					    return i;
				    }
			    }
		    }

		    return -1;

	    }

	    // Ende des JPEG bildes: 2 Bytes FFD9: -1;-39
	    public int CheckForFFD9(byte[] bytes) {

		    for (int i = 0; i < bytes.Length; i++) {

			    // first FF
			    if (bytes[i] == 255) {
				    // check for following D9

				    if (i + 1 < bytes.Length && bytes[i + 1] == 217) {
					    return i;
				    }
			    }
		    }

		    return -1;

	    }

	    public void PrintBytes(byte[] bytes) {
		    Console.WriteLine("[");
		    foreach (byte b in bytes) {
			    Console.Write(b + ",");
		    }
		    Console.WriteLine("]");

	    }

	    public void PrintBorderBytes(byte[] bytes, int borderDepth) {
		    Console.WriteLine("[");
		    for (int i = 0; i < borderDepth; i++) {
			    Console.Write(bytes[i] + ",");
		    }
		    Console.Write("...,");
		    for (int i = borderDepth; i > -1; i--) {
			    Console.Write(bytes[bytes.Length - 1 - i] + ",");
		    }

		   Console.WriteLine("]");

	    }
    }
}
