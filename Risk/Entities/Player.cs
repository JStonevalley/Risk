using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Risk.GameControllers;
namespace Risk
{
    public class Player: IEquatable<Player>
    {
        public Player() { }
        public int ID { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public bool Equals(Player other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return Email.Equals(other.Email);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            return Equals((Player)obj);
        }
    }
}
