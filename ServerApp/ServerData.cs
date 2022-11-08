using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    public class ServerData
    {
        const string JOKE_FILE = "jokes.txt";
        const string CONSPIRACY_FILE = "conspiracies.txt";

        string[] allJokes;
        string[] allConspiracies;

        Random random = new Random();

        public void LoadFiles()
        {
            try
            {
                allJokes = File.ReadAllLines(JOKE_FILE);
                allConspiracies = File.ReadAllLines(CONSPIRACY_FILE);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string RandomJoke()
        {
            return allJokes[random.Next(allJokes.Length)];
        }

        public string RandomConspiracy()
        {
            return allConspiracies[random.Next(allConspiracies.Length)];
        }
    }
}
