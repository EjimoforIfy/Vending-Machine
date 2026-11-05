namespace VendingMachine1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lbItems = new System.Windows.Forms.ListBox();
            this.cbCoinSlot = new System.Windows.Forms.ComboBox();
            this.btnInsertCoin = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnDispense = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnReturnCoins = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCart = new System.Windows.Forms.ListBox();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 16;
            this.lbItems.Location = new System.Drawing.Point(12, 50);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(200, 164);
            this.lbItems.TabIndex = 0;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // cbCoinSlot
            // 
            this.cbCoinSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoinSlot.Location = new System.Drawing.Point(230, 50);
            this.cbCoinSlot.Name = "cbCoinSlot";
            this.cbCoinSlot.Size = new System.Drawing.Size(120, 24);
            this.cbCoinSlot.TabIndex = 1;
            // 
            // btnInsertCoin
            // 
            this.btnInsertCoin.Location = new System.Drawing.Point(230, 80);
            this.btnInsertCoin.Name = "btnInsertCoin";
            this.btnInsertCoin.Size = new System.Drawing.Size(120, 30);
            this.btnInsertCoin.TabIndex = 2;
            this.btnInsertCoin.Text = "Insert Coin";
            this.btnInsertCoin.UseVisualStyleBackColor = true;
            this.btnInsertCoin.Click += new System.EventHandler(this.btnInsertCoin_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(230, 116);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(120, 30);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnDispense
            // 
            this.btnDispense.Location = new System.Drawing.Point(230, 152);
            this.btnDispense.Name = "btnDispense";
            this.btnDispense.Size = new System.Drawing.Size(120, 30);
            this.btnDispense.TabIndex = 4;
            this.btnDispense.Text = "Dispense Single";
            this.btnDispense.UseVisualStyleBackColor = true;
            this.btnDispense.Click += new System.EventHandler(this.btnDispense_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(230, 188);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(120, 30);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnReturnCoins
            // 
            this.btnReturnCoins.Location = new System.Drawing.Point(230, 244);
            this.btnReturnCoins.Name = "btnReturnCoins";
            this.btnReturnCoins.Size = new System.Drawing.Size(120, 30);
            this.btnReturnCoins.TabIndex = 6;
            this.btnReturnCoins.Text = "Return Coins";
            this.btnReturnCoins.UseVisualStyleBackColor = true;
            this.btnReturnCoins.Click += new System.EventHandler(this.btnReturnCoins_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(12, 25);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(94, 16);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "Balance: £0.00";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 330);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 16);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Ready";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Coin Slot (£):";
            // 
            // lbCart
            // 
            this.lbCart.FormattingEnabled = true;
            this.lbCart.ItemHeight = 16;
            this.lbCart.Location = new System.Drawing.Point(12, 244);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(200, 84);
            this.lbCart.TabIndex = 10;
            this.lbCart.SelectedIndexChanged += new System.EventHandler(this.lbCart_SelectedIndexChanged);
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Location = new System.Drawing.Point(9, 221);
            this.lblOrderSummary.MinimumSize = new System.Drawing.Size(231, 16);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(231, 16);
            this.lblOrderSummary.TabIndex = 11;
            this.lblOrderSummary.Text = "Order Summary: 0 item(s), Total: £0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 360);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.lbCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnReturnCoins);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnDispense);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnInsertCoin);
            this.Controls.Add(this.cbCoinSlot);
            this.Controls.Add(this.lbItems);
            this.Name = "Form1";
            this.Text = "Vending Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.ComboBox cbCoinSlot;
        private System.Windows.Forms.Button btnInsertCoin;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnDispense;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnReturnCoins;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCart;
        private System.Windows.Forms.Label lblOrderSummary;
    }
}