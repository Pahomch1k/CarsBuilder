using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_7_CarsBuilder
{
    interface IBuilder
    {
        void BuildKorpus(); 
        void BuildDigatel(); 
        void BuildKolesa();
        void BuildKPP();
    }
}
