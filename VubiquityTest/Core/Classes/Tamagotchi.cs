using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VubiquityTest.Core.Classes
{
    public sealed class Tamagotchi
    {

        #region properties

        private string name;
        private int hungriness = 0;
        private int fullness = 0;
        private int tiredness = 0;
        private int happiness = 0;

        //fields encapsulation
        public string Name { get => name; set => name = value; }
        public int Hungriness { get => hungriness; } //readonly
        public int Fullness { get => fullness; } //readonly
        public int Tiredness { get => tiredness; } //readonly
        public int Happiness { get => happiness; } //readonly

        #endregion


        #region methods

        #region Thread Safe Singleton implementation using Double Check Locking

        Tamagotchi()
        {

        }
        private static readonly object padlock = new object();
        private static Tamagotchi instance = null;
        public static Tamagotchi Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Tamagotchi();
                        }
                    }
                }
                return instance;
            }
        }

        #endregion

        /// <summary>
        /// function that takes the basic need by ref and increase its amount max 100
        /// </summary>
        /// <param name="basicNeed"></param>
        /// <param name="amount"></param>
        private void IncreaseBasicNeed(ref int basicNeed, int amount)
        {
            if (basicNeed + amount >= 100)
                basicNeed = 100;
            else
                basicNeed += amount;
        }

        /// <summary>
        /// function that takes the basic need by ref and decrease its amount min 0
        /// </summary>
        /// <param name="basicNeed"></param>
        /// <param name="amount"></param>
        private void DecreaseBasicNeed(ref int basicNeed, int amount)
        {
            if (basicNeed - amount <= 0)
                basicNeed = 0;
            else
                basicNeed -= amount;
        }

        /// <summary>
        /// reset the properties of the Tamagotchi
        /// </summary>
        public void Reset() {
             this.hungriness = 0;
             this.fullness = 0;
             this.tiredness = 0;
             this.happiness = 0;
        }

        public void IncreaseHungriness(int amount) => IncreaseBasicNeed(ref this.hungriness, amount);

        public void DecreaseHungriness(int amount) => DecreaseBasicNeed(ref this.hungriness, amount);

        public void IncreaseFullness(int amount) => IncreaseBasicNeed(ref this.fullness, amount);

        public void DecreaseFullness(int amount) => DecreaseBasicNeed(ref this.fullness, amount);

        public void IncreaseTiredness(int amount) => IncreaseBasicNeed(ref this.tiredness, amount);

        public void DecreaseTiredness(int amount) => DecreaseBasicNeed(ref this.tiredness, amount);

        public void IncreaseHappiness(int amount) => IncreaseBasicNeed(ref this.happiness, amount);

        public void DecreaseHappiness(int amount) => DecreaseBasicNeed(ref this.happiness, amount);


        #endregion

    }
}
