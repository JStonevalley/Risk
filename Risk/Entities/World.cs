using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk.Entities
{
    public class World
    {
        public World() { }
        public int ID { get; set; }
        public ICollection<Area> Areas { get; set; }
    }
}
