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
        private int _awayPlayerScore;
        private Dictionary<int, string> _scoreMappings;
        public TennisGame()
        {
            _scoreMappings = new Dictionary<int, string>()
            {
                { 0,"Love"},
                { 1,"Fifteen"},
                { 2,"Thirty"},
                { 3,"Forty"}
            };
        }
        public string score()
        {
            if (_homePlayerScore == _awayPlayerScore)
            {
                if (_homePlayerScore >= 3)
                {
                    return "Deuce";
                }
                return $"{_scoreMappings[_homePlayerScore]} All";
            }
            if (_homePlayerScore >= 3 && _awayPlayerScore >= 3)
            {
                var advPlayer = _homePlayerScore > _awayPlayerScore ? "John" : "Tom";
                if (Math.Abs(_homePlayerScore - _awayPlayerScore) == 1)
                {
                    return $"{advPlayer} Adv";
                }
                return $"{advPlayer} Win";
            }

            return $"{_scoreMappings[_homePlayerScore]} {_scoreMappings[_awayPlayerScore]}";

        }
        public void HomePlayerScore()
        {
            _homePlayerScore++;
        }
        public void AwayPlayerScore()
        {
            _awayPlayerScore++;
        }
    }
}
