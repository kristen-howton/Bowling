using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingChallenge.Tests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void PlayerNameValid()
        {
            //Arrange
            //Instance of player class
            var player = new Player
            {
                //using object initatior
                Name = "Jon",
            };
            string expected = "Jon";

            //Act
            string actual = player.Name;
            //Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
