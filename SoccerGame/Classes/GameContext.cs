using SoccerGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Classes
{
    public class GameContext
    {
        public Team RightTeam { get; set; }
        public Team LeftTeam { get; set; }

        public GameContext(Team TeamOne , Team TeamTwo)
        {
            this.RightTeam = TeamOne;
            this.LeftTeam = TeamTwo;
        }

    }
}
