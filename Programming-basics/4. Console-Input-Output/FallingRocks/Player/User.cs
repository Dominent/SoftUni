namespace FallingRocks.Player
{
    class User
    {
        private string _texture;
        public string userName { get; set; }
        public int CurrPos { get; set; }
        public int Lives = 1; 

        public string SetTexture()
        {
            _texture = "(0)";
            return _texture;
        }
    }
}
