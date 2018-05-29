using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Work
    {
        /// <summary>
        /// Runs the application
        /// </summary>
        public static void Start()
        {
            var _worker = true;

            while (_worker)
            {
                try
                {
                    var _point = Menu.ShowMenu();
                    switch (_point)
                    {
                        case 1:
                            {
                                int _countCollection, _maxWeight, _maxValue, _minValue;

                                Menu.InitializationMenu(out _countCollection, out _maxWeight, out _minValue, out _maxValue);

                                Shop shop = new Shop(_countCollection, _minValue, _maxValue);
                                Console.WriteLine(shop);

                                Position position = new Position();
                                position.MaxWeight = _maxWeight;
                                position.GetProducts(shop.CollectionSugar);
                                Console.WriteLine(position.GetInformations());

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine(Menu.ShowMenuForExample());
                                Shop shop = new Shop(40, 50, 60);
                                Console.WriteLine(shop);

                                Position position = new Position();
                                position.MaxWeight = 102;
                                position.GetProducts(shop.CollectionSugar);
                                Console.WriteLine(position.GetInformations());

                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        case 3:
                            {
                                _worker = false;
                                break;
                            }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect data entry!!!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
