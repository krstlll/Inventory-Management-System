using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace WindowsFormsApp10.Controls
{
    public partial class UserControlAddItem : UserControl
    {
        private string dataFilePath = "inventoryData.json";

        public UserControlAddItem()
        {
            InitializeComponent();
            InitializeCategoryComboBox();
        }

        private void UserControlAddItem_Load(object sender, EventArgs e)
        {
            // Any initialization logic that needs to run when the control loads
        }

        private void InitializeCategoryComboBox()
        {
            category_cb.Items.Add("Frozen");
            category_cb.Items.Add("Snack");
            category_cb.Items.Add("Toiletries");
            category_cb.Items.Add("Fresh Goods");
            category_cb.Items.Add("SoftDrinks");
            category_cb.Items.Add("Noodles");

            category_cb.SelectedIndex = -1;
        }


        private List<Item> LoadItems()
        {
            if (!File.Exists(dataFilePath))
                return new List<Item>();

            var json = File.ReadAllText(dataFilePath);
            return JsonSerializer.Deserialize<List<Item>>(json);
        }

        private void SaveItems(List<Item> items)
        {
            var json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(dataFilePath, json);
        }

        private void addItem_ucInventory_Click_1(object sender, EventArgs e)
        {
            var item = new Item
            {
                Name = name_tb.Text,
                Description = desc_tb.Text,
                Quantity = quantity_tb.Text,
                Price = price_tb.Text,
                Category = category_cb.SelectedItem?.ToString(),
            };

            var items = LoadItems();
            items.Add(item);
            SaveItems(items);

            name_tb.Clear();
            desc_tb.Clear();
            quantity_tb.Clear();
            price_tb.Clear();
            category_cb.SelectedIndex = -1;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void category_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void price_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void quantity_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void desc_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void name_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }
    }
}
