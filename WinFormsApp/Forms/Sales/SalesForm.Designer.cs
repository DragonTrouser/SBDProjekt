namespace WinFormsApp.Forms
{
    partial class SalesForm
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
            DateTimePickerFrom = new DateTimePicker();
            DateTimePickerTo = new DateTimePicker();
            LabelDateFrom = new Label();
            LabelDateTo = new Label();
            ComboBoxCategories = new ComboBox();
            ComboBoxSubcategories = new ComboBox();
            ComboBoxProducts = new ComboBox();
            LabelCategory = new Label();
            LabelSubcategory = new Label();
            LabelProduct = new Label();
            ListBoxOrders = new ListBox();
            LabelOrders = new Label();
            ButtonGoBack = new Button();
            ButtonNewOrder = new Button();
            ComboBoxLastName = new ComboBox();
            ComboBoxFirstName = new ComboBox();
            LabelLastName = new Label();
            LabelFirstName = new Label();
            SuspendLayout();
            // 
            // DateTimePickerFrom
            // 
            DateTimePickerFrom.Location = new Point(53, 12);
            DateTimePickerFrom.Name = "DateTimePickerFrom";
            DateTimePickerFrom.Size = new Size(200, 23);
            DateTimePickerFrom.TabIndex = 0;
            DateTimePickerFrom.ValueChanged += DateTimePickerFrom_ValueChanged;
            // 
            // DateTimePickerTo
            // 
            DateTimePickerTo.Location = new Point(53, 41);
            DateTimePickerTo.Name = "DateTimePickerTo";
            DateTimePickerTo.Size = new Size(200, 23);
            DateTimePickerTo.TabIndex = 1;
            DateTimePickerTo.ValueChanged += DateTimePickerTo_ValueChanged;
            // 
            // LabelDateFrom
            // 
            LabelDateFrom.AutoSize = true;
            LabelDateFrom.Location = new Point(12, 18);
            LabelDateFrom.Name = "LabelDateFrom";
            LabelDateFrom.Size = new Size(35, 15);
            LabelDateFrom.TabIndex = 2;
            LabelDateFrom.Text = "From";
            // 
            // LabelDateTo
            // 
            LabelDateTo.AutoSize = true;
            LabelDateTo.Location = new Point(12, 47);
            LabelDateTo.Name = "LabelDateTo";
            LabelDateTo.Size = new Size(20, 15);
            LabelDateTo.TabIndex = 3;
            LabelDateTo.Text = "To";
            // 
            // ComboBoxCategories
            // 
            ComboBoxCategories.FormattingEnabled = true;
            ComboBoxCategories.Location = new Point(87, 70);
            ComboBoxCategories.Name = "ComboBoxCategories";
            ComboBoxCategories.Size = new Size(166, 23);
            ComboBoxCategories.TabIndex = 4;
            ComboBoxCategories.SelectedIndexChanged += ComboBoxCategories_SelectedIndexChanged;
            // 
            // ComboBoxSubcategories
            // 
            ComboBoxSubcategories.FormattingEnabled = true;
            ComboBoxSubcategories.Location = new Point(87, 99);
            ComboBoxSubcategories.Name = "ComboBoxSubcategories";
            ComboBoxSubcategories.Size = new Size(166, 23);
            ComboBoxSubcategories.TabIndex = 5;
            ComboBoxSubcategories.SelectedIndexChanged += ComboBoxSubcategories_SelectedIndexChanged;
            // 
            // ComboBoxProducts
            // 
            ComboBoxProducts.FormattingEnabled = true;
            ComboBoxProducts.Location = new Point(87, 128);
            ComboBoxProducts.Name = "ComboBoxProducts";
            ComboBoxProducts.Size = new Size(166, 23);
            ComboBoxProducts.TabIndex = 6;
            ComboBoxProducts.SelectedIndexChanged += ComboBoxProducts_SelectedIndexChanged;
            // 
            // LabelCategory
            // 
            LabelCategory.AutoSize = true;
            LabelCategory.Location = new Point(12, 73);
            LabelCategory.Name = "LabelCategory";
            LabelCategory.Size = new Size(55, 15);
            LabelCategory.TabIndex = 7;
            LabelCategory.Text = "Category";
            // 
            // LabelSubcategory
            // 
            LabelSubcategory.AutoSize = true;
            LabelSubcategory.Location = new Point(12, 102);
            LabelSubcategory.Name = "LabelSubcategory";
            LabelSubcategory.Size = new Size(73, 15);
            LabelSubcategory.TabIndex = 8;
            LabelSubcategory.Text = "Subcategory";
            // 
            // LabelProduct
            // 
            LabelProduct.AutoSize = true;
            LabelProduct.Location = new Point(12, 131);
            LabelProduct.Name = "LabelProduct";
            LabelProduct.Size = new Size(49, 15);
            LabelProduct.TabIndex = 9;
            LabelProduct.Text = "Product";
            // 
            // ListBoxOrders
            // 
            ListBoxOrders.FormattingEnabled = true;
            ListBoxOrders.Location = new Point(259, 41);
            ListBoxOrders.Name = "ListBoxOrders";
            ListBoxOrders.Size = new Size(387, 394);
            ListBoxOrders.TabIndex = 10;
            ListBoxOrders.MouseDoubleClick += ListBoxOrders_MouseDoubleClick;
            // 
            // LabelOrders
            // 
            LabelOrders.AutoSize = true;
            LabelOrders.Location = new Point(259, 18);
            LabelOrders.Name = "LabelOrders";
            LabelOrders.Size = new Size(42, 15);
            LabelOrders.TabIndex = 11;
            LabelOrders.Text = "Orders";
            // 
            // ButtonGoBack
            // 
            ButtonGoBack.Location = new Point(12, 412);
            ButtonGoBack.Name = "ButtonGoBack";
            ButtonGoBack.Size = new Size(75, 23);
            ButtonGoBack.TabIndex = 12;
            ButtonGoBack.Text = "Go Back";
            ButtonGoBack.UseVisualStyleBackColor = true;
            ButtonGoBack.Click += ButtonGoBack_Click;
            // 
            // ButtonNewOrder
            // 
            ButtonNewOrder.Enabled = false;
            ButtonNewOrder.Location = new Point(12, 383);
            ButtonNewOrder.Name = "ButtonNewOrder";
            ButtonNewOrder.Size = new Size(75, 23);
            ButtonNewOrder.TabIndex = 13;
            ButtonNewOrder.Text = "New Order";
            ButtonNewOrder.UseVisualStyleBackColor = true;
            ButtonNewOrder.Click += ButtonNewOrder_Click;
            // 
            // ComboBoxLastName
            // 
            ComboBoxLastName.FormattingEnabled = true;
            ComboBoxLastName.Location = new Point(87, 186);
            ComboBoxLastName.Name = "ComboBoxLastName";
            ComboBoxLastName.Size = new Size(121, 23);
            ComboBoxLastName.TabIndex = 15;
            ComboBoxLastName.SelectedIndexChanged += ComboBoxLastName_SelectedIndexChanged;
            // 
            // ComboBoxFirstName
            // 
            ComboBoxFirstName.FormattingEnabled = true;
            ComboBoxFirstName.Location = new Point(87, 215);
            ComboBoxFirstName.Name = "ComboBoxFirstName";
            ComboBoxFirstName.Size = new Size(121, 23);
            ComboBoxFirstName.TabIndex = 16;
            ComboBoxFirstName.SelectedIndexChanged += ComboBoxFirstName_SelectedIndexChanged;
            // 
            // LabelLastName
            // 
            LabelLastName.AutoSize = true;
            LabelLastName.Location = new Point(12, 189);
            LabelLastName.Name = "LabelLastName";
            LabelLastName.Size = new Size(63, 15);
            LabelLastName.TabIndex = 18;
            LabelLastName.Text = "Last Name";
            // 
            // LabelFirstName
            // 
            LabelFirstName.AutoSize = true;
            LabelFirstName.Location = new Point(12, 218);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new Size(64, 15);
            LabelFirstName.TabIndex = 19;
            LabelFirstName.Text = "First Name";
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 450);
            Controls.Add(LabelFirstName);
            Controls.Add(LabelLastName);
            Controls.Add(ComboBoxFirstName);
            Controls.Add(ComboBoxLastName);
            Controls.Add(ButtonNewOrder);
            Controls.Add(ButtonGoBack);
            Controls.Add(LabelOrders);
            Controls.Add(ListBoxOrders);
            Controls.Add(LabelProduct);
            Controls.Add(LabelSubcategory);
            Controls.Add(LabelCategory);
            Controls.Add(ComboBoxProducts);
            Controls.Add(ComboBoxSubcategories);
            Controls.Add(ComboBoxCategories);
            Controls.Add(LabelDateTo);
            Controls.Add(LabelDateFrom);
            Controls.Add(DateTimePickerTo);
            Controls.Add(DateTimePickerFrom);
            Name = "SalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales";
            Load += SalesAnalyticsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DateTimePickerFrom;
        private DateTimePicker DateTimePickerTo;
        private Label LabelDateFrom;
        private Label LabelDateTo;
        private ComboBox ComboBoxCategories;
        private ComboBox ComboBoxSubcategories;
        private ComboBox ComboBoxProducts;
        private Label LabelCategory;
        private Label LabelSubcategory;
        private Label LabelProduct;
        private ListBox ListBoxOrders;
        private Label LabelOrders;
        private Button ButtonGoBack;
        private Button ButtonNewOrder;
        private ComboBox ComboBoxLastName;
        private ComboBox ComboBoxFirstName;
        private Label LabelLastName;
        private Label LabelFirstName;
    }
}