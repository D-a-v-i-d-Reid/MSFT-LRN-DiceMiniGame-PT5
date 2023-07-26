namespace DiceMiniGame;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        Console.WriteLine("Would you like to play? (Y/N)");
        if (ShouldPlay())
        {
            PlayGame();
        }
    }
    static bool ShouldPlay()
    {
        string? response = Console.ReadLine();
        return response != null && response.ToLower().Equals("y");
    }

    static void PlayGame()
    {
        var play = true;

        while (play)
        {
            var target = GetTarget();
            var roll = RollDice();

            Console.WriteLine($"Roll a number greater than {target} to win!");
            Console.WriteLine($"You rolled a {roll}");
            Console.WriteLine(WinOrLose(roll, target));
            Console.WriteLine("\nPlay again? (Y/N)");

            play = ShouldPlay();

        }

        static int GetTarget()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }

        int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        string WinOrLose(int roll, int target)
        {
            if (roll > target)
            {
                return "You Win!";
            }
            return "You Lose!";
        }



    }




}

