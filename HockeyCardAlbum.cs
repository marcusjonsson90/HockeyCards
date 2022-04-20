using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyCards
{
    public class HockeyCardAlbum
    {
        public List<HockeyCard> HockeyCards { get; set; } = new();

        public int TaskOne()
        {
            //ER KOD HÄR
            return 0;
        }

        public string TaskTwo()
        {
            //ER KOD HÄR
            return "";
        }

        public int TaskThree()
        {
            //ER KOD HÄR
            return 0;
        }

        public string TaskFour()
        {
            //ER KOD HÄR
            return "";
        }

        public int TaskFive()
        {
            //ER KOD HÄR
            return 0;
        }

        public void TaskSix()
        {
            //ER KOD HÄR
        }

        public HockeyCardAlbum()
        {
            HockeyCards.Add(new HockeyCard(1, "Markus Näslund", Team.Penguins, Position.Forward, 4));
            HockeyCards.Add(new HockeyCard(2, "Jamie Storr", Team.Kings, Position.Goalkeeper, 0));
            HockeyCards.Add(new HockeyCard(2, "Jamie Storr", Team.Kings, Position.Goalkeeper, 0));
            HockeyCards.Add(new HockeyCard(3, "TODD KRYGIER", Team.Capitals, Position.Forward, 67));
            HockeyCards.Add(new HockeyCard(4, "Tom Kurvers", Team.Ducks, Position.Defender, 89));
            HockeyCards.Add(new HockeyCard(5, "Mike Donelly", Team.Kings, Position.Forward, 21));
            HockeyCards.Add(new HockeyCard(6, "Luc Robitaille", Team.Penguins, Position.Forward, 392));
            HockeyCards.Add(new HockeyCard(7, "DIMITRI KHRISTICH", Team.Capitals, Position.Forward, 109));
            HockeyCards.Add(new HockeyCard(8, "Troy Loney", Team.Ducks, Position.Forward, 69));
            HockeyCards.Add(new HockeyCard(9, "Len Barrie", Team.Penguins, Position.Forward, 2));
            HockeyCards.Add(new HockeyCard(10, "Anatoli Semenov", Team.Ducks, Position.Forward, 58));
            HockeyCards.Add(new HockeyCard(10, "Anatoli Semenov", Team.Ducks, Position.Forward, 58));
            HockeyCards.Add(new HockeyCard(11, "DON BEAUPRE", Team.Capitals, Position.Goalkeeper, 0));
            HockeyCards.Add(new HockeyCard(12, "Marty McSorley", Team.Kings, Position.Defender, 85));
            HockeyCards.Add(new HockeyCard(13, "Kjell Samuelsson", Team.Penguins, Position.Defender, 39));
            HockeyCards.Add(new HockeyCard(13, "Kjell Samuelsson", Team.Penguins, Position.Defender, 39));
            HockeyCards.Add(new HockeyCard(14, "Bob Corcum", Team.Ducks, Position.Forward, 33));
            HockeyCards.Add(new HockeyCard(15, "Rick Tocchet", Team.Kings, Position.Forward, 291));
            HockeyCards.Add(new HockeyCard(16, "Tony Granato", Team.Kings, Position.Forward, 161));
            HockeyCards.Add(new HockeyCard(17, "Peter Douris", Team.Ducks, Position.Forward, 36));
            HockeyCards.Add(new HockeyCard(18, "Paul Stanton", Team.Penguins, Position.Defender, 5));
            HockeyCards.Add(new HockeyCard(19, "MICHAL PIVONKA", Team.Capitals, Position.Forward, 82));
            HockeyCards.Add(new HockeyCard(19, "MICHAL PIVONKA", Team.Capitals, Position.Forward, 82));
        }
    }

    public class HockeyCard
    {
        public int CardNumber { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Team { get; set; }
        public Position Position { get; set; }
        public int NumberOfGoals { get; set; }

        public HockeyCard(int number, string name, string team, Position position, int goals)
        {
            CardNumber = number;
            FullName = name;
            Team = team;
            Position = position;
            NumberOfGoals = goals;
        }
    }

    public enum Position
    {
        Goalkeeper,
        Defender,
        Forward
    }

    public static class Team
    {
        public const string Penguins = "Pittsburgh Penguins";
        public const string Ducks = "Anaheim Mighty Ducks";
        public const string Capitals = "Washington Capitals";
        public const string Kings = "Los Angeles Kings";
    }
}
