using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
     public class MobileClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;


        public MobileClient(IMobilePhone factory)
        {
            smartPhone = factory.GetSmartPhone();   
            normalPhone = factory.GetNormalPhone(); 
        }

        public string GetSmartMobilePhone()
        {
            return smartPhone.GetModelDetails();  
        }
        public string GetNormalMobilePhone()
        {
            return normalPhone.GetModelDetalis();
        }

    }
}
