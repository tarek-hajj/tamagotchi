using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VubiquityTest.Core.Classes;
using static VubiquityTest.Core.Tools.Converter;

namespace VubiquityTest.Forms.Popups
{
    public partial class frmPopFeed : Form
    {
        #region properties

        List<Food> lstShop = new List<Food>();

        #endregion

        #region methods



        public frmPopFeed()
        {
            InitializeComponent();
        }

        private void frmPopFeed_Load(object sender, EventArgs e)
        {
            InitializePlayerItems();

            LoadShopItems();
        }

        /// <summary>
        /// generate a display string of a food list 
        /// </summary>
        /// <param name="lstFood"></param>
        /// <returns></returns>
        private string GenerateFoodList(List<Food> lstFood)
        {
            string lst = "";
            //load the available food
            for (int i = 0; i < lstFood.Count; i++)
            {
                lst += Environment.NewLine;
                lst += "-Food Number : " + (i + 1) + Environment.NewLine;
                lst += "-Food Name : " + lstFood[i].Name + Environment.NewLine;
                lst += "-Hungriness Decrease : " + lstFood[i].AmountHungrinessDecreased + Environment.NewLine;
                lst += "-Fullness Increase : " + lstFood[i].AmountFullnessIncreased + Environment.NewLine;
                lst += "-Price : " + lstFood[i].Cost + Environment.NewLine;
                lst += "------------------" + Environment.NewLine;
            }

            return lst;

        }

        /// <summary>
        /// function that initializes the player items 
        /// </summary>
        private void InitializePlayerItems()
        {
            //set the available money
            this.txtPlayerKablammo.Text = Player.Instance.KablammoCount.ToString();

            string inventory = "PLAYER FOOD INVENTORY : ";
            inventory += GenerateFoodList(Player.Instance.LstFood);
            this.txtInventory.Text = inventory;
        }

        /// <summary>
        /// function that fills the shop items
        /// </summary>
        private void LoadShopItems()
        {
            this.txtShop.Text = string.Empty;
            lstShop = new List<Food>();

            //5 items in the shop

            //each item once in the shop
            lstShop.Add(new Food("apple", 5, 12, 18));
            lstShop.Add(new Food("banana", 8, 20, 15));
            lstShop.Add(new Food("potato", 4, 10, 25));
            lstShop.Add(new Food("chicken", 12, 32, 38));
            lstShop.Add(new Food("meat", 18, 22, 26));

            string inventory = "FOOD IN THE SHOP : ";
            inventory += GenerateFoodList(lstShop);
            this.txtShop.Text = inventory;
        }

        #endregion

        /// <summary>
        /// when choosing an item and clicking on button feed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFeed_Click(object sender, EventArgs e)
        {
            int choice = ConvertToInt(this.txtFeedChoice.Text);

            //control user input
            if (choice > 0 && choice <= Player.Instance.LstFood.Count)
            {
                //consume the food
                Player.Instance.LstFood[choice - 1].Consume();

                //refresh player inventory and money
                InitializePlayerItems();

                this.txtFeedChoice.Text = string.Empty;
            }
        }

        private void btnBuyFood_Click(object sender, EventArgs e)
        {
            int choice = ConvertToInt(this.txtBuyChoice.Text);

            //control user input
            if (choice > 0 && choice <= lstShop.Count)
            {
                //buy the food
               bool success = Player.Instance.BuyFood(lstShop[choice - 1]);

                if (success)
                    MessageBox.Show("Food purchased successfully");
                else
                    MessageBox.Show("Couldn't purchase food, not enough kablammo");

                //refresh player inventory and money
                InitializePlayerItems();

                this.txtBuyChoice.Text = string.Empty;
                LoadShopItems();
            }

        }
    }
}
