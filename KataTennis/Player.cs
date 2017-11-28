
namespace TennisKata
{
    public class Player
    {
        public int BallWons { get; set; }
        public int GamesWons { get; set; }
        public int SetWons { get; set; }
        public string Name { get; set; }
        
        public Player(string name)
        {
            Name = name;
        }
    }
}
