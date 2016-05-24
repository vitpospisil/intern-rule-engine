using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule_engine.Model
{
    public class Teams
    {
        public List<string> TeamsList = new List<string>();
        public int NumberOfTeam { get; private set; }
        public void AddTeam()
        {
            NumberOfTeam = 1;
            for(int i = 0; i < NumberOfTeam; i += 1, NumberOfTeam += 1)
            {
                if (NumberOfTeam > 15)
                {
                    return;
                }
                TeamsList.Add("Team " + NumberOfTeam.ToString());
            }
        }
    }

    public class Races
    {

        public int[] PositionFirstRace = new int[15];

        public void FirstRace()
        {
            PositionFirstRace[0] = 6;
            PositionFirstRace[1] = 5;
            PositionFirstRace[2] = 4;
            PositionFirstRace[3] = 7;
            PositionFirstRace[4] = 3;
            PositionFirstRace[5] = 11;
            PositionFirstRace[6] = 8;
            PositionFirstRace[7] = 12;
            PositionFirstRace[8] = 9;
            PositionFirstRace[9] = 13;
            PositionFirstRace[10] = 10;
            PositionFirstRace[11] = 15;
            PositionFirstRace[12] = 2;
            PositionFirstRace[13] = 1;
            PositionFirstRace[14] = 14;
        }


        public int[] PositionSecondRace = new int[15];

        public void SecondRace()
        {
            PositionSecondRace[0] = 6;
            PositionSecondRace[1] = 5;
            PositionSecondRace[2] = 12;
            PositionSecondRace[3] = 15;
            PositionSecondRace[4] = 4;
            PositionSecondRace[5] = 7;
            PositionSecondRace[6] = 2;
            PositionSecondRace[7] = 1;
            PositionSecondRace[8] = 13;
            PositionSecondRace[9] = 14;
            PositionSecondRace[10] = 8;
            PositionSecondRace[11] = 3;
            PositionSecondRace[12] = 9;
            PositionSecondRace[13] = 11;
            PositionSecondRace[14] = 10;
        }

        public int[] PositionThirdRace = new int[15];

        public void ThirdRace()
        {
            PositionThirdRace[0] = 5;
            PositionThirdRace[1] = 1;
            PositionThirdRace[2] = 11;
            PositionThirdRace[3] = 7;
            PositionThirdRace[4] = 12;
            PositionThirdRace[5] = 8;
            PositionThirdRace[6] = 2;
            PositionThirdRace[7] = 6;
            PositionThirdRace[8] = 13;
            PositionThirdRace[9] = 4;
            PositionThirdRace[10] = 14;
            PositionThirdRace[11] = 10;
            PositionThirdRace[12] = 3;
            PositionThirdRace[13] = 9;
            PositionThirdRace[14] = 15;

        }

        public int[] PointsOfTeams()
        {
            FirstRace();
            SecondRace();
            ThirdRace();

            int[] ScoreBoard = new int[15];
            for (int i = 0; i < ScoreBoard.Length; i += 1)
            {
                ScoreBoard[i] = PositionFirstRace[i] + PositionSecondRace[i] + PositionThirdRace[i]; 
            }
            return ScoreBoard;
        }
    }

    public class Competition
    {

    }
}
