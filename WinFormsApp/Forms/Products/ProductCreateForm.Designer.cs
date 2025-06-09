namespace WinFormsApp.Forms.Products
{
    partial class ProductCreateForm
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
            LabelName = new Label();
            TextBoxName = new TextBox();
            TextBoxProductNumber = new TextBox();
            LabelProductNumber = new Label();
            LabelColor = new Label();
            LabelSafetyStockLevel = new Label();
            LabelReorderPoint = new Label();
            NumericSafetyStockLevel = new NumericUpDown();
            NumericReorderPoint = new NumericUpDown();
            NumericStandardCost = new NumericUpDown();
            NumericListPrice = new NumericUpDown();
            LabelStandardCost = new Label();
            LabelListPrice = new Label();
            TextBoxSize = new TextBox();
            NumericWeight = new NumericUpDown();
            DateTimePickerSellStartDate = new DateTimePicker();
            LabelSellStartDate = new Label();
            LabelWeightUnit = new Label();
            LabelWeight = new Label();
            LabelSizeUnit = new Label();
            LabelSize = new Label();
            LabelHint = new Label();
            ButtonCreate = new Button();
            ButtonCancel = new Button();
            ComboBoxCategories = new ComboBox();
            ComboBoxSubcategories = new ComboBox();
            LabelCategory = new Label();
            LabelSubcategory = new Label();
            TextBoxColor = new TextBox();
            ComboBoxSizeUnit = new ComboBox();
            ComboBoxWeightUnit = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)NumericSafetyStockLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericReorderPoint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericStandardCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericListPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericWeight).BeginInit();
            SuspendLayout();
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(12, 15);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(44, 15);
            LabelName.TabIndex = 0;
            LabelName.Text = "Name*";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(119, 12);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(161, 23);
            TextBoxName.TabIndex = 1;
            // 
            // TextBoxProductNumber
            // 
            TextBoxProductNumber.Location = new Point(119, 41);
            TextBoxProductNumber.Name = "TextBoxProductNumber";
            TextBoxProductNumber.Size = new Size(120, 23);
            TextBoxProductNumber.TabIndex = 2;
            // 
            // LabelProductNumber
            // 
            LabelProductNumber.AutoSize = true;
            LabelProductNumber.Location = new Point(12, 44);
            LabelProductNumber.Name = "LabelProductNumber";
            LabelProductNumber.Size = new Size(101, 15);
            LabelProductNumber.TabIndex = 3;
            LabelProductNumber.Text = "Product Number*";
            // 
            // LabelColor
            // 
            LabelColor.AutoSize = true;
            LabelColor.Location = new Point(12, 73);
            LabelColor.Name = "LabelColor";
            LabelColor.Size = new Size(36, 15);
            LabelColor.TabIndex = 5;
            LabelColor.Text = "Color";
            // 
            // LabelSafetyStockLevel
            // 
            LabelSafetyStockLevel.AutoSize = true;
            LabelSafetyStockLevel.Location = new Point(12, 120);
            LabelSafetyStockLevel.Name = "LabelSafetyStockLevel";
            LabelSafetyStockLevel.Size = new Size(101, 15);
            LabelSafetyStockLevel.TabIndex = 6;
            LabelSafetyStockLevel.Text = "Safety Stock Level";
            // 
            // LabelReorderPoint
            // 
            LabelReorderPoint.AutoSize = true;
            LabelReorderPoint.Location = new Point(12, 149);
            LabelReorderPoint.Name = "LabelReorderPoint";
            LabelReorderPoint.Size = new Size(79, 15);
            LabelReorderPoint.TabIndex = 7;
            LabelReorderPoint.Text = "Reorder Point";
            // 
            // NumericSafetyStockLevel
            // 
            NumericSafetyStockLevel.Location = new Point(119, 118);
            NumericSafetyStockLevel.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NumericSafetyStockLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericSafetyStockLevel.Name = "NumericSafetyStockLevel";
            NumericSafetyStockLevel.Size = new Size(120, 23);
            NumericSafetyStockLevel.TabIndex = 8;
            NumericSafetyStockLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NumericReorderPoint
            // 
            NumericReorderPoint.Location = new Point(119, 147);
            NumericReorderPoint.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NumericReorderPoint.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericReorderPoint.Name = "NumericReorderPoint";
            NumericReorderPoint.Size = new Size(120, 23);
            NumericReorderPoint.TabIndex = 9;
            NumericReorderPoint.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NumericStandardCost
            // 
            NumericStandardCost.DecimalPlaces = 4;
            NumericStandardCost.Location = new Point(373, 118);
            NumericStandardCost.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NumericStandardCost.Name = "NumericStandardCost";
            NumericStandardCost.Size = new Size(120, 23);
            NumericStandardCost.TabIndex = 10;
            // 
            // NumericListPrice
            // 
            NumericListPrice.DecimalPlaces = 4;
            NumericListPrice.Location = new Point(373, 147);
            NumericListPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NumericListPrice.Name = "NumericListPrice";
            NumericListPrice.Size = new Size(120, 23);
            NumericListPrice.TabIndex = 11;
            // 
            // LabelStandardCost
            // 
            LabelStandardCost.AutoSize = true;
            LabelStandardCost.Location = new Point(286, 120);
            LabelStandardCost.Name = "LabelStandardCost";
            LabelStandardCost.Size = new Size(81, 15);
            LabelStandardCost.TabIndex = 12;
            LabelStandardCost.Text = "Standard Cost";
            // 
            // LabelListPrice
            // 
            LabelListPrice.AutoSize = true;
            LabelListPrice.Location = new Point(286, 149);
            LabelListPrice.Name = "LabelListPrice";
            LabelListPrice.Size = new Size(51, 15);
            LabelListPrice.TabIndex = 13;
            LabelListPrice.Text = "ListPrice";
            // 
            // TextBoxSize
            // 
            TextBoxSize.Location = new Point(68, 224);
            TextBoxSize.MaxLength = 5;
            TextBoxSize.Name = "TextBoxSize";
            TextBoxSize.Size = new Size(120, 23);
            TextBoxSize.TabIndex = 14;
            // 
            // NumericWeight
            // 
            NumericWeight.DecimalPlaces = 2;
            NumericWeight.Location = new Point(68, 195);
            NumericWeight.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NumericWeight.Name = "NumericWeight";
            NumericWeight.Size = new Size(120, 23);
            NumericWeight.TabIndex = 17;
            // 
            // DateTimePickerSellStartDate
            // 
            DateTimePickerSellStartDate.Location = new Point(102, 274);
            DateTimePickerSellStartDate.Name = "DateTimePickerSellStartDate";
            DateTimePickerSellStartDate.Size = new Size(200, 23);
            DateTimePickerSellStartDate.TabIndex = 18;
            // 
            // LabelSellStartDate
            // 
            LabelSellStartDate.AutoSize = true;
            LabelSellStartDate.Location = new Point(12, 280);
            LabelSellStartDate.Name = "LabelSellStartDate";
            LabelSellStartDate.Size = new Size(84, 15);
            LabelSellStartDate.TabIndex = 19;
            LabelSellStartDate.Text = "Sell Start Date*";
            // 
            // LabelWeightUnit
            // 
            LabelWeightUnit.AutoSize = true;
            LabelWeightUnit.Location = new Point(194, 227);
            LabelWeightUnit.Name = "LabelWeightUnit";
            LabelWeightUnit.Size = new Size(29, 15);
            LabelWeightUnit.TabIndex = 20;
            LabelWeightUnit.Text = "Unit";
            // 
            // LabelWeight
            // 
            LabelWeight.AutoSize = true;
            LabelWeight.Location = new Point(12, 198);
            LabelWeight.Name = "LabelWeight";
            LabelWeight.Size = new Size(45, 15);
            LabelWeight.TabIndex = 21;
            LabelWeight.Text = "Weight";
            // 
            // LabelSizeUnit
            // 
            LabelSizeUnit.AutoSize = true;
            LabelSizeUnit.Location = new Point(194, 198);
            LabelSizeUnit.Name = "LabelSizeUnit";
            LabelSizeUnit.Size = new Size(29, 15);
            LabelSizeUnit.TabIndex = 22;
            LabelSizeUnit.Text = "Unit";
            // 
            // LabelSize
            // 
            LabelSize.AutoSize = true;
            LabelSize.Location = new Point(12, 227);
            LabelSize.Name = "LabelSize";
            LabelSize.Size = new Size(27, 15);
            LabelSize.TabIndex = 23;
            LabelSize.Text = "Size";
            // 
            // LabelHint
            // 
            LabelHint.AutoSize = true;
            LabelHint.Location = new Point(12, 358);
            LabelHint.Name = "LabelHint";
            LabelHint.Size = new Size(70, 15);
            LabelHint.TabIndex = 24;
            LabelHint.Text = "* - Required";
            // 
            // ButtonCreate
            // 
            ButtonCreate.Location = new Point(12, 322);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(75, 23);
            ButtonCreate.TabIndex = 25;
            ButtonCreate.Text = "Create";
            ButtonCreate.UseVisualStyleBackColor = true;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(93, 322);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(75, 23);
            ButtonCancel.TabIndex = 26;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ComboBoxCategories
            // 
            ComboBoxCategories.Location = new Point(372, 12);
            ComboBoxCategories.Name = "ComboBoxCategories";
            ComboBoxCategories.Size = new Size(121, 23);
            ComboBoxCategories.TabIndex = 27;
            ComboBoxCategories.SelectedIndexChanged += ComboBoxCategory_SelectedIndexChanged;
            // 
            // ComboBoxSubcategories
            // 
            ComboBoxSubcategories.Location = new Point(372, 41);
            ComboBoxSubcategories.Name = "ComboBoxSubcategories";
            ComboBoxSubcategories.Size = new Size(121, 23);
            ComboBoxSubcategories.TabIndex = 28;
            // 
            // LabelCategory
            // 
            LabelCategory.AutoSize = true;
            LabelCategory.Location = new Point(286, 15);
            LabelCategory.Name = "LabelCategory";
            LabelCategory.Size = new Size(60, 15);
            LabelCategory.TabIndex = 29;
            LabelCategory.Text = "Category*";
            // 
            // LabelSubcategory
            // 
            LabelSubcategory.AutoSize = true;
            LabelSubcategory.Location = new Point(286, 44);
            LabelSubcategory.Name = "LabelSubcategory";
            LabelSubcategory.Size = new Size(78, 15);
            LabelSubcategory.TabIndex = 30;
            LabelSubcategory.Text = "Subcategory*";
            // 
            // TextBoxColor
            // 
            TextBoxColor.Location = new Point(119, 70);
            TextBoxColor.Name = "TextBoxColor";
            TextBoxColor.Size = new Size(120, 23);
            TextBoxColor.TabIndex = 31;
            // 
            // ComboBoxSizeUnit
            // 
            ComboBoxSizeUnit.FormattingEnabled = true;
            ComboBoxSizeUnit.Location = new Point(229, 224);
            ComboBoxSizeUnit.Name = "ComboBoxSizeUnit";
            ComboBoxSizeUnit.Size = new Size(121, 23);
            ComboBoxSizeUnit.TabIndex = 32;
            // 
            // ComboBoxWeightUnit
            // 
            ComboBoxWeightUnit.FormattingEnabled = true;
            ComboBoxWeightUnit.Location = new Point(229, 195);
            ComboBoxWeightUnit.Name = "ComboBoxWeightUnit";
            ComboBoxWeightUnit.Size = new Size(121, 23);
            ComboBoxWeightUnit.TabIndex = 33;
            // 
            // ProductCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 386);
            Controls.Add(ComboBoxWeightUnit);
            Controls.Add(ComboBoxSizeUnit);
            Controls.Add(TextBoxColor);
            Controls.Add(LabelSubcategory);
            Controls.Add(LabelCategory);
            Controls.Add(ComboBoxSubcategories);
            Controls.Add(ComboBoxCategories);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonCreate);
            Controls.Add(LabelHint);
            Controls.Add(LabelSize);
            Controls.Add(LabelSizeUnit);
            Controls.Add(LabelWeight);
            Controls.Add(LabelWeightUnit);
            Controls.Add(LabelSellStartDate);
            Controls.Add(DateTimePickerSellStartDate);
            Controls.Add(NumericWeight);
            Controls.Add(TextBoxSize);
            Controls.Add(LabelListPrice);
            Controls.Add(LabelStandardCost);
            Controls.Add(NumericListPrice);
            Controls.Add(NumericStandardCost);
            Controls.Add(NumericReorderPoint);
            Controls.Add(NumericSafetyStockLevel);
            Controls.Add(LabelReorderPoint);
            Controls.Add(LabelSafetyStockLevel);
            Controls.Add(LabelColor);
            Controls.Add(LabelProductNumber);
            Controls.Add(TextBoxProductNumber);
            Controls.Add(TextBoxName);
            Controls.Add(LabelName);
            Name = "ProductCreateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Product";
            Load += ProductCreateForm_Load;
            ((System.ComponentModel.ISupportInitialize)NumericSafetyStockLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericReorderPoint).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericStandardCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericListPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelName;
        private TextBox TextBoxName;
        private TextBox TextBoxProductNumber;
        private Label LabelProductNumber;
        private Label LabelColor;
        private Label LabelSafetyStockLevel;
        private Label LabelReorderPoint;
        private NumericUpDown NumericSafetyStockLevel;
        private NumericUpDown NumericReorderPoint;
        private NumericUpDown NumericStandardCost;
        private NumericUpDown NumericListPrice;
        private Label LabelStandardCost;
        private Label LabelListPrice;
        private TextBox TextBoxSize;
        private NumericUpDown NumericWeight;
        private DateTimePicker DateTimePickerSellStartDate;
        private Label LabelSellStartDate;
        private Label LabelWeightUnit;
        private Label LabelWeight;
        private Label LabelSizeUnit;
        private Label LabelSize;
        private Label LabelHint;
        private Button ButtonCreate;
        private Button ButtonCancel;
        private ComboBox ComboBoxCategories;
        private ComboBox ComboBoxSubcategories;
        private Label LabelCategory;
        private Label LabelSubcategory;
        private TextBox TextBoxColor;
        private ComboBox ComboBoxSizeUnit;
        private ComboBox ComboBoxWeightUnit;
    }
}