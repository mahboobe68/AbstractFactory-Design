using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class NokiaPixel : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model: NokiaPixel; \nRAM: 3GB ; \nCamera: 8MP \n";
        }
    }
}
