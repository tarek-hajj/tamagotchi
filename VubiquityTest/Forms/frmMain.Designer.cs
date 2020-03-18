namespace VubiquityTest.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStartNewGame = new System.Windows.Forms.Button();
            this.btnFeed = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMakingPoop = new System.Windows.Forms.Button();
            this.btnPutToBed = new System.Windows.Forms.Button();
            this.btnPlayWith = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pgbHappiness = new System.Windows.Forms.ProgressBar();
            this.pgbTiredness = new System.Windows.Forms.ProgressBar();
            this.pgbFullness = new System.Windows.Forms.ProgressBar();
            this.pgbHungriness = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.timerHungriness = new System.Windows.Forms.Timer(this.components);
            this.timerTiredness = new System.Windows.Forms.Timer(this.components);
            this.timerFullness = new System.Windows.Forms.Timer(this.components);
            this.timerHappiness = new System.Windows.Forms.Timer(this.components);
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.timerSleep = new System.Windows.Forms.Timer(this.components);
            this.timerPoop = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartNewGame
            // 
            this.btnStartNewGame.Location = new System.Drawing.Point(24, 39);
            this.btnStartNewGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartNewGame.Name = "btnStartNewGame";
            this.btnStartNewGame.Size = new System.Drawing.Size(247, 49);
            this.btnStartNewGame.TabIndex = 0;
            this.btnStartNewGame.Text = "Start a new Game";
            this.btnStartNewGame.UseVisualStyleBackColor = true;
            this.btnStartNewGame.Click += new System.EventHandler(this.btnStartNewGame_Click);
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(24, 34);
            this.btnFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(247, 49);
            this.btnFeed.TabIndex = 2;
            this.btnFeed.Text = "Feed";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMakingPoop);
            this.groupBox1.Controls.Add(this.btnPutToBed);
            this.groupBox1.Controls.Add(this.btnPlayWith);
            this.groupBox1.Controls.Add(this.btnFeed);
            this.groupBox1.Location = new System.Drawing.Point(28, 213);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(304, 352);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // btnMakingPoop
            // 
            this.btnMakingPoop.Location = new System.Drawing.Point(24, 273);
            this.btnMakingPoop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMakingPoop.Name = "btnMakingPoop";
            this.btnMakingPoop.Size = new System.Drawing.Size(247, 49);
            this.btnMakingPoop.TabIndex = 5;
            this.btnMakingPoop.Text = "Making Poop";
            this.btnMakingPoop.UseVisualStyleBackColor = true;
            this.btnMakingPoop.Click += new System.EventHandler(this.btnMakingPoop_Click);
            // 
            // btnPutToBed
            // 
            this.btnPutToBed.Location = new System.Drawing.Point(24, 193);
            this.btnPutToBed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPutToBed.Name = "btnPutToBed";
            this.btnPutToBed.Size = new System.Drawing.Size(247, 49);
            this.btnPutToBed.TabIndex = 4;
            this.btnPutToBed.Text = "Put to Bed";
            this.btnPutToBed.UseVisualStyleBackColor = true;
            this.btnPutToBed.Click += new System.EventHandler(this.btnPutToBed_Click);
            // 
            // btnPlayWith
            // 
            this.btnPlayWith.Location = new System.Drawing.Point(24, 113);
            this.btnPlayWith.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayWith.Name = "btnPlayWith";
            this.btnPlayWith.Size = new System.Drawing.Size(247, 49);
            this.btnPlayWith.TabIndex = 3;
            this.btnPlayWith.Text = "Play With";
            this.btnPlayWith.UseVisualStyleBackColor = true;
            this.btnPlayWith.Click += new System.EventHandler(this.btnPlayWith_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStartNewGame);
            this.groupBox2.Location = new System.Drawing.Point(28, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(304, 117);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tamagotchi";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.progressBarMain, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1033, 641);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(55, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 568);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtLog, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(416, 36);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(560, 568);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pgbHappiness);
            this.panel2.Controls.Add(this.pgbTiredness);
            this.panel2.Controls.Add(this.pgbFullness);
            this.panel2.Controls.Add(this.pgbHungriness);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 105);
            this.panel2.TabIndex = 0;
            // 
            // pgbHappiness
            // 
            this.pgbHappiness.Location = new System.Drawing.Point(391, 58);
            this.pgbHappiness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgbHappiness.Name = "pgbHappiness";
            this.pgbHappiness.Size = new System.Drawing.Size(133, 28);
            this.pgbHappiness.TabIndex = 7;
            // 
            // pgbTiredness
            // 
            this.pgbTiredness.Location = new System.Drawing.Point(391, 15);
            this.pgbTiredness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgbTiredness.Name = "pgbTiredness";
            this.pgbTiredness.Size = new System.Drawing.Size(133, 28);
            this.pgbTiredness.TabIndex = 6;
            // 
            // pgbFullness
            // 
            this.pgbFullness.Location = new System.Drawing.Point(111, 58);
            this.pgbFullness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgbFullness.Name = "pgbFullness";
            this.pgbFullness.Size = new System.Drawing.Size(133, 28);
            this.pgbFullness.TabIndex = 5;
            // 
            // pgbHungriness
            // 
            this.pgbHungriness.Location = new System.Drawing.Point(111, 15);
            this.pgbHungriness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgbHungriness.Name = "pgbHungriness";
            this.pgbHungriness.Size = new System.Drawing.Size(133, 28);
            this.pgbHungriness.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Happiness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiredness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fullness";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hungriness";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.White;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(4, 117);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(552, 447);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "";
            // 
            // progressBarMain
            // 
            this.progressBarMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarMain.Location = new System.Drawing.Point(416, 612);
            this.progressBarMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(560, 25);
            this.progressBarMain.TabIndex = 2;
            // 
            // timerHungriness
            // 
            this.timerHungriness.Interval = 10000;
            this.timerHungriness.Tick += new System.EventHandler(this.timerHungriness_Tick);
            // 
            // timerTiredness
            // 
            this.timerTiredness.Interval = 15000;
            this.timerTiredness.Tick += new System.EventHandler(this.timerTiredness_Tick);
            // 
            // timerFullness
            // 
            this.timerFullness.Interval = 12000;
            // 
            // timerHappiness
            // 
            this.timerHappiness.Interval = 13000;
            this.timerHappiness.Tick += new System.EventHandler(this.timerHappiness_Tick);
            // 
            // timerPlay
            // 
            this.timerPlay.Interval = 20000;
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // timerSleep
            // 
            this.timerSleep.Interval = 20000;
            this.timerSleep.Tick += new System.EventHandler(this.timerSleep_Tick);
            // 
            // timerPoop
            // 
            this.timerPoop.Interval = 20000;
            this.timerPoop.Tick += new System.EventHandler(this.timerPoop_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 641);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Tamagotchi Game";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartNewGame;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMakingPoop;
        private System.Windows.Forms.Button btnPutToBed;
        private System.Windows.Forms.Button btnPlayWith;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pgbHappiness;
        private System.Windows.Forms.ProgressBar pgbTiredness;
        private System.Windows.Forms.ProgressBar pgbFullness;
        private System.Windows.Forms.ProgressBar pgbHungriness;
        private System.Windows.Forms.Timer timerHungriness;
        private System.Windows.Forms.Timer timerTiredness;
        private System.Windows.Forms.Timer timerFullness;
        private System.Windows.Forms.Timer timerHappiness;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.Timer timerPlay;
        private System.Windows.Forms.Timer timerSleep;
        private System.Windows.Forms.Timer timerPoop;
        private System.Windows.Forms.RichTextBox txtLog;
    }
}