using System;

class BasketBattle
{
    #region TrackPoints
    static bool TrackPoints(string playerName, ref int trackPoints, int i, int nextPlayerPoints)
    {
        int score;
        string input;
                
        score = Convert.ToInt32(Console.ReadLine());
        input = Console.ReadLine();

        if (input == "success")
        {
            if (trackPoints + score == 500)
            {
                trackPoints += score;
                Console.Write("{0} \n{1}\n{2}", playerName, (i + 1), nextPlayerPoints);
                return true;
            }
            else if (trackPoints + score < 500)
            {
                trackPoints += score;
            }
        }
        return false;
    }
    #endregion

    #region Switch
    static void Switch(ref int playerOnePoints, ref int playerTwoPoints,
                                ref string playerOne, ref string playerTwo)// pass by reference
    {
        int tempVal = playerOnePoints;
        playerOnePoints = playerTwoPoints;
        playerTwoPoints = tempVal;

        string tempString = playerOne;
        playerOne = playerTwo;
        playerTwo = tempString;
    }
    #endregion

    static void Main()
    {
        string playerOne;
        int trackPointsPlayerOne = 0;
        string playerTwo;
        int trackPointsPlayerTwo = 0;
        int? rounds;

        playerOne = Console.ReadLine();
        rounds = Convert.ToInt32(Console.ReadLine());

        if (playerOne == "Simeon")
        {
            playerTwo = "Nakov";
        }
        else
        {
            playerTwo = "Simeon";
        }
        for (int i = 0; i < rounds; ++i)
        {
            if (TrackPoints(playerOne, ref trackPointsPlayerOne, i, trackPointsPlayerTwo))
            {
                break;
            }
            if (TrackPoints(playerTwo, ref trackPointsPlayerTwo, i, trackPointsPlayerOne))
            {
                break;
            }
            if (trackPointsPlayerOne == trackPointsPlayerTwo)
            {
                Console.WriteLine("DRAW!\n{0}", trackPointsPlayerOne);
            }
            Switch(ref trackPointsPlayerOne, ref trackPointsPlayerTwo, ref playerOne, ref playerTwo);
        }
    }
}

