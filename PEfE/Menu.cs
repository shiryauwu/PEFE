using System;

using System.Runtime.InteropServices;
namespace PEfE
{
    public class Menu
    {
        public void StartMenu()
        {
            Console.Clear();

            Console.WriteLine("1. Выбор тренировки.");
            Console.WriteLine("2. Настройки.");
            Console.WriteLine("3. Выход");

            char startMenuSelection = char.Parse(Console.ReadLine());

            switch (startMenuSelection)
            {
                case '1':
                    TrainingMenu();
                    break;

            }


        }

        public void TrainingMenu()
        {
            Console.Clear();

            Console.WriteLine("1. Быстрая тренировка.");
            Console.WriteLine("2. Отдых для глаз.");
            Console.WriteLine("3. Полная тренировка.");
            Console.WriteLine("4. Назад.");
        }   
     }
}