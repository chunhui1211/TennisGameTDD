using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisGameTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = new TennisGame();
            Console.WriteLine("請輸入Player1分數\n");
            string home = Console.ReadLine();
            Console.WriteLine("請輸入Player2分數\n");
            string away = Console.ReadLine();
            int player1Score = Convert.ToInt32(home);
            int player2Score = Convert.ToInt32(away);
            for (var i = 0; i < player1Score; i++)
            {
                target.HomePlayerScore();
            }
            for (var i = 0; i < player2Score; i++)
            {
                target.AwayPlayerScore();
            }
            var result = target.score();
            Console.WriteLine("分數"+player1Score + ":"+ player2Score + "------"+result);
            Console.ReadLine();
        }
    }
}
