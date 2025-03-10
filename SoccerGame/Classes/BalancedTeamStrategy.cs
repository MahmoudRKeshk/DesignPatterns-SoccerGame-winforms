﻿using SoccerGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Classes
{
    public class BalancedTeamStrategy : ITeamStrategy
    {
        Circle[] StartegyPlan = new Circle[11];
        public BalancedTeamStrategy()
        {
            // Balanced formation: 4-4-2
            // Field dimensions: 1070 x 729

            // Goal Keeper
            StartegyPlan[0] = new Circle(60, 320, 40);

            // Defenders (4 players)
            StartegyPlan[1] = new Circle(150, 100, 40);
            StartegyPlan[2] = new Circle(150, 250, 40);
            StartegyPlan[3] = new Circle(150, 480, 40);
            StartegyPlan[4] = new Circle(150, 620, 40);

            // Midfielders (4 players)
            StartegyPlan[5] = new Circle(250, 150, 40);
            StartegyPlan[6] = new Circle(250, 300, 40);
            StartegyPlan[7] = new Circle(250, 450, 40);
            StartegyPlan[8] = new Circle(250, 600, 40);

            // Attackers (2 players)
            StartegyPlan[9] = new Circle(400, 300, 40);
            StartegyPlan[10] = new Circle(400, 450, 40);
        }
        public Circle[] Startegy()
        {
            return StartegyPlan;
        }
        public override string ToString()
        {
            return "Balanced";
        }
    }

}
