using Project.App.Abstract;
using Project.App.Concrete;
using Project.App.Manager;
using Project.Domain.Entity;
using System;

namespace project
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            PlayerManager playerManager = new PlayerManager(actionService);
            GameManager gameManager = new GameManager();
           
            
            Console.WriteLine("Witaj w grze");

            var mainMenu = actionService.GetMenuActionsByMenuName("Menu");
            for (int i = 0; i< mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            Console.WriteLine();
            switch (operation.KeyChar)
            {
                case '1':
                    Console.WriteLine("Wybierz poziom");
                    var levelId = playerManager.NewPlayer();

                    Console.WriteLine("TERAZ ZACZNIE SIĘ ROZGRYWKA");
                    break;
                case '2':
                  // Tutaj będzie wczytywanie stanu gry z pliku
                  // (najpierw wyświetli zapisane stany gier i użytkownik  wybierze interesujący go stan)
                  // chciałem zacząć pisać kod, ale nie bardzo wiedziałem, w której klasie
                    break;
                case '3':
                    Console.WriteLine("Ustawienia sterownia");
                  // będzie uzupełnione później
                    break;
                case '4':
                  // uzupełnię później - zależy co będę umiał zrobić

                    break;
                default:
                    Console.WriteLine("Nie istnieje wybrana opcja");
                    break;

            }
            
        }

       
    }
}
