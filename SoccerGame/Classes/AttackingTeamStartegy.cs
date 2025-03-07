using SoccerGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Classes
{
    public class AttackingTeamStartegy : ITeamStrategy
    {
        Circle[] StartegyPlan = new Circle[11];
        public AttackingTeamStartegy() 
        {
            // Attacking strategy 
            // 4 : 3 : 3

            // Goal Keeper
            Circle goalKeeperCircle = new Circle(60,320,40);
            StartegyPlan[0] = goalKeeperCircle;

            // Defending
            Circle firstDefenderCircle = new Circle(150, 95, 40);
            StartegyPlan[1] = firstDefenderCircle;

            Circle secondDefenderCircle = new Circle(150, 220, 40);
            StartegyPlan[2] = secondDefenderCircle;

            Circle thirdDefenderCircle = new Circle(150, 415, 40);
            StartegyPlan[3] = thirdDefenderCircle;

            Circle fourthDefenderCircle = new Circle(150, 550, 40);
            StartegyPlan[4] = fourthDefenderCircle;

            // Mid-Field
            Circle firstMidFielderCircle = new Circle(255, 130, 40);
            StartegyPlan[5] = firstMidFielderCircle;

            Circle secondMidFielderCircle = new Circle(255, 320, 40);
            StartegyPlan[6] = secondMidFielderCircle;

            Circle thirdMidFielderCircle = new Circle(255, 480, 40);
            StartegyPlan[7] = thirdMidFielderCircle;

            // Attacking
            Circle firstAttackerCircle = new Circle(370, 210, 40);
            StartegyPlan[8] = firstAttackerCircle;

            Circle secondAttackerCircle = new Circle(370, 320, 40);
            StartegyPlan[9] = secondAttackerCircle;

            Circle thirdAttackerCircle = new Circle(370, 420, 40);
            StartegyPlan[10] = thirdAttackerCircle;

        }
        public Circle[] Startegy()
        {
            return StartegyPlan;
        }
        public override string ToString()
        {
            return "Attacking";
        }
    }
}
