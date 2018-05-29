using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Position
    {
        private int _pointX;
        private int _pointY;
        public int MaxWeight { get; set; }

        /// <summary>
        /// Selects the appropriate weight in the product collection
        /// </summary>
        /// <param name="products">Product collection</param>
        public void GetProducts(int[] products)
        {
            var flag = false;
            for (int i = 0; i < products.Length; i++)
            {
                for (int j = i + 1; j < products.Length; j++)
                {
                    if (products[i] + products[j] <= MaxWeight)
                    {
                        _pointX = i;
                        _pointY = j;
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Displays information about the selection of products
        /// </summary>
        /// <returns></returns>
        public string GetInformations()
        {
            var result = string.Empty;
            if (_pointX == 0 && _pointY == 0)
            {
                return result += "There is no suitable weight in this product";
            }
            if (_pointX >= 0 && _pointY >= 0)
            {
                return result += string.Format("Position bags in products = {0} and {1}", _pointX, _pointY);
            }
            return result += "There is no suitable weight in this product";
        }
    }
}
