namespace WinFormsApp.Forms
{
    partial class CategoriesForm
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
            ListBoxSubcategories = new ListBox();
            ButtonNewCategory = new Button();
            ButtonNewSubcategory = new Button();
            LabelSubcategories = new Label();
            LabelCategories = new Label();
            ListBoxCategories = new ListBox();
            ButtonGoBack = new Button();
            SuspendLayout();
            // 
            // ListBoxSubcategories
            // 
            ListBoxSubcategories.FormattingEnabled = true;
            ListBoxSubcategories.Location = new Point(198, 64);
            ListBoxSubcategories.Name = "ListBoxSubcategories";
            ListBoxSubcategories.Size = new Size(180, 364);
            ListBoxSubcategories.TabIndex = 0;
            ListBoxSubcategories.MouseDoubleClick += ListBoxSubcategories_MouseDoubleClick;
            // 
            // ButtonNewCategory
            // 
            ButtonNewCategory.AutoSize = true;
            ButtonNewCategory.Location = new Point(12, 33);
            ButtonNewCategory.Name = "ButtonNewCategory";
            ButtonNewCategory.Size = new Size(92, 25);
            ButtonNewCategory.TabIndex = 2;
            ButtonNewCategory.Text = "New Category";
            ButtonNewCategory.UseVisualStyleBackColor = true;
            ButtonNewCategory.Click += ButtonNewCategory_Click;
            // 
            // ButtonNewSubcategory
            // 
            ButtonNewSubcategory.AutoSize = true;
            ButtonNewSubcategory.Location = new Point(198, 33);
            ButtonNewSubcategory.Name = "ButtonNewSubcategory";
            ButtonNewSubcategory.Size = new Size(110, 25);
            ButtonNewSubcategory.TabIndex = 3;
            ButtonNewSubcategory.Text = "New Subcategory";
            ButtonNewSubcategory.UseVisualStyleBackColor = true;
            ButtonNewSubcategory.Click += ButtonNewSubcategory_Click;
            // 
            // LabelSubcategories
            // 
            LabelSubcategories.AutoSize = true;
            LabelSubcategories.Location = new Point(198, 15);
            LabelSubcategories.Name = "LabelSubcategories";
            LabelSubcategories.Size = new Size(81, 15);
            LabelSubcategories.TabIndex = 4;
            LabelSubcategories.Text = "Subcategories";
            // 
            // LabelCategories
            // 
            LabelCategories.AutoSize = true;
            LabelCategories.Location = new Point(12, 15);
            LabelCategories.Name = "LabelCategories";
            LabelCategories.Size = new Size(63, 15);
            LabelCategories.TabIndex = 5;
            LabelCategories.Text = "Categories";
            // 
            // ListBoxCategories
            // 
            ListBoxCategories.FormattingEnabled = true;
            ListBoxCategories.Location = new Point(12, 64);
            ListBoxCategories.Name = "ListBoxCategories";
            ListBoxCategories.Size = new Size(180, 364);
            ListBoxCategories.TabIndex = 6;
            ListBoxCategories.SelectedIndexChanged += ListBoxCategories_SelectedIndexChanged;
            ListBoxCategories.MouseDoubleClick += ListBoxCategories_MouseDoubleClick;
            // 
            // ButtonGoBack
            // 
            ButtonGoBack.Location = new Point(12, 434);
            ButtonGoBack.Name = "ButtonGoBack";
            ButtonGoBack.Size = new Size(75, 23);
            ButtonGoBack.TabIndex = 7;
            ButtonGoBack.Text = "Go Back";
            ButtonGoBack.UseVisualStyleBackColor = true;
            ButtonGoBack.Click += ButtonGoBack_Click;
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 468);
            Controls.Add(ButtonGoBack);
            Controls.Add(ListBoxCategories);
            Controls.Add(LabelCategories);
            Controls.Add(LabelSubcategories);
            Controls.Add(ButtonNewSubcategory);
            Controls.Add(ButtonNewCategory);
            Controls.Add(ListBoxSubcategories);
            Name = "CategoriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Categories";
            Load += CategoriesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBoxSubcategories;
        private Button ButtonNewCategory;
        private Button ButtonNewSubcategory;
        private Label LabelSubcategories;
        private Label LabelCategories;
        private ListBox ListBoxCategories;
        private Button ButtonGoBack;
    }
}