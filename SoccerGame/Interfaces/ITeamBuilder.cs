using SoccerGame.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Interfaces
{
    public interface ITeamBuilder
    {
        public ITeamBuilder setPlayerOne(Player player);
        public ITeamBuilder setPlayerTwo(Player player);
        public ITeamBuilder setPlayerThree(Player player);
        public ITeamBuilder setPlayerFour(Player player);
        public ITeamBuilder setPlayerFive(Player player);
        public ITeamBuilder setPlayerSix(Player player);
        public ITeamBuilder setPlayerSeven(Player player);
        public ITeamBuilder setPlayerEight(Player player);
        public ITeamBuilder setPlayerNine(Player player);
        public ITeamBuilder setPlayerTen(Player player);
        public ITeamBuilder setGoalKeeper(Player player);
        public Team Build();
    }
}
