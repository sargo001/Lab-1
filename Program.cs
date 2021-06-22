using System;

namespace laba_1_massivy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Лабораторная работа №1. " );
            int v = 32;
            Console.WriteLine("                      Порядковый номер по списку группы: 32");
            Console.WriteLine("                      " + ((v % 15) + 1) + " вариант");

            Console.Write   ("Введите количество элементов:");
            var len = int.Parse(0 + Console.ReadLine());



            var array = new int[len];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(i + 1 + " Элемент = ");
                array[i] = int.Parse(Console.ReadLine());


            }
            Console.Write("Положительные элменты массива:");
            for (int i = 0; i < array.Length; i++)


                if (array[i] > 0)



                    Console.Write(array[i] + "; ");


                else Console.Write("");




            Console.ReadKey();
        }
    }
}
