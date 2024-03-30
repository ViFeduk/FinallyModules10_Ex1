namespace FinallyModules10_Ex1
{
    internal class Program
    {
        static ILogger logger = new Logger();
        static void Main(string[] args)
        {
            var colculater = new Colculater(logger);
            colculater.WorkCalculate();
        }

    }
}
