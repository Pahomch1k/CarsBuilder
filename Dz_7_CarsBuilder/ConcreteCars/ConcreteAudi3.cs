using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_7_CarsBuilder
{
    class ConcreteAudi3 : IBuilder
    {
        private Audi3 _product;

        public ConcreteAudi3() { Reset(); }

        public void Reset() { _product = new Audi3(); }


        public void BuildKorpus()
        {
            _product.Add("Корпус - купе");
        }

        public void BuildDigatel()
        {
            _product.Add("Двигатель - 160");
        }

        public void BuildKolesa()
        {
            _product.Add("Колеса - 14");
        }

        public void BuildKPP()
        {
            _product.Add("КПП - 4 Auto");
        }

        public Audi3 GetProduct()
        {
            Audi3 result = _product;
            Reset();
            return result;
        }
    }
}
