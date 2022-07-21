using Domain.v1;

namespace Console.IfElse.v1
{
    public class BasePointManager
    {
        /// <summary>
        /// Use of if-else ladder
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int GetHitPoint(PokemonType value)
        {
            var point = 0;

            if (value == PokemonType.NORMAL)
            {
                point = 1;
            }
            else if (value == PokemonType.GRASS)
            {
                point = 2;
            }
            else if (value == PokemonType.ELECTRIC)
            {
                point = 3;
            }
            else if (value == PokemonType.WATER)
            {
                point = 4;
            }
            else if (value == PokemonType.FIRE)
            {
                point = 5;
            }
            else if (value == PokemonType.BUG)
            {
                point = 6;
            }

            // and soo on

            return point;
        }
    }
}
