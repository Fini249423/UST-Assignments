using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dahlia", "rose", "lotus", "lily", "hibiscus", "daffodil" };
            var fQuery=
                from flower in flowers
                where (flower.StartsWith("d"))
                select flower;           
            foreach(string f in fQuery)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine();
            var lquery = 
                from flower in flowers
                let len=flower.Length
                where (flower.StartsWith("d")&& len >6)
                select flower;
            foreach (string l in fQuery)
            {
                Console.WriteLine(l);
            }
        }
    }
}
