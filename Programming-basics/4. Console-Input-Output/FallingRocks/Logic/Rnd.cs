using System;

namespace FallingRocks.Logic
{
    class Rnd
    {
        Random random = new Random(); // add seed maybe

        public int Generate(int min, int max)
        {
            int randNum = random.Next(min, max);
            return randNum;
        }
    }
}
