using System;
using System.Collections.Generic;

namespace Yahtzee
{
    class Die
    {
        public int Faces;
        public int FaceUp;
        public List<Die> dice = new List<Die>();
       
        public Die(int faces)
        {
            Random cast = new Random();
            this.Faces = faces;
            this.FaceUp = cast.Next(1, faces); 
        }

        public Die(int faces, int faceUp)
        {
            
            this.FaceUp = faceUp;
        }

        


    }
}
