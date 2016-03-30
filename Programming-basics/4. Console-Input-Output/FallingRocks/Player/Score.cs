using System.IO;

namespace FallingRocks.Player
{
    class Score
    {
       
        public void Write(string input)
        {
            StreamWriter write;
            const string filePath = "score.txt";

            if (File.Exists(filePath))
            {
                write = File.AppendText(filePath);// research
            }
            else
            {
                File.Create(filePath);
                write = new StreamWriter(filePath);
            }

            write.WriteLine(input);
            write.Close();
        }
    }
}
