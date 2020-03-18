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
using VubiquityTest.Core.Enumerations;
using VubiquityTest.Core.Tools;
using VubiquityTest.Forms.Popups;

namespace VubiquityTest.Forms
{
    public partial class frmMain : Form
    {
        #region properties

        private static readonly Random getrandom = new Random();

        #endregion

        #region methods

        /// <summary>
        /// default constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();

        }

        /// <summary>
        /// on page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            //initialize
            WriteLog("Application started !", Color.DarkGray);

            InitializeGameParameters();

            StartTimers();
        }

        /// <summary>
        /// start a new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            //initialize 
            this.txtLog.Text = "";
            InitializeGameParameters();
            StartTimers();

            WriteLog("Starting a new game !", Color.DarkMagenta);
        }

        /// <summary>
        /// a function that will randomly initialize the game parameters 
        /// </summary>
        private void InitializeGameParameters()
        {
            //reset properties
            Tamagotchi.Instance.Reset();
            Player.Instance.Reset();

            //random fullness
            this.pgbFullness.Maximum = 100;
            this.pgbFullness.Step = 1;
            Tamagotchi.Instance.IncreaseFullness(GetRandomNumber(20, 80));

            //random happiness
            this.pgbHappiness.Maximum = 100;
            this.pgbHappiness.Step = 1;
            Tamagotchi.Instance.IncreaseHappiness(GetRandomNumber(20, 80));

            //random hungriness
            this.pgbHungriness.Maximum = 100;
            this.pgbHungriness.Step = 1;
            Tamagotchi.Instance.IncreaseHungriness(GetRandomNumber(20, 80));

            //random tiredness
            this.pgbTiredness.Maximum = 100;
            this.pgbTiredness.Step = 1;
            Tamagotchi.Instance.IncreaseTiredness(GetRandomNumber(20, 80));

            //fill the player's random list of food
            int count = GetRandomNumber(1, 5);
            for (int i = 0; i < count; i++)
            {
                //generate a random food and append it to the list
                Player.Instance.AppendFood(new BasicNeedFactory().Produce(BasicNeed.food) as Food);
            }

            //fill the player currency random count
            Player.Instance.IncreaseKablammoCount(GetRandomNumber(100, 500));

            WriteLog("Game parameters initialized randomly !", Color.DarkGray);
            WriteLog("Giving player a random amount of kablammo : " + Player.Instance.KablammoCount, Color.DarkGreen);

            SetProgressBarValues();
        }

        /// <summary>
        /// start the timers cause tamagotchi's needs change over time
        /// </summary>
        private void StartTimers()
        {
            timerFullness.Start();
            timerHappiness.Start();
            timerHungriness.Start();
            timerTiredness.Start();

            WriteLog("Starting timers to modify the tamagotchi's needs over time", Color.DarkGray);

        }

        /// <summary>
        /// function to write a formatted log
        /// </summary>
        /// <param name="log"></param>
        /// <param name="color"></param>
        private void WriteLog(string log, Color color)
        {
            //changing the font
            Font currentFont = txtLog.SelectionFont;
            FontStyle newFontStyle = (FontStyle)(currentFont.Style | FontStyle.Bold);
            txtLog.SelectionFont = new Font(currentFont.FontFamily, 10, newFontStyle);

            //appending colored text
            txtLog.Select(txtLog.TextLength, 0);
            txtLog.SelectionColor = color;
            txtLog.AppendText(log);
            txtLog.AppendText(Environment.NewLine);
            txtLog.AppendText(Environment.NewLine);

            // set the current caret position to the end
            txtLog.SelectionStart = txtLog.Text.Length;
            // scroll it automatically to bottom
            txtLog.ScrollToCaret();
        }

        /// <summary>
        /// set the games parameters
        /// </summary>
        private void SetProgressBarValues()
        {

            this.pgbFullness.Value = Tamagotchi.Instance.Fullness;
            this.pgbHappiness.Value = Tamagotchi.Instance.Happiness;
            this.pgbHungriness.Value = Tamagotchi.Instance.Hungriness;
            this.pgbTiredness.Value = Tamagotchi.Instance.Tiredness;
        }

        /// <summary>
        /// get a random number in range
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }

        /// <summary>
        /// disable buttons while waiting for action to complete
        /// </summary>
        private void DisableButtons()
        {
            this.btnFeed.Enabled = false;
            this.btnMakingPoop.Enabled = false;
            this.btnPlayWith.Enabled = false;
            this.btnPutToBed.Enabled = false;
            this.btnStartNewGame.Enabled = false;

            WriteLog("Disabling buttons to complete current operation", Color.DarkGray);

        }

        /// <summary>
        /// enable buttons after action finishes
        /// </summary>
        private void EnableButtons()
        {
            this.btnFeed.Enabled = true;
            this.btnMakingPoop.Enabled = true;
            this.btnPlayWith.Enabled = true;
            this.btnPutToBed.Enabled = true;
            this.btnStartNewGame.Enabled = true;

            WriteLog("Enabling the buttons", Color.DarkGray);

        }

        #region timers
        private void timerHungriness_Tick(object sender, EventArgs e)
        {
            Tamagotchi.Instance.IncreaseHungriness(5);
            SetProgressBarValues();

            WriteLog("Hungriness increased over time for 5", Color.DarkGray);
        }

        private void timerTiredness_Tick(object sender, EventArgs e)
        {
            Tamagotchi.Instance.IncreaseTiredness(4);
            SetProgressBarValues();

            WriteLog("Tiredness increased over time for 4", Color.DarkGray);
        }

        private void timerHappiness_Tick(object sender, EventArgs e)
        {
            Tamagotchi.Instance.DecreaseHappiness(6);
            SetProgressBarValues();

            WriteLog("Happiness decreased over time for 6", Color.DarkGray);
        }

        #endregion

        /// <summary>
        /// button feed clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFeed_Click(object sender, EventArgs e)
        {
            WriteLog("Feeding the Tamagotchi", Color.DarkGreen);

            //open popup 
            frmPopFeed popFeed = new frmPopFeed();

            popFeed.ShowDialog(this);

            //the below line will be executed upon popup closing
            SetProgressBarValues();
        }

        /// <summary>
        /// button play clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayWith_Click(object sender, EventArgs e)
        {

            this.progressBarMain.Maximum = GetRandomNumber(10, 20);
            this.progressBarMain.Step = 1;
            this.progressBarMain.Value = 0;

            //timer interval 1 second
            this.timerPlay.Interval = 1000;

            WriteLog("Playing with Tamagotchi for " + this.progressBarMain.Maximum + " seconds", Color.DarkGreen);

            this.timerPlay.Start();
            DisableButtons();
        }

        /// <summary>
        /// timer play ticked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPlay_Tick(object sender, EventArgs e)
        {
            this.progressBarMain.PerformStep();

            //if timer complete all seconds
            if (this.progressBarMain.Value == this.progressBarMain.Maximum)
            {

                this.timerPlay.Stop();
                this.progressBarMain.Value = 0;

                //produce a fun object and consume it
                Fun fun = new BasicNeedFactory().Produce(BasicNeed.fun) as Fun;
                fun.Consume();

                WriteLog("Playing with Tamagotchi completed he should be in better shape now", Color.DarkGreen);

                SetProgressBarValues();
                EnableButtons();
            }
        }

        /// <summary>
        /// button put to bed clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPutToBed_Click(object sender, EventArgs e)
        {
            this.progressBarMain.Maximum = GetRandomNumber(20, 30);
            this.progressBarMain.Step = 1;
            this.progressBarMain.Value = 0;

            //timer interval 1 second
            this.timerSleep.Interval = 1000;

            WriteLog("Putting Tamagotchi in bed for " + this.progressBarMain.Maximum + " seconds", Color.DarkGreen);

            this.timerSleep.Start();
            DisableButtons();
        }

        /// <summary>
        /// timer sleep ticked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerSleep_Tick(object sender, EventArgs e)
        {
            this.progressBarMain.PerformStep();

            //if timer complete all seconds
            if (this.progressBarMain.Value == this.progressBarMain.Maximum)
            {
                this.timerSleep.Stop();
                this.progressBarMain.Value = 0;

                //produce a sleep object and consume it
                Sleep sleep = new BasicNeedFactory().Produce(BasicNeed.sleep) as Sleep;
                sleep.Consume();

                WriteLog("After this nap the Tamagotchi should feel more relaxed", Color.DarkGreen);

                SetProgressBarValues();
                EnableButtons();
            }
        }

        /// <summary>
        /// button poop clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakingPoop_Click(object sender, EventArgs e)
        {
            this.progressBarMain.Maximum = GetRandomNumber(5, 15);
            this.progressBarMain.Step = 1;
            this.progressBarMain.Value = 0;

            //timer interval 1 second
            this.timerPoop.Interval = 1000;

            WriteLog("Making Tamagotchi poop for " + this.progressBarMain.Maximum + " seconds", Color.DarkGreen);

            this.timerPoop.Start();
            DisableButtons();
        }

        /// <summary>
        /// timer poop ticked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPoop_Tick(object sender, EventArgs e)
        {
            this.progressBarMain.PerformStep();

            //if timer complete all seconds
            if (this.progressBarMain.Value == this.progressBarMain.Maximum)
            {
                this.timerPoop.Stop();
                this.progressBarMain.Value = 0;

                //produce a poop object and consume it ... wait whaaaaaaaattt !!! ughhh
                Poop poop = new BasicNeedFactory().Produce(BasicNeed.poop) as Poop;
                poop.Consume();

                WriteLog("After pooping the Tamagotchi should feel fresh new again", Color.DarkGreen);

                SetProgressBarValues();
                EnableButtons();
            }

        }

        #endregion

    }
}
