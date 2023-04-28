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
        public MemberCar(long id, Member memberr,Car carr, string carRegistrationNumber, string carColor)
        {
            _id = id;
            _member = memberr;
            _car = carr;
            _carRegistrationNumber = carRegistrationNumber;
            _carColor = carColor;
           
        }

        
    }
}
