using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10.Controls
{
    public partial class UserControlInventorySummary : UserControl
    {

        private DataTable inventoryDataTable;

        public UserControlInventorySummary(DataTable dataTable)
        {
            InitializeComponent();
            inventoryDataTable = dataTable;
            GenerateSummary();
        }

        private void UserControlInventorySummary_Load(object sender, EventArgs e)
        {

        }
        private void GenerateSummary()
        {
            int totalItems = inventoryDataTable.Rows.Count;
            int totalQuantity = inventoryDataTable.AsEnumerable().Sum(row => row.Field<int>("Quantity"));
            decimal totalValue = inventoryDataTable.AsEnumerable().Sum(row => row.Field<decimal>("Price") * row.Field<int>("Quantity"));
            var categoryCounts = inventoryDataTable.AsEnumerable()
                .GroupBy(row => row.Field<string>("Category"))
                .Select(group => new
                {
                    Category = group.Key,
                    Count = group.Count()
                }).ToList();

            lblTotalItems.Text = $"Total Items: {totalItems}";
            lblTotalQuantity.Text = $"Total Quantity: {totalQuantity}";
            lblTotalValue.Text = $"Total Value: ${totalValue:F2}";

            lstCategorySummary.Items.Clear();
            foreach (var category in categoryCounts)
            {
                lstCategorySummary.Items.Add($"{category.Category}: {category.Count} items");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
