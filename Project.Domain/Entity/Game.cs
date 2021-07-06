using Project.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Domain.Entity
{
    public class Game : BaseEntity
    {
        public List<Player> Players { get; set; }
        int PresentLevel { get; set; }
        int Level { get; set; }
        public Game(int level, Player player)
        {
            Level = level;
            Players = new List<Player>();
            Players.Add(player);

        }

    }
}
