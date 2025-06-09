namespace WinFormsApp.Forms.Categories
{
    partial class SubcategoryDetailsForm
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
            TextBoxName = new TextBox();
            LabelID = new Label();
            LabelName = new Label();
            ButtonUpdate = new Button();
            TextBoxID = new TextBox();
            ComboBoxCategories = new ComboBox();
            LabelCategory = new Label();
            Cancel = new Button();
            ButtonDelete = new Button();
            SuspendLayout();
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(73, 41);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(100, 23);
            TextBoxName.TabIndex = 0;
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Location = new Point(12, 15);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(18, 15);
            LabelID.TabIndex = 1;
            LabelID.Text = "ID";
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(12, 44);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(39, 15);
            LabelName.TabIndex = 2;
            LabelName.Text = "Name";
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(12, 128);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(75, 23);
            ButtonUpdate.TabIndex = 4;
            ButtonUpdate.Text = "Update";
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.Click += ButtonUpdate_Click;
            // 
            // TextBoxID
            // 
            TextBoxID.Location = new Point(73, 12);
            TextBoxID.Name = "TextBoxID";
            TextBoxID.ReadOnly = true;
            TextBoxID.Size = new Size(100, 23);
            TextBoxID.TabIndex = 5;
            // 
            // ComboBoxCategories
            // 
            ComboBoxCategories.FormattingEnabled = true;
            ComboBoxCategories.Location = new Point(73, 70);
            ComboBoxCategories.Name = "ComboBoxCategories";
            ComboBoxCategories.Size = new Size(121, 23);
            ComboBoxCategories.TabIndex = 6;
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
            // Cancel
            // 
            Cancel.Location = new Point(174, 128);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 8;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(93, 128);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(75, 23);
            ButtonDelete.TabIndex = 9;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // SubcategoryDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 162);
            Controls.Add(ButtonDelete);
            Controls.Add(Cancel);
            Controls.Add(LabelCategory);
            Controls.Add(ComboBoxCategories);
            Controls.Add(TextBoxID);
            Controls.Add(ButtonUpdate);
            Controls.Add(LabelName);
            Controls.Add(LabelID);
            Controls.Add(TextBoxName);
            Name = "SubcategoryDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subcategory Details";
            Load += EditSubcategoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxName;
        private Label LabelID;
        private Label LabelName;
        private Button ButtonUpdate;
        private TextBox TextBoxID;
        private ComboBox ComboBoxCategories;
        private Label LabelCategory;
        private Button Cancel;
        private Button ButtonDelete;
    }
}