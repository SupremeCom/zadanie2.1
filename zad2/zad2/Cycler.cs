using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Cycler
    {

        static int i = 0;             // глобальная переменная на весь класс, хранит нулевой индекс списка

        public int method(ref int param)           // функция увеличивающая индекс списка на 1, вызывается при помощи ссылки
        {
            if (i <= 7)
            {
                i++;
                return i;
                
            }
            else
            {
                i = 0;
                return i;
            }
            
        }

        public int method2(ref int param2)     // метод недающий счетчику быть больше размерности списка
        {
            if (i >= 8)
                i = 0;
            return i;
        }



       public int Output(List<int> numbers)        // сама функция для объекта класса выводящая 1 элемент списка
        {
         
            
                int result;
            method2(ref i);
            result = numbers[i];
               method(ref i);
                return result;
            
            
        }
    }
}
