using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VubiquityTest.Core.Tools
{
    public static class Converter
    {
        public static int ConvertToInt(Object intObject)
        {
            if (intObject == null)
            {
                return 0;
            }
            else
            {
                int res = 0;

                int.TryParse(intObject.ToString(), out res);

                return res;
            }
        }

    }
}
