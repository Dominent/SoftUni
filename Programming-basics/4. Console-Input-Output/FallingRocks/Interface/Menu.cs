using System;
using FallingRocks.Logic;
using FallingRocks.Player;

//To DO : Implement Every menu in diferent method !

namespace FallingRocks.Interface
{
    class Menu
    {
        public void Main()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("| *******     *     *       *       ******* *       *   ****   |");
            Console.WriteLine("| *          * *    *       *          *    * *     *  *    *  |");
            Console.WriteLine("| *******   *****   *       *          *    *   *   * *        |");
            Console.WriteLine("| *        *     *  *       *          *    *     * *  *   *** |");
            Console.WriteLine("| *       *       * ******* ******* ******* *       *   *****  |");
            Console.WriteLine("|                                                              |");
            Console.WriteLine("|          ******     ****     ****** *    *   *****           |");
            Console.WriteLine("|          *     *   *    *   *       *   *   *                |");
            Console.WriteLine("|          ******   *      * *        ****      ****           |");
            Console.WriteLine("|          *   *     *    *   *       *   *         *          |");
            Console.WriteLine("|          *     *    ****     ****** *    *   *****           |");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("                      *   *  ***** *   * *   *");
            Console.WriteLine("                     *  *  * *___  **  * *   *");
            Console.WriteLine("                     *     * *     * * * *   *");
            Console.WriteLine("                     *     * ***** *   *  *** ");
            Console.WriteLine("                             1. New Game");
            Console.WriteLine("                             2. Options");
            Console.WriteLine("                             3. Exit");

            byte select = 0;
            select = Convert.ToByte(Console.ReadLine());

            NewGame newGame = new NewGame();
            User user = new User();

            switch (select)
            {
                case 1://New Game
                    {
                        Console.Clear();
                        //user.userName = "new User";
                        newGame.SinglePlayer();
                    }
                    break;
                case 2://Options
                    {
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("          C H O O S E   O P T I O N S :      ");
                            Console.WriteLine("                       1: View controls     ");
                            Console.WriteLine("                       2: Difficulty       ");
                            Console.WriteLine("                       3: Credits         ");


                            select = Convert.ToByte(Console.ReadLine());
                            switch (select)
                            {
                                case 1:
                                    {
                                        Controls();
                                        return;
                                    }
                                    break;
                                case 2:
                                    {
                                        Diffuculty();
                                        return;
                                    }
                                    break;
                                case 3:
                                    {
                                        Credits();
                                        return;
                                    }
                                    break;
                                default:
                                    {
                                        BadInput();
                                        return;
                                    }
                                    break;
                            }
                        }
                    }
                case 3:
                    {
                        Exit();
                    }
                    break;
                default:
                    {
                        BadInput();
                    }
                    break;
            }
        }

        public void MainMenu() { }
        public void Options() { }

        public void Credits()
        {
            char exit = '?';
            Console.Clear();
            while (true)
            {
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("               Lead programmers: Dominent and IvoryTailor");
                Console.WriteLine("               Designer: Dominent and IvoryTailor");
                Console.WriteLine("               Testers: Dominent , brat_mi, IvoryTailor, Bai_Nero");
                Console.WriteLine("               Special thanks to: Bai_Nero and brat_mi");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("Go back? [y/n]  ");

                exit = Convert.ToChar(Console.ReadLine());
                if (exit == 'y')
                    return;
            }
        }

        public void Controls()
        {
            char exit = '?';
            Console.Clear();
            while (true)
            {
                Console.WriteLine(" -------------------------------------------------");
                Console.WriteLine("|                                                |");
                Console.WriteLine("|            left - <-        -> - right         |");
                Console.WriteLine("|                                                |");
                Console.WriteLine(" -------------------------------------------------");
                Console.WriteLine("Go back? [y/n]  ");

                exit = Convert.ToChar(Console.ReadLine());
                if (exit == 'y')
                    return;
            }
        }
        public void GameOver() { }

        public void Diffuculty()
        {
            char exit = '?';
            Console.Clear();
            while (true)
            {
                Console.WriteLine("          C H O O S E   D I F F I C U L T Y :");
                Console.WriteLine("                       1: Easy        ");
                Console.WriteLine("                       2: Normal      ");
                Console.WriteLine("                       3: Hard        ");
                Console.WriteLine("                       4: Super Hard  ");
                Console.WriteLine("                       5: Impossible  ");
                Console.WriteLine("Go back? [y/n]  ");

                exit = Convert.ToChar(Console.ReadLine());
                if (exit == 'y')
                    return;
            }
        }

        public void Exit()
        {
            char exit = '?';
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Are you sure you want to exit the game ?[y/n]"); // ToDo add exit game menu
                exit = Convert.ToChar(Console.ReadLine());

                if (exit == 'y')
                {
                    //exit game
                }
                else
                {
                    //go back
                }
            }
        }

        public void BadInput()
        {
            char exit = '?';
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Something messed up !");
                Console.WriteLine("Go back? [y/n]  ");

                exit = Convert.ToChar(Console.ReadLine());
                if (exit == 'y')
                    return;
            }
        }
    }
}
