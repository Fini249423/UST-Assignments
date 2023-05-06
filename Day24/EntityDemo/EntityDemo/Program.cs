using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ASSIGNMENTSQL1Entities2())
            {
                //insert data
                //var emp = new EMP()
                //{
                //    ID = 100,
                //    NAME = "Anaswara",
                //    SAL = 65000,
                //    COMM_PCT = 77,
                //    PF= 2000

                //};
                //context.EMPs.Add(emp);

                //context.SaveChanges();

                //update data

                //using (var context1 = new ASSIGNMENTSQL1Entities2())
                //{
                //    var emp1 = context1.EMPs.First<EMP>();
                //    emp1.NAME = "Steve";
                //    context1.SaveChanges();
                //}


                //DELETING DATA
                //using (var context2 = new ASSIGNMENTSQL1Entities2())
                //{
                //    var emp = context2.EMPs.First<EMP>();
                //    context2.EMPs.Remove(emp);

                //    context2.SaveChanges();
                //}
            }
        }
    }
}
