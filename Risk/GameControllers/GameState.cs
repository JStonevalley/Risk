using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Risk.Entities;

namespace Risk.GameControllers
{
    public class GameState
    {
        public GameState() { }
        public int ID { get; set; }
        public World World { get; set; }
        public Player PlayerInTurn { get; set; }
    }
}
