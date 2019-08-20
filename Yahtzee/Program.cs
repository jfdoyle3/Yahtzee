using System;
using System.Collections.Generic;

namespace Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
            Die die = new Die();
           
            List<Die> dice = die.Dice(6);

            foreach (var cube in dice)
                Console.WriteLine(cube.FaceUp);

           // int index=dice.FindIndex(item=> item.FaceUp == )
        }
    }
}
