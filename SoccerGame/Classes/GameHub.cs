using SoccerGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Classes
{
    public static class GameHub
    {
        public static List<Team> RightTeamList { get; set; } = new List<Team>();
        public static List<Team> LeftTeamList { get; set; } = new List<Team>();
        public static List<ITeamStrategy> LeftTeamStrategies { get; set; } = new List<ITeamStrategy>();
        public static List<ITeamStrategy> RightTeamStrategies { get; set; } = new List<ITeamStrategy>();
        public static List<Clothes> LeftTeamClothes { get; set; }
        public static List<Clothes> RightTeamClothes { get; set; }

        static GameHub()
        {

            fillLeftTeamClothes();
            fillRightTeamClothes();
           
            fillRightTeamStrategies();
            fillLeftTeamStrategies();

            fillRightTeams();
            fillLeftTeams();
            

        }

        private static void fillRightTeams()
        {

            // Team One - FC Barcelona
            Team barcelona = new TeamBuilder()
                .setGoalKeeper(new Player("Marc-André ter Stegen", "1", PlayerRole.G)) 
                .setPlayerTen(new Player("Sergi Roberto", "20", PlayerRole.D | PlayerRole.M)) 
                .setPlayerOne(new Player("Gerard Piqué", "3", PlayerRole.D | PlayerRole.M)) 
                .setPlayerTwo(new Player("Ronald Araújo", "4", PlayerRole.D)) 
                .setPlayerThree(new Player("Jordi Alba", "18", PlayerRole.D | PlayerRole.M)) 
                .setPlayerFour(new Player("Sergio Busquets", "5", PlayerRole.M | PlayerRole.D)) 
                .setPlayerFive(new Player("Frenkie de Jong", "21", PlayerRole.M | PlayerRole.D)) 
                .setPlayerSix(new Player("Pedri", "16", PlayerRole.M | PlayerRole.A)) 
                .setPlayerSeven(new Player("Ousmane Dembélé", "11", PlayerRole.A | PlayerRole.M)) 
                .setPlayerEight(new Player("Ansu Fati", "22", PlayerRole.A)) 
                .setPlayerNine(new Player("Robert Lewandowski", "9", PlayerRole.A)) 
                .Build();

            barcelona.setTeamStrategy(RightTeamStrategies[0]);
            barcelona.setTeamClothes(RightTeamClothes[0]);
            barcelona.setTeamName("Barcelona");
            RightTeamList.Add(barcelona);


            // Team Two - Real Madrid
            Team realMadrid = new TeamBuilder()
                .setGoalKeeper(new Player("Thibaut Courtois", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Dani Carvajal", "2", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("Sergio Ramos", "4", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("Raphaël Varane", "5", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Ferland Mendy", "3", PlayerRole.D), PlayerRole.M)) 
                .setPlayerFour(new Player(new Player("Casemiro", "18", PlayerRole.M), PlayerRole.D)) 
                .setPlayerFive(new Player(new Player("Luka Modrić", "10", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSix(new Player(new Player("Toni Kroos", "8", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSeven(new Player(new Player("Isco", "22", PlayerRole.M), PlayerRole.A)) 
                .setPlayerEight(new Player(new Player("Karim Benzema", "9", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Eden Hazard", "7", PlayerRole.A), PlayerRole.M)) 
                .Build();

            realMadrid.setTeamStrategy(RightTeamStrategies[1]);
            realMadrid.setTeamClothes(RightTeamClothes[1]);
            realMadrid.setTeamName("Real Madrid");
            RightTeamList.Add(realMadrid);


            // Team Three - Manchester United
            Team manUnited = new TeamBuilder()
                .setGoalKeeper(new Player("David de Gea", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Aaron Wan-Bissaka", "29", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("Harry Maguire", "5", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("Luke Shaw", "23", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Victor Lindelöf", "2", PlayerRole.D), PlayerRole.M)) 
                .setPlayerFour(new Player(new Player("Paul Pogba", "6", PlayerRole.M), PlayerRole.A)) 
                .setPlayerFive(new Player(new Player("Fred", "17", PlayerRole.M), PlayerRole.D)) 
                .setPlayerSix(new Player(new Player("Scott McTominay", "39", PlayerRole.M), PlayerRole.D)) 
                .setPlayerSeven(new Player(new Player("Bruno Fernandes", "18", PlayerRole.A), PlayerRole.M)) 
                .setPlayerEight(new Player(new Player("Marcus Rashford", "10", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Mason Greenwood", "11", PlayerRole.A), PlayerRole.M)) 
                .Build();

            manUnited.setTeamStrategy(RightTeamStrategies[0]);
            manUnited.setTeamClothes(RightTeamClothes[2]);
            manUnited.setTeamName("Manchester United");
            RightTeamList.Add(manUnited);


            // Team Four - Bayern Munich
            Team bayern = new TeamBuilder()
                .setGoalKeeper(new Player("Manuel Neuer", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Joshua Kimmich", "6", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("Niklas Süle", "4", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("Lucas Hernandez", "21", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Alphonso Davies", "19", PlayerRole.D), PlayerRole.A)) 
                .setPlayerFour(new Player(new Player("Leon Goretzka", "8", PlayerRole.M), PlayerRole.D)) 
                .setPlayerFive(new Player(new Player("Thomas Müller", "25", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSix(new Player(new Player("Leroy Sané", "10", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSeven(new Player(new Player("Serge Gnabry", "7", PlayerRole.A), PlayerRole.M)) 
                .setPlayerEight(new Player(new Player("Robert Lewandowski", "9", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Kingsley Coman", "11", PlayerRole.A), PlayerRole.M)) 
                .Build();

            bayern.setTeamStrategy(RightTeamStrategies[2]);
            bayern.setTeamClothes(RightTeamClothes[3]);
            bayern.setTeamName("Bayern Munich");
            RightTeamList.Add(bayern);


            // Team Five - Liverpool
            Team liverpool = new TeamBuilder()
                .setGoalKeeper(new Player("Alisson Becker", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Trent Alexander-Arnold", "66", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("Virgil van Dijk", "4", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("Joe Gomez", "12", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Andrew Robertson", "26", PlayerRole.D), PlayerRole.A)) 
                .setPlayerFour(new Player(new Player("Fabinho", "3", PlayerRole.M), PlayerRole.D)) 
                .setPlayerFive(new Player(new Player("Jordan Henderson", "14", PlayerRole.M), PlayerRole.D)) 
                .setPlayerSix(new Player(new Player("Thiago Alcântara", "6", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSeven(new Player(new Player("Naby Keïta", "8", PlayerRole.M), PlayerRole.A)) 
                .setPlayerEight(new Player(new Player("Mohamed Salah", "11", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Sadio Mané", "10", PlayerRole.A), PlayerRole.M)) 
                .Build();

            liverpool.setTeamStrategy(RightTeamStrategies[0]);
            liverpool.setTeamClothes(RightTeamClothes[4]);
            liverpool.setTeamName("Liverpool");
            RightTeamList.Add(liverpool);


            // Team Six - Juventus
            Team juventus = new TeamBuilder()
                .setGoalKeeper(new Player("Wojciech Szczęsny", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Danilo", "12", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("Giorgio Chiellini", "3", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("Leonardo Bonucci", "19", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Alex Sandro", "21", PlayerRole.D), PlayerRole.A)) 
                .setPlayerFour(new Player(new Player("Miralem Pjanic", "8", PlayerRole.M), PlayerRole.A)) 
                .setPlayerFive(new Player(new Player("Adrien Rabiot", "25", PlayerRole.M), PlayerRole.D)) 
                .setPlayerSix(new Player(new Player("Manuel Locatelli", "5", PlayerRole.M), PlayerRole.D)) 
                .setPlayerSeven(new Player(new Player("Paulo Dybala", "10", PlayerRole.A), PlayerRole.M)) 
                .setPlayerEight(new Player(new Player("Cristiano Ronaldo", "7", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Alvaro Morata", "9", PlayerRole.A), PlayerRole.M)) 
                .Build();

            juventus.setTeamStrategy(RightTeamStrategies[1]);
            juventus.setTeamClothes(RightTeamClothes[5]);
            juventus.setTeamName("Juventus");
            RightTeamList.Add(juventus);


            // Team Seven - Paris Saint-Germain
            Team psg = new TeamBuilder()
                .setGoalKeeper(new Player("Keylor Navas", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Achraf Hakimi", "2", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("Presnel Kimpembe", "3", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("Marquinhos", "5", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Layvin Kurzawa", "26", PlayerRole.D), PlayerRole.A)) 
                .setPlayerFour(new Player(new Player("Marco Verratti", "6", PlayerRole.M), PlayerRole.A)) 
                .setPlayerFive(new Player(new Player("Leandro Paredes", "8", PlayerRole.M), PlayerRole.D)) 
                .setPlayerSix(new Player(new Player("Georginio Wijnaldum", "7", PlayerRole.M), PlayerRole.D)) 
                .setPlayerSeven(new Player(new Player("Mauro Icardi", "10", PlayerRole.A), PlayerRole.M)) 
                .setPlayerEight(new Player(new Player("Lionel Messi", "30", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Kylian Mbappé", "7", PlayerRole.A), PlayerRole.M)) 
                .Build();

            psg.setTeamStrategy(RightTeamStrategies[0]);
            psg.setTeamClothes(RightTeamClothes[6]);
            psg.setTeamName("Paris Saint-Germain");
            RightTeamList.Add(psg);


            // Team Eight - Manchester City
            Team manCity = new TeamBuilder()
                .setGoalKeeper(new Player("Ederson", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Kyle Walker", "2", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("Rúben Dias", "3", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("John Stones", "5", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Aymeric Laporte", "4", PlayerRole.D), PlayerRole.A)) 
                .setPlayerFour(new Player(new Player("Rodri", "16", PlayerRole.M), PlayerRole.D)) 
                .setPlayerFive(new Player(new Player("Kevin De Bruyne", "17", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSix(new Player(new Player("Bernardo Silva", "10", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSeven(new Player(new Player("Phil Foden", "47", PlayerRole.A), PlayerRole.M)) 
                .setPlayerEight(new Player(new Player("Riyad Mahrez", "26", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Erling Haaland", "9", PlayerRole.A), PlayerRole.M)) 
                .Build();

            manCity.setTeamStrategy(RightTeamStrategies[0]);
            manCity.setTeamClothes(RightTeamClothes[7]);
            manCity.setTeamName("Manchester City");
            RightTeamList.Add(manCity);


            // Team Nine - Arsenal
            Team arsenal = new TeamBuilder()
                .setGoalKeeper(new Player("Bernd Leno", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Héctor Bellerín", "2", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("Kieran Tierney", "3", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("Gabriel Magalhães", "4", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Rob Holding", "5", PlayerRole.D), PlayerRole.A)) 
                .setPlayerFour(new Player(new Player("Thomas Partey", "8", PlayerRole.M), PlayerRole.D)) 
                .setPlayerFive(new Player(new Player("Granit Xhaka", "34", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSix(new Player(new Player("Bukayo Saka", "7", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSeven(new Player(new Player("Emile Smith Rowe", "10", PlayerRole.A), PlayerRole.M)) 
                .setPlayerEight(new Player(new Player("Martin Ødegaard", "8", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Pierre-Emerick Aubameyang", "14", PlayerRole.A), PlayerRole.M)) 
                .Build();

            arsenal.setTeamStrategy(RightTeamStrategies[1]);
            arsenal.setTeamClothes(RightTeamClothes[8]);
            arsenal.setTeamName("Arsenal");
            RightTeamList.Add(arsenal);


            // Team Ten - Chelsea
            Team chelsea = new TeamBuilder()
                .setGoalKeeper(new Player("Edouard Mendy", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Reece James", "4", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("César Azpilicueta", "28", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("Thiago Silva", "2", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Antonio Rüdiger", "2", PlayerRole.D), PlayerRole.A)) 
                .setPlayerFour(new Player(new Player("N'Golo Kanté", "7", PlayerRole.M), PlayerRole.D)) 
                .setPlayerFive(new Player(new Player("Jorginho", "5", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSix(new Player(new Player("Mateo Kovačić", "8", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSeven(new Player(new Player("Mason Mount", "10", PlayerRole.A), PlayerRole.M)) 
                .setPlayerEight(new Player(new Player("Kai Havertz", "29", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Timo Werner", "11", PlayerRole.A), PlayerRole.M)) 
                .Build();

            chelsea.setTeamStrategy(RightTeamStrategies[2]);
            chelsea.setTeamClothes(RightTeamClothes[9]);
            chelsea.setTeamName("Chelsea");
            RightTeamList.Add(chelsea);

        }
        private static void fillLeftTeams()
        {

            // Team One - FC Barcelona
            Team barcelona = new TeamBuilder()
                .setGoalKeeper(new Player("Marc-André ter Stegen", "1", PlayerRole.G)) 
                .setPlayerTen(new Player("Sergi Roberto", "20", PlayerRole.D | PlayerRole.M)) 
                .setPlayerOne(new Player("Gerard Piqué", "3", PlayerRole.D | PlayerRole.M)) 
                .setPlayerTwo(new Player("Ronald Araújo", "4", PlayerRole.D)) 
                .setPlayerThree(new Player("Jordi Alba", "18", PlayerRole.D | PlayerRole.M)) 
                .setPlayerFour(new Player("Sergio Busquets", "5", PlayerRole.M | PlayerRole.D)) 
                .setPlayerFive(new Player("Frenkie de Jong", "21", PlayerRole.M | PlayerRole.D)) 
                .setPlayerSix(new Player("Pedri", "16", PlayerRole.M | PlayerRole.A)) 
                .setPlayerSeven(new Player("Ousmane Dembélé", "11", PlayerRole.A | PlayerRole.M)) 
                .setPlayerEight(new Player("Ansu Fati", "22", PlayerRole.A)) 
                .setPlayerNine(new Player("Robert Lewandowski", "9", PlayerRole.A)) 
                .Build();

            barcelona.setTeamStrategy(LeftTeamStrategies[1]);
            barcelona.setTeamClothes(LeftTeamClothes[0]);
            barcelona.setTeamName("Barcelona");
            LeftTeamList.Add(barcelona);


            // Team Two - Real Madrid
            Team realMadrid = new TeamBuilder()
                .setGoalKeeper(new Player("Thibaut Courtois", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Dani Carvajal", "2", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("Sergio Ramos", "4", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("Raphaël Varane", "5", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Ferland Mendy", "3", PlayerRole.D), PlayerRole.M)) 
                .setPlayerFour(new Player(new Player("Casemiro", "18", PlayerRole.M), PlayerRole.D)) 
                .setPlayerFive(new Player(new Player("Luka Modrić", "10", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSix(new Player(new Player("Toni Kroos", "8", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSeven(new Player(new Player("Isco", "22", PlayerRole.M), PlayerRole.A)) 
                .setPlayerEight(new Player(new Player("Karim Benzema", "9", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Eden Hazard", "7", PlayerRole.A), PlayerRole.M)) 
                .Build();

            realMadrid.setTeamStrategy(LeftTeamStrategies[1]);
            realMadrid.setTeamClothes(LeftTeamClothes[1]);
            realMadrid.setTeamName("Real Madrid");
            LeftTeamList.Add(realMadrid);


            // Team Three - Manchester United
            Team manUnited = new TeamBuilder()
                .setGoalKeeper(new Player("David de Gea", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Aaron Wan-Bissaka", "29", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("Harry Maguire", "5", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("Luke Shaw", "23", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Victor Lindelöf", "2", PlayerRole.D), PlayerRole.M)) 
                .setPlayerFour(new Player(new Player("Paul Pogba", "6", PlayerRole.M), PlayerRole.A)) 
                .setPlayerFive(new Player(new Player("Fred", "17", PlayerRole.M), PlayerRole.D)) 
                .setPlayerSix(new Player(new Player("Scott McTominay", "39", PlayerRole.M), PlayerRole.D)) 
                .setPlayerSeven(new Player(new Player("Bruno Fernandes", "18", PlayerRole.A), PlayerRole.M)) 
                .setPlayerEight(new Player(new Player("Marcus Rashford", "10", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Mason Greenwood", "11", PlayerRole.A), PlayerRole.M)) 
                .Build();

            manUnited.setTeamStrategy(LeftTeamStrategies[3]);
            manUnited.setTeamClothes(LeftTeamClothes[2]);
            manUnited.setTeamName("Manchester United");
            LeftTeamList.Add(manUnited);


            // Team Four - Bayern Munich
            Team bayern = new TeamBuilder()
                .setGoalKeeper(new Player("Manuel Neuer", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Joshua Kimmich", "6", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("Niklas Süle", "4", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("Lucas Hernandez", "21", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Alphonso Davies", "19", PlayerRole.D), PlayerRole.A)) 
                .setPlayerFour(new Player(new Player("Leon Goretzka", "8", PlayerRole.M), PlayerRole.D)) 
                .setPlayerFive(new Player(new Player("Thomas Müller", "25", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSix(new Player(new Player("Leroy Sané", "10", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSeven(new Player(new Player("Serge Gnabry", "7", PlayerRole.A), PlayerRole.M)) 
                .setPlayerEight(new Player(new Player("Robert Lewandowski", "9", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Kingsley Coman", "11", PlayerRole.A), PlayerRole.M)) 
                .Build();

            bayern.setTeamStrategy(LeftTeamStrategies[2]);
            bayern.setTeamClothes(LeftTeamClothes[3]);
            bayern.setTeamName("Bayern Munich");
            LeftTeamList.Add(bayern);


            // Team Five - Liverpool
            Team liverpool = new TeamBuilder()
                .setGoalKeeper(new Player("Alisson Becker", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Trent Alexander-Arnold", "66", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("Virgil van Dijk", "4", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("Joe Gomez", "12", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Andrew Robertson", "26", PlayerRole.D), PlayerRole.A)) 
                .setPlayerFour(new Player(new Player("Fabinho", "3", PlayerRole.M), PlayerRole.D)) 
                .setPlayerFive(new Player(new Player("Jordan Henderson", "14", PlayerRole.M), PlayerRole.D)) 
                .setPlayerSix(new Player(new Player("Thiago Alcântara", "6", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSeven(new Player(new Player("Naby Keïta", "8", PlayerRole.M), PlayerRole.A)) 
                .setPlayerEight(new Player(new Player("Mohamed Salah", "11", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Sadio Mané", "10", PlayerRole.A), PlayerRole.M)) 
                .Build();

            liverpool.setTeamStrategy(LeftTeamStrategies[0]);
            liverpool.setTeamClothes(LeftTeamClothes[4]);
            liverpool.setTeamName("Liverpool");
            LeftTeamList.Add(liverpool);


            // Team Six - Juventus
            Team juventus = new TeamBuilder()
                .setGoalKeeper(new Player("Wojciech Szczęsny", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Danilo", "12", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("Giorgio Chiellini", "3", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("Leonardo Bonucci", "19", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Alex Sandro", "21", PlayerRole.D), PlayerRole.A)) 
                .setPlayerFour(new Player(new Player("Miralem Pjanic", "8", PlayerRole.M), PlayerRole.A)) 
                .setPlayerFive(new Player(new Player("Adrien Rabiot", "25", PlayerRole.M), PlayerRole.D)) 
                .setPlayerSix(new Player(new Player("Manuel Locatelli", "5", PlayerRole.M), PlayerRole.D)) 
                .setPlayerSeven(new Player(new Player("Paulo Dybala", "10", PlayerRole.A), PlayerRole.M)) 
                .setPlayerEight(new Player(new Player("Cristiano Ronaldo", "7", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Alvaro Morata", "9", PlayerRole.A), PlayerRole.M)) 
                .Build();

            juventus.setTeamStrategy(LeftTeamStrategies[3]);
            juventus.setTeamClothes(LeftTeamClothes[5]);
            juventus.setTeamName("Juventus");
            LeftTeamList.Add(juventus);


            // Team Seven - Paris Saint-Germain
            Team psg = new TeamBuilder()
                .setGoalKeeper(new Player("Keylor Navas", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Achraf Hakimi", "2", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("Presnel Kimpembe", "3", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("Marquinhos", "5", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Layvin Kurzawa", "26", PlayerRole.D), PlayerRole.A)) 
                .setPlayerFour(new Player(new Player("Marco Verratti", "6", PlayerRole.M), PlayerRole.A)) 
                .setPlayerFive(new Player(new Player("Leandro Paredes", "8", PlayerRole.M), PlayerRole.D)) 
                .setPlayerSix(new Player(new Player("Georginio Wijnaldum", "7", PlayerRole.M), PlayerRole.D)) 
                .setPlayerSeven(new Player(new Player("Mauro Icardi", "10", PlayerRole.A), PlayerRole.M)) 
                .setPlayerEight(new Player(new Player("Lionel Messi", "30", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Kylian Mbappé", "7", PlayerRole.A), PlayerRole.M)) 
                .Build();

            psg.setTeamStrategy(LeftTeamStrategies[2]);
            psg.setTeamClothes(LeftTeamClothes[6]);
            psg.setTeamName("Paris Saint-Germain");
            LeftTeamList.Add(psg);


            // Team Eight - Manchester City
            Team manCity = new TeamBuilder()
                .setGoalKeeper(new Player("Ederson", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Kyle Walker", "2", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("Rúben Dias", "3", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("John Stones", "5", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Aymeric Laporte", "4", PlayerRole.D), PlayerRole.A)) 
                .setPlayerFour(new Player(new Player("Rodri", "16", PlayerRole.M), PlayerRole.D)) 
                .setPlayerFive(new Player(new Player("Kevin De Bruyne", "17", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSix(new Player(new Player("Bernardo Silva", "10", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSeven(new Player(new Player("Phil Foden", "47", PlayerRole.A), PlayerRole.M)) 
                .setPlayerEight(new Player(new Player("Riyad Mahrez", "26", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Erling Haaland", "9", PlayerRole.A), PlayerRole.M)) 
                .Build();

            manCity.setTeamStrategy(LeftTeamStrategies[0]);
            manCity.setTeamClothes(LeftTeamClothes[7]);
            manCity.setTeamName("Manchester City");
            LeftTeamList.Add(manCity);


            // Team Nine - Arsenal
            Team arsenal = new TeamBuilder()
                .setGoalKeeper(new Player("Bernd Leno", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Héctor Bellerín", "2", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("Kieran Tierney", "3", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("Gabriel Magalhães", "4", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Rob Holding", "5", PlayerRole.D), PlayerRole.A)) 
                .setPlayerFour(new Player(new Player("Thomas Partey", "8", PlayerRole.M), PlayerRole.D)) 
                .setPlayerFive(new Player(new Player("Granit Xhaka", "34", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSix(new Player(new Player("Bukayo Saka", "7", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSeven(new Player(new Player("Emile Smith Rowe", "10", PlayerRole.A), PlayerRole.M)) 
                .setPlayerEight(new Player(new Player("Martin Ødegaard", "8", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Pierre-Emerick Aubameyang", "14", PlayerRole.A), PlayerRole.M)) 
                .Build();

            arsenal.setTeamStrategy(LeftTeamStrategies[3]);
            arsenal.setTeamClothes(LeftTeamClothes[8]);
            arsenal.setTeamName("Arsenal");
            LeftTeamList.Add(arsenal);


            // Team Ten - Chelsea
            Team chelsea = new TeamBuilder()
                .setGoalKeeper(new Player("Edouard Mendy", "1", PlayerRole.G)) 
                .setPlayerTen(new Player(new Player("Reece James", "4", PlayerRole.D), PlayerRole.M)) 
                .setPlayerOne(new Player(new Player("César Azpilicueta", "28", PlayerRole.D), PlayerRole.M)) 
                .setPlayerTwo(new Player(new Player("Thiago Silva", "2", PlayerRole.D), PlayerRole.M)) 
                .setPlayerThree(new Player(new Player("Antonio Rüdiger", "2", PlayerRole.D), PlayerRole.A)) 
                .setPlayerFour(new Player(new Player("N'Golo Kanté", "7", PlayerRole.M), PlayerRole.D)) 
                .setPlayerFive(new Player(new Player("Jorginho", "5", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSix(new Player(new Player("Mateo Kovačić", "8", PlayerRole.M), PlayerRole.A)) 
                .setPlayerSeven(new Player(new Player("Mason Mount", "10", PlayerRole.A), PlayerRole.M)) 
                .setPlayerEight(new Player(new Player("Kai Havertz", "29", PlayerRole.A), PlayerRole.M)) 
                .setPlayerNine(new Player(new Player("Timo Werner", "11", PlayerRole.A), PlayerRole.M)) 
                .Build();

            chelsea.setTeamStrategy(LeftTeamStrategies[2]);
            chelsea.setTeamClothes(LeftTeamClothes[9]);
            chelsea.setTeamName("Chelsea");
            LeftTeamList.Add(chelsea);

        }

        private static void fillRightTeamStrategies()
        {
            ITeamStrategy Balanced = new BalancedTeamStrategy();
            ITeamStrategy Attacking = new AttackingTeamStartegy();
            ITeamStrategy MidField = new MidfieldTeamStrategy();
            ITeamStrategy Defencive = new DefensiveTeamStrategy();
            RightTeamStrategies.Add(Balanced);
            RightTeamStrategies.Add(Attacking);
            RightTeamStrategies.Add(MidField);
            RightTeamStrategies.Add(Defencive);
        }
        private static void fillLeftTeamStrategies()
        {
            ITeamStrategy Balanced = new BalancedTeamStrategy();
            ITeamStrategy Attacking = new AttackingTeamStartegy();
            ITeamStrategy MidField = new MidfieldTeamStrategy();
            ITeamStrategy Defencive = new DefensiveTeamStrategy();
            LeftTeamStrategies.Add(Balanced);
            LeftTeamStrategies.Add(Attacking);
            LeftTeamStrategies.Add(MidField);
            LeftTeamStrategies.Add(Defencive);
        }

        private static void fillLeftTeamClothes()
        {
            LeftTeamClothes = new List<Clothes>
            {
                new Clothes(Color.Blue, Color.DarkRed, Color.Black, Color.White, "Barcelona"),          // Example: Barcelona National Team
                new Clothes(Color.White, Color.Black, Color.Gray, Color.Black, "Real Madrid"),     // Example: Real Madrid
                new Clothes(Color.Red, Color.White, Color.DarkGreen, Color.White, "Man United"),   // Example: Man United
                new Clothes(Color.Red, Color.White, Color.DarkGray, Color.White, "Bayern"),       // Example: Bayern
                new Clothes(Color.Red, Color.White, Color.Yellow, Color.Black, "Liverpool"),        // Example: Liverpool
                new Clothes(Color.Black, Color.Gold, Color.Purple, Color.White, "Juventus"),       // Example: Juventus (alternative)
                new Clothes(Color.Purple, Color.White, Color.Green, Color.Black, "Paris Sant German"),   // Example: Paris Sant German
                new Clothes(Color.SkyBlue, Color.Navy, Color.White, Color.Black, "Man City"),      // Example: Manchester City
                new Clothes(Color.DarkRed, Color.Gold, Color.Navy, Color.White, "Arsenal"),      // Example: Arsenal
                new Clothes(Color.Blue, Color.White, Color.Green, Color.Black, "Chelsea")         // Example: Chelsea
            };
        }
        private static void fillRightTeamClothes()
        {
            RightTeamClothes = new List<Clothes>
            {
                new Clothes(Color.Blue, Color.DarkRed, Color.Black, Color.White, "Barcelona"),          // Example: Barcelona National Team
                new Clothes(Color.White, Color.Black, Color.Gray, Color.Black, "Real Madrid"),     // Example: Real Madrid
                new Clothes(Color.Red, Color.White, Color.DarkGreen, Color.White, "Man United"),   // Example: Man United
                new Clothes(Color.Red, Color.White, Color.DarkGray, Color.White, "Bayern"),       // Example: Bayern
                new Clothes(Color.Red, Color.White, Color.Yellow, Color.Black, "Liverpool"),        // Example: Liverpool
                new Clothes(Color.Black, Color.Gold, Color.Purple, Color.White, "Juventus"),       // Example: Juventus (alternative)
                new Clothes(Color.Purple, Color.White, Color.Green, Color.Black, "Paris Sant German"),   // Example: Paris Sant German
                new Clothes(Color.SkyBlue, Color.Navy, Color.White, Color.Black, "Man City"),      // Example: Manchester City
                new Clothes(Color.DarkRed, Color.Gold, Color.Navy, Color.White, "Arsenal"),      // Example: Arsenal
                new Clothes(Color.Blue, Color.White, Color.Green, Color.Black, "Chelsea")         // Example: Chelsea
            };
        }
    }
}
