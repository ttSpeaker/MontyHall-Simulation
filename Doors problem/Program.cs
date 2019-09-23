using System;

namespace montyhall
{
    class Program
    {
        static void Main(string[] args)
        {
            var timesToPlay = 500000;
            play(false, timesToPlay);
            play(true, timesToPlay);
        }
        static void play(bool change, int timesToPlay)
        {
            var message = "NOT changing the choice."; ;
            Score score = new Score();
            var rand = new Random();
            for (var i = 0; i < timesToPlay; i++)
            {
                var board = new Board();
                var firstPick = rand.Next(3);
                var currentPick = firstPick;
                var openDoor = board.openDoor(firstPick);
                if (change)
                {
                    message = "by  changing the choice.";
                    var secondPick = board.changePick(firstPick, openDoor);
                    currentPick = secondPick;
                }
                if (board.Doors[currentPick])
                {
                    score.won += 1;
                }
                else
                {
                    score.lost += 1;
                }
            }
            Console.Write("Played {0} cases {1}", timesToPlay, message);
            Console.WriteLine(" won {0}. Lost {1}. Won {2}%.", score.won, score.lost, score.wonQ());
        }
    }
}
