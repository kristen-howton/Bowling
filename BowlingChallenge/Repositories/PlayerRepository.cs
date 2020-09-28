using BowlingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingChallenge.Repositories
{
    public class PlayerRepository
    {
        public PlayerRepository()
        {
            playerRepository = new PlayerRepository();
        }
        private PlayerRepository playerRepository { get; set; }
        public Player Retrieve(int playerId)

        {
            //Create the instance of the player class
            //Pass in the requested id
            Player player = new Player(playerId);
            //Temp hard coded
            if (playerId == 1)
            {
                player.Name = "Jon";
            }
            return player;
        }
        public bool Save(Player player)
        {
            return true;
        }
    }
}
