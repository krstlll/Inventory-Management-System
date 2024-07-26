namespace WindowsFormsApp10.Controls
{
    partial class UserControlInventorySummary
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
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstCategorySummary = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham Bold", 12F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(65, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Inventory Summary";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Gotham Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lblTotalItems.Location = new System.Drawing.Point(168, 137);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(237, 28);
            this.lblTotalItems.TabIndex = 35;
            this.lblTotalItems.Text = "Inventory Summary";
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.AutoSize = true;
            this.lblTotalQuantity.Font = new System.Drawing.Font("Gotham Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lblTotalQuantity.Location = new System.Drawing.Point(168, 179);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(237, 28);
            this.lblTotalQuantity.TabIndex = 36;
            this.lblTotalQuantity.Text = "Inventory Summary";
            this.lblTotalQuantity.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Gotham Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.lblTotalValue.Location = new System.Drawing.Point(168, 223);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(237, 28);
            this.lblTotalValue.TabIndex = 37;
            this.lblTotalValue.Text = "Inventory Summary";
            this.lblTotalValue.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gotham Book", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.label5.Location = new System.Drawing.Point(168, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 28);
            this.label5.TabIndex = 38;
            this.label5.Text = "Category Summary";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lstCategorySummary
            // 
            this.lstCategorySummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstCategorySummary.HideSelection = false;
            this.lstCategorySummary.Location = new System.Drawing.Point(173, 314);
            this.lstCategorySummary.Name = "lstCategorySummary";
            this.lstCategorySummary.Size = new System.Drawing.Size(343, 97);
            this.lstCategorySummary.TabIndex = 39;
            this.lstCategorySummary.UseCompatibleStateImageBehavior = false;
            // 
            // UserControlInventorySummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.lstCategorySummary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotalQuantity);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.label1);
            this.Name = "UserControlInventorySummary";
            this.Size = new System.Drawing.Size(1118, 701);
            this.Load += new System.EventHandler(this.UserControlInventorySummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstCategorySummary;
    }
}
