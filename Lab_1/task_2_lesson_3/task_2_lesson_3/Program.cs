using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создаем массив
            int[] numbers = new int[4000];
            Random random = new Random();
            //Заполняем массив случайными числами 
            for (int i = 0; i < 4000; i++)
            {
                numbers[i] = random.Next(1, 5000);
            }
            //Создаем массив для хранения сумм пар соседних чисел
            int[] sums = new int[1999];
            //Вычисляем суммы пар четных соседних чисел
            for (int i = 0, j = 0; i < 3998; i += 2, j++)
            {
                sums[j] = numbers[i] + numbers[i + 1];
            }
           
        }

    }
}
