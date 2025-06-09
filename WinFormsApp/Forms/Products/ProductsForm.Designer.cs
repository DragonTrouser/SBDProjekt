namespace WinFormsApp.Forms
{
    partial class ProductsForm
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
            ComboBoxCategories = new ComboBox();
            ComboBoxSubcategories = new ComboBox();
            ListBoxProducts = new ListBox();
            LabelCategories = new Label();
            LabelSubcategories = new Label();
            LabelProducts = new Label();
            ButtonNewProduct = new Button();
            ButtonGoBack = new Button();
            SuspendLayout();
            // 
            // ComboBoxCategories
            // 
            ComboBoxCategories.FormattingEnabled = true;
            ComboBoxCategories.Location = new Point(12, 33);
            ComboBoxCategories.Name = "ComboBoxCategories";
            ComboBoxCategories.Size = new Size(121, 23);
            ComboBoxCategories.TabIndex = 0;
            ComboBoxCategories.SelectedIndexChanged += ComboBoxCategories_SelectedIndexChanged;
            // 
            // ComboBoxSubcategories
            // 
            ComboBoxSubcategories.FormattingEnabled = true;
            ComboBoxSubcategories.Location = new Point(12, 83);
            ComboBoxSubcategories.Name = "ComboBoxSubcategories";
            ComboBoxSubcategories.Size = new Size(121, 23);
            ComboBoxSubcategories.TabIndex = 1;
            ComboBoxSubcategories.SelectedIndexChanged += ComboBoxSubcategories_SelectedIndexChanged;
            // 
            // ListBoxProducts
            // 
            ListBoxProducts.FormattingEnabled = true;
            ListBoxProducts.Location = new Point(139, 33);
            ListBoxProducts.Name = "ListBoxProducts";
            ListBoxProducts.Size = new Size(560, 349);
            ListBoxProducts.TabIndex = 2;
            ListBoxProducts.MouseDoubleClick += ListBoxProducts_MouseDoubleClick;
            // 
            // LabelCategories
            // 
            LabelCategories.AutoSize = true;
            LabelCategories.Location = new Point(12, 15);
            LabelCategories.Name = "LabelCategories";
            LabelCategories.Size = new Size(63, 15);
            LabelCategories.TabIndex = 3;
            LabelCategories.Text = "Categories";
            // 
            // LabelSubcategories
            // 
            LabelSubcategories.AutoSize = true;
            LabelSubcategories.Location = new Point(12, 65);
            LabelSubcategories.Name = "LabelSubcategories";
            LabelSubcategories.Size = new Size(81, 15);
            LabelSubcategories.TabIndex = 4;
            LabelSubcategories.Text = "Subcategories";
            // 
            // LabelProducts
            // 
            LabelProducts.AutoSize = true;
            LabelProducts.Location = new Point(139, 15);
            LabelProducts.Name = "LabelProducts";
            LabelProducts.Size = new Size(54, 15);
            LabelProducts.TabIndex = 5;
            LabelProducts.Text = "Products";
            // 
            // ButtonNewProduct
            // 
            ButtonNewProduct.AutoSize = true;
            ButtonNewProduct.Location = new Point(12, 112);
            ButtonNewProduct.Name = "ButtonNewProduct";
            ButtonNewProduct.Size = new Size(86, 25);
            ButtonNewProduct.TabIndex = 6;
            ButtonNewProduct.Text = "New Product";
            ButtonNewProduct.UseVisualStyleBackColor = true;
            ButtonNewProduct.Click += ButtonNewProduct_Click;
            // 
            // ButtonGoBack
            // 
            ButtonGoBack.Location = new Point(12, 359);
            ButtonGoBack.Name = "ButtonGoBack";
            ButtonGoBack.Size = new Size(75, 23);
            ButtonGoBack.TabIndex = 7;
            ButtonGoBack.Text = "Go Back";
            ButtonGoBack.UseVisualStyleBackColor = true;
            ButtonGoBack.Click += ButtonGoBack_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 394);
            Controls.Add(ButtonGoBack);
            Controls.Add(ButtonNewProduct);
            Controls.Add(LabelProducts);
            Controls.Add(LabelSubcategories);
            Controls.Add(LabelCategories);
            Controls.Add(ListBoxProducts);
            Controls.Add(ComboBoxSubcategories);
            Controls.Add(ComboBoxCategories);
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            Load += ProductsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBoxCategories;
        private ComboBox ComboBoxSubcategories;
        private ListBox ListBoxProducts;
        private Label LabelCategories;
        private Label LabelSubcategories;
        private Label LabelProducts;
        private Button ButtonNewProduct;
        private Button ButtonGoBack;
    }
}