namespace Utveckla_programmet
{
    internal class Program
    {
        
        
         class WordGuessingGame
         {
            static string[] wordsEasy = { "apple", "date", "pear", "banana", "cherry", "elderberry", "pineapple", "raspberry" };
            static string[] wordsNormal = { "toyota", "volvo", "mercedes", "lexus", "fiat", "ferrari"};
            static string[] wordsHard = { "fisherman", "scientist", "seismologist", "otolaryngolist", "amalgamator"};
            static Random random = new Random();
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("\nWord Guessing Game");
                    Console.WriteLine("1. Play Game");
                    Console.WriteLine("2. Exit");
                    Console.Write("Enter your choice: ");

                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.WriteLine("Choose difficulty: 1. Easy\n2. Normal\n3.Hard");
                        int difficultyChoice = Convert.ToInt32(Console.ReadLine());
                        switch(difficultyChoice)
                        {
                            case 1:
                                PlayGameEasy();
                                    break;
                            case 2:
                                PlayGameNormal();
                                break;
                            case 3:
                                PlayGameHard();
                                break;
                        }
                    }
                    else if (choice == "2")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }
                }
            }

            static void PlayGameEasy()
            {
                char exit = '!';
                string wordToGuess = wordsEasy[random.Next(wordsEasy.Length)];
                char[] guessedWord = new char[wordToGuess.Length];
                for (int i = 0; i < guessedWord.Length; i++)
                {
                    guessedWord[i] = '_';
                }

                List<string> hangMan = new List<string>();
                hangMan.Add(" +---+\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n=========");
                hangMan.Add(" +---+\r\n  |   |\r\n  O   |\r\n      |\r\n      |\r\n      |\r\n=========");
                hangMan.Add(" +---+\r\n  |   |\r\n  O   |\r\n  |   |\r\n      |\r\n      |\r\n=========");
                hangMan.Add(" +---+\r\n  |   |\r\n  O   |\r\n /|   |\r\n      |\r\n      |\r\n=========");
                hangMan.Add(" +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n      |\r\n      |\r\n=========");
                hangMan.Add(" +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n /    |\r\n      |\r\n=========");
                hangMan.Add(" +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n / \\  |\r\n      |\r\n=========");
                int attemptsLeft = 6;
                Console.WriteLine(hangMan[7 - attemptsLeft]);

                while (attemptsLeft > 0)
                {
                    Console.WriteLine($"\nWord: {new string(guessedWord)}");
                    Console.WriteLine($"Attempts left: {attemptsLeft}");
                    Console.Write("Guess a letter: ");
                    Console.WriteLine("Vill du ge upp tryck '!'");


                    char guess = Console.ReadLine().ToLower()[0];
                    bool correctGuess = false;

                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guess)
                        {
                            guessedWord[i] = guess;
                            correctGuess = true;
                        }
                    }
                    if (guess == exit)
                    {
                        Console.WriteLine($"The right word was { wordToGuess }");
                        return;
                    }
                    if (attemptsLeft == 3) 
                    {
                        attemptsLeft--;
                        Console.WriteLine("Hint its a fruit or berry");
                    
                    }
                    else if (!correctGuess)
                    {
                        attemptsLeft--;
                        Console.WriteLine("Incorrect guess!");
                    }

                    if (new string(guessedWord) == wordToGuess)
                    {
                        Console.WriteLine($"Congratulations! You guessed the word: {wordToGuess}");
                        return;
                    }
                    
                }

                Console.WriteLine($"Game over! The word was: {wordToGuess}");
            }
            static void PlayGameNormal()
            {
                char exit = '!';
                string wordToGuess = wordsNormal[random.Next(wordsNormal.Length)];
                char[] guessedWord = new char[wordToGuess.Length];
                for (int i = 0; i < guessedWord.Length; i++)
                {
                    guessedWord[i] = '_';
                }

                int attemptsLeft = 6;

                while (attemptsLeft > 0)
                {
                    Console.WriteLine($"\nWord: {new string(guessedWord)}");
                    Console.WriteLine($"Attempts left: {attemptsLeft}");
                    Console.Write("Guess a letter: ");
                    Console.WriteLine("Vill du ge upp tryck '!'");

                    char guess = Console.ReadLine().ToLower()[0];
                    bool correctGuess = false;

                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guess)
                        {
                            guessedWord[i] = guess;
                            correctGuess = true;
                        }
                    }
                    if (guess == exit)
                    {
                        Console.WriteLine($"The right word was {wordToGuess}");
                        return;
                    }
                    if (attemptsLeft == 3)
                    {
                        attemptsLeft--;
                        Console.WriteLine("Hint its a fruit or car brand");

                    }
                    else if (!correctGuess)
                    {
                        attemptsLeft--;
                        Console.WriteLine("Incorrect guess!");
                    }

                    if (new string(guessedWord) == wordToGuess)
                    {
                        Console.WriteLine($"Congratulations! You guessed the word: {wordToGuess}");
                        return;
                    }

                }

                Console.WriteLine($"Game over! The word was: {wordToGuess}");
            }
            static void PlayGameHard()
            {
                char exit = '!';
                string wordToGuess = wordsHard[random.Next(wordsHard.Length)];
                char[] guessedWord = new char[wordToGuess.Length];
                for (int i = 0; i < guessedWord.Length; i++)
                {
                    guessedWord[i] = '_';
                }

                int attemptsLeft = 7;

                while (attemptsLeft > 0)
                {
                    Console.WriteLine($"\nWord: {new string(guessedWord)}");
                    Console.WriteLine($"Attempts left: {attemptsLeft}");
                    Console.Write("Guess a letter: ");
                    Console.WriteLine("Vill du ge upp tryck '!'");
                    char guess = Console.ReadLine().ToLower()[0];
                    bool correctGuess = false;

                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guess)
                        {
                            guessedWord[i] = guess;
                            correctGuess = true;
                        }
                    }
                    
                    if (guess == exit)
                    {
                        Console.WriteLine($"The right word was {wordToGuess}");
                        return;
                    }
                    else if (!correctGuess)
                    {
                        attemptsLeft--;
                        Console.WriteLine("Incorrect guess!");
                    }

                    if (new string(guessedWord) == wordToGuess)
                    {
                        Console.WriteLine($"Congratulations! You guessed the word: {wordToGuess}");
                        return;
                    }

                }

                Console.WriteLine($"Game over! The word was: {wordToGuess}");
            }
        }
    }

}

