namespace WinFormsApp.Forms.Products
{
    partial class ProductDetailsForm
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
            TextBoxColor = new TextBox();
            LabelSubcategory = new Label();
            LabelCategory = new Label();
            ButtonOK = new Button();
            LabelSize = new Label();
            LabelSizeUnit = new Label();
            LabelWeight = new Label();
            LabelWeightUnit = new Label();
            LabelSellStartDate = new Label();
            DateTimePickerSellStartDate = new DateTimePicker();
            TextBoxWeight = new TextBox();
            LabelListPrice = new Label();
            LabelStandardCost = new Label();
            LabelReorderPoint = new Label();
            LabelSafetyStockLevel = new Label();
            LabelColor = new Label();
            LabelProductNumber = new Label();
            TextBoxProductNumber = new TextBox();
            TextBoxName = new TextBox();
            LabelName = new Label();
            TextBoxCategory = new TextBox();
            TextBoxSubcategory = new TextBox();
            TextBoxStandardCost = new TextBox();
            TextBoxListPrice = new TextBox();
            TextBoxSafetyStockLevel = new TextBox();
            TextBoxReorderPoint = new TextBox();
            TextBoxSize = new TextBox();
            TextBoxWeightUnit = new TextBox();
            TextBoxSizeUnit = new TextBox();
            SuspendLayout();
            // 
            // TextBoxColor
            // 
            TextBoxColor.Location = new Point(119, 70);
            TextBoxColor.Name = "TextBoxColor";
            TextBoxColor.ReadOnly = true;
            TextBoxColor.Size = new Size(120, 23);
            TextBoxColor.TabIndex = 62;
            // 
            // LabelSubcategory
            // 
            LabelSubcategory.AutoSize = true;
            LabelSubcategory.Location = new Point(286, 44);
            LabelSubcategory.Name = "LabelSubcategory";
            LabelSubcategory.Size = new Size(73, 15);
            LabelSubcategory.TabIndex = 61;
            LabelSubcategory.Text = "Subcategory";
            // 
            // LabelCategory
            // 
            LabelCategory.AutoSize = true;
            LabelCategory.Location = new Point(286, 15);
            LabelCategory.Name = "LabelCategory";
            LabelCategory.Size = new Size(55, 15);
            LabelCategory.TabIndex = 60;
            LabelCategory.Text = "Category";
            // 
            // ButtonOK
            // 
            ButtonOK.Location = new Point(12, 322);
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Size = new Size(75, 23);
            ButtonOK.TabIndex = 56;
            ButtonOK.Text = "OK";
            ButtonOK.UseVisualStyleBackColor = true;
            ButtonOK.Click += ButtonOK_Click;
            // 
            // LabelSize
            // 
            LabelSize.AutoSize = true;
            LabelSize.Location = new Point(12, 227);
            LabelSize.Name = "LabelSize";
            LabelSize.Size = new Size(27, 15);
            LabelSize.TabIndex = 54;
            LabelSize.Text = "Size";
            // 
            // LabelSizeUnit
            // 
            LabelSizeUnit.AutoSize = true;
            LabelSizeUnit.Location = new Point(194, 198);
            LabelSizeUnit.Name = "LabelSizeUnit";
            LabelSizeUnit.Size = new Size(29, 15);
            LabelSizeUnit.TabIndex = 53;
            LabelSizeUnit.Text = "Unit";
            // 
            // LabelWeight
            // 
            LabelWeight.AutoSize = true;
            LabelWeight.Location = new Point(12, 198);
            LabelWeight.Name = "LabelWeight";
            LabelWeight.Size = new Size(45, 15);
            LabelWeight.TabIndex = 52;
            LabelWeight.Text = "Weight";
            // 
            // LabelWeightUnit
            // 
            LabelWeightUnit.AutoSize = true;
            LabelWeightUnit.Location = new Point(194, 227);
            LabelWeightUnit.Name = "LabelWeightUnit";
            LabelWeightUnit.Size = new Size(29, 15);
            LabelWeightUnit.TabIndex = 51;
            LabelWeightUnit.Text = "Unit";
            // 
            // LabelSellStartDate
            // 
            LabelSellStartDate.AutoSize = true;
            LabelSellStartDate.Location = new Point(12, 280);
            LabelSellStartDate.Name = "LabelSellStartDate";
            LabelSellStartDate.Size = new Size(79, 15);
            LabelSellStartDate.TabIndex = 50;
            LabelSellStartDate.Text = "Sell Start Date";
            // 
            // DateTimePickerSellStartDate
            // 
            DateTimePickerSellStartDate.Enabled = false;
            DateTimePickerSellStartDate.Location = new Point(102, 274);
            DateTimePickerSellStartDate.Name = "DateTimePickerSellStartDate";
            DateTimePickerSellStartDate.Size = new Size(200, 23);
            DateTimePickerSellStartDate.TabIndex = 49;
            // 
            // TextBoxWeight
            // 
            TextBoxWeight.Location = new Point(68, 195);
            TextBoxWeight.MaxLength = 5;
            TextBoxWeight.Name = "TextBoxWeight";
            TextBoxWeight.ReadOnly = true;
            TextBoxWeight.Size = new Size(120, 23);
            TextBoxWeight.TabIndex = 47;
            // 
            // LabelListPrice
            // 
            LabelListPrice.AutoSize = true;
            LabelListPrice.Location = new Point(286, 149);
            LabelListPrice.Name = "LabelListPrice";
            LabelListPrice.Size = new Size(51, 15);
            LabelListPrice.TabIndex = 46;
            LabelListPrice.Text = "ListPrice";
            // 
            // LabelStandardCost
            // 
            LabelStandardCost.AutoSize = true;
            LabelStandardCost.Location = new Point(286, 120);
            LabelStandardCost.Name = "LabelStandardCost";
            LabelStandardCost.Size = new Size(81, 15);
            LabelStandardCost.TabIndex = 45;
            LabelStandardCost.Text = "Standard Cost";
            // 
            // LabelReorderPoint
            // 
            LabelReorderPoint.AutoSize = true;
            LabelReorderPoint.Location = new Point(12, 149);
            LabelReorderPoint.Name = "LabelReorderPoint";
            LabelReorderPoint.Size = new Size(79, 15);
            LabelReorderPoint.TabIndex = 40;
            LabelReorderPoint.Text = "Reorder Point";
            // 
            // LabelSafetyStockLevel
            // 
            LabelSafetyStockLevel.AutoSize = true;
            LabelSafetyStockLevel.Location = new Point(12, 120);
            LabelSafetyStockLevel.Name = "LabelSafetyStockLevel";
            LabelSafetyStockLevel.Size = new Size(101, 15);
            LabelSafetyStockLevel.TabIndex = 39;
            LabelSafetyStockLevel.Text = "Safety Stock Level";
            // 
            // LabelColor
            // 
            LabelColor.AutoSize = true;
            LabelColor.Location = new Point(12, 73);
            LabelColor.Name = "LabelColor";
            LabelColor.Size = new Size(36, 15);
            LabelColor.TabIndex = 38;
            LabelColor.Text = "Color";
            // 
            // LabelProductNumber
            // 
            LabelProductNumber.AutoSize = true;
            LabelProductNumber.Location = new Point(12, 44);
            LabelProductNumber.Name = "LabelProductNumber";
            LabelProductNumber.Size = new Size(96, 15);
            LabelProductNumber.TabIndex = 37;
            LabelProductNumber.Text = "Product Number";
            // 
            // TextBoxProductNumber
            // 
            TextBoxProductNumber.Location = new Point(119, 41);
            TextBoxProductNumber.Name = "TextBoxProductNumber";
            TextBoxProductNumber.ReadOnly = true;
            TextBoxProductNumber.Size = new Size(120, 23);
            TextBoxProductNumber.TabIndex = 36;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(119, 12);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.ReadOnly = true;
            TextBoxName.Size = new Size(161, 23);
            TextBoxName.TabIndex = 35;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(12, 15);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(39, 15);
            LabelName.TabIndex = 34;
            LabelName.Text = "Name";
            // 
            // TextBoxCategory
            // 
            TextBoxCategory.Location = new Point(372, 12);
            TextBoxCategory.Name = "TextBoxCategory";
            TextBoxCategory.ReadOnly = true;
            TextBoxCategory.Size = new Size(121, 23);
            TextBoxCategory.TabIndex = 65;
            // 
            // TextBoxSubcategory
            // 
            TextBoxSubcategory.Location = new Point(373, 41);
            TextBoxSubcategory.Name = "TextBoxSubcategory";
            TextBoxSubcategory.ReadOnly = true;
            TextBoxSubcategory.Size = new Size(120, 23);
            TextBoxSubcategory.TabIndex = 66;
            // 
            // TextBoxStandardCost
            // 
            TextBoxStandardCost.Location = new Point(373, 117);
            TextBoxStandardCost.Name = "TextBoxStandardCost";
            TextBoxStandardCost.ReadOnly = true;
            TextBoxStandardCost.Size = new Size(120, 23);
            TextBoxStandardCost.TabIndex = 67;
            // 
            // TextBoxListPrice
            // 
            TextBoxListPrice.Location = new Point(372, 146);
            TextBoxListPrice.Name = "TextBoxListPrice";
            TextBoxListPrice.ReadOnly = true;
            TextBoxListPrice.Size = new Size(121, 23);
            TextBoxListPrice.TabIndex = 68;
            // 
            // TextBoxSafetyStockLevel
            // 
            TextBoxSafetyStockLevel.Location = new Point(119, 117);
            TextBoxSafetyStockLevel.Name = "TextBoxSafetyStockLevel";
            TextBoxSafetyStockLevel.ReadOnly = true;
            TextBoxSafetyStockLevel.Size = new Size(120, 23);
            TextBoxSafetyStockLevel.TabIndex = 69;
            // 
            // TextBoxReorderPoint
            // 
            TextBoxReorderPoint.Location = new Point(119, 146);
            TextBoxReorderPoint.Name = "TextBoxReorderPoint";
            TextBoxReorderPoint.ReadOnly = true;
            TextBoxReorderPoint.Size = new Size(120, 23);
            TextBoxReorderPoint.TabIndex = 70;
            // 
            // TextBoxSize
            // 
            TextBoxSize.Location = new Point(68, 224);
            TextBoxSize.Name = "TextBoxSize";
            TextBoxSize.ReadOnly = true;
            TextBoxSize.Size = new Size(120, 23);
            TextBoxSize.TabIndex = 71;
            // 
            // TextBoxWeightUnit
            // 
            TextBoxWeightUnit.Location = new Point(229, 195);
            TextBoxWeightUnit.Name = "TextBoxWeightUnit";
            TextBoxWeightUnit.ReadOnly = true;
            TextBoxWeightUnit.Size = new Size(121, 23);
            TextBoxWeightUnit.TabIndex = 72;
            // 
            // TextBoxSizeUnit
            // 
            TextBoxSizeUnit.Location = new Point(229, 224);
            TextBoxSizeUnit.Name = "TextBoxSizeUnit";
            TextBoxSizeUnit.ReadOnly = true;
            TextBoxSizeUnit.Size = new Size(121, 23);
            TextBoxSizeUnit.TabIndex = 73;
            // 
            // ProductDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 357);
            Controls.Add(TextBoxSizeUnit);
            Controls.Add(TextBoxWeightUnit);
            Controls.Add(TextBoxSize);
            Controls.Add(TextBoxReorderPoint);
            Controls.Add(TextBoxSafetyStockLevel);
            Controls.Add(TextBoxListPrice);
            Controls.Add(TextBoxStandardCost);
            Controls.Add(TextBoxSubcategory);
            Controls.Add(TextBoxCategory);
            Controls.Add(TextBoxColor);
            Controls.Add(LabelSubcategory);
            Controls.Add(LabelCategory);
            Controls.Add(ButtonOK);
            Controls.Add(LabelSize);
            Controls.Add(LabelSizeUnit);
            Controls.Add(LabelWeight);
            Controls.Add(LabelWeightUnit);
            Controls.Add(LabelSellStartDate);
            Controls.Add(DateTimePickerSellStartDate);
            Controls.Add(TextBoxWeight);
            Controls.Add(LabelListPrice);
            Controls.Add(LabelStandardCost);
            Controls.Add(LabelReorderPoint);
            Controls.Add(LabelSafetyStockLevel);
            Controls.Add(LabelColor);
            Controls.Add(LabelProductNumber);
            Controls.Add(TextBoxProductNumber);
            Controls.Add(TextBoxName);
            Controls.Add(LabelName);
            Name = "ProductDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Details";
            Load += ProductDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TextBoxColor;
        private Label LabelSubcategory;
        private Label LabelCategory;
        private Button ButtonOK;
        private Label LabelSize;
        private Label LabelSizeUnit;
        private Label LabelWeight;
        private Label LabelWeightUnit;
        private Label LabelSellStartDate;
        private DateTimePicker DateTimePickerSellStartDate;
        private TextBox TextBoxWeight;
        private Label LabelListPrice;
        private Label LabelStandardCost;
        private Label LabelReorderPoint;
        private Label LabelSafetyStockLevel;
        private Label LabelColor;
        private Label LabelProductNumber;
        private TextBox TextBoxProductNumber;
        private TextBox TextBoxName;
        private Label LabelName;
        private TextBox TextBoxCategory;
        private TextBox TextBoxSubcategory;
        private TextBox TextBoxStandardCost;
        private TextBox TextBoxListPrice;
        private TextBox TextBoxSafetyStockLevel;
        private TextBox TextBoxReorderPoint;
        private TextBox TextBoxSize;
        private TextBox TextBoxWeightUnit;
        private TextBox TextBoxSizeUnit;
    }
}