using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    public class SynchronousSocketClient
    {
        const int PORT_NUMBER = 11000;
        const string IP_ADDRESS = "127.0.0.1";

        public string ContactServer(string userRequest)
        {
            string response = "";
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(IPAddress.Parse(IP_ADDRESS), PORT_NUMBER);

            try
            {
                NetworkStream networkStream = tcpClient.GetStream();

                StreamWriter streamWriter = new StreamWriter(networkStream);
                StreamReader streamReader = new StreamReader(networkStream);

                streamWriter.AutoFlush = true;
                streamWriter.WriteLine(userRequest);
                response = streamReader.ReadLine();

                networkStream.Close();
                tcpClient.Close();
            }
            catch (Exception ex)
            {

                return(ex.Message);
            }

            return response;
        }
    }
}
