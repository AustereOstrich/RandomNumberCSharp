using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRandomsToGenerate = 1;

            if (args.Length > 0) {
                try {
                    int.TryParse(args[0], out numberRandomsToGenerate);
                    if (numberRandomsToGenerate < 1) {
                        Console.WriteLine("Please enter a valid number greater than 0 and rerun this application.");
                        return;
                    }
                } catch (Exception e) {
                    Console.WriteLine("Please enter a valid number greater than 0 and rerun this application.");
                }
            }
            for (int i = 0; i < numberRandomsToGenerate; i++) {
                Random random = new Random();
                int randomInt = random.Next();
                Console.WriteLine(randomInt);
            }
        }
    }
}
