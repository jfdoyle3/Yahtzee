using System;
using System.Collections.Generic;
using System.Text;

namespace Yahtzee
{
    class Die
    {
        public int Faces;
        public int FaceUp;
        public List<Die> dice = new List<Die>();
       
        public Die()
        {
            Random cast = new Random();
            this.Faces = 6;
            this.FaceUp = cast.Next(1, 6); 
        }

        public Die( int faceUp)
        {
 
            this.FaceUp = faceUp;
        }

        public List<Die> Dice(int count)
        {
            for (int cast = 1; cast < count; cast++)
            {
                Die die = new Die();
                dice.Add(die); 
            }
            return dice;
        }
    }
}
