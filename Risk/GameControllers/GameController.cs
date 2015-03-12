using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk.GameControllers
{
    public class GameController
    {
        public GameController() { }
        public Player getPlayerFromEmail(string email)
        {
            using (var context = new RiskContext())
            {
                var players = from p in context.Players 
                   where p.Email.Equals(email) 
                   select p;
                return players.First();
            }
        }
        public Game getGameFromID(int ID)
        {
            using (var context = new RiskContext())
            {
                var games = from g in context.Games
                            where g.ID.Equals(ID)
                            select g;
                return games.First();
            }
        }

        public ICollection<Game> getGamesForPlayerID(int _ID)
        {
            Player player = new Player() { ID = _ID };
            IQueryable<Game> games;
            using (var context = new RiskContext())
            {
                games = from g in context.Games
                            where g.Players.Contains(player)
                            select g;
            }
            ICollection<Game> returnedGames = new List<Game>();
            foreach (Game game in games)
            {
                returnedGames.Add(game);
            }
            return returnedGames;
        }
    }
}
