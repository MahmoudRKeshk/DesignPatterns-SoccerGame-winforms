using SoccerGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Classes
{
    public class TeamBuilder : ITeamBuilder
    {
        Team _team = new Team();
        public Team Build()
        {
            return _team;
        }

        public ITeamBuilder setGoalKeeper(Player player)
        {
            _team.players[0] = player;
            return this;
        }
        public ITeamBuilder setPlayerOne(Player player)
        {
            _team.players[1] = player;
            return this;
        }
        public ITeamBuilder setPlayerTwo(Player player)
        {
            _team.players[2] = player;
            return this;
        }
        public ITeamBuilder setPlayerThree(Player player)
        {
            _team.players[3] = player;
            return this;
        }
        public ITeamBuilder setPlayerFour(Player player)
        {
            _team.players[4] = player;
            return this;
        }
        public ITeamBuilder setPlayerFive(Player player)
        {
            _team.players[5] = player;
            return this;
        }
        public ITeamBuilder setPlayerSix(Player player)
        {
            _team.players[6] = player;
            return this;
        }
        public ITeamBuilder setPlayerSeven(Player player)
        {
            _team.players[7] = player;
            return this;
        }
        public ITeamBuilder setPlayerEight(Player player)
        {
            _team.players[8] = player;
            return this;
        }
        public ITeamBuilder setPlayerNine(Player player)
        {
            _team.players[9] = player;
            return this;
        }
        public ITeamBuilder setPlayerTen(Player player)
        {
            _team.players[10] = player;
            return this;
        }
    }
}
