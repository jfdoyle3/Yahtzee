using System;
using System.Collections.Generic;
using System.Text;

namespace Yahtzee
{
    class Game
    {
        public void Play()
        {

            int rollCount = 0;
            List<Die> playerRoll=Roll(5);
           
            Console.Write("Roll:    ");

            for (int die=0; die<playerRoll.Count; die++)
            {
                Console.Write("{0} ",playerRoll[die].FaceUp);

            }
            Console.WriteLine();
            Console.Write("Choice:  ");
            for (int opt = 0; opt < playerRoll.Count; opt++)
            {
                Console.Write("{0} ", opt);
            }



            Console.WriteLine("\n-----------------------------\n");
            Console.WriteLine("Roll Count: {0}",rollCount);
        }
        public  List<Die> Roll(int dieCount)
        {
            List<Die> roll = new List<Die>();
                for (int rollnum = 0; rollnum < dieCount; rollnum++)
                {
                    Die dice = new Die(6);
                    roll.Add(dice);
                }
            return roll;    
        }
    }
}
