using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingSocketClient7917
{
    public class Client
    {
        public Client()
        {
            int port = 80;
            TcpClient client = new TcpClient("webservicedemo.datamatiker-skolen.dk", port);
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter(client.GetStream());
            sw.AutoFlush = true;
            sw.WriteLine("GET /RegneWcfService.svc/RESTjson/Add?a=5&b=3 HTTP/1.1\n" +
                "Host: webservicedemo.datamatiker-skolen.dk\n");
            int res;
            do
            {
                res = sr.Read();
                Console.Write((char)res);
            } while (res != 0);
            client.Close();
        }
    }
}
