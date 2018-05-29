using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Shop
    {
        private Generator generator = new Generator();
        private int[] _collectionSugar;
        public int[] CollectionSugar { get => _collectionSugar; set => _collectionSugar = value; }

        public Shop(int count, int minValue, int maxValue)
        {
            CollectionSugar = generator.GetArrayWithRandomValues(count, minValue, maxValue);
        }

        /// <summary>
        /// Shows the contents of the collection
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = "\nProduct`s Information: \n";
            for (int i = 0; i < CollectionSugar.Length; i++)
            {
                result += "Weight " + i + " bag = " + CollectionSugar[i] + " kg" + Environment.NewLine; 
            }
            return result;
        }
    }
}
