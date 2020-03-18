using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VubiquityTest.Core.Interfaces;

namespace VubiquityTest.Core.Classes
{
    public class Food : IBasicNeed
    {

        #region properties

        private string name;
        private int cost;
        private int amountHungrinessDecreased;
        private int amountFullnessIncreased;
        private bool isConsumed = false;
        static Random getrandom = new Random();


        public int Cost { get => cost; set => cost = value; }
        public int AmountHungrinessDecreased { get => amountHungrinessDecreased; set => amountHungrinessDecreased = value; }
        public int AmountFullnessIncreased { get => amountFullnessIncreased; set => amountFullnessIncreased = value; }
        public bool IsConsumed { get => isConsumed; set => isConsumed = value; }
        public string Name { get => name; set => name = value; }

        #endregion

        #region methods

        /// <summary>
        /// Constructor for food class
        /// </summary>
        /// <param name="cost"></param>
        /// <param name="amountHungrinessDecreased"></param>
        /// <param name="amountFullnessIncreased"></param>
        public Food(string name, int cost, int amountHungrinessDecreased, int amountFullnessIncreased)
        {
            this.name = name;
            this.cost = cost;
            this.amountHungrinessDecreased = amountHungrinessDecreased;
            this.amountFullnessIncreased = amountFullnessIncreased;
            this.isConsumed = false;
        }

        /// <summary>
        /// a function that consumes the food and apply its effects on the tamagotchi
        /// </summary>
        public bool Consume()
        {
            if (this.isConsumed)
                return false;

            //decrease tamagotchi's hungriness
            Tamagotchi.Instance.DecreaseHungriness(this.amountHungrinessDecreased);

            //increase tamagotchi's fullness
            Tamagotchi.Instance.IncreaseFullness(this.amountFullnessIncreased);

            //set the food as consumed so it cannot be used again
            this.isConsumed = true;

            return true;
        }

        /// <summary>
        /// a static function that generates a random food
        /// </summary>
        /// <returns></returns>
        public static Food GenerateRandomFood()
        {

            //list of predefined food
            List<Food> lstFood = new List<Food>();

            lstFood.Add(new Food("apple", 5, 12, 18));
            lstFood.Add(new Food("banana", 8, 20, 15));
            lstFood.Add(new Food("potato", 4, 10, 25));
            lstFood.Add(new Food("chicken", 12, 32, 38));
            lstFood.Add(new Food("meat", 18, 22, 26));

            int index = Food.getrandom.Next(0, 4);

            return lstFood[index];
        }

        #endregion

    }
}
