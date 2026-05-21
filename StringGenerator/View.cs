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

            return int.Parse(args[0]);
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