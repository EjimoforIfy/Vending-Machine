using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VendingMachine1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, (double Price, int Stock)> _items;
        private List<(string Item, double Price)> _cart;
        private double _balance;

        public Form1()
        {
            InitializeComponent();
            InitializeVendingMachine();
        }

        private void InitializeVendingMachine()
        {
            // Initialize items with prices and stock
            _items = new Dictionary<string, (double Price, int Stock)>
            {
                { "Cola", (1.50, 5) },
                { "Chips", (1.00, 5) },
                { "Candy", (0.75, 5) },
                { "Water", (1.20, 5) },
                { "Chocolate", (1.25, 5) },
                { "Cookies", (0.90, 5) }
            };
            _cart = new List<(string Item, double Price)>();
            _balance = 0.0;
            // Populate coin slot with UK coin denominations
            cbCoinSlot.Items.AddRange(new object[] { 0.05, 0.10, 0.20, 0.50, 1.00, 2.00 });
            cbCoinSlot.SelectedIndex = 0;
            UpdateUI();
        }

        private void UpdateUI()
        {
            lblBalance.Text = $"Balance: £{_balance:F2}";
            lbItems.Items.Clear();
            foreach (var item in _items)
            {
                lbItems.Items.Add($"{item.Key}: £{item.Value.Price:F2} ({item.Value.Stock} left)");
            }
            lbCart.Items.Clear();
            foreach (var item in _cart)
            {
                lbCart.Items.Add($"{item.Item}: £{item.Price:F2}");
            }
            double totalPrice = _cart.Sum(item => item.Price);
            lblOrderSummary.Text = $"Order Summary: {_cart.Count} item(s), Total: £{totalPrice:F2}";
            btnDispense.Enabled = lbItems.SelectedIndex >= 0 && _balance >= _items[lbItems.SelectedItem?.ToString().Split(':')[0]].Price;
            btnCheckout.Enabled = _cart.Any() && _balance >= totalPrice;
        }

        private void btnInsertCoin_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCoinSlot.SelectedItem == null)
                {
                    lblStatus.Text = "Select a coin denomination.";
                    return;
                }
                double coin = (double)cbCoinSlot.SelectedItem;
                _balance += coin;
                lblStatus.Text = $"Inserted £{coin:F2}.";
                UpdateUI();
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error: {ex.Message}";
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbItems.SelectedIndex < 0)
                {
                    lblStatus.Text = "Select an item to add to cart.";
                    return;
                }
                string selectedItem = lbItems.SelectedItem.ToString().Split(':')[0];
                var (price, stock) = _items[selectedItem];
                if (stock <= 0)
                {
                    lblStatus.Text = $"{selectedItem} is out of stock.";
                    return;
                }
                _cart.Add((selectedItem, price));
                lblStatus.Text = $"Added {selectedItem} to cart.";
                UpdateUI();
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error: {ex.Message}";
            }
        }

        private void btnDispense_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbItems.SelectedIndex < 0)
                {
                    lblStatus.Text = "Select an item first.";
                    return;
                }
                string selectedItem = lbItems.SelectedItem.ToString().Split(':')[0];
                var (price, stock) = _items[selectedItem];
                if (stock <= 0)
                {
                    lblStatus.Text = $"{selectedItem} is out of stock.";
                    return;
                }
                if (_balance < price)
                {
                    lblStatus.Text = $"Insufficient funds. Need £{price:F2}, have £{_balance:F2}.";
                    return;
                }
                _balance -= price;
                _items[selectedItem] = (price, stock - 1);
                lblStatus.Text = $"Dispensed {selectedItem}. Change: £{_balance:F2}.";
                UpdateUI();
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error: {ex.Message}";
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_cart.Any())
                {
                    lblStatus.Text = "Cart is empty.";
                    return;
                }
                double totalPrice = _cart.Sum(item => item.Price);
                if (_balance < totalPrice)
                {
                    lblStatus.Text = $"Insufficient funds. Need £{totalPrice:F2}, have £{_balance:F2}.";
                    return;
                }
                foreach (var item in _cart)
                {
                    var (price, stock) = _items[item.Item];
                    if (stock <= 0)
                    {
                        lblStatus.Text = $"{item.Item} is out of stock.";
                        return;
                    }
                    _items[item.Item] = (price, stock - 1);
                }
                _balance -= totalPrice;
                lblStatus.Text = $"Checked out {_cart.Count} item(s). Change: £{_balance:F2}.";
                _cart.Clear();
                UpdateUI();
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error: {ex.Message}";
            }
        }

        private void btnReturnCoins_Click(object sender, EventArgs e)
        {
            if (_balance > 0)
            {
                lblStatus.Text = $"Returned £{_balance:F2}.";
                _balance = 0.0;
                _cart.Clear();
                UpdateUI();
            }
            else
            {
                lblStatus.Text = "No coins to return.";
            }
        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void lbCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}