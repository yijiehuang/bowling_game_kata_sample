using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    public class Game
    {
        const int gameCount = 18;
        public static int GetScore(List<int> pins)
        {
            int score = 0;
            for (int i = 0; i <= gameCount;i++ )
            {
                score += pins[i];
                
                if (pins[i] == 10 )
                {
                    score += pins[i + 2];
                    if (pins[i + 2] == 10)
                    {
                        score += pins[i + 4];
                    }
                    else 
                        score += pins[i + 3];
                   
                }
                else if (pins[i] + pins[i + 1] == 10 && i % 2 == 0)
                    score += pins[i + 2];
            }

            return score+pins[19];
        }
    }
}
