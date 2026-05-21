namespace StringGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new();
            controller.Run(args);
        }
    }
}