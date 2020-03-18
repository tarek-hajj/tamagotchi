using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VubiquityTest.Core.Interfaces;

namespace VubiquityTest.Core.Classes
{
    class Fun : IBasicNeed
    {
        #region properties

        private int amountHappinessIncreased;
        private int amountTirednessIncreased;
        private bool isConsumed = false;
        static Random getrandom = new Random();
        #endregion

        #region methods

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="amountHappinessIncreased"></param>
        /// <param name="amountTirednessIncreased"></param>
        public Fun(int amountHappinessIncreased, int amountTirednessIncreased)
        {
            this.amountHappinessIncreased = amountHappinessIncreased;
            this.amountTirednessIncreased = amountTirednessIncreased;
        }

        /// <summary>
        /// a function that consumes the fun and apply its effects on the tamagotchi
        /// </summary>
        /// <returns></returns>
        public bool Consume()
        {
            if (this.isConsumed)
                return false;

            //increase tamagotchi's happiness
            Tamagotchi.Instance.IncreaseHappiness(this.amountHappinessIncreased);

            //increase tamagotchi's tiredness
            Tamagotchi.Instance.IncreaseTiredness(this.amountTirednessIncreased);

            //set the fun as consumed so it cannot be used again
            this.isConsumed = true;

            return true;
        }

        /// <summary>
        /// a static funtion that generate a random fun object
        /// </summary>
        /// <returns></returns>
        public static Fun GenerateRandomFun()
        {           
            int happiness = Fun.getrandom.Next(20, 60);
            int tiredness = Fun.getrandom.Next(10, 30);

            return new Fun(happiness, tiredness);
        }


        #endregion

    }
}
