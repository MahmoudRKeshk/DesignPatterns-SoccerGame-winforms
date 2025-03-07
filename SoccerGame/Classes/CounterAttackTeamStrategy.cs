using SoccerGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Classes
{
    public class CounterAttackTeamStrategy : ITeamStrategy
    {
        Circle[] StartegyPlan = new Circle[11];
        public CounterAttackTeamStrategy()
        {
            // Counter attack formation: 4-2-4
            // Field dimensions: 1070 x 729

            // Goal Keeper
            StartegyPlan[0] = new Circle(60, 320, 40);

            // Defenders (4 players)
            StartegyPlan[1] = new Circle(150, 50, 40);
            StartegyPlan[2] = new Circle(150, 200, 40);
            StartegyPlan[3] = new Circle(150, 380, 40);
            StartegyPlan[4] = new Circle(150, 530, 40);

            // Midfielders (2 players)
            StartegyPlan[5] = new Circle(250, 150, 40);
            StartegyPlan[6] = new Circle(250, 380, 40);

            // Attackers (4 players)
            StartegyPlan[7] = new Circle(400, 50, 40);
            StartegyPlan[8] = new Circle(400, 200, 40);
            StartegyPlan[9] = new Circle(400, 350, 40);
            StartegyPlan[10] = new Circle(400, 500, 40);
        }
        public Circle[] Startegy()
        {
            return StartegyPlan;
        }
        public override string ToString()
        {
            return "Counter Attack";
        }
    }

}
