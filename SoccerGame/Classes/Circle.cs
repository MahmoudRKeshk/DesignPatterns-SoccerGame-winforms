using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Classes
{
    public class Circle
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int Diameter { get; set; }
        public string Number { get; set; }
        public string Label { get; set; }
        public string PlayerRole {  get; set; } 
        public Circle()
        {

        }
        public Circle(int x, int y, int diameter, string number, string label)
        {
            X = x;
            Y = y;
            Diameter = diameter;
            Number = number;
            Label = label;
        }
        public Circle(int x, int y, int diameter)
        {
            X = x;
            Y = y;
            Diameter = diameter;
        }


    }
}
