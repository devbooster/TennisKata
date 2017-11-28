
namespace TennisKata
{

    public partial class TennisGame
    {
        private const int NumberOfSet = 1;
       
        public const string winthegame = " wins the game";
        public const string wintheset = " wins the set";
        public const string winthesetAndGame = " wins the set and the match";
        
            
        private bool OnePlayerHasMoreThan(int score)
        {
            return player1.BallWons > score || player2.BallWons > score;
        }

        private bool BothPlayersHas(int score)
        {
            return player1.BallWons >= score && player2.BallWons >= score;
        }

        private string LeadingPlayer()
        {
            return player1.BallWons > player2.BallWons ? "player1" : "player2";
        }

        private bool ScoreIsEqual()
        {
            return player1.BallWons == player2.BallWons;
        }

        private bool APlayerLeadByOneBall()
        {
            return player1.BallWons == player2.BallWons + 1 || player2.BallWons == player1.BallWons + 1;
        }

        private bool APlayerLeadByTwoOrMoreBalls()
        {
            return player1.BallWons >= player2.BallWons + 2 || player2.BallWons >= player1.BallWons + 2;
        }
        
        private bool IsTieBreack()
        {
            return player1.GamesWons == 6 && player2.GamesWons == 6;
        }

        public enum EScore :int
        {
            love = 0,
            fifteen =1,
            thirty=2,
            forty=3,
            deuce,
            advantage,
           
        }

        
    }
}
