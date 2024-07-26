namespace WindowsFormsApp10.Controls
{
    partial class UserControlAddItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.category_cb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.price_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantity_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.desc_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addItem_ucInventory = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gotham Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Item";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // category_cb
            // 
            this.category_cb.BackColor = System.Drawing.Color.Transparent;
            this.category_cb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.category_cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.category_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_cb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.category_cb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(188)))), ((int)(((byte)(16)))));
            this.category_cb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(188)))), ((int)(((byte)(16)))));
            this.category_cb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.category_cb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.category_cb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(188)))), ((int)(((byte)(16)))));
            this.category_cb.ItemHeight = 30;
            this.category_cb.Location = new System.Drawing.Point(61, 522);
            this.category_cb.Name = "category_cb";
            this.category_cb.Size = new System.Drawing.Size(296, 36);
            this.category_cb.TabIndex = 40;
            this.category_cb.SelectedIndexChanged += new System.EventHandler(this.category_cb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gotham Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.label7.Location = new System.Drawing.Point(57, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Category";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // price_tb
            // 
            this.price_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.price_tb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.price_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price_tb.CustomizableEdges.BottomLeft = false;
            this.price_tb.CustomizableEdges.BottomRight = false;
            this.price_tb.CustomizableEdges.TopLeft = false;
            this.price_tb.CustomizableEdges.TopRight = false;
            this.price_tb.DefaultText = "";
            this.price_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.price_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.price_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price_tb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.price_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(188)))), ((int)(((byte)(16)))));
            this.price_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.price_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.price_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(188)))), ((int)(((byte)(16)))));
            this.price_tb.Location = new System.Drawing.Point(61, 426);
            this.price_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.price_tb.Name = "price_tb";
            this.price_tb.PasswordChar = '\0';
            this.price_tb.PlaceholderText = "";
            this.price_tb.SelectedText = "";
            this.price_tb.Size = new System.Drawing.Size(296, 33);
            this.price_tb.TabIndex = 38;
            this.price_tb.TextChanged += new System.EventHandler(this.price_tb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gotham Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(59, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // quantity_tb
            // 
            this.quantity_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.quantity_tb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.quantity_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantity_tb.CustomizableEdges.BottomLeft = false;
            this.quantity_tb.CustomizableEdges.BottomRight = false;
            this.quantity_tb.CustomizableEdges.TopLeft = false;
            this.quantity_tb.CustomizableEdges.TopRight = false;
            this.quantity_tb.DefaultText = "";
            this.quantity_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantity_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantity_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantity_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantity_tb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.quantity_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(188)))), ((int)(((byte)(16)))));
            this.quantity_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quantity_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.quantity_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(188)))), ((int)(((byte)(16)))));
            this.quantity_tb.Location = new System.Drawing.Point(59, 327);
            this.quantity_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quantity_tb.Name = "quantity_tb";
            this.quantity_tb.PasswordChar = '\0';
            this.quantity_tb.PlaceholderText = "";
            this.quantity_tb.SelectedText = "";
            this.quantity_tb.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.quantity_tb.Size = new System.Drawing.Size(296, 33);
            this.quantity_tb.TabIndex = 36;
            this.quantity_tb.TextChanged += new System.EventHandler(this.quantity_tb_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gotham Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.label3.Location = new System.Drawing.Point(57, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Stock";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // desc_tb
            // 
            this.desc_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.desc_tb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.desc_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.desc_tb.CustomizableEdges.BottomLeft = false;
            this.desc_tb.CustomizableEdges.BottomRight = false;
            this.desc_tb.CustomizableEdges.TopLeft = false;
            this.desc_tb.CustomizableEdges.TopRight = false;
            this.desc_tb.DefaultText = "";
            this.desc_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.desc_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.desc_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.desc_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.desc_tb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.desc_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(188)))), ((int)(((byte)(16)))));
            this.desc_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.desc_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.desc_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(188)))), ((int)(((byte)(16)))));
            this.desc_tb.Location = new System.Drawing.Point(61, 229);
            this.desc_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.desc_tb.Name = "desc_tb";
            this.desc_tb.PasswordChar = '\0';
            this.desc_tb.PlaceholderText = "";
            this.desc_tb.SelectedText = "";
            this.desc_tb.Size = new System.Drawing.Size(985, 33);
            this.desc_tb.TabIndex = 34;
            this.desc_tb.TextChanged += new System.EventHandler(this.desc_tb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gotham Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(59, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Description";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // name_tb
            // 
            this.name_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.name_tb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.name_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_tb.CustomizableEdges.BottomLeft = false;
            this.name_tb.CustomizableEdges.BottomRight = false;
            this.name_tb.CustomizableEdges.TopLeft = false;
            this.name_tb.CustomizableEdges.TopRight = false;
            this.name_tb.DefaultText = "";
            this.name_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_tb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.name_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(188)))), ((int)(((byte)(16)))));
            this.name_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.name_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.name_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(188)))), ((int)(((byte)(16)))));
            this.name_tb.Location = new System.Drawing.Point(59, 130);
            this.name_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_tb.Name = "name_tb";
            this.name_tb.PasswordChar = '\0';
            this.name_tb.PlaceholderText = "";
            this.name_tb.SelectedText = "";
            this.name_tb.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.name_tb.Size = new System.Drawing.Size(987, 33);
            this.name_tb.TabIndex = 32;
            this.name_tb.TextChanged += new System.EventHandler(this.name_tb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gotham Book", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(57, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Item";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // addItem_ucInventory
            // 
            this.addItem_ucInventory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.addItem_ucInventory.BorderRadius = 5;
            this.addItem_ucInventory.BorderThickness = 1;
            this.addItem_ucInventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addItem_ucInventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addItem_ucInventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addItem_ucInventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addItem_ucInventory.FillColor = System.Drawing.Color.Transparent;
            this.addItem_ucInventory.Font = new System.Drawing.Font("Gotham Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem_ucInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(84)))));
            this.addItem_ucInventory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(12)))));
            this.addItem_ucInventory.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(12)))));
            this.addItem_ucInventory.HoverState.Image = global::WindowsFormsApp10.Properties.Resources.Plus_Math1;
            this.addItem_ucInventory.Image = global::WindowsFormsApp10.Properties.Resources.kjlkjl;
            this.addItem_ucInventory.Location = new System.Drawing.Point(737, 600);
            this.addItem_ucInventory.Name = "addItem_ucInventory";
            this.addItem_ucInventory.Size = new System.Drawing.Size(296, 38);
            this.addItem_ucInventory.TabIndex = 30;
            this.addItem_ucInventory.Text = "Add Item";
            this.addItem_ucInventory.Click += new System.EventHandler(this.addItem_ucInventory_Click_1);
            // 
            // UserControlAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.category_cb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.price_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantity_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desc_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addItem_ucInventory);
            this.Controls.Add(this.label1);
            this.Name = "UserControlAddItem";
            this.Size = new System.Drawing.Size(1118, 748);
            this.Load += new System.EventHandler(this.UserControlAddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox category_cb;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox price_tb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox quantity_tb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox desc_tb;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox name_tb;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button addItem_ucInventory;
    }
}
