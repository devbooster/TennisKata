using NUnit.Framework;

namespace TennisKata
{
    [TestFixture]
    public class TennisGameShould
    {
        private TennisGame tennis;

        [SetUp]
        public void Init()
        {
           tennis = new TennisGame();
        }

        [Test]
        public void Return_fifteen_love_If_Player1WinBall()
        {
           
            tennis.Player1WinsTheBall();
            Assert.AreEqual(tennis.DisplayScore(), "fifteen - love");

        }
                
        [Test]
        public void Return_Deuce_If_ThreeBallForEach()
        {
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            Assert.AreEqual(tennis.DisplayScore(), "deuce");
        }

        [Test]
        public void ReturnAdvantagePlayer2_If_PLayer2WonFourBall_And_Player1ThreeBall()
        {
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player2WinsTheBall();
            Assert.AreEqual(tennis.DisplayScore(), "advantage player2");
        }

        [Test]
        public void Return_Deuce_If_FourBallForEach()
        {
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player1WinsTheBall();
            Assert.AreEqual(tennis.DisplayScore(), "deuce");
        }

        [Test]
        public void Return_AdvantagePlayer2_If_PLayer2WonFiveBall_And_Player1FourBall()
        {
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            Assert.AreEqual(tennis.DisplayScore(), "advantage player2");
        }

        [Test]
        public void Return_Player2WinsTheGame_If_Player2LeadByTwoBall()
        {
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player1WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player2WinsTheBall();
            Assert.AreEqual(tennis.DisplayScore(), "player2 wins the game");
        }

       
        [Test]
        public void Return_Player1WinsTheGame_If_Player1HaveFortyAndPlayer2Love()
        {
            tennis.Player1WinsTheBall();
            tennis.Player1WinsTheBall();
            tennis.Player1WinsTheBall();
            tennis.Player1WinsTheBall();
            Assert.AreEqual(tennis.DisplayScore(), "player1 wins the game");
        }

        [Test]
        public void Return_player1winsthesetandthematch_If_Player1WonSixGames()
        {

            Player1WinsAGame();//1-0

            Player1WinsAGame();//2-0

            Player1WinsAGame();//3-0

            Player1WinsAGame();//4-0

            Player1WinsAGame();//5-0

            Player1WinsAGame();//6-0

            Assert.AreEqual(tennis.DisplayScore(), "player1 wins the set and the match");

        }

        [Test]
        public void Return_6_7_when_ItsTiebreack()
        {

            tennis = new TennisGame();

            Player1WinsAGame();//1-0

            Player1WinsAGame();//2-0

            Player1WinsAGame();//3-0

            Player1WinsAGame();//4-0

            Player1WinsAGame();//5-0


            Player2WinsAGame();//5-1

            Player2WinsAGame();//5-2

            Player2WinsAGame();//5-3

            Player2WinsAGame();//5-4

            Player2WinsAGame();//5-5

            Player1WinsAGame();//6-5

            Player2WinsAGame();//6-6

            //TIEBreack
            tennis.Player1WinsTheBall();//1-0
            tennis.Player1WinsTheBall();//2-0
            tennis.Player1WinsTheBall();//3-0
            tennis.Player1WinsTheBall();//4-0
            tennis.Player1WinsTheBall();//5-0
            tennis.Player2WinsTheBall();//5-1
            tennis.Player2WinsTheBall();//5-2
            tennis.Player2WinsTheBall();//5-3
            tennis.Player2WinsTheBall();//5-4
            tennis.Player2WinsTheBall();//5-5
            tennis.Player2WinsTheBall();//5-6
            tennis.Player1WinsTheBall();//6-6
            tennis.Player2WinsTheBall();//6-7


            Assert.AreEqual(tennis.DisplayScore(), "6 - 7");

        }

        [Test]
        public void Return_player1winsthesetandthematchWhenPalyer1WonTheTieBreack()
        {

            Player1WinsAGame();//1-0

            Player1WinsAGame();//2-0

            Player1WinsAGame();//3-0

            Player1WinsAGame();//4-0

            Player1WinsAGame();//5-0

            Player2WinsAGame();//5-1

            Player2WinsAGame();//5-2

            Player2WinsAGame();//5-3

            Player2WinsAGame();//5-4

            Player2WinsAGame();//5-5

            Player1WinsAGame();//6-5

            Player2WinsAGame();//6-6

            //TIEBreack
            tennis.Player1WinsTheBall();//1-0
            tennis.Player1WinsTheBall();//2-0
            tennis.Player1WinsTheBall();//3-0
            tennis.Player1WinsTheBall();//4-0
            tennis.Player1WinsTheBall();//5-0
            tennis.Player2WinsTheBall();//5-1
            tennis.Player2WinsTheBall();//5-2
            tennis.Player2WinsTheBall();//5-3
            tennis.Player2WinsTheBall();//5-4
            tennis.Player2WinsTheBall();//5-5
            tennis.Player2WinsTheBall();//6-5
            tennis.Player1WinsTheBall();//6-6
            tennis.Player2WinsTheBall();//6-7
            tennis.Player1WinsTheBall();//7-7
            tennis.Player1WinsTheBall();//8-7
            tennis.Player1WinsTheBall();//9-7

            Assert.AreEqual(tennis.DisplayScore(), "player1 wins the set and the match");

        }

        private void Player1WinsAGame()
        {
            tennis.Player1WinsTheBall();
            tennis.Player1WinsTheBall();
            tennis.Player1WinsTheBall();
            tennis.Player1WinsTheBall();
        }

        private void Player2WinsAGame()
        {
            tennis.Player2WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player2WinsTheBall();
            tennis.Player2WinsTheBall();
        }
    }
}
