using System;
using System.Collections.Generic;

namespace Yahtzee
{
    class Die
    {
        public int Faces;
        public int FaceUp;
        public List<Die> dice = new List<Die>();
        private Random rnd=new Random();

        public Die(int faces)
        {
            this.Faces = faces;
            this.FaceUp = rnd.Next(1, faces); 
        }

        public Die(int faces, int faceUp)
        {
            
            this.FaceUp = faceUp;
        }

        public void Roll()
        {
            this.FaceUp= rnd.Next(1,this.Faces);

        }
    }
}
