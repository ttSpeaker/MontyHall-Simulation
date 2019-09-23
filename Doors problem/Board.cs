using System;
using System.Collections.Generic;
using System.Text;

namespace montyhall
{
    class Board
    {
        public bool[] Doors { get; set;} 
        
        public int openDoor (int pickedDoor)
        {
            int i = 0;
            foreach (bool door in Doors)
            {
                if (i != pickedDoor && door == false)
                {
                    return i;
                }
                i++;
            }
            return 3;
        }

        public int changePick (int pickedDoor, int showedDoor)
        {
            int i = 0;
            foreach (bool door in Doors)
            {
                if (i != pickedDoor && i != showedDoor)
                {
                    return i;
                }
                i++;
            }
            return 3;
        }
        public Board()
        {
            var rand = new Random();
            Doors = new bool[] { false, false, false };
            var prizePosition = rand.Next(3);
            Doors[prizePosition] = true;
        }
    }
}
