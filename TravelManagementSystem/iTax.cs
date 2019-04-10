using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelManagementSystem
{
    class iTax
    {
        public double mcTax_Rate = 0.55;
        public Double iFindTax(double icAmount)
        {
            double findTax = icAmount - (icAmount * mcTax_Rate);
            return findTax;
        }
    }
}
