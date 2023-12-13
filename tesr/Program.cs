using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesr
{
    internal class Program
    {
        //12. Напишите программу, которая запрашивает у пользователя два числа
        //    и выводит на экран все простые числа в этом диапазоне
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number B: ");
            int b = int.Parse(Console.ReadLine());

            int countb = 0;
            int counta = 0;
            for(int i = 0; i < a; i++) 
            {
                if (a % 2 == 0) ;
            }
            counta++;

            for (int i = 0; i < b; i++)
            {
                if (b % 2 == 0) ;
            }
            countb++;
            Console.WriteLine(counta + countb);
           
        }
    }
}
