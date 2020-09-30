using System;

using System.Runtime.InteropServices;
namespace PEfE
{
    public class RussianMenu   //This class have all menus and methods with them.
    {
        
        public void StartMenu()
        {
            Console.Clear();

            Console.WriteLine("1. Выбор тренировки.");
            Console.WriteLine("2. Выбор языка.");
            Console.WriteLine("3. Выход.");

            Console.WriteLine("Введите номер выбранного пункта меню и нажмите Enter: ");

            char startMenuSelection = char.Parse(Console.ReadLine());

            switch (startMenuSelection)
            {
                case '1':
                    TrainingMenu();
                    break;

                case '2':
                    SettingsMenu();
                    break;    

                case '3':
                    break;

                default:
                    Console.WriteLine("Вы ввели неизвестный мне символ.");
                    StartMenu();
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

            Console.WriteLine("Введите номер выбранного пункта меню и нажмите Enter: ");

            char trainingMenuSelection = char.Parse(Console.ReadLine());

            switch (trainingMenuSelection)
            {
                case '1':
                    break;

                case '2':
                    break;

                case '3':
                    break;

                case '4':
                    StartMenu();
                    break;

                default:
                    Console.WriteLine("Вы ввели неизвестный мне символ.");
                    TrainingMenu();
                    break;
            }
        } 

          public void SettingsMenu()
          {
              Console.Clear();
              Console.WriteLine("Язык приложения: ");
              Console.WriteLine("1. Русский");
              Console.WriteLine("2. English");

              Console.WriteLine("Введите номер выбранного пункта меню и нажмите Enter: ");

              char languageSettingsSelection = char.Parse(Console.ReadLine());

              switch (languageSettingsSelection)
              {
                  case '1':
                    StartMenu();
                    break;
                  case '2':
                    EnglishMenu engmenu = new EnglishMenu();
                    engmenu.EngStartMenu();
                    break;

                  default:
                    Console.WriteLine("Вы ввели неизвестный мне символ.");
                    SettingsMenu();
                    break;   
              }
          }
     }
}