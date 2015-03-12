using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class Area
    {
        public Area() { }
        public int ID { get; set; }
        public string Name { get; set; }
        public int TroopBonus { get; set; }
        public IList<Territory> Territories { get; set; }
    }
}
