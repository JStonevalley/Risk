using System;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Risk;

namespace Test
{
    [TestClass]
    public class DbTest
    {
        [TestMethod]
        public void PlayerSave()
        {
            using (var ctx = new RiskContext())
            {
                Player player = new Player() { Email = "email", DisplayName = "dName" };
                ctx.Players.Add(player);
                ctx.SaveChanges();
            }
            Assert.AreEqual(true, true);
        }
    }
}
