using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вводим содержание массива
            Console.Write("Введите числа, содержащиеся в массиве через пробел: ");
            string input = Console.ReadLine();
            Console.WriteLine();
            //Преобразовываем введенные числа в массив
            string[] parts = input.Split(' ');
            int[] numbers = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                numbers[i] = int.Parse(parts[i]);
            }
            //Проверяем наличие однинаковых элементов
            bool Duplicates = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        Duplicates = true;
                        break;
                    }
                }
                if (Duplicates) break;

            }
            

        }
    }
}
