using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace examConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file1 = new FileStream("D:\\examen.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            writer.Write("Задание сделано");
            writer.Close();
            FileStream file2 = new FileStream("D:\\examen.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file2);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            Console.ReadLine();

        }
    }
}
