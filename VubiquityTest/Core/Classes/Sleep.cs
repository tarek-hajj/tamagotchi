using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VubiquityTest.Core.Interfaces;

namespace VubiquityTest.Core.Classes
{
    class Sleep : IBasicNeed
    {

        #region properties

        private int amountTirednessDecreased;
        private bool isConsumed = false;
        static Random getrandom = new Random();

        #endregion


        #region methods

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="amountTirednessDecreased"></param>
        public Sleep(int amountTirednessDecreased) {
            this.amountTirednessDecreased = amountTirednessDecreased;
        }

        /// <summary>
        /// a function that consumes the sleep and apply its effects on the tamagotchi
        /// </summary>
        /// <returns></returns>
        public bool Consume()
        {
            if (this.isConsumed)
                return false;

            //decrease tamagotchi's tiredness
            Tamagotchi.Instance.DecreaseTiredness(this.amountTirednessDecreased);

            //set the sleep as consumed so it cannot be used again
            this.isConsumed = true;

            return true;
        }

        /// <summary>
        /// a static funtion that generate a random sleep object
        /// </summary>
        /// <returns></returns>
        public static Sleep GenerateRandomSleep()
        {
            int tiredness = Sleep.getrandom.Next(20, 60);

            return new Sleep(tiredness);
        }

        #endregion
    }
}
