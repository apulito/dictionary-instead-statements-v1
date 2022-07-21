using Domain.v1;

namespace Console.Dictionary.v1
{
    public class BasePointManager
    {
        private readonly Dictionary<PokemonType, int> _basePointMapping = new Dictionary<PokemonType, int>(){
            {PokemonType.NORMAL, 1},
            {PokemonType.GRASS, 2},
            {PokemonType.ELECTRIC, 3},
            {PokemonType.WATER, 4},
            {PokemonType.FIRE, 5},
            {PokemonType.BUG, 6}
        };

        /// <summary>
        /// Use dictionary data structure
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int GetHitPoint(PokemonType value)
        {
            return _basePointMapping.ContainsKey(value) ? _basePointMapping[value] : 0;
        }
    }
}
