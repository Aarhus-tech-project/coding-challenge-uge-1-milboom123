class NumberGenerator
{
    public int number;
    public int minNumber;
    public int maxNumber;

    public NumberGenerator(int min, int max)
    {
        minNumber = min;
        maxNumber = max;
    }

    public int Generate()
    {
        Random rand = new Random();

        int number = rand.Next(minNumber, maxNumber + 1);

        return number;
    }
}