using Risk.Entities;
using Risk.GameControllers;
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
        public DbSet<Area> Areas { get; set; }
        public DbSet<World> Worlds { get; set; }
        public DbSet<GameState> GameStates { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
