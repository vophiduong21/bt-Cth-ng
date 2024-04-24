using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("\nChuong trinh ghi file trong C#");
                Console.WriteLine("-----------------------------\n");
                string sentence = " ";
                StreamWriter myfile;
                myfile = File.CreateText("test.txt");
                do
                {
                    Console.Write("Nhap mot cau text: ");
                    sentence = Console.ReadLine();
                    if (sentence.Length != 0)
                    {
                        myfile.WriteLine(sentence);
                    }
                }
                while (sentence.Length != 0);
                myfile.Close();

                Console.ReadKey();
            }
        }
}
