namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess the right number!");
            Console.WriteLine("What is the upper limit for the range of the number?");

            var userResponse = Console.ReadLine();

            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1, upperLimit);

            Console.WriteLine("Input your guess:");

            var guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Your guess is too high, sorry.");
            }
            else if (guess < number)
            {
                Console.WriteLine("Your guess is too low, try again.");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }

    }

    static void Main(string[] args)

    {
        Console.WriteLine("What is your favorite school subject?");

        var subject = Console.ReadLine(); //evaluate to a string

        switch (subject.ToLower())
        {
            case "Math":
                Console.WriteLine("Math is very difficult.");
                break;

            case "Science":
                Console.WriteLine("Science can be very interesting.");
                break;

            case "Latin":
                Console.WriteLine("Latin is very cool.");
                break;

            case "PE":
                Console.WriteLine("PE is good for the body.");
                break;

            case "English":
                Console.WriteLine("English can be boring sometimes.");
                break;

            default:
                Console.WriteLine("Oh interesting, I've never had that subject before. {subject} sounds fun.");
                break;
        }
    }
}
