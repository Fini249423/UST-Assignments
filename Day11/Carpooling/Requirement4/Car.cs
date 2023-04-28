using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement4
{
    public  abstract class Car
    {
        private long _id;
        public long Id { get { return _id; } set { _id = value; } }

        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        public Car()
        {

        }

        public Car(long _id, string _name)
        {
            Id = _id;
            Name = _name;
        }
        public abstract double CalculateDriveCost(double km);

        public class HatchBack : Car
        {
            private bool _powerWindoesEnabled;
            public bool PowerWindoesEnabled
            {
                get { return _powerWindoesEnabled; }
                set { _powerWindoesEnabled = value; }

            }

            private bool _automaticGear;
            public bool AutomaticGear
            {
                get { return _automaticGear; }
                set { _automaticGear = value; }
            }

            public HatchBack()
            {

            }
            public HatchBack(long _id, string _name, bool _powerWindowsEnabled, bool _automaticGear) : base(_id, _name)
            {
                Id = _id;
                Name = _name;
                PowerWindoesEnabled = _powerWindowsEnabled;
                AutomaticGear = _automaticGear;

            }
            public override double CalculateDriveCost(double km)
            {
                double cost = 0;
                if (AutomaticGear)
                    cost = 12;
                else
                    cost = 10;
                return cost * km;
            }
        


            public class Sedan : Car
            {
                private bool _absEnabled;
                public bool AbsEnabled { get { return _absEnabled; } set { _absEnabled = value; } }
                private Int32 _bootSpace;
                public Int32 BootSpace { get { return _bootSpace; } set { _bootSpace = value; } }
                public Sedan()
                {

                }
                public Sedan(long _id, string _name, bool _absEnabled, Int32 _bootSpace) : base(_id, _name)
                {
                    Id = _id;
                    Name = _name;
                    AbsEnabled = _absEnabled;
                    BootSpace = _bootSpace;
                }
                public override double CalculateDriveCost(double km)
                {
                    double cost = 0;
                    if (BootSpace > 600)
                        cost = 15 + (15 * 0.20);
                    else
                        cost = 15;
                    return cost;
                }
            }

            public class UtilityCar : Car
            {
                private bool _rearCoolingVents;
                public bool RearCoolingVents { get { return _rearCoolingVents; } set { _rearCoolingVents = value; } }
                public UtilityCar()
                {

                }
                public UtilityCar(long _id, string _name, bool _rearCoolingVents) : base(_id, _name)
                {
                    Id = _id;
                    Name = _name;
                    RearCoolingVents = _rearCoolingVents;
                }
                public override double CalculateDriveCost(double km)
                {
                    return 18 * km;
                }

            }
        }
    }
}


