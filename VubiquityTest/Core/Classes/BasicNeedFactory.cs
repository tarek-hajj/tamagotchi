using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VubiquityTest.Core.Enumerations;
using VubiquityTest.Core.Interfaces;

namespace VubiquityTest.Core.Classes
{
    class BasicNeedFactory
    {
        #region properties

        #endregion


        #region methods

        /// <summary>
        /// factory pattern producing basic needs
        /// </summary>
        /// <param name="basicNeed"></param>
        /// <returns></returns>
        public IBasicNeed Produce(BasicNeed basicNeed)
        {
            if (basicNeed == BasicNeed.food)
            {
                return Food.GenerateRandomFood();
            }
            else if (basicNeed == BasicNeed.fun)
            {
                return Fun.GenerateRandomFun();
            }
            else if (basicNeed == BasicNeed.sleep)
            {
                return Sleep.GenerateRandomSleep();
            }
            else if (basicNeed == BasicNeed.poop)
            {
                return Poop.GenerateRandomPoop();
            }

            return null;
        }

        #endregion

    }
}
