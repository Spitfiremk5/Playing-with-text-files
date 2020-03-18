using System;
using System.IO;

namespace CsharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type some stuff and it will appear in a text file");
            while (true)
            {
                string path = @"plik.txt";

                StreamWriter sw;

                if (!File.Exists(path))
                {
                    sw = File.CreateText(path);
                   
                }
                else
                {
                    sw = new StreamWriter(path, true);
                   

                }

                string s = Console.ReadLine();
                sw.WriteLine(s);
                sw.Close();
                StreamReader sr = File.OpenText(path);
                string yeetus = "";

                int loop = 1;

                while ((yeetus = sr.ReadLine()) != null)
                {

                }
                sr.Close();
            }
               
            
        }
    }
}
