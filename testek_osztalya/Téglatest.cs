using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testek_osztalya
{
    internal class Téglatest : Test
    {
        double oldalA;
        double oldalB;
        double oldalC;
        public Téglatest(string tipus) : base(tipus)
        {   
        }
        public double OldalA { get => oldalA; }
        public double OldalB { get => oldalB; }
        public double OldalC { get => oldalC; }

        public override double Felszin()
        {

            return 2 * ((oldalA * oldalB) + (oldalA * oldalC) + (oldalB * oldalC));
        
        }

        public override double Terfogat()
        {
             return oldalA * oldalB * oldalC;
        }
    }
}
