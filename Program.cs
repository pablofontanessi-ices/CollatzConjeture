using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzConjeture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? Num;
            do
            {
                Console.WriteLine("Ingrese un numero positivo");
                Num = int.Parse(Console.ReadLine());
            }
            while (Num < 1);
            int pasos = 0;
            while (Num !=1)
            {
                if (Num % 2 == 0)//Par
                {
                    Num = Num / 2;
                }
                else //Impar
                {
                    Num = (Num * 3) + 1;
                }
                pasos++;
            }
            Console.WriteLine(pasos);
        }
    }
}
