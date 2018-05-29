using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Menu
    {
        /// <summary>
        /// Initializes input parameters
        /// </summary>
        /// <param name="_countCollection">Number of items in the collection</param>
        /// <param name="_maxWeight">Maximum weight</param>
        /// <param name="_minValue">Minimum random value</param>
        /// <param name="_maxValue">Maximum random value</param>
        public static void InitializationMenu(out int _countCollection, out int _maxWeight, out int _minValue, out int _maxValue)
        {
            Console.WriteLine("Enter the count of items in the bag collection: ");
            _countCollection = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the maximum carrying capacity: ");
            _maxWeight = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the minimum weight of the bag: ");
            _minValue = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the maximum weight of the bag: ");
            _maxValue = int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Select a menu item
        /// </summary>
        /// <returns></returns>
        public static int ShowMenu()
        {
            Console.WriteLine("Select the menu item:");
            Console.WriteLine("1. Manual input of information;");
            Console.WriteLine("2. Example of program execution;");
            Console.WriteLine("3. Close solution;\n");

            var result = int.Parse(Console.ReadLine());

            if (result < 1 || result > 3)
            {
                throw new FormatException("Incorrect data entry!!!");
            }

            return result;
        }

        /// <summary>
        /// Shows the sample program parameters
        /// </summary>
        /// <returns></returns>
        public static string ShowMenuForExample()
        {
            return string.Format("CountCollection = {0};\nMaxWeight = {1};\nMinValue = {2};\nMaxValue = {3};\n", 40, 102, 50, 60);
        }
    }
}
