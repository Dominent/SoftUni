using System.Windows.Input;

namespace FallingRocks.Player
{
    class Move
    {
        public bool HasMovedLeft()
        {
            if (Keyboard.IsKeyDown(Key.A))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HasMovedRight()
        {
            if (Keyboard.IsKeyDown(Key.D))
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
