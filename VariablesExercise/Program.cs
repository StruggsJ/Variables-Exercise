namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myString = "This string of words";
            int numberWords = 3;
            char startingLetter = 'J';
            bool isTrue = true;
            double myDouble = 12.60;
            decimal maxSpend = 30.00m;

            Console.WriteLine($"{myString} has more than {numberWords} words.");
            //To-Do: See if it is possible to convert boolean to string in order to force lowercasing via ToLower()
            Console.WriteLine($"While it is {isTrue} that my name starts with the letter {startingLetter}," +
                $" I do not want to spend more than ${maxSpend} for sheets of paper."); 
            Console.WriteLine($"For ${myDouble}, I can buy a handful of snacks, however.");
        }
    }
}
