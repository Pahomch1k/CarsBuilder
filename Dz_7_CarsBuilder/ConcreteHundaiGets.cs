using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_7_CarsBuilder
{
    class ConcreteHundaiGets : IBuilder
    {
        private HundaiGets _product;

        public ConcreteHundaiGets() { Reset(); }

        public void Reset() { _product = new HundaiGets(); }


        public void BuildKorpus()
        {
            _product.Add("Корпус - Хетчбек");
        }

        public void BuildDigatel()
        {
            _product.Add("Двигатель - 66");
        }

        public void BuildKolesa()
        {
            _product.Add("Колеса - 13");
        }

        public void BuildKPP()
        {
            _product.Add("КПП - 4 Auto");
        }

        public HundaiGets GetProduct()
        {
            HundaiGets result = _product;
            Reset();
            return result;
        }
    }
}
