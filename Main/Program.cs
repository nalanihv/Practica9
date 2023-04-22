using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee;
using Department;

namespace Main
{
    internal class Program    {
        static void Main(string[] args){

           Employ empleado= new Employ(1500, new DateTime(2011, 5, 1), new Department.Depto[] {Depto.deptNumber.set() });
            empleado.GetTotalSalary(new DateTime(2022,1,30),2);

          /*
            DateTime cutOffDate= new DateTime(2014, 3, 31);
            DateTime workingFrom = new DateTime(2010, 5,30);
          
            int workExperience = ((cutOffDate - workingFrom ).Days) / 365;

            Console.WriteLine(workExperience);*/







        }
    }
}
