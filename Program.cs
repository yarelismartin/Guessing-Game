// See https://aka.ms/new-console-template for more information

using System.Numerics;

Random randomNumber = new Random();


int secretNumber = randomNumber.Next(1, 100);

int numberGuess = 0;

int numberOfGussesAllowed = 0;
while(true)
{

    Console.WriteLine(@"Please Enter The Number For Your Difficulty Level:
        1. Easy 
        2. Medium 
        3. Hard 
        4. Cheater
");
    if (int.TryParse(Console.ReadLine(), out int selectedLevel) && selectedLevel >= 1 && selectedLevel <= 4)
    {
        switch(selectedLevel)
            {
        case 1:
            numberOfGussesAllowed = 8;
            break;
        case 2:
            numberOfGussesAllowed = 6;
            break;
        case 3:
            numberOfGussesAllowed = 4;
            break;
        case 4: 
            numberOfGussesAllowed = int.MaxValue;
            break;
        default:
            Console.WriteLine("Invalid Input.");
                break;
            }
        break;
    }
 else
    {
        Console.WriteLine("Invalid Input please enter a number within range.");
    }

}

Console.WriteLine("Guess the secret number");
while ( numberGuess < numberOfGussesAllowed) 
{
    if (int.TryParse(Console.ReadLine(), out int userGuess))
    { 
        if (userGuess == secretNumber)
        {
            Console.WriteLine("You are correct!");
            break;
        }
        else
        {
            GuessFeedback(secretNumber, userGuess);
            numberGuess++;
            GuessesLeft(numberOfGussesAllowed, numberGuess);
        }
    }
    else 
    {
        Console.WriteLine("This is an invalid input please enter a number only.");
    }
}

void GuessesLeft( int totalGuessesAllowed, int currentGuess)
{
    if(numberOfGussesAllowed == int.MaxValue)
    {
        Console.WriteLine("");
    }
    else
    {
    int leftOver = totalGuessesAllowed - currentGuess;
    Console.WriteLine($"You have {leftOver} guesses left.");

    }
}

void GuessFeedback( int answer, int guess)
{
    if( guess > answer )
    {
        Console.WriteLine("Your guess was too high.");
    }
    else
    {
        Console.WriteLine("Your guess was too low. ");
    }
}

