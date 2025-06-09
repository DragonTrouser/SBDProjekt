namespace WinFormsApp.Forms.Sales
{
    partial class OrderDetailsForm
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
            TextBoxOrderNumber = new TextBox();
            DateTimeOderDate = new DateTimePicker();
            DateTimeDueDate = new DateTimePicker();
            CheckBoxOnlineOrder = new CheckBox();
            TextBoxPurchaseNumber = new TextBox();
            TextBoxCustomerName = new TextBox();
            TextBoxBillingAddress = new TextBox();
            TextBoxBillingCity = new TextBox();
            TextBoxBillingState = new TextBox();
            TextBoxBillingCountry = new TextBox();
            TextBoxShippingAddress = new TextBox();
            TextBoxShippingCity = new TextBox();
            TextBoxShippingState = new TextBox();
            TextBoxShippingCountry = new TextBox();
            GroupBoxBillingAddress = new GroupBox();
            TextBoxBillingAddressL2 = new TextBox();
            GroupBoxShippingAddress = new GroupBox();
            TextBoxShippingAddressL2 = new TextBox();
            GroupBoxGeneral = new GroupBox();
            LabelCustomerName = new Label();
            LabelPurchaseNumber = new Label();
            LabelOrderNumber = new Label();
            LabelDueDate = new Label();
            LabelOrderDate = new Label();
            GroupBoxOrderedProducts = new GroupBox();
            LabelTotal = new Label();
            TextBoxTotal = new TextBox();
            ListBoxOrderedProducts = new ListBox();
            ButtonOK = new Button();
            GroupBoxBillingAddress.SuspendLayout();
            GroupBoxShippingAddress.SuspendLayout();
            GroupBoxGeneral.SuspendLayout();
            GroupBoxOrderedProducts.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxOrderNumber
            // 
            TextBoxOrderNumber.Location = new Point(114, 22);
            TextBoxOrderNumber.Name = "TextBoxOrderNumber";
            TextBoxOrderNumber.ReadOnly = true;
            TextBoxOrderNumber.Size = new Size(100, 23);
            TextBoxOrderNumber.TabIndex = 0;
            // 
            // DateTimeOderDate
            // 
            DateTimeOderDate.Enabled = false;
            DateTimeOderDate.Location = new Point(114, 51);
            DateTimeOderDate.Name = "DateTimeOderDate";
            DateTimeOderDate.Size = new Size(200, 23);
            DateTimeOderDate.TabIndex = 1;
            // 
            // DateTimeDueDate
            // 
            DateTimeDueDate.Enabled = false;
            DateTimeDueDate.Location = new Point(114, 80);
            DateTimeDueDate.Name = "DateTimeDueDate";
            DateTimeDueDate.Size = new Size(200, 23);
            DateTimeDueDate.TabIndex = 2;
            // 
            // CheckBoxOnlineOrder
            // 
            CheckBoxOnlineOrder.AutoSize = true;
            CheckBoxOnlineOrder.Enabled = false;
            CheckBoxOnlineOrder.Location = new Point(114, 109);
            CheckBoxOnlineOrder.Name = "CheckBoxOnlineOrder";
            CheckBoxOnlineOrder.Size = new Size(94, 19);
            CheckBoxOnlineOrder.TabIndex = 3;
            CheckBoxOnlineOrder.Text = "Online Order";
            CheckBoxOnlineOrder.UseVisualStyleBackColor = true;
            // 
            // TextBoxPurchaseNumber
            // 
            TextBoxPurchaseNumber.Location = new Point(114, 134);
            TextBoxPurchaseNumber.Name = "TextBoxPurchaseNumber";
            TextBoxPurchaseNumber.ReadOnly = true;
            TextBoxPurchaseNumber.Size = new Size(100, 23);
            TextBoxPurchaseNumber.TabIndex = 4;
            // 
            // TextBoxCustomerName
            // 
            TextBoxCustomerName.Location = new Point(114, 163);
            TextBoxCustomerName.Name = "TextBoxCustomerName";
            TextBoxCustomerName.ReadOnly = true;
            TextBoxCustomerName.Size = new Size(100, 23);
            TextBoxCustomerName.TabIndex = 5;
            // 
            // TextBoxBillingAddress
            // 
            TextBoxBillingAddress.Location = new Point(7, 22);
            TextBoxBillingAddress.Name = "TextBoxBillingAddress";
            TextBoxBillingAddress.ReadOnly = true;
            TextBoxBillingAddress.Size = new Size(140, 23);
            TextBoxBillingAddress.TabIndex = 6;
            // 
            // TextBoxBillingCity
            // 
            TextBoxBillingCity.Location = new Point(7, 51);
            TextBoxBillingCity.Name = "TextBoxBillingCity";
            TextBoxBillingCity.ReadOnly = true;
            TextBoxBillingCity.Size = new Size(100, 23);
            TextBoxBillingCity.TabIndex = 7;
            // 
            // TextBoxBillingState
            // 
            TextBoxBillingState.Location = new Point(7, 80);
            TextBoxBillingState.Name = "TextBoxBillingState";
            TextBoxBillingState.ReadOnly = true;
            TextBoxBillingState.Size = new Size(100, 23);
            TextBoxBillingState.TabIndex = 8;
            // 
            // TextBoxBillingCountry
            // 
            TextBoxBillingCountry.Location = new Point(7, 109);
            TextBoxBillingCountry.Name = "TextBoxBillingCountry";
            TextBoxBillingCountry.ReadOnly = true;
            TextBoxBillingCountry.Size = new Size(100, 23);
            TextBoxBillingCountry.TabIndex = 9;
            // 
            // TextBoxShippingAddress
            // 
            TextBoxShippingAddress.Location = new Point(6, 22);
            TextBoxShippingAddress.Name = "TextBoxShippingAddress";
            TextBoxShippingAddress.ReadOnly = true;
            TextBoxShippingAddress.Size = new Size(140, 23);
            TextBoxShippingAddress.TabIndex = 10;
            // 
            // TextBoxShippingCity
            // 
            TextBoxShippingCity.Location = new Point(6, 51);
            TextBoxShippingCity.Name = "TextBoxShippingCity";
            TextBoxShippingCity.ReadOnly = true;
            TextBoxShippingCity.Size = new Size(100, 23);
            TextBoxShippingCity.TabIndex = 11;
            // 
            // TextBoxShippingState
            // 
            TextBoxShippingState.Location = new Point(6, 80);
            TextBoxShippingState.Name = "TextBoxShippingState";
            TextBoxShippingState.ReadOnly = true;
            TextBoxShippingState.Size = new Size(100, 23);
            TextBoxShippingState.TabIndex = 12;
            // 
            // TextBoxShippingCountry
            // 
            TextBoxShippingCountry.Location = new Point(6, 109);
            TextBoxShippingCountry.Name = "TextBoxShippingCountry";
            TextBoxShippingCountry.ReadOnly = true;
            TextBoxShippingCountry.Size = new Size(100, 23);
            TextBoxShippingCountry.TabIndex = 13;
            // 
            // GroupBoxBillingAddress
            // 
            GroupBoxBillingAddress.Controls.Add(TextBoxBillingAddressL2);
            GroupBoxBillingAddress.Controls.Add(TextBoxBillingAddress);
            GroupBoxBillingAddress.Controls.Add(TextBoxBillingCity);
            GroupBoxBillingAddress.Controls.Add(TextBoxBillingState);
            GroupBoxBillingAddress.Controls.Add(TextBoxBillingCountry);
            GroupBoxBillingAddress.Location = new Point(12, 254);
            GroupBoxBillingAddress.Name = "GroupBoxBillingAddress";
            GroupBoxBillingAddress.Size = new Size(220, 140);
            GroupBoxBillingAddress.TabIndex = 14;
            GroupBoxBillingAddress.TabStop = false;
            GroupBoxBillingAddress.Text = "Billing Address";
            // 
            // TextBoxBillingAddressL2
            // 
            TextBoxBillingAddressL2.Location = new Point(153, 22);
            TextBoxBillingAddressL2.Name = "TextBoxBillingAddressL2";
            TextBoxBillingAddressL2.ReadOnly = true;
            TextBoxBillingAddressL2.Size = new Size(60, 23);
            TextBoxBillingAddressL2.TabIndex = 10;
            // 
            // GroupBoxShippingAddress
            // 
            GroupBoxShippingAddress.Controls.Add(TextBoxShippingAddressL2);
            GroupBoxShippingAddress.Controls.Add(TextBoxShippingAddress);
            GroupBoxShippingAddress.Controls.Add(TextBoxShippingCity);
            GroupBoxShippingAddress.Controls.Add(TextBoxShippingState);
            GroupBoxShippingAddress.Controls.Add(TextBoxShippingCountry);
            GroupBoxShippingAddress.Location = new Point(238, 254);
            GroupBoxShippingAddress.Name = "GroupBoxShippingAddress";
            GroupBoxShippingAddress.Size = new Size(220, 140);
            GroupBoxShippingAddress.TabIndex = 15;
            GroupBoxShippingAddress.TabStop = false;
            GroupBoxShippingAddress.Text = "Shipping Address";
            // 
            // TextBoxShippingAddressL2
            // 
            TextBoxShippingAddressL2.Location = new Point(152, 22);
            TextBoxShippingAddressL2.Name = "TextBoxShippingAddressL2";
            TextBoxShippingAddressL2.ReadOnly = true;
            TextBoxShippingAddressL2.Size = new Size(60, 23);
            TextBoxShippingAddressL2.TabIndex = 14;
            // 
            // GroupBoxGeneral
            // 
            GroupBoxGeneral.Controls.Add(LabelCustomerName);
            GroupBoxGeneral.Controls.Add(TextBoxOrderNumber);
            GroupBoxGeneral.Controls.Add(LabelPurchaseNumber);
            GroupBoxGeneral.Controls.Add(LabelOrderNumber);
            GroupBoxGeneral.Controls.Add(LabelDueDate);
            GroupBoxGeneral.Controls.Add(TextBoxCustomerName);
            GroupBoxGeneral.Controls.Add(DateTimeOderDate);
            GroupBoxGeneral.Controls.Add(LabelOrderDate);
            GroupBoxGeneral.Controls.Add(DateTimeDueDate);
            GroupBoxGeneral.Controls.Add(TextBoxPurchaseNumber);
            GroupBoxGeneral.Controls.Add(CheckBoxOnlineOrder);
            GroupBoxGeneral.Location = new Point(12, 12);
            GroupBoxGeneral.Name = "GroupBoxGeneral";
            GroupBoxGeneral.Size = new Size(446, 236);
            GroupBoxGeneral.TabIndex = 16;
            GroupBoxGeneral.TabStop = false;
            GroupBoxGeneral.Text = "General Information";
            // 
            // LabelCustomerName
            // 
            LabelCustomerName.AutoSize = true;
            LabelCustomerName.Location = new Point(6, 166);
            LabelCustomerName.Name = "LabelCustomerName";
            LabelCustomerName.Size = new Size(94, 15);
            LabelCustomerName.TabIndex = 21;
            LabelCustomerName.Text = "Customer Name";
            // 
            // LabelPurchaseNumber
            // 
            LabelPurchaseNumber.AutoSize = true;
            LabelPurchaseNumber.Location = new Point(6, 137);
            LabelPurchaseNumber.Name = "LabelPurchaseNumber";
            LabelPurchaseNumber.Size = new Size(102, 15);
            LabelPurchaseNumber.TabIndex = 20;
            LabelPurchaseNumber.Text = "Purchase Number";
            // 
            // LabelOrderNumber
            // 
            LabelOrderNumber.AutoSize = true;
            LabelOrderNumber.Location = new Point(6, 25);
            LabelOrderNumber.Name = "LabelOrderNumber";
            LabelOrderNumber.Size = new Size(84, 15);
            LabelOrderNumber.TabIndex = 17;
            LabelOrderNumber.Text = "Order Number";
            // 
            // LabelDueDate
            // 
            LabelDueDate.AutoSize = true;
            LabelDueDate.Location = new Point(6, 86);
            LabelDueDate.Name = "LabelDueDate";
            LabelDueDate.Size = new Size(55, 15);
            LabelDueDate.TabIndex = 19;
            LabelDueDate.Text = "Due Date";
            // 
            // LabelOrderDate
            // 
            LabelOrderDate.AutoSize = true;
            LabelOrderDate.Location = new Point(6, 57);
            LabelOrderDate.Name = "LabelOrderDate";
            LabelOrderDate.Size = new Size(64, 15);
            LabelOrderDate.TabIndex = 18;
            LabelOrderDate.Text = "Order Date";
            // 
            // GroupBoxOrderedProducts
            // 
            GroupBoxOrderedProducts.Controls.Add(LabelTotal);
            GroupBoxOrderedProducts.Controls.Add(TextBoxTotal);
            GroupBoxOrderedProducts.Controls.Add(ListBoxOrderedProducts);
            GroupBoxOrderedProducts.Location = new Point(464, 15);
            GroupBoxOrderedProducts.Name = "GroupBoxOrderedProducts";
            GroupBoxOrderedProducts.Size = new Size(381, 379);
            GroupBoxOrderedProducts.TabIndex = 17;
            GroupBoxOrderedProducts.TabStop = false;
            GroupBoxOrderedProducts.Text = "Ordered Products";
            // 
            // LabelTotal
            // 
            LabelTotal.AutoSize = true;
            LabelTotal.Location = new Point(6, 351);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(33, 15);
            LabelTotal.TabIndex = 2;
            LabelTotal.Text = "Total";
            // 
            // TextBoxTotal
            // 
            TextBoxTotal.Location = new Point(45, 347);
            TextBoxTotal.Name = "TextBoxTotal";
            TextBoxTotal.ReadOnly = true;
            TextBoxTotal.Size = new Size(100, 23);
            TextBoxTotal.TabIndex = 1;
            // 
            // ListBoxOrderedProducts
            // 
            ListBoxOrderedProducts.FormattingEnabled = true;
            ListBoxOrderedProducts.Location = new Point(6, 22);
            ListBoxOrderedProducts.Name = "ListBoxOrderedProducts";
            ListBoxOrderedProducts.Size = new Size(369, 319);
            ListBoxOrderedProducts.TabIndex = 0;
            // 
            // ButtonOK
            // 
            ButtonOK.Location = new Point(12, 400);
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Size = new Size(75, 23);
            ButtonOK.TabIndex = 18;
            ButtonOK.Text = "OK";
            ButtonOK.UseVisualStyleBackColor = true;
            ButtonOK.Click += ButtonOK_Click;
            // 
            // OrderDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 434);
            Controls.Add(ButtonOK);
            Controls.Add(GroupBoxOrderedProducts);
            Controls.Add(GroupBoxGeneral);
            Controls.Add(GroupBoxShippingAddress);
            Controls.Add(GroupBoxBillingAddress);
            Name = "OrderDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Details";
            Load += OrderDetailsForm_Load;
            GroupBoxBillingAddress.ResumeLayout(false);
            GroupBoxBillingAddress.PerformLayout();
            GroupBoxShippingAddress.ResumeLayout(false);
            GroupBoxShippingAddress.PerformLayout();
            GroupBoxGeneral.ResumeLayout(false);
            GroupBoxGeneral.PerformLayout();
            GroupBoxOrderedProducts.ResumeLayout(false);
            GroupBoxOrderedProducts.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TextBoxOrderNumber;
        private DateTimePicker DateTimeOderDate;
        private DateTimePicker DateTimeDueDate;
        private CheckBox CheckBoxOnlineOrder;
        private TextBox TextBoxPurchaseNumber;
        private TextBox TextBoxCustomerName;
        private TextBox TextBoxBillingAddress;
        private TextBox TextBoxBillingCity;
        private TextBox TextBoxBillingState;
        private TextBox TextBoxBillingCountry;
        private TextBox TextBoxShippingAddress;
        private TextBox TextBoxShippingCity;
        private TextBox TextBoxShippingState;
        private TextBox TextBoxShippingCountry;
        private GroupBox GroupBoxBillingAddress;
        private GroupBox GroupBoxShippingAddress;
        private GroupBox GroupBoxGeneral;
        private Label LabelOrderNumber;
        private Label LabelOrderDate;
        private Label LabelDueDate;
        private Label LabelPurchaseNumber;
        private Label LabelCustomerName;
        private GroupBox GroupBoxOrderedProducts;
        private ListBox ListBoxOrderedProducts;
        private Label LabelTotal;
        private TextBox TextBoxTotal;
        private TextBox TextBoxBillingAddressL2;
        private TextBox TextBoxShippingAddressL2;
        private Button ButtonOK;
    }
}