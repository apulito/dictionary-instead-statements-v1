using Domain.v1;

namespace Console.Dictionary.v1
{
    internal class Program
    {
        static void Main()
        {
            var hitPointManager = new BasePointManager();
            var result = hitPointManager.GetHitPoint(PokemonType.WATER);
            System.Console.WriteLine($"The result of the operation managed with dictionary is {result}");
            System.Console.ReadKey();
        }
    }
}
