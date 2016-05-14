using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    public class Game
    {

        public static int GetScore(List<int> pins)
        {
            int score = 0;
            for (int i = 0; i < pins.Count - 1; i++)
            {
                if (pins[i] == 10 && i < 20 && pins[i + 2] != 10 && i % 2 == 0 && i != 18)
                    score += pins[i] + pins[i + 2] + pins[i + 3];

                else if (pins[i] == 10 && pins[i + 2] == 10 && i % 2 == 0 && i != 18 && i < 20)
                    score += pins[i] + pins[i + 2] + pins[i + 4];

                else if (pins[i] + pins[i + 1] >= 10 && i % 2 == 0 && i != 20)
                    score += pins[i] + pins[i + 2];

                else
                    score += pins[i];
            }

            return score + pins[9];
        }
    }
}
