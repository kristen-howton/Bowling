using BowlingChallenge.Models;
using BowlingChallenge.Repositories;
using System;
using Xunit;

namespace BowlingChallengeTests.RepositoryTests
{
    public class PlayerRepositoryTest
    {
        [Fact]
        public void RetriveValid()
        {
            var playerRepository = new PlayerRepository();
            var expected = new Player(1)
            {
                Name = "Jon",
            };
            //Act
            var actual = playerRepository.Retrieve(1);

            //Assert 

            Assert.Equal(expected.PlayerId, actual.PlayerId);
            Assert.Equal(expected.Name, actual.Name);

        }
    }
}


