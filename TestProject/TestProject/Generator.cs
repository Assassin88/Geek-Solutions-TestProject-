using System;

namespace TestProject
{
    class Generator
    {
        private Random random = new Random();

        /// <summary>
        /// Returns a collection with random numbers
        /// </summary>
        /// <param name="count">Number of items in the collection</param>
        /// <param name="minValue">Minimum random value</param>
        /// <param name="maxValue">Maximum random value</param>
        /// <returns></returns>
        public int[] GetArrayWithRandomValues(int count, int minValue, int maxValue)
        {
            var result = new int[count];
            for (var i = 0; i < result.Length; i++)
            {
                result[i] = RandomValue(minValue, maxValue);
            }
            return result;
        }

        /// <summary>
        /// Returns a random number
        /// </summary>
        /// <param name="minValue">Minimum random value</param>
        /// <param name="maxValue">Maximum random value</param>
        /// <returns></returns>
        private int RandomValue(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }
    }
}
