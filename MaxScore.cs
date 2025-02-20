namespace GuessingGame
{
    class MaxScore
    {
        private int score;
        private const int maxScore = 60;
        private const int penalty = 10;

        public MaxScore()
        {
            score = maxScore;
        }

        public void DeductPoints()
        {
            score -= penalty;
        }

        public int GetScore()
        {
            return score;
        }
    }
}