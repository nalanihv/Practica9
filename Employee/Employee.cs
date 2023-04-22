using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department;

namespace Employee
{
    public class Employ{

        //atributos de la clase
        int fixedSalary;
        DateTime workingFrom;

        /* public Employ(int fixedSalary, DateTime workingFrom)
         {
             this.fixedSalary = fixedSalary;
             this.workingFrom = workingFrom;
         }*/

        //objeto de la clase department para poder calcular el incentive
        Depto incentive = new Depto(1,true,234);








        public Depto[] employDepto = { Depto.};

        public Employ(int fixedSalary, DateTime workingFrom, Depto[] deptos) {

            this.fixedSalary = fixedSalary;
            this.workingFrom = workingFrom;
            this.employDepto = deptos;
        }













        // ------------  METODOS QUE CALCULAN LA PRESTACION  -------------------------//

        // calcula el complemento salarial basándose en el número de años trabajados



        //si se tiene fecha de corte
        double GetAllowance(DateTime cutOffDate ) {

            // la fecha pasa a dias y
            //se calcula los años que se tienen de experiencia
            int workExperience = ((cutOffDate - workingFrom).Days) / 365;

          

            //dependiendo del valor de la experiencia será el porcentaje asignado para  aumento al salario
            if (workExperience < 5)
                return fixedSalary*.5;

            else if (workExperience >= 5 && workExperience < 10)
                return fixedSalary* .10;

            else if (workExperience >= 10 && workExperience < 15)
                return fixedSalary*.15;

            else if (workExperience >=15)
                return fixedSalary* .20;

            //en caso de que no se tenga la suficiente experiencia no se aumentará nada
                return 0;
   
        }


        // si no se asigna fecha de corte,se asigna 31/03/2014
        double GetAllowance() {

        // se llama al metodo allowance que recibe parámetros para asignar el aumento que se dará respecto al salario

        //  double  Salary = GetAllowance(new DateTime(2014, 3, 31));  
             return GetAllowance(new DateTime(2014, 3, 31));
            
        }


        // ------------  METODOS QUE CALCULAN EL SALARIO TOTAL  -------------------------//

        //dependiendo de si recibe fecha de corte, será el metodo que use para sumar todos los valores
        //calculados anteriormente para sacar el salario total 


        //se calcula sumando el salario inicial con la prestación (calculada dependiente de los años
        //que se lleva trabajando y el incentivo 


        public double GetTotalSalary(DateTime cutOffDate, float multiplyfactor) {
            
            return fixedSalary + GetAllowance(cutOffDate)+incentive.GetIncentive(multiplyfactor);
        }


        public double GetTotalSalary(float multiplyfactor){
           
            return fixedSalary + GetAllowance() + incentive.GetIncentive(multiplyfactor);
        }

    }
}
