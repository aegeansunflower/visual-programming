using System;

class Craps
{
    private enum Status { Continue, Won, Lost }

    private enum DiceNames
    {
        SnakeEyes = 2,
        Trey = 3,
        Seven = 7,
        YoLeven = 11,
        BoxCars = 12
    }

    static void Main()
    {
        Status gameStatus = Status.Continue;
        int myPoint = 0;
        int sumOfDice = RollDice();

        switch ((DiceNames)sumOfDice)
        {
            case DiceNames.Seven:
            case DiceNames.YoLeven:
                gameStatus = Status.Won;
                break;
            case DiceNames.SnakeEyes:
            case DiceNames.Trey:
            case DiceNames.BoxCars:
                gameStatus = Status.Lost;
                break;
            default:
                gameStatus = Status.Continue;
                myPoint = sumOfDice;
                Console.WriteLine($"Puanınız: {myPoint}");
                break;
        }

        while (gameStatus == Status.Continue)
        {
            sumOfDice = RollDice();

            if (sumOfDice == myPoint)
                gameStatus = Status.Won;
            else if (sumOfDice == (int)DiceNames.Seven)
                gameStatus = Status.Lost;
        }

        if (gameStatus == Status.Won)
            Console.WriteLine("Oyuncu kazandı!");
        else
            Console.WriteLine("Oyuncu kaybetti.");
    }

    static int RollDice()
    {
        Random randomNumbers = new Random();
        int die1 = randomNumbers.Next(1, 7);
        int die2 = randomNumbers.Next(1, 7);
        int sum = die1 + die2;
        Console.WriteLine($"Oyuncu attı: {die1} + {die2} = {sum}");
        return sum;
    }
}
