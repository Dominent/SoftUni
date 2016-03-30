namespace FallingRocks.Logic
{
    class Collision
    {
        public bool Hit(int currPosRock,int currPosPlayer)
        {
            if (currPosRock == currPosPlayer ||
                currPosRock == currPosPlayer + 1 ||
                currPosRock == currPosPlayer - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
