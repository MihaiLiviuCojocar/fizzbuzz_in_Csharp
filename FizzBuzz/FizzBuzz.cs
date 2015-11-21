using System;

public class FizzBuzz
{
    public bool IsDivisibleByThree(int number)
    {
        return number % 3 == 0;
    }

    public bool IsDivisibleByFive(int number)
    {
        return number % 5 == 0;
    }

    public bool IsDivisibleByFifteen(int number)
    {
        return number % 15 == 0;
    }

    public string Play(int number)
    {
        return "Fizz";
    }
}
