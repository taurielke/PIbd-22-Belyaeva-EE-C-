using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelyaevaTank
{
    public class VehicleComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is ArmoredCar && y is Tank)
            {
                return 1;
            }
            if (x is Tank && y is ArmoredCar)
            {
                return -1;
            }
            if (x is ArmoredCar && y is ArmoredCar)
            {
                return -ComparerArmoredCar((ArmoredCar)x, (ArmoredCar)y);
            }
            if (x is Tank && y is Tank)
            {
                return -ComparerTank((Tank)x, (Tank)y);
            }
            return 0;
        }

        private int ComparerArmoredCar(ArmoredCar x, ArmoredCar y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerTank(Tank x, Tank y)
        {
            var res = ComparerArmoredCar(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Weapon != y.Weapon)
            {
                return x.Weapon.CompareTo(y.Weapon);
            }
            if (x.Tower != y.Tower)
            {
                return x.Tower.CompareTo(y.Tower);
            }
            return 0;
        }
    }
}
