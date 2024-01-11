namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myString = "James";
            Console.WriteLine(myString);

            int myNumber = 7;
            Console.WriteLine(myNumber);

            char myChar = 'A';
            Console.WriteLine(myChar);

            bool myBool = false;
            Console.WriteLine(myBool);

            double myDouble = 1.10;
            Console.WriteLine(myDouble);

            decimal myDecimal = 2.11m;
            Console.WriteLine(myDecimal);

            Console.WriteLine($"My friend {myString} was dreaming around {myNumber} that he had a {myChar} in science class. Measuring out a substance for his final came up to {myDecimal}," +
                $" suddenly in his dream the glass slipped from his hand and right before it hit the ground he woke up. He came to the realization that his dream was {myBool} and that his gpa was a {myDouble} so he went back to sleep to try it again.");

        }
    }
}
