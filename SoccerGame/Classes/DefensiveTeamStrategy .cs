using SoccerGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Classes
{
    public class DefensiveTeamStrategy : ITeamStrategy
    {
        Circle[] StartegyPlan = new Circle[11];
        public DefensiveTeamStrategy()
        {
            // Defensive formation: 5-4-1
            // Field dimensions: 1070 x 729

            // Goal Keeper
            StartegyPlan[0] = new Circle(60, 320, 40);

            // Defenders (5 players)
            StartegyPlan[1] = new Circle(150, 100, 40);
            StartegyPlan[2] = new Circle(150, 250, 40);
            StartegyPlan[3] = new Circle(150, 365, 40);
            StartegyPlan[4] = new Circle(150, 480, 40);
            StartegyPlan[5] = new Circle(150, 620, 40);

            // Midfielders (4 players)
            StartegyPlan[6] = new Circle(300, 150, 40);
            StartegyPlan[7] = new Circle(300, 300, 40);
            StartegyPlan[8] = new Circle(300, 450, 40);
            StartegyPlan[9] = new Circle(300, 600, 40);

            // Attacker (1 player)
            StartegyPlan[10] = new Circle(500, 365, 40);
        }
        public Circle[] Startegy()
        {
            return StartegyPlan;
        }
        public override string ToString()
        {
            return "Defensive";
        }
    }

}
