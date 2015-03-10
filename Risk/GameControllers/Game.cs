using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk.GameControllers
{
    public class Game
    {
        public Game() { }
        public int ID { get; set; }
        public ICollection<Player> Players { get; set; }
        public ICollection<GameState> GameStates { get; set; }
        public Player? Winner { get; set; }
    }
}
