using BowlingChallenge.Models;
using System;
using Xunit;

namespace BowlingChallengeTests
{
    public class PlayerTests
    {
        [Fact]
        public void PlayerNameValid()
        {
            Player player = new Player
            {
                //using object initatior
                Name = "Jon",
            };
            string expected = "Jon";

            //Act
            string actual = player.Name;
            //Assert 
            Assert.Equal(expected, actual);

        }
    }
}

