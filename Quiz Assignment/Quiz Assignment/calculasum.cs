using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Assignment
{
    internal class calculasum
    {
        private double nsum = 0;
        private double ngsum = 0;

        public void setn(double nna)
        {
            this.nsum = (int)(nsum + nna);


        }

        public void setng(double nnga)
        {
            this.ngsum = (int)(ngsum + nnga);


        }



        public double getn()
        { return nsum ; }

        public double getng()
        { return ngsum ; }
    }
}
