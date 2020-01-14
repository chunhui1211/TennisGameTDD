using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGameTDD
{
    public class TennisGame
    {
        private int _homePlayerScore;
        public string score()
        {
            if (_homePlayerScore == 1)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }
        public void HomePlayerScore()
        {
            _homePlayerScore++;
        }
    }
}
