using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_7_CarsBuilder
{
    class Audi3
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            string str = "";

            for (int i = 0; i < _parts.Count; i++)
                str += _parts[i] + ", ";

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Audi3 parts: " + str + "\n";
        }
    }
}
