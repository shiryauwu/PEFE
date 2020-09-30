using System;

namespace PEfE
{
    public class EnglishMenu : RussianMenu
    {
        
        public void EngStartMenu()
        {
            Console.Clear();

            Console.WriteLine("1. Workout selection.");
            Console.WriteLine("2. Language selection.");
            Console.WriteLine("3. Exit.");

            Console.WriteLine("Type selected menu item number and press Enter: ");

            char engStartMenuSelection = char.Parse(Console.ReadLine());

            switch (engStartMenuSelection)
            {
                case '1':
                    EngTrainingMenu();
                    break;

                case '2':
                    EngSettingsMenu();
                    break;    

                case '3':
                    break;

                default:
                    Console.WriteLine("You entered a character unknown to me.");
                    EngStartMenu();
                    break;    
            }


        }

        public void EngTrainingMenu()
        {
            Console.Clear();

            Console.WriteLine("1. Fast workout.");
            Console.WriteLine("2. Relaxing for eyes.");
            Console.WriteLine("3. Full workout.");
            Console.WriteLine("4. Back.");

            Console.WriteLine("Type selected menu item number and press Enter: ");

            char engTrainingMenuSelection = char.Parse(Console.ReadLine());

            switch (engTrainingMenuSelection)
            {
                case '1':
                    break;

                case '2':
                    break;

                case '3':
                    break;

                case '4':
                   
                    break;

                 default:
                    Console.WriteLine("You entered a character unknown to me.");
                    EngTrainingMenu();
                    break;    
            }
        } 

          public void EngSettingsMenu()
          {
              Console.Clear();
              Console.WriteLine("Application language: ");
              Console.WriteLine("1. Русский");
              Console.WriteLine("2. English");

              Console.WriteLine("Type selected menu item number and press Enter: ");

              char engLanguageSettingsSelection = char.Parse(Console.ReadLine());

              switch (engLanguageSettingsSelection)
              {
                  case '1':
                    StartMenu();
                    break;
                  case '2':
                    EngStartMenu();
                    break;

                   default:
                    Console.WriteLine("You entered a character unknown to me.");
                    EngSettingsMenu();
                    break;      
              }
          }
     
    }
}