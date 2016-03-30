using System;

class TorrentPirate
{
    static void Main()
    {
        int d;
        int p = 0;
        int w = 0;
        int movieSizeMB = 1500;
        d = Convert.ToInt32(Console.ReadLine());
        p = Convert.ToInt32(Console.ReadLine());
        w = Convert.ToInt32(Console.ReadLine());

        double downloadTime = (((double)d / 2.0d) / 60.0d) / 60.0d;
        double priceDownload = downloadTime * w;
        double moviesToDownload = (double)d / movieSizeMB;
        double cinemaPrice = moviesToDownload * p;
        if (priceDownload > cinemaPrice)
        {
            Console.WriteLine("cinema -> {0:0.00}lv", cinemaPrice);
        }
        else
        {
            Console.WriteLine("mall -> {0:0.00}lv", priceDownload);
        }
    }
}

