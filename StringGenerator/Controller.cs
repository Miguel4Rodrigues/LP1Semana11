using System;

namespace StringGenerator
{
    public class Controller
    {
        private readonly View _view = new View();

        public void Run(string[] args)
        {
            try
            {
                int seed = _view.ParseSeed(args);
                Model model = new Model(seed);
                model.Generate();
                _view.DisplayResult(model.Output);
            }
            catch (Exception ex)
            {
                _view.DisplayError(ex.Message);
                Environment.Exit(1);
            }
        }
    }
}