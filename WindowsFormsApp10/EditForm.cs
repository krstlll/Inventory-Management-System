using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class EditForm : Form
    {
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string ItemQuantity { get; set; }
        public string ItemPrice { get; set; }
        public string ItemCategory { get; set; }

        public EditForm(List<string> categories)
        {
            InitializeComponent();

            // Populate the ComboBox with categories
            categoryComboBox.Items.AddRange(categories.ToArray());
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = ItemName;
            descriptionTextBox.Text = ItemDescription;
            quantityTextBox.Text = ItemQuantity;
            priceTextBox.Text = ItemPrice;
            categoryComboBox.SelectedItem = ItemCategory;
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            ItemName = nameTextBox.Text;
            ItemDescription = descriptionTextBox.Text;
            ItemQuantity = quantityTextBox.Text;
            ItemPrice = priceTextBox.Text;
            ItemCategory = categoryComboBox.SelectedItem?.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
