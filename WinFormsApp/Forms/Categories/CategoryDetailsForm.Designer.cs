namespace WinFormsApp.Forms.Categories
{
    partial class CategoryDetailsForm
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
            LabelID = new Label();
            LabelName = new Label();
            TextBoxID = new TextBox();
            TextBoxName = new TextBox();
            ButtonUpdate = new Button();
            ButtonCancel = new Button();
            ButtonDelete = new Button();
            SuspendLayout();
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Location = new Point(12, 15);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(18, 15);
            LabelID.TabIndex = 0;
            LabelID.Text = "ID";
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(12, 44);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(39, 15);
            LabelName.TabIndex = 1;
            LabelName.Text = "Name";
            // 
            // TextBoxID
            // 
            TextBoxID.Location = new Point(57, 12);
            TextBoxID.Name = "TextBoxID";
            TextBoxID.ReadOnly = true;
            TextBoxID.Size = new Size(100, 23);
            TextBoxID.TabIndex = 2;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(57, 41);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(100, 23);
            TextBoxName.TabIndex = 3;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(12, 99);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(75, 23);
            ButtonUpdate.TabIndex = 4;
            ButtonUpdate.Text = "Update";
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.Click += ButtonUpdate_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(174, 99);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(75, 23);
            ButtonCancel.TabIndex = 5;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(93, 99);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(75, 23);
            ButtonDelete.TabIndex = 6;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // CategoryDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 133);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonUpdate);
            Controls.Add(TextBoxName);
            Controls.Add(TextBoxID);
            Controls.Add(LabelName);
            Controls.Add(LabelID);
            Name = "CategoryDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category Details";
            Load += EditCategoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelID;
        private Label LabelName;
        private TextBox TextBoxID;
        private TextBox TextBoxName;
        private Button ButtonUpdate;
        private Button ButtonCancel;
        private Button ButtonDelete;
    }
}