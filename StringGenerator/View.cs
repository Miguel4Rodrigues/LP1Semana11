using System;

namespace StringGenerator
{
    public class View
    {
        public int ParseSeed(string[] args)
        {
            if (args.Length == 0)
            {
                throw new ArgumentException("No seed provided");
            }

            if (!int.TryParse(args[0], out int seed))
            {
                throw new ArgumentException("Nope");
            }

            return seed;
        }

        public void DisplayResult(string result)
        {
            Console.WriteLine(result);
        }

        public void DisplayError(string message)
        {
            Console.Error.WriteLine(message);
        }
    }
}