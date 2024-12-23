using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegitigaPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Information");
            Console.WriteLine("1. Untuk segitiga normal, masukkan angka biasa (misal: 3)");
            Console.WriteLine("2. Untuk segitiga terbalik, gunakan format 99.x (misal: 99.3)");

            Console.Write("Masukkan angka: ");
            string input = Console.ReadLine();


            if (input.Contains("."))
            {
                string[] parts = input.Split('.');
                //99.5.10 [0]==99, [1]=5
                //
                if (parts[0] == "99")
                {
                    int rows = int.Parse(parts[1]);

                    for (int i = rows; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Format tidak valid! Untuk segitiga terbalik gunakan 99.x");
                }
            }
            else
            {

                int rows = int.Parse(input);
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
