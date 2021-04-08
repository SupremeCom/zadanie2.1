using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{


   /* class Cycler // класс принимающий объекты
    {
        public int k;
        List<int> numbers = new List<int>() { 1, 2, 3, 45, 7, 8, 23, 45 };

        public void GetNext(int k)  // Метод который будет выводить элементы объекта в порядке их записи
        {
            var firstElement = numbers[0];
            foreach (int i in numbers)           // цикл при помощи которого выводятся элементы объекта list "numbers"
            {
                Console.WriteLine(i + " - элементы объекта list");
            }
            for (int d = 0; d <= k; d++)
            {
                foreach (int i in numbers)
                {
                    Console.WriteLine(i);
                    //Console.WriteLine(numbers[d]);
                }
            }
            Console.ReadKey();

        }


        int GetNext2(int number)
        {
            
        }


    }
    */






    class Program
    {
        static void Main(string[] args)
        {
            //Cycler data = new Cycler(); // инициализация объекта data класса Cycler
            //Console.WriteLine("Введите сколько раз вывести элементы объекта list");
            //data.k = Convert.ToInt32(Console.ReadLine()); // счетчик сколько элементов выводить
            //data.GetNext(data.k);             // метод вывода информации

            int result;
            Cycler numb = new Cycler();
            List<int> numbers1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };


            Console.WriteLine("Введите кол-во вызовов функции");
           int k;
            k = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= k; i++)               // цикл вызова выводящей функции
            {

                result = numb.Output(numbers1);
                Console.WriteLine(result);
            }

            
            Console.ReadKey();

        }
    } 
    
}
