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
    public partial class ControlsForm : Form, ISubject
    {
        private List<IObserver> subscribers = new List<IObserver>();

        private GameContext GameContext { get; set; } = new GameContext(GameHub.RightTeamList[0], GameHub.LeftTeamList[0]);
        public ControlsForm()
        {
            InitializeComponent();
            GameForm gameForm = new GameForm();
            Attach(gameForm);
            gameForm.Show();

            // Binding Team Names 
            this.TeamOneName.DataSource = null;
            this.TeamOneName.DataSource = GameHub.LeftTeamList;
            this.TeamOneName.SelectedIndex = 1;

            this.TeamTwoName.DataSource = null;
            this.TeamTwoName.DataSource = GameHub.RightTeamList;
            this.TeamTwoName.SelectedIndex = 4;

            // Binding Strategies
            this.TeamOneStrategyComboBox.DataSource = null;
            this.TeamOneStrategyComboBox.DataSource = GameHub.LeftTeamStrategies;
            this.TeamTwoStrategyComboBox.DataSource = null;
            this.TeamTwoStrategyComboBox.DataSource = GameHub.RightTeamStrategies;

            //Binding clothes 
            this.TeamOneClothesCoboBox.DataSource = null;
            this.TeamOneClothesCoboBox.DataSource = GameHub.LeftTeamClothes;

            this.TeamTwoClothesComboBox.DataSource = null;
            this.TeamTwoClothesComboBox.DataSource = GameHub.RightTeamClothes;

        }

        private void ControlsForm_Load(object sender, EventArgs e)
        {
            this.TeamOneClothesCoboBox.SelectedItem = (Clothes)((Team)this.TeamOneName.SelectedItem).Clothes;
            this.TeamOneStrategyComboBox.SelectedItem = (ITeamStrategy)((Team)this.TeamOneName.SelectedItem).getStrategy();
            this.TeamTwoClothesComboBox.SelectedItem = (Clothes)((Team)this.TeamTwoName.SelectedItem).Clothes;
            this.TeamTwoStrategyComboBox.SelectedItem = (ITeamStrategy)((Team)this.TeamTwoName.SelectedItem).getStrategy();
        }

        public void Attach(IObserver observer)
        {
            subscribers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            subscribers.Remove(observer);
        }

        public void Notify(GameContext context)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Update(context);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            // Subscribing to Teams
            Team leftTeamSelection = (Team)this.TeamOneName.SelectedItem;
            Team rightTeamSelection = (Team)this.TeamTwoName.SelectedItem;

            // Subscribing to Strategies
            ITeamStrategy leftTeamStrategySelection = (ITeamStrategy)this.TeamOneStrategyComboBox.SelectedItem;
            ITeamStrategy rightTeamStrategySelection = (ITeamStrategy)this.TeamTwoStrategyComboBox.SelectedItem;
            GameContext.LeftTeam = leftTeamSelection;
            GameContext.RightTeam = rightTeamSelection;
            leftTeamSelection.setTeamStrategy(leftTeamStrategySelection);
            rightTeamSelection.setTeamStrategy(rightTeamStrategySelection);

            // Catching clothes changing
            leftTeamSelection.setTeamClothes((Clothes)TeamOneClothesCoboBox.SelectedItem);
            rightTeamSelection.setTeamClothes((Clothes)TeamTwoClothesComboBox.SelectedItem);

            Notify(GameContext);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TeamOneName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TeamOneClothesCoboBox.SelectedItem = (Clothes)((Team)this.TeamOneName.SelectedItem).Clothes;
            this.TeamOneStrategyComboBox.SelectedItem = (ITeamStrategy)((Team)this.TeamOneName.SelectedItem).getStrategy();        }

        private void TeamTwoName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TeamTwoClothesComboBox.SelectedItem = (Clothes)((Team)this.TeamTwoName.SelectedItem).Clothes;
            this.TeamTwoStrategyComboBox.SelectedItem = (ITeamStrategy)((Team)this.TeamTwoName.SelectedItem).getStrategy();
        }
    }
}
