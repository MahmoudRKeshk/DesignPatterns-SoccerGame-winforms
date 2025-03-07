using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Classes
{
    [Flags]
    public enum PlayerRole
    {
        N = 0,
        A = 1,
        M = 2,
        D = 4,
        G = 8
    }
    public class Player
    {
        public string playerName;
        public string playerNumber;
        public PlayerRole playerRole;

        public Player(string name, string playerNumber, PlayerRole playerRole)
        {
            this.playerName = name;
            this.playerNumber = playerNumber;
            this.playerRole = playerRole;
        }

        // Decorator Constructor
        public Player(Player player, PlayerRole extraRole)
        {
            // Combine roles using bitwise OR
            this.playerName = player.playerName;
            this.playerNumber = player.playerNumber;
            this.playerRole = player.playerRole | extraRole;
        }

        // Getting Player Role 
        public string getPlayerRole()
        {
            return playerRole.ToString();
        }

    }
}
