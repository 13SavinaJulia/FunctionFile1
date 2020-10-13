using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionFile1
{
    public class From
    {
        /// <summary>
        /// Функция выводит приветствие студента 
        /// </summary>
        /// <param name="name"></param>
        public void HelloWord(string name)
        {
            Console.WriteLine($"Здравствуйте, Вы студент педагогического колледжа, ваше имя-, {name}");

        }

        /// <summary>
        /// Функция считает в каком году студент окончит колледж
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public int AgeToFive(int age)
        {
            return age + 4;
        }
    }
}
