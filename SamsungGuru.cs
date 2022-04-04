using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SamsungGuru : INormalPhone
    {
        public string GetModelDetalis()
        {
            return "Model: SamsungGuru; \nRAM: 1GB ; \n";
        }
    }
}
