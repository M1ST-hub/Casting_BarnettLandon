namespace Casting_BarnettLandon
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            // Asks question 1
            Console.WriteLine("Please input a whole number. Your favorite or a significant number");

            //Favorite Number var and user input
            int favNumber = Convert.ToInt32(Console.ReadLine());

            //Responds to answer
            Console.WriteLine($"Your special number is {favNumber}");

            //Asks question 2
            Console.WriteLine("Have you ever played Apex Legends? Answer with true(yes) or false(no)");

            //User input true or false
            bool isTrue = Convert.ToBoolean(Console.ReadLine());

            //Responds to user
            Console.WriteLine($"It is {isTrue}, I have played Apex Legends before.");

        }
    }
}