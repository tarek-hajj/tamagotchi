namespace VubiquityTest.Forms.Popups
{
    partial class frmPopFeed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopFeed));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuyFood = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuyChoice = new System.Windows.Forms.TextBox();
            this.txtShop = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFeed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFeedChoice = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPlayerKablammo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(43, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 376);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuyFood);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBuyChoice);
            this.groupBox2.Controls.Add(this.txtShop);
            this.groupBox2.Location = new System.Drawing.Point(360, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 338);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Food Store";
            // 
            // btnBuyFood
            // 
            this.btnBuyFood.Location = new System.Drawing.Point(15, 286);
            this.btnBuyFood.Name = "btnBuyFood";
            this.btnBuyFood.Size = new System.Drawing.Size(300, 23);
            this.btnBuyFood.TabIndex = 3;
            this.btnBuyFood.Text = "Buy food from store";
            this.btnBuyFood.UseVisualStyleBackColor = true;
            this.btnBuyFood.Click += new System.EventHandler(this.btnBuyFood_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose food number";
            // 
            // txtBuyChoice
            // 
            this.txtBuyChoice.Location = new System.Drawing.Point(215, 232);
            this.txtBuyChoice.Name = "txtBuyChoice";
            this.txtBuyChoice.Size = new System.Drawing.Size(100, 20);
            this.txtBuyChoice.TabIndex = 1;
            // 
            // txtShop
            // 
            this.txtShop.Location = new System.Drawing.Point(15, 39);
            this.txtShop.Multiline = true;
            this.txtShop.Name = "txtShop";
            this.txtShop.ReadOnly = true;
            this.txtShop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShop.Size = new System.Drawing.Size(300, 152);
            this.txtShop.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFeed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFeedChoice);
            this.groupBox1.Controls.Add(this.txtInventory);
            this.groupBox1.Location = new System.Drawing.Point(22, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 338);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food in my inventory";
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(15, 286);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(283, 23);
            this.btnFeed.TabIndex = 3;
            this.btnFeed.Text = "Feed Tamagotchi the selected item";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose food number";
            // 
            // txtFeedChoice
            // 
            this.txtFeedChoice.Location = new System.Drawing.Point(198, 232);
            this.txtFeedChoice.Name = "txtFeedChoice";
            this.txtFeedChoice.Size = new System.Drawing.Size(100, 20);
            this.txtFeedChoice.TabIndex = 1;
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(15, 39);
            this.txtInventory.Multiline = true;
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.ReadOnly = true;
            this.txtInventory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInventory.Size = new System.Drawing.Size(283, 152);
            this.txtInventory.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPlayerKablammo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(43, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 39);
            this.panel2.TabIndex = 1;
            // 
            // txtPlayerKablammo
            // 
            this.txtPlayerKablammo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerKablammo.ForeColor = System.Drawing.Color.Green;
            this.txtPlayerKablammo.Location = new System.Drawing.Point(585, 7);
            this.txtPlayerKablammo.Name = "txtPlayerKablammo";
            this.txtPlayerKablammo.ReadOnly = true;
            this.txtPlayerKablammo.Size = new System.Drawing.Size(100, 23);
            this.txtPlayerKablammo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(483, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kablammo $";
            // 
            // frmPopFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPopFeed";
            this.Text = "Feed Tamagotchi";
            this.Load += new System.EventHandler(this.frmPopFeed_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFeedChoice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuyFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuyChoice;
        private System.Windows.Forms.TextBox txtShop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPlayerKablammo;
        private System.Windows.Forms.Label label3;
    }
}