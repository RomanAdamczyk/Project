using Project.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Domain.Entity
{
    public class Player : BaseEntity
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Skill { get; set; }
        public int Speed { get; set; }
        public int Score { get; set; }

        public Player(int id, string name)
        {
            Name = name;
            Id = id;
        }
    }
    

}
