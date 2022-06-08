using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_7_CarsBuilder
{
    class ConcreteBMWx4 : IBuilder
    {
        private BMWx4 _product;

        public ConcreteBMWx4() { Reset(); }

        public void Reset() { _product = new BMWx4(); }


        public void BuildKorpus()
        {
            _product.Add("Корпус - Универсал");
        }

        public void BuildDigatel()
        {
            _product.Add("Двигатель - 120");
        }

        public void BuildKolesa()
        {
            _product.Add("Колеса - 16");
        }

        public void BuildKPP()
        {
            _product.Add("КПП - 4 Manual");
        }

        public BMWx4 GetProduct()
        {
            BMWx4 result = _product;
            Reset();
            return result;
        }
    }
}
