using Project.App.Concrete;
using Project.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.App.Manager
{
    public class PlayerManager
    {
        private readonly MenuActionService _actionService;
        private PlayerService _playerService;
        public PlayerManager(MenuActionService actionService)
        {
            _playerService = new PlayerService();
            _actionService = actionService;
        }
        public int NewPlayer()
        {
            var newGameMenu = _actionService.GetMenuActionsByMenuName("NewPlayMenu");
            for (int i = 0; i < newGameMenu.Count; i++)
            {
                Console.WriteLine($"{newGameMenu[i].Id}. {newGameMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            int levelId;// będzie wykorzystane później do obiektu klasy Game
            Int32.TryParse(operation.KeyChar.ToString(), out levelId);
            Console.WriteLine("\nPodaj swoje imię");
            var name = Console.ReadLine();
            Player player = new Player(0, name);
            _playerService.AddItem(player);
            return levelId;
        }
    }
}
