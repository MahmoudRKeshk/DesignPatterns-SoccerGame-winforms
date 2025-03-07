using SoccerGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Classes
{
    public class MidfieldTeamStrategy : ITeamStrategy
    {
        Circle[] StartegyPlan = new Circle[11];
        public MidfieldTeamStrategy()
        {
            // Midfield-heavy formation: 3-5-2
            // Field dimensions: 1070 x 729

            // Goal Keeper
            StartegyPlan[0] = new Circle(60, 320, 40);

            // Defenders (3 players)
            StartegyPlan[1] = new Circle(150, 200, 40);
            StartegyPlan[2] = new Circle(150, 365, 40);
            StartegyPlan[3] = new Circle(150, 530, 40);

            // Midfielders (5 players)
            StartegyPlan[4] = new Circle(250, 100, 40);
            StartegyPlan[5] = new Circle(250, 250, 40);
            StartegyPlan[6] = new Circle(250, 365, 40);
            StartegyPlan[7] = new Circle(250, 480, 40);
            StartegyPlan[8] = new Circle(250, 620, 40);

            // Attackers (2 players)
            StartegyPlan[9] = new Circle(400, 300, 40);
            StartegyPlan[10] = new Circle(400, 430, 40);
        }
        public Circle[] Startegy()
        {
            return StartegyPlan;
        }
        public override string ToString()
        {
            return "Mid Field";
        }
    }

}
