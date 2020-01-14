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
        private Dictionary<int, string> _scoreMappings;
        public TennisGame()
        {
            _scoreMappings = new Dictionary<int, string>()
            {
                { 1,"Fifteen"},
                { 2,"Thirty"},
                { 3,"Forty"}
            };
        }
        public string score()
        {
            if (_homePlayerScore > 0)
            {
                return $"{_scoreMappings[_homePlayerScore]} Love";
            }
            return "Love All";
        }
        public void HomePlayerScore()
        {
            _homePlayerScore++;
        }
    }
}
