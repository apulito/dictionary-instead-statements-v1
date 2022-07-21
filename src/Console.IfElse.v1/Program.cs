using Domain.v1;

namespace Console.IfElse.v1
{
    internal class Program
    {
        static void Main()
        {
            var hitPointManager = new BasePointManager();
            var result = hitPointManager.GetHitPoint_with_if(PokemonType.WATER);
            System.Console.WriteLine($"The result of the operation managed with if else ladder is {result}");
            System.Console.ReadKey();
        }
    }
}