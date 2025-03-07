using SoccerGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Classes
{
    
    public class Team 
    {
        ITeamStrategy teamStrategy;
        public Clothes Clothes { get; set; } = new Clothes();

        public Player[] players = new Player[11];
        private string TeamName { get; set; }
        
        public void setTeamStrategy(ITeamStrategy startegy)
        {
            teamStrategy = startegy;
        }
        public ITeamStrategy getStrategy()
        {
            return teamStrategy;
        }
        public void setTeamClothes(Clothes clothes)
        {
            this.Clothes = clothes;
        }
        public void setTeamName(string teamName)
        {
            this.TeamName = teamName;
        }
        public override string ToString()
        {
            return TeamName;
        }
    }
}
