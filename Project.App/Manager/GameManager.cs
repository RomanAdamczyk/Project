using Project.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.App.Manager
{
    public class GameManager
    {
        public void NewGame(int levelId, Player player)
        {
            Game game = new Game(levelId, player);

        }
        public GameManager()
        {

        }
    }

}
