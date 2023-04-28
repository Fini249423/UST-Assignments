using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carpooling;
//id  long

//_member	Member

//_car	car

//_carRegistrationNumber	string

//_carColor	string

namespace Requirement2
{
    public class MemberCar
    {
        private long _id;
        public long Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;

            }
        }
        private Member _member;
        public Member memberr
        {
            get
            {
                return _member;
            }
            set
            {
                _member = value;

            }
        }
        private Car _car;
        public Car carr
        {
            get
            {
                return _car;
            }
            set
            {
                _car = value;

            }
        }
        private string _carRegistrationNumber;
        public string carRegistrationNumber
        {
            get
            {
                return _carRegistrationNumber;
            }
            set
            {
                _carRegistrationNumber = value;

            }
        }
        private string _carColor;
        public string carColor
        {
            get
            {
                return _carColor;
            }
            set
            {
                _carColor = value;

            }
        }
        public MemberCar()
        {

        }
        public MemberCar(long id, Member memberr, Car carr, string carRegistrationNumber, string carColor)
        {
            _id = id;
            _member = memberr;
            _car = carr;
            _carRegistrationNumber = carRegistrationNumber;
            _carColor = carColor;

        }
        public class CarPoolingSystem
        {
            private List<Member> _members;
            private List<Car> _cars;
            private List<MemberCar> _membersCars;
            public CarPoolingSystem(List<Member> members, List<Car> cars, List<MemberCar> memberCars)
            {
                this._members = members;
                this._cars = cars;
                this._membersCars = memberCars;
            }
            public Dictionary<string, List<MemberCar>> GroupByColor()
            {
                var result = new Dictionary<string, List<MemberCar>>();
                foreach (var car in _cars)
                {
                    var color = car.Company.ToLower();
                    if (!result.ContainsKey(color))
                    {
                        result[color] = new List<MemberCar>();
                    }
                    var memberCarsWithColor = _membersCars.Where(mc => mc.Id == car.Id);
                    result[color].AddRange(memberCarsWithColor);
                }
                return result;
            }
        }
    }
}


    
//      {

//        return _carRegistrationNumber;

//      }

//set

//      {

//}

