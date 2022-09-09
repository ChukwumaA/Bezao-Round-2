Random RandomNumber = new Random();
int answer = RandomNumber.Next(1, 100);
Console.WriteLine("I am thinking of a number between 1-100. Can you guess what it is?");

int guess = 0;
int guessCount = 0;

while (guess != answer)
{
    guessCount++;
    guess = Convert.ToInt32(Console.ReadLine());

    if (guess == answer)
    {
        Console.WriteLine($"Well done! The answer was { answer } and you found it in { guessCount } guesses");
    }
    else if (guess != answer)
    {
        if (guess < answer)
            {
                Console.WriteLine($"No, the number I am thinking of is higher than { guess }. Can you guess what it is?");
            }
        else if (guess > answer)
        {
            Console.WriteLine($"No, the number I am thinking of is lower than { guess }. Can you guess what it is?");
        }
    }
}