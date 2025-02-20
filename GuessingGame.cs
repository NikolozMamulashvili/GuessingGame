namespace GuessingGame;


class GuessingGame
{
    private Random random = new Random();

    public int GenerateNumber()
    {
        return random.Next(1, 101);
    }
}
