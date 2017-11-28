
namespace TennisKata
{

    public partial class TennisGame
    {
        private string Score { get; set; }

        private readonly Player player1 = new Player("player1");
        private readonly Player player2 = new Player("player2");
        
        public void Player1WinsTheBall()
        {
            player1.BallWons++;

            Score = IsTieBreack() ? GetScoreTieBreak() : GetScoreGame();

            GetScoreMatch(player1, player2);

        }
        public void Player2WinsTheBall()
        {
            player2.BallWons++;

            Score = IsTieBreack() ? GetScoreTieBreak() : GetScoreGame();

            GetScoreMatch(player2, player1);
        }
        private string GetScoreGame()
        {
            if (OnePlayerHasMoreThan((int)EScore.forty) && APlayerLeadByTwoOrMoreBalls())
                return LeadingPlayer() + winthegame;

            if (BothPlayersHas((int)EScore.forty) && ScoreIsEqual())
                return EScore.deuce.ToString();

            if (BothPlayersHas((int)EScore.forty) && APlayerLeadByOneBall())
                return EScore.advantage.ToString() + " " + LeadingPlayer();

            return string.Format("{0} - {1}", (EScore)player1.BallWons, (EScore)player2.BallWons);
        }
        private string GetScoreTieBreak()
        {
            if (OnePlayerHasMoreThan(6) && APlayerLeadByTwoOrMoreBalls())
                return LeadingPlayer() + winthegame;

            return string.Format("{0} - {1}", player1.BallWons, player2.BallWons);
        }
        private void GetScoreMatch(Player playerOne, Player playerTwo)
        {
            if (Score == playerOne.Name + winthegame)
            {
                playerOne.GamesWons++;
                player1.BallWons = player2.BallWons = 0;
            }
            if (playerOne.GamesWons > 5 && playerOne.GamesWons - playerTwo.GamesWons > 1 || (playerOne.GamesWons == 7 && playerTwo.GamesWons == 6))
            {
                Score = playerOne.Name + wintheset;
                playerOne.SetWons++;
                player1.GamesWons = player2.GamesWons = 0;

            }
            if (playerOne.SetWons == NumberOfSet)
            {
                Score = playerOne.Name + " wins the set and the match";
            }
        }

        public string DisplayScore()
        {
            return Score;
        }
    }

}
