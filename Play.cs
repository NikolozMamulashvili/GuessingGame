namespace GuessingGame
{
    class Game
    {
        public void Play()
        {
            GuessingGame guessingGame = new GuessingGame();
            MaxScore maxScore = new MaxScore();
            int numberToGuess = guessingGame.GenerateNumber();
            int userGuess = 0;
            int numberOfGuesses = 0;
            int maxAttempts = 6;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine($"You have a maximum of {maxAttempts} attempts and a maximum score of 60 points.");

            while (userGuess != numberToGuess && numberOfGuesses < maxAttempts)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out userGuess))
                {
                    numberOfGuesses++;

                    if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("Too low! Try again.");
                        maxScore.DeductPoints();
                    }
                    else if (userGuess > numberToGuess)
                    {
                        Console.WriteLine("Too high! Try again.");
                        maxScore.DeductPoints();
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the number in {numberOfGuesses} attempts.");
                    }
                }
                else
                {
                    Console.WriteLine("Error try again");
                }
            }

            if (userGuess != numberToGuess)
            {
                Console.WriteLine($"You've used all {maxAttempts} attempts. The number was {numberToGuess}.");
            }

            Console.WriteLine($"Your final score is: {maxScore.GetScore()}");
        }
    }
}