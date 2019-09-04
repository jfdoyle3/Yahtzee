using System;
using System.Collections.Generic;
using System.Text;

namespace Yahtzee
{
    class Game
    {
        // int rollCount = 0;
        public List<Die> playerDice=new List<Die>();
        public void Play()
        {

            for (int rollDice = 0; rollDice < 5; rollDice++)
                    playerDice.Add(new Die(6));


            for (int i = 0; i < 3; i++)
            {

                Roll();

                Output();
            }
        }
        public void Roll()
        { 
           for (int rollnum = 0; rollnum < playerDice.Count; rollnum++)
              playerDice[rollnum].Roll();    
        }
        
        public void Output()
        {
            Console.Write("Roll:    ");

            for (int die = 0; die < playerDice.Count; die++)
            {
                Console.Write("{0} ", playerDice[die].FaceUp);

            }
            Console.WriteLine();
            //Console.Write("Choice:  ");
            //for (int opt = 0; opt < playerDice.Count; opt++)
            //{
            //    Console.Write("{0} ", opt);
            //}



            //Console.WriteLine("\n-----------------------------\n");
            //Console.WriteLine("Roll Count: {0}", rollCount);
        }
    }
}
