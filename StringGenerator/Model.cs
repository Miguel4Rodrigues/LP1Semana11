using System;
using System.Text;

namespace StringGenerator
{
    public class Model
    {
        private const string Chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public int Seed { get; }
        public int Length { get; }
        public string Output { get; private set; } = string.Empty;

        public Model(int seed, int length = 16)
        {
            Seed = seed;
            Length = length;
        }

        public void Generate()
        {
            Random rng = new Random(Seed);
            StringBuilder builder = new StringBuilder(Length);

            for (int i = 0; i < Length; i++)
            {
                int index = rng.Next(Chars.Length);
                builder.Append(Chars[index]);
            }

            Output = builder.ToString();
        }
    }
}