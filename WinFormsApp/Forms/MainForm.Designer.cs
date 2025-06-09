namespace WinFormsApp.Forms
{
    partial class MainForm
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
            ButtonSales = new Button();
            ButtonProducts = new Button();
            ButtonCategories = new Button();
            ButtonExit = new Button();
            SuspendLayout();
            // 
            // ButtonSales
            // 
            ButtonSales.Location = new Point(12, 12);
            ButtonSales.Name = "ButtonSales";
            ButtonSales.Size = new Size(75, 23);
            ButtonSales.TabIndex = 4;
            ButtonSales.Text = "Sales";
            ButtonSales.UseVisualStyleBackColor = true;
            ButtonSales.Click += ButtonSales_Click;
            // 
            // ButtonProducts
            // 
            ButtonProducts.Location = new Point(12, 41);
            ButtonProducts.Name = "ButtonProducts";
            ButtonProducts.Size = new Size(75, 23);
            ButtonProducts.TabIndex = 6;
            ButtonProducts.Text = "Products";
            ButtonProducts.UseVisualStyleBackColor = true;
            ButtonProducts.Click += ButtonProducts_Click;
            // 
            // ButtonCategories
            // 
            ButtonCategories.Location = new Point(12, 70);
            ButtonCategories.Name = "ButtonCategories";
            ButtonCategories.Size = new Size(75, 23);
            ButtonCategories.TabIndex = 7;
            ButtonCategories.Text = "Categories";
            ButtonCategories.UseVisualStyleBackColor = true;
            ButtonCategories.Click += ButtonCategories_Click;
            // 
            // ButtonExit
            // 
            ButtonExit.Location = new Point(12, 166);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(75, 23);
            ButtonExit.TabIndex = 8;
            ButtonExit.Text = "Exit";
            ButtonExit.UseVisualStyleBackColor = true;
            ButtonExit.Click += ButtonExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 201);
            Controls.Add(ButtonExit);
            Controls.Add(ButtonCategories);
            Controls.Add(ButtonProducts);
            Controls.Add(ButtonSales);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button ButtonSales;
        private Button ButtonProducts;
        private Button ButtonCategories;
        private Button ButtonExit;
    }
}