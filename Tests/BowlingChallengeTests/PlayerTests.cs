using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingChallengeTests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void NameValid()
        {
            //Arrange
            //Instance of player class
            Player player = new Player
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
