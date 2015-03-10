using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk
{
    public class RiskContext: DbContext
    {
        public RiskContext() : base() { }
        public DbSet<Player> Players { get; set; }
        public DbSet<Territory> Territories { get; set; }
    }
}
