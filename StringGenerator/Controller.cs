using System;

namespace StringGenerator
{
    public class Controller
    {
        private readonly View _view = new();

        public static void Run(string[] args)
        {
            try
            {
                int seed = View.ParseSeed(args);
                Model model = new(seed);
                model.Generate();
                View.DisplayResult(model.Output);
            }
            catch (Exception ex)
            {
                View.DisplayError(ex.Message);
                Environment.Exit(1);
            }
        }
    }
}