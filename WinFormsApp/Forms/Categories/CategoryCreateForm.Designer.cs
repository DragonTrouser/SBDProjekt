namespace WinFormsApp.Forms.Categories
{
    partial class CategoryCreateForm
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
            ButtonCancel = new Button();
            ButtonCreate = new Button();
            TextBoxName = new TextBox();
            LabelName = new Label();
            SuspendLayout();
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(93, 70);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(75, 23);
            ButtonCancel.TabIndex = 9;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ButtonCreate
            // 
            ButtonCreate.Location = new Point(12, 70);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(75, 23);
            ButtonCreate.TabIndex = 8;
            ButtonCreate.Text = "Create";
            ButtonCreate.UseVisualStyleBackColor = true;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(57, 12);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(100, 23);
            TextBoxName.TabIndex = 7;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(12, 15);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(39, 15);
            LabelName.TabIndex = 6;
            LabelName.Text = "Name";
            // 
            // CategoryCreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 105);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonCreate);
            Controls.Add(TextBoxName);
            Controls.Add(LabelName);
            Name = "CategoryCreateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonCancel;
        private Button ButtonCreate;
        private TextBox TextBoxName;
        private Label LabelName;
    }
}