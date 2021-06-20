using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student_info _instance = new Student_info();
            _instance.SetId("100");
            _instance.SetName("SUSHMA");
            string idvalue = _instance.GetId();
            System.Console.WriteLine();
            Console.ReadLine();
        }
    }
}
