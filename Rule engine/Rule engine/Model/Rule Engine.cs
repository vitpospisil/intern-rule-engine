using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule_engine.Model
{

    public class Team
    {
        public int Position { get; set; }
        public string Name { get; set; }

        public Team(string name, int position)
        {
            Name = name;
            Position = position;
        }

    }

    public class Races
    {
        public List<Team> FirstRace() // generic Lists
        {
            return new List<Team>
            {
                new Team("Team 1", 6),
                new Team("Team 2", 5),
                new Team("Team 3", 4),
                new Team("Team 4", 7),
                new Team("Team 5", 3),
                new Team("Team 6", 11),
                new Team("Team 7", 8),
                new Team("Team 8", 12),
                new Team("Team 9", 9),
                new Team("Team 10", 13),
                new Team("Team 11", 10),
                new Team("Team 12", 15),
                new Team("Team 13", 2),
                new Team("Team 14", 1),
                new Team("Team 15", 14)
            };
        }

        public List<Team> SecondRace()
        {
            return new List<Team>
            {
                new Team("Team 1", 6),
                new Team("Team 2", 5),
                new Team("Team 3", 12),
                new Team("Team 4", 15),
                new Team("Team 5", 4),
                new Team("Team 6", 7),
                new Team("Team 7", 2),
                new Team("Team 8", 1),
                new Team("Team 9", 13),
                new Team("Team 10", 14),
                new Team("Team 11", 8),
                new Team("Team 12", 3),
                new Team("Team 13", 9),
                new Team("Team 14", 11),
                new Team("Team 15", 10)
            };
        }

        public List<Team> ThirdRace()
        {
            return new List<Team>
            {
                new Team("Team 1", 5),
                new Team("Team 2", 1),
                new Team("Team 3", 11),
                new Team("Team 4", 7),
                new Team("Team 5", 12),
                new Team("Team 6", 8),
                new Team("Team 7", 2),
                new Team("Team 8", 6),
                new Team("Team 9", 13),
                new Team("Team 10", 4),
                new Team("Team 11", 14),
                new Team("Team 12", 10),
                new Team("Team 13", 3),
                new Team("Team 14", 9),
                new Team("Team 15", 15)
            };

        }

        //public int[] PointsOfTeams()
        //{
        //    FirstRace();
        //    SecondRace();
        //    ThirdRace();

        //    int[] ScoreBoard = new int[15];
        //    for (int i = 0; i < ScoreBoard.Length; i += 1)
        //    {
        //        ScoreBoard[i] = PositionFirstRace[i] + PositionSecondRace[i] + PositionThirdRace[i]; 
        //    }
        //    return ScoreBoard;
        //}
    }

    public class Rules
    {
        public static void PointsCalculate(List<Team> teams)
        {
            Races x;
            int PointsOfTeams = 0;
            for (int i = 0; i < teams.Count; i += 1)
            {
                PointsOfTeams = x.FirstRace[i];
            }
        }
    }
}
