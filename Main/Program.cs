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

            //se crean objetos y se le agregan los valores corresponientes 
            //de sus clases
           Depto departamento= new Depto(1,true,250);

           Employ empleado1= new Employ(2000, new DateTime(2011, 5, 1),departamento);
            Employ empleado2 = new Employ(2000, new DateTime(2000, 11, 30), departamento);


            Console.WriteLine("__SALARIO TOTAl__");

            Console.WriteLine("Empleado con fecha de corte: "+ empleado1.GetTotalSalary(new DateTime(2022,1,30),1.85f));
            Console.WriteLine("Empleado con fecha de corte sin asignar: " +empleado2.GetTotalSalary( .2f));


            /*  
                DateTime cutOffDate= new DateTime(2022, 1, 30);
                DateTime workingFrom = new DateTime(2011, 5,1);

                int workExperience = ((cutOffDate - workingFrom ).Days) / 365;

                Console.WriteLine(workExperience);
            */

        }
    }
}
