using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    public class Depto {
        //atributos de la clase
        public int deptNumber;
        public bool isProducting=true;
        public float produce;

        public float Produce { get { return produce; } set { produce= value; } }

        public Depto(int deptNumber, bool isProducting, float produce)
        {
            this.deptNumber = deptNumber;
            this.isProducting = isProducting;
            this.produce = produce;
        }




        //Método GetIncentive
        //calcula el incentive si su producting es true ,sino retorna 0
        public  float GetIncentive(float multiplyfactor) {
            if(isProducting)
                //P
                return Produce*multiplyfactor;
            else
            return 0;
        }
    }
}
