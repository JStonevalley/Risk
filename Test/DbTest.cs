using System;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Risk;
using Risk.Entities;
using Risk.GameControllers;

namespace Test
{
    [TestClass]
    public class DbTest
    {
        public void clearDatabase(){
            using (var ctx = new RiskContext())
            {
                ctx.Database.ExecuteSqlCommand("DELETE FROM Players");
                ctx.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Players',RESEED, 0)");
            }
        }
        [TestMethod]
        public void PlayerSave()
        {
            Player player = new Player() { Email = "email", DisplayName = "dName" };
            using (var ctx = new RiskContext())
            {
                ctx.Players.Add(player);
                ctx.SaveChanges();
            }
            var gameController = new GameController();
            var retrievedPlayer = gameController.getPlayerFromEmail("email");
            Assert.AreEqual(retrievedPlayer.Email, player.Email);
            Assert.AreEqual(retrievedPlayer.DisplayName, player.DisplayName);
            clearDatabase();
        }
        [TestMethod]
        public void BasicGameGeneration()
        {
            GameFactory gameFactory = new GameFactory();
            Game game = gameFactory.createBasicGame();
            Assert.AreEqual(true, game.GameStates[0].World.Areas[0].Territories[0].AreNeighbours(game.GameStates[0].World.Areas[0].Territories[1]));
        }
    }
}
