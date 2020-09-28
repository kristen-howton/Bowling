using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingChallenge.Models
{
    public class Player
    {
        public Player() 
        {

        }
        public Player(int playerId)
        {
            PlayerId = playerId;
        }
        public int PlayerId { get; set; }
        public string Name { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            return isValid;
        }
    }
}
