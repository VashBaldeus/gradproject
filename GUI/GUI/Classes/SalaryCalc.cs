using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Classes
{
    class SalaryCalc
    {
        public double bruto { get; set; }//bruto salary
        public double neto { get; set; }//neto salary

        public double salary { get; set; }//hours100%
        public double salary125 { get; set; }//hours 125%
        public double salary150 { get; set; }//hours 150%
        public double salary175 { get; set; }//hours 175%
        public double salary200 { get; set; }//hours 200%

        public double ssecurity { get; set; }//social security
        public double healthtax { get; set; }

    }
}
