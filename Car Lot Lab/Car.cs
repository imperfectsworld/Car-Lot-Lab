using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Lot_Lab
{
    internal class Car
    {
        //parameters 

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        //constructor

        public Car()

        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;

        }

        public Car(string _make, string _model, int _year, decimal _price)

        {
            Make = _make;
            Model = _model;
            Year = _year;
            Price = _price;

        }

        //methods

        public override string ToString()
        {

            return ($"{Make}\t\t{Model}\t\t{Year}\t\t${Price}");
            //return (String.Format("{0,10} {1,10} {3,10} {4,10}", $"{Make}", $"{Model}", $"{Year}", $"{Price}"));
        }

        public static List<Car> Inventory = new List<Car>();
        public static void ListCars(List<Car> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1} {list[i]}");
            }
        }

        public static void Remove (int index)
        {
           
            Car.Inventory.RemoveAt(index-1);
            
        }








    }
}

