using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Risk.GameControllers;
namespace Risk
{
    public class Player
    {
        public Player() { }
        public int ID { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
