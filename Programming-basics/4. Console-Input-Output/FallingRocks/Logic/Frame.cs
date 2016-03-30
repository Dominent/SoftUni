using System;
using System.Threading;
using FallingRocks.Entities;
using FallingRocks.Player;

namespace FallingRocks.Logic
{
    internal class Frame
    {
        private const int RefreshRate = 150;
        private const int MaxHeight = 15; //x
        private const int MaxWidth = 64; //y


        public void DrawCore() // Draws the inner part
        {
            User player = new User();
            Move move = new Move();
            Rocks rocks = new Rocks();
            Rnd rnd = new Rnd();
            Collision collision = new Collision();

            int temp = 0;
            char[] tempArr = player.SetTexture().ToCharArray();
            char[,] viewSpace;
            viewSpace = new char[MaxHeight, MaxWidth];
            player.CurrPos = (MaxWidth / 2) - 1;


            #region Fill View Space
            for (int x = 0; x < MaxHeight; ++x)
            {
                for (int y = 0; y < MaxWidth; ++y)
                {
                    if (x == MaxHeight - 1 &&
                        (y <= (MaxWidth / 2) && y >= (MaxWidth / 2) - 2))
                    {
                        viewSpace[x, y] = tempArr[temp];
                        ++temp;
                    }
                    else
                    {
                        viewSpace[x, y] = ' ';
                    }
                }
            }
            #endregion

            #region Print View Space

            while (true)
            {
                for (var d = 0; d < MaxHeight - 1; ++d)
                {
                    rocks.Generate(viewSpace);

                    for (var i = 0; i < MaxWidth; ++i)
                    {
                        rocks.Move(d, i, viewSpace);

                        if ((!collision.Hit(player.CurrPos, rocks.CurrPos)) && player.Lives != 0)
                        {
                            for (var x = 0; x < MaxHeight; ++x)
                            {
                                for (var y = 0; y < MaxWidth; ++y)
                                {
                                    #region PlayerMovement
                                    if (move.HasMovedLeft())
                                    {
                                        Thread.Sleep(50);
                                        if (player.CurrPos > 1)
                                        {
                                            viewSpace[MaxHeight - 1, player.CurrPos - 1] = ' ';
                                            viewSpace[MaxHeight - 1, player.CurrPos] = ' ';
                                            viewSpace[MaxHeight - 1, player.CurrPos + 1] = ' ';

                                            --player.CurrPos;
                                            viewSpace[MaxHeight - 1, player.CurrPos - 1] = tempArr[0];
                                            viewSpace[MaxHeight - 1, player.CurrPos] = tempArr[1];
                                            viewSpace[MaxHeight - 1, player.CurrPos + 1] = tempArr[2];
                                        }
                                        else if (player.CurrPos == 1) //Prevent Index out of Range.
                                        {
                                            viewSpace[MaxHeight - 1, player.CurrPos - 1] = tempArr[0];
                                            viewSpace[MaxHeight - 1, player.CurrPos] = tempArr[1];
                                            viewSpace[MaxHeight - 1, player.CurrPos + 1] = tempArr[2];
                                        }
                                    }
                                    else if (move.HasMovedRight())
                                    {
                                        Thread.Sleep(50);
                                        if (player.CurrPos < MaxWidth - 2)
                                        {
                                            viewSpace[MaxHeight - 1, player.CurrPos - 1] = ' ';
                                            viewSpace[MaxHeight - 1, player.CurrPos] = ' ';
                                            viewSpace[MaxHeight - 1, player.CurrPos + 1] = ' ';

                                            ++player.CurrPos;
                                            viewSpace[MaxHeight - 1, player.CurrPos - 1] = tempArr[0];
                                            viewSpace[MaxHeight - 1, player.CurrPos] = tempArr[1];
                                            viewSpace[MaxHeight - 1, player.CurrPos + 1] = tempArr[2];
                                        }
                                        else if (player.CurrPos == MaxWidth - 2) //Prevent Index out of Range.
                                        {
                                            viewSpace[MaxHeight - 1, player.CurrPos - 1] = tempArr[0];
                                            viewSpace[MaxHeight - 1, player.CurrPos] = tempArr[1];
                                            viewSpace[MaxHeight - 1, player.CurrPos + 1] = tempArr[2];
                                        }
                                    }
                                    Console.Write(viewSpace[x, y]);
                                    #endregion
                                }
                                Console.WriteLine();
                            }
                            Thread.Sleep(RefreshRate);
                            Console.Clear();
                        }
                        else if (player.Lives == 0)
                        {
                            return; // here quit the program and dispaly GameOver Screen
                        }
                        else
                        {
                            --player.Lives;
                        }
                    }
                }
            }
            #endregion
        }
    }
}



