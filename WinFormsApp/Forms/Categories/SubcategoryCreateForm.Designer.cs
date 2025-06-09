namespace WinFormsApp.Forms.Categories
{
    partial class SubcategoryCreateForm
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
            Cancel = new Button();
            ComboBoxCategories = new ComboBox();
            ButtonCreate = new Button();
            TextBoxName = new TextBox();
            LabelCategory = new Label();
            LabelName = new Label();
            SuspendLayout();
            // 
            // Cancel
            // 
            Cancel.Location = new Point(93, 99);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 12;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // ComboBoxCategories
            // 
            ComboBoxCategories.FormattingEnabled = true;
            ComboBoxCategories.Location = new Point(73, 41);
            ComboBoxCategories.Name = "ComboBoxCategories";
            ComboBoxCategories.Size = new Size(121, 23);
            ComboBoxCategories.TabIndex = 11;
            // 
            // ButtonCreate
            // 
            ButtonCreate.Location = new Point(12, 99);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(75, 23);
            ButtonCreate.TabIndex = 10;
            ButtonCreate.Text = "Create";
            ButtonCreate.UseVisualStyleBackColor = true;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(73, 12);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(100, 23);
            TextBoxName.TabIndex = 9;
            // 
            // LabelCategory
            // 
            LabelCategory.AutoSize = true;
            LabelCategory.Location = new Point(12, 44);
            LabelCategory.Name = "LabelCategory";
            LabelCategory.Size = new Size(55, 15);
            LabelCategory.TabIndex = 14;
            LabelCategory.Text = "Category";
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(12, 15);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(39, 15);
            LabelName.TabIndex = 13;
            LabelName.Text = "Name";
            // 
            // SubcategoryCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 133);
            Controls.Add(LabelCategory);
            Controls.Add(LabelName);
            Controls.Add(Cancel);
            Controls.Add(ComboBoxCategories);
            Controls.Add(ButtonCreate);
            Controls.Add(TextBoxName);
            Name = "SubcategoryCreateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Subcategory";
            Load += SubcategoryCreateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancel;
        private ComboBox ComboBoxCategories;
        private Button ButtonCreate;
        private TextBox TextBoxName;
        private Label LabelCategory;
        private Label LabelName;
    }
}