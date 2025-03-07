using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Classes
{
    public class Clothes
    {
        public String Name { get; set; }
        public Color PlayerShirtColor { get; set; } = Color.White;
        public Color PlayerNumberColor { get; set; } = Color.Black;
        public Color GoalKeeperShirtColor { get; set; } = Color.Black;
        public Color GoalKeeperNumberColor { get; set; } = Color.White;
        public Clothes(Color PlayerShirtColor , Color PlayerNumberColor, Color GoalKeeperShirtColor, Color GoalKeeperNumberColor, string name)
        {
            this.PlayerShirtColor = PlayerShirtColor;
            this.PlayerNumberColor = PlayerNumberColor;
            this.GoalKeeperNumberColor = GoalKeeperNumberColor;
            this.GoalKeeperShirtColor = GoalKeeperShirtColor;
            this.Name = name;
        }
        public Clothes()
        {

        }
        public override string ToString()
        {
            return Name;
        }
    }
}
