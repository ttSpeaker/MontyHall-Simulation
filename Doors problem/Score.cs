using System;
using System.Collections.Generic;
using System.Text;

namespace montyhall
{
    class Score
    {
        public float won { get; set; }
        public float lost { get; set; }
        public float wonQ()
        {
            if (won != 0 || lost != 0)
            {
                var q = (won / (won + lost)) * 100;
                return q;
            }
            else
            {
                return 0;
            }
        }

        public Score()
        {
            won = 0;
            lost = 0;
        }
    }
}
