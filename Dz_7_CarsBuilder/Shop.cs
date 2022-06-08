using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_7_CarsBuilder
{
    class Shop
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        } 

        public void buildFullFeaturedProduct()
        {
            _builder.BuildKorpus();
            _builder.BuildDigatel();
            _builder.BuildKolesa();
            _builder.BuildKPP();
        }
    }
}
