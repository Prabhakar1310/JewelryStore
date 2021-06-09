namespace JewelryStore
{
    partial class Estimation
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
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.GoldPriceTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.TotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.GoldPriceLbl = new System.Windows.Forms.Label();
            this.TotalPriceLbl = new System.Windows.Forms.Label();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.DiscountLbl = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.PrintToPaperBtn = new System.Windows.Forms.Button();
            this.PrintToFileBtn = new System.Windows.Forms.Button();
            this.PrintToScreenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Location = new System.Drawing.Point(678, 23);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(0, 13);
            this.WelcomeLbl.TabIndex = 0;
            // 
            // GoldPriceTextBox
            // 
            this.GoldPriceTextBox.Location = new System.Drawing.Point(415, 87);
            this.GoldPriceTextBox.Name = "GoldPriceTextBox";
            this.GoldPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.GoldPriceTextBox.TabIndex = 1;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(415, 138);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.WeightTextBox.TabIndex = 2;
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.Location = new System.Drawing.Point(415, 196);
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.ReadOnly = true;
            this.TotalPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalPriceTextBox.TabIndex = 3;
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Enabled = false;
            this.DiscountTextBox.Location = new System.Drawing.Point(501, 247);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiscountTextBox.TabIndex = 4;
            this.DiscountTextBox.Text = "0";
            // 
            // GoldPriceLbl
            // 
            this.GoldPriceLbl.AutoSize = true;
            this.GoldPriceLbl.Location = new System.Drawing.Point(261, 87);
            this.GoldPriceLbl.Name = "GoldPriceLbl";
            this.GoldPriceLbl.Size = new System.Drawing.Size(106, 13);
            this.GoldPriceLbl.TabIndex = 5;
            this.GoldPriceLbl.Text = "Gold Price (per gram)";
            // 
            // TotalPriceLbl
            // 
            this.TotalPriceLbl.AutoSize = true;
            this.TotalPriceLbl.Location = new System.Drawing.Point(261, 203);
            this.TotalPriceLbl.Name = "TotalPriceLbl";
            this.TotalPriceLbl.Size = new System.Drawing.Size(58, 13);
            this.TotalPriceLbl.TabIndex = 6;
            this.TotalPriceLbl.Text = "Total Price";
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Location = new System.Drawing.Point(261, 141);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(78, 13);
            this.WeightLbl.TabIndex = 7;
            this.WeightLbl.Text = "Weight (grams)";
            // 
            // DiscountLbl
            // 
            this.DiscountLbl.AutoSize = true;
            this.DiscountLbl.Location = new System.Drawing.Point(424, 250);
            this.DiscountLbl.Name = "DiscountLbl";
            this.DiscountLbl.Size = new System.Drawing.Size(60, 13);
            this.DiscountLbl.TabIndex = 8;
            this.DiscountLbl.Text = "Discount %";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(71, 306);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(78, 40);
            this.CalculateBtn.TabIndex = 9;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(512, 306);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(76, 40);
            this.CloseBtn.TabIndex = 10;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // PrintToPaperBtn
            // 
            this.PrintToPaperBtn.Location = new System.Drawing.Point(396, 306);
            this.PrintToPaperBtn.Name = "PrintToPaperBtn";
            this.PrintToPaperBtn.Size = new System.Drawing.Size(75, 40);
            this.PrintToPaperBtn.TabIndex = 11;
            this.PrintToPaperBtn.Text = "Print to paper";
            this.PrintToPaperBtn.UseVisualStyleBackColor = true;
            this.PrintToPaperBtn.Click += new System.EventHandler(this.PrintToPaperBtn_Click);
            // 
            // PrintToFileBtn
            // 
            this.PrintToFileBtn.Location = new System.Drawing.Point(292, 306);
            this.PrintToFileBtn.Name = "PrintToFileBtn";
            this.PrintToFileBtn.Size = new System.Drawing.Size(75, 40);
            this.PrintToFileBtn.TabIndex = 12;
            this.PrintToFileBtn.Text = "Print to file";
            this.PrintToFileBtn.UseVisualStyleBackColor = true;
            this.PrintToFileBtn.Click += new System.EventHandler(this.PrintToFileBtn_Click);
            // 
            // PrintToScreenBtn
            // 
            this.PrintToScreenBtn.Location = new System.Drawing.Point(196, 306);
            this.PrintToScreenBtn.Name = "PrintToScreenBtn";
            this.PrintToScreenBtn.Size = new System.Drawing.Size(75, 40);
            this.PrintToScreenBtn.TabIndex = 13;
            this.PrintToScreenBtn.Text = "Print to screen";
            this.PrintToScreenBtn.UseVisualStyleBackColor = true;
            this.PrintToScreenBtn.Click += new System.EventHandler(this.PrintToScreenBtn_Click);
            // 
            // Estimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrintToScreenBtn);
            this.Controls.Add(this.PrintToFileBtn);
            this.Controls.Add(this.PrintToPaperBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.DiscountLbl);
            this.Controls.Add(this.WeightLbl);
            this.Controls.Add(this.TotalPriceLbl);
            this.Controls.Add(this.GoldPriceLbl);
            this.Controls.Add(this.DiscountTextBox);
            this.Controls.Add(this.TotalPriceTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.GoldPriceTextBox);
            this.Controls.Add(this.WelcomeLbl);
            this.Name = "Estimation";
            this.Text = "Estimation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Estimation_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.TextBox GoldPriceTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox TotalPriceTextBox;
        private System.Windows.Forms.TextBox DiscountTextBox;
        private System.Windows.Forms.Label GoldPriceLbl;
        private System.Windows.Forms.Label TotalPriceLbl;
        private System.Windows.Forms.Label WeightLbl;
        private System.Windows.Forms.Label DiscountLbl;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button PrintToPaperBtn;
        private System.Windows.Forms.Button PrintToFileBtn;
        private System.Windows.Forms.Button PrintToScreenBtn;
    }
}