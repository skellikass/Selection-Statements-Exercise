namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main()
        {
            #region Exercise 1
            var favNumber = 7;
            Console.WriteLine("Guess my favorite number.  You get 3 tries!");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
            {
                Console.WriteLine("too low. guess again!");
                var secondGuess = int.Parse(Console.ReadLine());
                if (secondGuess < favNumber)
                {
                    Console.WriteLine("too low. guess again!");
                    var thirdGuess = int.Parse(Console.ReadLine());
                    if (thirdGuess < favNumber || thirdGuess > favNumber)
                    {
                        Console.WriteLine("waaa waaaaa waaaaaaaa. sorry, no dice.");
                    }
                    else
                    {
                        Console.WriteLine("ding ding ding! you got it!");
                    }
                }
                else if (secondGuess > favNumber)
                {
                    Console.WriteLine("too high. guess again!");
                    var thirdGuess = int.Parse(Console.ReadLine());
                    if (thirdGuess < favNumber || thirdGuess > favNumber)
                    {
                        Console.WriteLine("waaa waaaaa waaaaaaaa. sorry, no dice.");
                    }
                    else
                    {
                        Console.WriteLine("ding ding ding! you got it!");
                    }
                }
                else
                {
                    Console.WriteLine("ding ding ding! you got it!");
                }
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high. guess again!");
                var secondGuess = int.Parse(Console.ReadLine());
                if (secondGuess < favNumber)
                {
                    Console.WriteLine("too low. guess again!");
                    var thirdGuess = int.Parse(Console.ReadLine());
                    if (thirdGuess < favNumber || thirdGuess > favNumber)
                    {
                        Console.WriteLine("waaa waaaaa waaaaaaaa. sorry, no dice.");
                    }
                    else
                    {
                        Console.WriteLine("ding ding ding! you got it!");
                    }
                }
                else if (secondGuess > favNumber)
                {
                    Console.WriteLine("too high. guess again!");
                    var thirdGuess = int.Parse(Console.ReadLine());
                    if (thirdGuess < favNumber || thirdGuess > favNumber)
                    {
                        Console.WriteLine("waaa waaaaa waaaaaaaa. sorry, no dice.");
                    }
                    else
                    {
                        Console.WriteLine("ding ding ding! you got it!");
                    }
                }
                else
                {
                    Console.WriteLine("ding ding ding! you got it!");
                }
            }
            else 
            {
                Console.WriteLine("ding ding ding! you got it!");
            }
            #endregion

            #region Exercise 2
            Console.WriteLine("What is your favorite school subject?");
            var favSchoolSubject = Console.ReadLine();
            switch (favSchoolSubject)
            {
                case "math":
                    Console.WriteLine("Your favorite school subject is math.");
                    break;
                case "science":
                    Console.WriteLine("Your favorite school subject is science.");
                    break;
                case "art":
                    Console.WriteLine("Your favorite school subject is art.");
                    break;
                case "history":
                    Console.WriteLine("Your favorite school subject is history.");
                    break;
                case "music":
                    Console.WriteLine("Your favorite school subject is music.");
                    break;
                default:
                    Console.WriteLine("Your favorite school subject is not math, science, art, history, or music.");
                    break;
            }
            #endregion 
        }
    }
}
