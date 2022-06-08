using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_7_CarsBuilder
{
    class ConcreteTeslaS: IBuilder
    {
        private TeslaS _product;

        public ConcreteTeslaS() { Reset(); }

        public void Reset() { _product = new TeslaS(); }


        public void BuildKorpus()
        {
            _product.Add("Корпус - седан");
        }

        public void BuildDigatel()
        {
            _product.Add("Двигатель - 98");
        }

        public void BuildKolesa()
        {
            _product.Add("Колеса - 13");
        }

        public void BuildKPP()
        {
            _product.Add("КПП - 5 Manual");
        }

        public TeslaS GetProduct()
        {
            TeslaS result = _product; 
            Reset(); 
            return result;
        }
    }
} 