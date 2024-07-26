using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace WindowsFormsApp10.Controls
{
    public partial class UserControlInventory : UserControl
    {
        public class Item
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Quantity { get; set; }
            public string Price { get; set; }
            public string Category { get; set; }
        }

        private DataTable inventoryDataTable;
        private string dataFilePath = "inventoryData.json";

        public UserControlInventory()
        {
            InitializeComponent();
            InitializeInventoryDataTable();
            LoadItems();
        }

        public DataTable GetInventoryDataTable()
        {
            return inventoryDataTable;
        }

        private void InitializeInventoryDataTable()
        {
            inventoryDataTable = new DataTable();
            inventoryDataTable.Columns.Add("Name");
            inventoryDataTable.Columns.Add("Description");
            inventoryDataTable.Columns.Add("Quantity", typeof(int)); // Ensure Quantity is numeric
            inventoryDataTable.Columns.Add("Price", typeof(decimal)); // Ensure Price is numeric
            inventoryDataTable.Columns.Add("Category");

            dataGridView1.DataSource = inventoryDataTable;

            // Add Edit and Delete buttons
            var editColumn = new DataGridViewButtonColumn
            {
                Name = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Width = 60,
                HeaderText = "Edit"
            };
            dataGridView1.Columns.Add(editColumn);

            var deleteColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 60,
                HeaderText = "Delete"
            };
            dataGridView1.Columns.Add(deleteColumn);
        }

        private void LoadItems()
        {
            // Initial load method left intentionally empty
        }

        private void ApplyFilter()
        {
            if (filter_cb.SelectedItem == null) return;

            string selectedFilter = filter_cb.SelectedItem.ToString();
            DataView view = new DataView(inventoryDataTable);

            string filterExpression = "";

            switch (selectedFilter)
            {
                case "Alphabetical":
                    view.Sort = "Name ASC";
                    break;
                case "Price":
                    view.Sort = "Price ASC";
                    break;
                case "Low Stock":
                    filterExpression = "Quantity < 10";
                    break;
                case "Out of Stock":
                    filterExpression = "Quantity = 0";
                    break;
                case "All":
                    filterExpression = "";
                    break;
            }

            if (!string.IsNullOrEmpty(filterExpression))
            {
                view.RowFilter = filterExpression;
            }

            dataGridView1.DataSource = view;
        }

        private void filter_cb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }


        private void UserControlInventory_Load(object sender, EventArgs e)
        {
            ReloadData();
            ApplyFilter();
        }

        public void ReloadData()
        {
            inventoryDataTable.Clear();
            if (!File.Exists(dataFilePath)) return;

            var json = File.ReadAllText(dataFilePath);
            var items = JsonSerializer.Deserialize<List<Item>>(json);

            foreach (var item in items)
            {
                var row = inventoryDataTable.NewRow();
                row["Name"] = item.Name;
                row["Description"] = item.Description;
                row["Quantity"] = int.TryParse(item.Quantity, out int qty) ? qty : 0; // Convert to integer
                row["Price"] = decimal.TryParse(item.Price, out decimal price) ? price : 0.0m; // Convert to decimal
                row["Category"] = item.Category;
                inventoryDataTable.Rows.Add(row);
            }
        }

        private void SaveItems()
        {
            var items = new List<Item>();
            foreach (DataRow row in inventoryDataTable.Rows)
            {
                items.Add(new Item
                {
                    Name = row["Name"].ToString(),
                    Description = row["Description"].ToString(),
                    Quantity = row["Quantity"].ToString(),
                    Price = row["Price"].ToString(),
                    Category = row["Category"].ToString()
                });
            }

            var json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(dataFilePath, json);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is within a valid row
            {
                // Handle Edit Button Click
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    var item = new Item
                    {
                        Name = row.Cells["Name"].Value.ToString(),
                        Description = row.Cells["Description"].Value.ToString(),
                        Quantity = row.Cells["Quantity"].Value.ToString(),
                        Price = row.Cells["Price"].Value.ToString(),
                        Category = row.Cells["Category"].Value.ToString(),
                    };

                    var categories = new List<string>
                    {
                        "Frozen",
                        "Snack",
                        "Toiletries",
                        "Fresh Goods",
                        "Soft Drinks",
                        "Noodles"
                    };

                    using (var editForm = new EditForm(categories))
                    {
                        editForm.ItemName = item.Name;
                        editForm.ItemDescription = item.Description;
                        editForm.ItemQuantity = item.Quantity;
                        editForm.ItemPrice = item.Price;
                        editForm.ItemCategory = item.Category;

                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            row.Cells["Name"].Value = editForm.ItemName;
                            row.Cells["Description"].Value = editForm.ItemDescription;
                            row.Cells["Quantity"].Value = editForm.ItemQuantity;
                            row.Cells["Price"].Value = editForm.ItemPrice;
                            row.Cells["Category"].Value = editForm.ItemCategory;
                            SaveItems();
                        }
                    }
                }
                // Handle Delete Button Click
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    // Confirm deletion
                    var confirmResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        // Remove the selected row
                        dataGridView1.Rows.RemoveAt(e.RowIndex);

                        // Also, remove the item from your data source
                        SaveItems(); // Save changes to the JSON file
                    }
                }
            }
        }
    }
}
