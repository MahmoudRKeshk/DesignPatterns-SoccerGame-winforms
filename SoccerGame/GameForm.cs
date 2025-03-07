using SoccerGame.Classes;
using SoccerGame.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerGame
{
    public partial class GameForm : Form , IObserver
    {

        // Drawing LeftTeamPositions 
        private Circle[] LeftTeamPositions = new Circle[11];
        private Circle[] RightTeamPositions = new Circle[11];
        private Team RightTeam;
        private Team LeftTeam;




        public GameForm()
        {
            InitializeComponent();
            this.Text = "Game Form";
        }
        private void DrawLeftTeamMembers(object sender, PaintEventArgs e)
        {
            // Fixed field dimensions
            int fieldWidth = 1070;
            int fieldHeight = 729;

            using (Pen pen = new Pen(Color.Black, 3))
            using (Brush brush = new SolidBrush(Color.White))
            using (Brush playerTShirtBrush = new SolidBrush(LeftTeam.Clothes.PlayerShirtColor))
            using (Brush playerNumberBrush = new SolidBrush(LeftTeam.Clothes.PlayerNumberColor))
            using (Brush goalKeeperTShirtBrush = new SolidBrush(LeftTeam.Clothes.GoalKeeperShirtColor))
            using (Brush goalKeeperNumberBrush = new SolidBrush(LeftTeam.Clothes.GoalKeeperNumberColor))
            using (Font numberFont = new Font("Arial", 12, FontStyle.Bold))
            using (Font labelFont = new Font("Arial", 10, FontStyle.Bold))
            {
                for (int i = 0; i < LeftTeamPositions.Length; i++)
                {
                    // Draw the player circle (using different brushes for goalkeeper vs. others)
                    if (i == 0)
                    {
                        e.Graphics.FillEllipse(goalKeeperTShirtBrush,
                            LeftTeamPositions[i].X,
                            LeftTeamPositions[i].Y,
                            LeftTeamPositions[i].Diameter,
                            LeftTeamPositions[i].Diameter);
                    }
                    else
                    {
                        e.Graphics.FillEllipse(playerTShirtBrush,
                            LeftTeamPositions[i].X,
                            LeftTeamPositions[i].Y,
                            LeftTeamPositions[i].Diameter,
                            LeftTeamPositions[i].Diameter);
                    }
                    e.Graphics.DrawEllipse(pen,
                        LeftTeamPositions[i].X,
                        LeftTeamPositions[i].Y,
                        LeftTeamPositions[i].Diameter,
                        LeftTeamPositions[i].Diameter);

                    // Draw the player number centered inside the circle
                    SizeF numberSize = e.Graphics.MeasureString(LeftTeamPositions[i].Number, numberFont);
                    float numberX = LeftTeamPositions[i].X + (LeftTeamPositions[i].Diameter - numberSize.Width) / 2;
                    float numberY = LeftTeamPositions[i].Y + (LeftTeamPositions[i].Diameter - numberSize.Height) / 2;
                    if (i == 0)
                    {
                        e.Graphics.DrawString(LeftTeamPositions[i].Number, numberFont, goalKeeperNumberBrush, numberX, numberY);
                    }
                    else
                    {
                        e.Graphics.DrawString(LeftTeamPositions[i].Number, numberFont, playerNumberBrush, numberX, numberY);
                    }

                    // Draw the label in parentheses above the circle (e.g. "(A)")
                    string labelText = "(" + LeftTeamPositions[i].Label + ")";
                    SizeF labelSize = e.Graphics.MeasureString(labelText, labelFont);
                    float labelX = LeftTeamPositions[i].X + (LeftTeamPositions[i].Diameter - labelSize.Width) / 2;
                    float labelY = LeftTeamPositions[i].Y - labelSize.Height - 5; // 5px margin above the circle
                    e.Graphics.DrawString(labelText, labelFont, brush, labelX, labelY);

                    // Draw the player role under the circle (obtained via getPlayerRole())
                    string roleText = LeftTeamPositions[i].PlayerRole;
                    SizeF roleSize = e.Graphics.MeasureString(roleText, labelFont);
                    float roleX = LeftTeamPositions[i].X + (LeftTeamPositions[i].Diameter - roleSize.Width) / 2;
                    float roleY = LeftTeamPositions[i].Y + LeftTeamPositions[i].Diameter + 5; // 5px margin below the circle
                    e.Graphics.DrawString(roleText, labelFont, brush, roleX, roleY);
                }
            }
        }

        private void DrawRightTeamMembers(object sender, PaintEventArgs e)
        {
            // Fixed field dimensions for the right team
            int fieldWidth = 1070;
            int fieldHeight = 729;

            using (Pen pen = new Pen(Color.Black, 3))
            using (Brush brush = new SolidBrush(Color.White))
            using (Brush playerTShirtBrush = new SolidBrush(RightTeam.Clothes.PlayerShirtColor))
            using (Brush playerNumberBrush = new SolidBrush(RightTeam.Clothes.PlayerNumberColor))
            using (Brush goalKeeperTShirtBrush = new SolidBrush(RightTeam.Clothes.GoalKeeperShirtColor))
            using (Brush goalKeeperNumberBrush = new SolidBrush(RightTeam.Clothes.GoalKeeperNumberColor))
            using (Font numberFont = new Font("Arial", 12, FontStyle.Bold))
            using (Font labelFont = new Font("Arial", 10, FontStyle.Bold))
            {
                for (int i = 0; i < RightTeamPositions.Length; i++)
                {
                    float posX, posY;
                    if (i == 0)
                    {
                        // For the goalkeeper: use offsets 70 and 91.
                        posX = fieldWidth - RightTeamPositions[i].X - 70;
                        posY = fieldHeight - RightTeamPositions[i].Y - 91;
                        e.Graphics.FillEllipse(goalKeeperTShirtBrush,
                            posX,
                            posY,
                            RightTeamPositions[i].Diameter,
                            RightTeamPositions[i].Diameter);
                        e.Graphics.DrawEllipse(pen,
                            posX,
                            posY,
                            RightTeamPositions[i].Diameter,
                            RightTeamPositions[i].Diameter);
                    }
                    else
                    {
                        // For other players: use offsets 90 and 50.
                        posX = fieldWidth - RightTeamPositions[i].X - 90;
                        posY = fieldHeight - RightTeamPositions[i].Y - 50;
                        e.Graphics.FillEllipse(playerTShirtBrush,
                            posX,
                            posY,
                            RightTeamPositions[i].Diameter,
                            RightTeamPositions[i].Diameter);
                        e.Graphics.DrawEllipse(pen,
                            posX,
                            posY,
                            RightTeamPositions[i].Diameter,
                            RightTeamPositions[i].Diameter);
                    }

                    // Draw the player number in the center of the circle
                    SizeF numberSize = e.Graphics.MeasureString(RightTeamPositions[i].Number, numberFont);
                    float numberX = posX + (RightTeamPositions[i].Diameter - numberSize.Width) / 2;
                    float numberY = posY + (RightTeamPositions[i].Diameter - numberSize.Height) / 2;
                    if (i == 0)
                    {
                        e.Graphics.DrawString(RightTeamPositions[i].Number, numberFont, goalKeeperNumberBrush, numberX, numberY);
                    }
                    else
                    {
                        e.Graphics.DrawString(RightTeamPositions[i].Number, numberFont, playerNumberBrush, numberX, numberY);
                    }

                    // Draw the label in parentheses above the circle
                    string labelText = "(" + RightTeamPositions[i].Label + ")";
                    SizeF labelSize = e.Graphics.MeasureString(labelText, labelFont);
                    float labelX = posX + (RightTeamPositions[i].Diameter - labelSize.Width) / 2;
                    float labelY = posY - labelSize.Height - 5; // 5px margin above
                    e.Graphics.DrawString(labelText, labelFont, brush, labelX, labelY);

                    // Draw the player role under the circle
                    string roleText = RightTeamPositions[i].PlayerRole;
                    SizeF roleSize = e.Graphics.MeasureString(roleText, labelFont);
                    float roleX = posX + (RightTeamPositions[i].Diameter - roleSize.Width) / 2;
                    float roleY = posY + RightTeamPositions[i].Diameter + 5; // 5px margin below
                    e.Graphics.DrawString(roleText, labelFont, brush, roleX, roleY);
                }
            }
        }


        private void AssignLeftTeam(Team team)
        {
            LeftTeamPositions = team.getStrategy().Startegy();
            for (int i = 0; i < LeftTeamPositions.Length && i < team.players.Count(); i++)
            {
                LeftTeamPositions[i].Label = team.players[i].playerName;
                LeftTeamPositions[i].Number = team.players[i].playerNumber;
                LeftTeamPositions[i].PlayerRole = team.players[i].getPlayerRole();
            }
        }
        private void AssignRightTeam(Team team)
        {
            RightTeamPositions = team.getStrategy().Startegy();
            for (int i = 0; i < RightTeamPositions.Length && i < team.players.Count(); i++)
            {
                RightTeamPositions[i].Label = team.players[i].playerName;
                RightTeamPositions[i].Number = team.players[i].playerNumber;
                RightTeamPositions[i].PlayerRole = team.players[i].getPlayerRole();
            }
        }

        // Clear the Players Drawing
        private void ClearDrawing()
        {
            this.Invalidate(); // Refresh the form
        }


        // IObserver Interface Implementation 
        public void Update(GameContext context)
        {
            ClearDrawing();
            RightTeam = context.RightTeam;
            LeftTeam = context.LeftTeam;
            AssignLeftTeam(LeftTeam);
            AssignRightTeam(RightTeam);
            this.Paint += new PaintEventHandler(DrawLeftTeamMembers);
            this.Paint += new PaintEventHandler(DrawRightTeamMembers);
            this.Refresh();
        }
    }
}
