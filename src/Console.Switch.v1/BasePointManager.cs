using Domain.v1;

namespace Console.Switch.v1
{
    internal class BasePointManager
    {
        /// <summary>
        /// Use switch statements
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int GetHitPoint_with_switch(PokemonType value)
        {
            var point = 0;

            switch (value)
            {
                case PokemonType.NORMAL:
                    point = 1;
                    break;
                case PokemonType.GRASS:
                    point = 2;
                    break;
                case PokemonType.ELECTRIC:
                    point = 3;
                    break;
                case PokemonType.WATER:
                    point = 4;
                    break;
                case PokemonType.FIRE:
                    point = 5;
                    break;
                case PokemonType.BUG:
                    point = 6;
                    break;

                // and soo on
            }

            return point;
        }
    }
}
