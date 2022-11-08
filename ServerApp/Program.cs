using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServerData serverData = new ServerData();
            serverData.LoadFiles();

            string randJoke = serverData.RandomJoke();
            string randConsp = serverData.RandomConspiracy();
        }
    }
}
