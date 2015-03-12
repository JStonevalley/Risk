using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class Territory : IEquatable<Territory>
    {
        public Territory() { }
        public int ID { get; set; }
        public string Name { get; set; }
        public int Troops { get; set; }
        public Player Occupant { get; set; }
        public IList<Territory> Neighbours { get; set; }
        public void AddNeighbour(Territory neighbour)
        {
            if (Neighbours == null)
            {
                Neighbours = new List<Territory>();
            }
            Neighbours.Add(neighbour);
        }
        public bool AreNeighbours(Territory candidate)
        {
            return Neighbours.Contains(candidate);
        }
        public bool Equals(Territory other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return Name.Equals(other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            return Equals((Territory)obj);
        }
    }
}
