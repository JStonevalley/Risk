using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class Territory
    {
        public Territory() { }
        public int ID { get; set; }
        public string Name { get; set; }
        public int Troops { get; set; }
        public Player Occupant { get; set; }
        public ICollection<Territory> neighbours { get; set; }
    }
}
