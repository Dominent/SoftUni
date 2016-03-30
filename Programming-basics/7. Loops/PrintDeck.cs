using System;

/*♣♦♥♠*/ //2,3,4,5,6,7,8,9,10,J,Q,K,A

internal class PrintDeck
{
    private static void Main()
    {
        char cardType = ' ';
        string cardRank = "?";

        for (int i = 2; i < 15; ++i)
        {
            switch (i)
            {
                case 11:
                    cardRank = "J";
                    break;
                case 12:
                    cardRank = "Q";
                    break;
                case 13:
                    cardRank = "K";
                    break;
                case 14:
                    cardRank = "A";
                    break;
                default:
                    cardRank = i.ToString();
                    break;
            }
            for (int u = 0; u < 4; ++u)
            {
                switch (u)
                {
                    case 0:
                        cardType = '♣';
                        Console.Write("{0}{1} ", cardRank, cardType);
                        break;
                    case 1:
                        cardType = '♦';
                        Console.Write("{0}{1} ", cardRank, cardType);
                        break;
                    case 2:
                        cardType = '♥';
                        Console.Write("{0}{1} ", cardRank, cardType);
                        break;
                    case 3:
                        cardType = '♠';
                        Console.Write("{0}{1} ", cardRank, cardType);
                        break;
                    default:
                        Console.WriteLine("Pi4 kakvo pravish ?");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}


