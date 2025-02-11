using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicum25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("n=");
            //int n = int.Parse(Console.ReadLine());
            //int[]mas = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"mas [{i}]=");
            //    mas[i]=int.Parse(Console.ReadLine());
            //}
            //for (int i = 0;i < n; i++)
            //{
            //    Console.WriteLine($"mas [{i}]={mas[i]}");
            //}
            //Console.Read();
            //Console.Write("n=");
            //int n = int.Parse(Console.ReadLine());
            //int[] mas = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"mas [{i}]=");
            //    mas[i] = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"mas [{i}]={mas[i]}");
            //}
            //Console.Read();
            //int[] omas = { 3, -3, 5, 6, -7, 8 };
            ////int[] omas=new int[]{3,-3,5,6,-7,8};
            //foreach (var element in omas)
            //{
            //    Console.Write($"{element}\t");
            //}
            //Console.Read();
            int[] omas = new int[6];
            Random rnd = new Random();
            for (int i = 0;i< omas.Length; i++)
            {
                Console.Write($" omas[{i}]=");
                omas [i] = rnd.Next(-10,10);
            }
            foreach (int i in omas)
            {
                Console.Write(i);

            }
            Console.Read();
        }

    }
}
