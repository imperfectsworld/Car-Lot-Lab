using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Lot_Lab
{
    internal class UsedCar:Car
    {
        //props
        public double Mileage { get; set; }

        //constructors
        public UsedCar(string _make, string _model, int _year, decimal _price, double _mileage)
            :base(_make, _model, _year, _price)
        {
            Mileage = _mileage;
        }
        public override string ToString()
        {
            return($"{Make}\t\t{Model}\t\t{Year}\t\t{Price}\t\t{Mileage}");
            //return (String.Format("{0,10} {1,10} {3,10} {4,10} {5,10}", $"{Make}", $"{Model}", $"{Year}", $"{Price}", $"{Mileage}"));
        }
    }
}
