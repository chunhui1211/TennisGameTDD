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
            if (_homePlayerScore == 4 && _awayPlayerScore == 4)
            {
                return "Deuce";
            }
            if (_homePlayerScore == 3 && _awayPlayerScore == 3)
            {
                return "Deuce";
            }
            if (_homePlayerScore == _awayPlayerScore)
            {
                return $"{_scoreMappings[_homePlayerScore]} All";
            }
            if (_homePlayerScore > 0 || _awayPlayerScore>0)
            {
                return $"{_scoreMappings[_homePlayerScore]} {_scoreMappings[_awayPlayerScore]}";
            }
            return "Love All";
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
