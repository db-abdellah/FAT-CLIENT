using beta.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Image = beta.Entities.Image;

namespace beta.Handlers
{
    class ClientServer
    {
        private Boolean _isConnected = false;
        private Boolean authorized = false;
        private TcpClient tcpclnt = new TcpClient();
        String serverIP = ConfigurationManager.AppSettings["ServerIP"].ToString();
        int port = (int)Int64.Parse(ConfigurationManager.AppSettings["port"].ToString());

        StreamWriter writer;
        NetworkStream nStream;
        StreamReader reader;






        private void getConnection()
        {

            if (!_isConnected)
            {

                Console.WriteLine("Connecting.....");
                try { 
                this.tcpclnt.Connect("127.0.0.1", 6060);
                    
                }
                catch {
                    Console.WriteLine("error Connecting to server");
                }
                // use the ipaddress as in the server program

                Console.WriteLine("Connected");
                _isConnected = true;
            }
        }
        public void sendImage(Image image)
        {
            this.login();
            if (authorized)
            {

                StreamWriter writer = new StreamWriter(tcpclnt.GetStream());
                writer.WriteLine(image.idProjet);
                writer.Flush();
                writer.WriteLine(image.nomImage);
                writer.Flush();


            }
            else
                Console.WriteLine("error Connecting");

            sendImageFile(image.pathImage);
            tcpclnt.Close();
            tcpclnt = null;


        }
        public void login()
        {
            getConnection();
            StreamWriter writer = new StreamWriter(tcpclnt.GetStream());
            StreamReader reader = new StreamReader(tcpclnt.GetStream());
            String username = String.Empty;
            String password = String.Empty;
            while (!authorized)
            {
                Console.WriteLine("hi");
                writer.WriteLine("admin");
                writer.Flush();
                writer.WriteLine("ensa");
                writer.Flush();
                if (reader.ReadLine().Equals("true"))
                {
                    Console.WriteLine("Succefuly connected");
                    authorized = true;

                }
            }
        }


        public int sendImageFile(String path)
        {
            if (path == null)
                return -1;
            else
            {


                try
                {
                    StreamWriter writer = new StreamWriter(tcpclnt.GetStream());

                    Console.WriteLine(path);



                    NetworkStream nStream = tcpclnt.GetStream();
                    Bitmap tImage = new Bitmap(path);
                    byte[] bStream = ImageToByte(tImage);

                    writer.Flush();
                    nStream.Write(bStream, 0, bStream.Length);
                    nStream.Flush();
                    nStream.Close();


                }
                catch (SocketException e1)
                {
                    Console.WriteLine("SocketException: " + e1);
                }
                return 1;
            }
        }

        private byte[] ImageToByte(System.Drawing.Image iImage)
        {
            MemoryStream mMemoryStream = new MemoryStream();
            iImage.Save(mMemoryStream, System.Drawing.Imaging.ImageFormat.Gif);
            return mMemoryStream.ToArray();
        }









    }


}