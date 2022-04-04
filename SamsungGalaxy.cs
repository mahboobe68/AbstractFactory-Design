using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SamsungGalaxy : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model: SamsungGalaxy; \nRAM: 2GB; \nCamera: 123MP; \n";
        }
    }
}
