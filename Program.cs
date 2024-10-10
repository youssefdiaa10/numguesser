namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isCorrect = false, flag;

            Random random = new();

            int randomNum, guessNum, minValue, maxValue;

            Console.WriteLine("Welcome to the Number Guessing Game!");            
            Console.WriteLine("A number between 1 and 10 will be generated.");           
            Console.WriteLine("If you guess the correct number, you win!");

            Console.WriteLine("");

            do
            {
                Console.WriteLine("Enter your min value (a valid one):");
                flag = int.TryParse(Console.ReadLine(), out minValue);
            } while (!flag);

            do
            {
                Console.WriteLine("Enter your max value (a valid one):");
                flag = int.TryParse(Console.ReadLine(), out maxValue);
            } while (!flag);


            randomNum = random.Next(minValue,maxValue + 1);

            Console.WriteLine("");

            while (!isCorrect)
            {
                do
                {
                    Console.WriteLine("Enter your guessing number (a valid one):");
                    flag = int.TryParse(Console.ReadLine(), out guessNum);
                } while (!flag);


                if (guessNum > randomNum)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Your guessing number is higher.");
                }

                else if (guessNum < randomNum)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Your guessing number is lower.");
                }
                
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("****************************************************");
                    Console.WriteLine("Your guessing number is Correct.");
                    Console.WriteLine($"Your number: {guessNum}");
                    Console.WriteLine($"The Range: [{minValue} - {maxValue}]");
                    isCorrect = true;
                }
            }
            
            Console.ReadKey();
        }
    }
}
