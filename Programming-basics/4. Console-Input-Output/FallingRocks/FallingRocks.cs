using System;
using FallingRocks.Interface;

namespace FallingRocks
{
    class FallingRocks
    {
        [STAThread]
        /*Need to research this !
        Keyboard.IsKeyDown  
        The calling thread must be STA, 
        because many UI components require this*/
        static void Main()
        {
            Console.SetWindowSize(64, 30);

            Menu menu = new Menu();

            while (true)
            {
                menu.Main();
            }
        }
    }
}
