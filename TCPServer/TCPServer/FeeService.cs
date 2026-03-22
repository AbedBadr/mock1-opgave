using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using Skat;

namespace TCPServer
{
    class FeeService
    {
        private TcpClient _connectionSocket;

        public FeeService(TcpClient connection)
        {
            _connectionSocket = connection;
        }

        public void DoIt()
        {
            Stream ns = _connectionSocket.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true;
            Afgift afgift = new Afgift();

            while (true)
            {
                string message = sr.ReadLine();
                Console.WriteLine("Client: " + message);

                if (message == "Personbil" || message == "personbil")
                {
                    string answer = "Indtast pris";
                    sw.WriteLine(answer);

                    message = sr.ReadLine();
                    Console.WriteLine("Client: " + message);

                    int pris = Convert.ToInt32(message);

                    answer = "Registreringsafgiften er: " + afgift.BilAfgift(pris).ToString();
                    sw.WriteLine(answer);
                }

                else if (message == "Elbil" || message == "elbil")
                {
                    string answer = "Indtast pris";
                    sw.WriteLine(answer);

                    message = sr.ReadLine();
                    Console.WriteLine("Client: " + message);

                    int pris = Convert.ToInt32(message);

                    answer = "Registreringsafgiften er: " + afgift.BilAfgift(pris).ToString();
                    sw.WriteLine(answer);
                }

                else
                {
                    string answer = "Du skal indtaste personbil eller elbil!";
                    sw.WriteLine(answer);
                }
            }
        }
    }
}
