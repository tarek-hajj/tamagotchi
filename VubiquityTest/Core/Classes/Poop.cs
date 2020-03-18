using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VubiquityTest.Core.Interfaces;

namespace VubiquityTest.Core.Classes
{
    class Poop : IBasicNeed
    {

        #region properties

        private int amountFullnessDecreased;
        private bool isConsumed = false;
        static Random getrandom = new Random();

        #endregion

        #region methods

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="amountFullnessDecreased"></param>
        public Poop(int amountFullnessDecreased)
        {
            this.amountFullnessDecreased = amountFullnessDecreased;
        }

        /// <summary>
        /// a function that consumes the poop and apply its effects on the tamagotchi
        /// </summary>
        /// <returns></returns>
        public bool Consume()
        {
            if (this.isConsumed)
                return false;

            //decrease tamagotchi's tiredness
            Tamagotchi.Instance.DecreaseFullness(this.amountFullnessDecreased);

            //set the poop as consumed so it cannot be used again
            this.isConsumed = true;

            return true;
        }


        /// <summary>
        /// a static funtion that generate a random poop object
        /// </summary>
        /// <returns></returns>
        public static Poop GenerateRandomPoop()
        {
            int fullness = Poop.getrandom.Next(20, 60);

            return new Poop(fullness);
        }

        #endregion


    }
}
