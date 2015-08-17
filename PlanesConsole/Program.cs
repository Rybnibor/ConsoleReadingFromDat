using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanesConsole
{
    /// <summary>
    /// Sample C# program which reads data from .dat file into sorted list. (no exceptions handled)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;
            //Dictionary<string, string> airports = new Dictionary<string, string>();
            SortedList<string, string> airports = new SortedList<string, string>();
            
            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader("airports.dat");
            while ((line = file.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                //if (line!=null)
                if (line.Length>1)
                {
                    airports.Add(zmien(ref line), line);
                    //Console.WriteLine();
                } 
                counter++;
            }

            file.Close();
            foreach (KeyValuePair<string,string> element in airports)
            {
                Console.WriteLine(element.Key + " x " + element.Value);
            }
        }

        /// <summary>
        /// Changes the specified value into Key and Value which can be used in sorted list.
        /// </summary>
        /// <param name="odczyt">odczyt - readed value</param>
        /// <returns></returns>
        static string zmien(ref string odczyt)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(odczyt);
            System.Text.StringBuilder sbPort = new System.Text.StringBuilder("000");
            System.Text.StringBuilder sbContinent = new System.Text.StringBuilder("00");


            for (int j = 0; j < 3; j++)
            {
                //if (System.Char.IsNumber(sb[j]) == true)
                    sbPort[j] = sb[j];
            }

            for (int j = 0; j < 2; j++)
            {
                //if (System.Char.IsNumber(sb[j]) == true)
                sbContinent[j] = sb[j+4];
            }

            
            // Store the new string. 
            odczyt = sbContinent.ToString();
            string got = sbPort.ToString();
            return got;
        }
    }
}
