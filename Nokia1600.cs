using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Nokia1600 : INormalPhone
    {
        public string GetModelDetalis()
        {
            return "Model: Nokia1600;\nRAM:2GB;\nCamera: 10MP \n";
        }


    }
}
