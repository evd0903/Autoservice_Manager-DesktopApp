namespace WindowsFormsApp2
{
    partial class AddDetail
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SalePriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CountTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.CodeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.BuyPriceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(203, 350);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(145, 34);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Добавить";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // SalePriceTextBox
            // 
            // 
            // 
            // 
            this.SalePriceTextBox.CustomButton.Image = null;
            this.SalePriceTextBox.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.SalePriceTextBox.CustomButton.Name = "";
            this.SalePriceTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SalePriceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SalePriceTextBox.CustomButton.TabIndex = 1;
            this.SalePriceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SalePriceTextBox.CustomButton.UseSelectable = true;
            this.SalePriceTextBox.CustomButton.Visible = false;
            this.SalePriceTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.SalePriceTextBox.Lines = new string[0];
            this.SalePriceTextBox.Location = new System.Drawing.Point(203, 275);
            this.SalePriceTextBox.MaxLength = 32767;
            this.SalePriceTextBox.Name = "SalePriceTextBox";
            this.SalePriceTextBox.PasswordChar = '\0';
            this.SalePriceTextBox.PromptText = "Введите цену";
            this.SalePriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SalePriceTextBox.SelectedText = "";
            this.SalePriceTextBox.SelectionLength = 0;
            this.SalePriceTextBox.SelectionStart = 0;
            this.SalePriceTextBox.ShortcutsEnabled = true;
            this.SalePriceTextBox.ShowClearButton = true;
            this.SalePriceTextBox.Size = new System.Drawing.Size(145, 23);
            this.SalePriceTextBox.TabIndex = 6;
            this.SalePriceTextBox.UseSelectable = true;
            this.SalePriceTextBox.WaterMark = "Введите цену";
            this.SalePriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SalePriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(38, 273);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(132, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Цена продажи";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(38, 182);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Количество";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(38, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Наименование";
            // 
            // CountTextBox
            // 
            // 
            // 
            // 
            this.CountTextBox.CustomButton.Image = null;
            this.CountTextBox.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.CountTextBox.CustomButton.Name = "";
            this.CountTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CountTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CountTextBox.CustomButton.TabIndex = 1;
            this.CountTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CountTextBox.CustomButton.UseSelectable = true;
            this.CountTextBox.CustomButton.Visible = false;
            this.CountTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.CountTextBox.Lines = new string[0];
            this.CountTextBox.Location = new System.Drawing.Point(203, 184);
            this.CountTextBox.MaxLength = 32767;
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.PasswordChar = '\0';
            this.CountTextBox.PromptText = "Введите количество";
            this.CountTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CountTextBox.SelectedText = "";
            this.CountTextBox.SelectionLength = 0;
            this.CountTextBox.SelectionStart = 0;
            this.CountTextBox.ShortcutsEnabled = true;
            this.CountTextBox.ShowClearButton = true;
            this.CountTextBox.Size = new System.Drawing.Size(145, 23);
            this.CountTextBox.TabIndex = 7;
            this.CountTextBox.UseSelectable = true;
            this.CountTextBox.WaterMark = "Введите количество";
            this.CountTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CountTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(38, 139);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 25);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Артикул";
            // 
            // CodeTextBox
            // 
            // 
            // 
            // 
            this.CodeTextBox.CustomButton.Image = null;
            this.CodeTextBox.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.CodeTextBox.CustomButton.Name = "";
            this.CodeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CodeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CodeTextBox.CustomButton.TabIndex = 1;
            this.CodeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CodeTextBox.CustomButton.UseSelectable = true;
            this.CodeTextBox.CustomButton.Visible = false;
            this.CodeTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.CodeTextBox.Lines = new string[0];
            this.CodeTextBox.Location = new System.Drawing.Point(203, 141);
            this.CodeTextBox.MaxLength = 32767;
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.PasswordChar = '\0';
            this.CodeTextBox.PromptText = "Введите артикул";
            this.CodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CodeTextBox.SelectedText = "";
            this.CodeTextBox.SelectionLength = 0;
            this.CodeTextBox.SelectionStart = 0;
            this.CodeTextBox.ShortcutsEnabled = true;
            this.CodeTextBox.ShowClearButton = true;
            this.CodeTextBox.Size = new System.Drawing.Size(145, 23);
            this.CodeTextBox.TabIndex = 7;
            this.CodeTextBox.UseSelectable = true;
            this.CodeTextBox.WaterMark = "Введите артикул";
            this.CodeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CodeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-1, -1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 26);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged_1);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.comboBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(203, 87);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(159, 29);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(38, 228);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(122, 25);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Цена закупки";
            // 
            // BuyPriceTextBox
            // 
            // 
            // 
            // 
            this.BuyPriceTextBox.CustomButton.Image = null;
            this.BuyPriceTextBox.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.BuyPriceTextBox.CustomButton.Name = "";
            this.BuyPriceTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.BuyPriceTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.BuyPriceTextBox.CustomButton.TabIndex = 1;
            this.BuyPriceTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BuyPriceTextBox.CustomButton.UseSelectable = true;
            this.BuyPriceTextBox.CustomButton.Visible = false;
            this.BuyPriceTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.BuyPriceTextBox.Lines = new string[0];
            this.BuyPriceTextBox.Location = new System.Drawing.Point(203, 230);
            this.BuyPriceTextBox.MaxLength = 32767;
            this.BuyPriceTextBox.Name = "BuyPriceTextBox";
            this.BuyPriceTextBox.PasswordChar = '\0';
            this.BuyPriceTextBox.PromptText = "Введите цену";
            this.BuyPriceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BuyPriceTextBox.SelectedText = "";
            this.BuyPriceTextBox.SelectionLength = 0;
            this.BuyPriceTextBox.SelectionStart = 0;
            this.BuyPriceTextBox.ShortcutsEnabled = true;
            this.BuyPriceTextBox.ShowClearButton = true;
            this.BuyPriceTextBox.Size = new System.Drawing.Size(145, 23);
            this.BuyPriceTextBox.TabIndex = 6;
            this.BuyPriceTextBox.UseSelectable = true;
            this.BuyPriceTextBox.WaterMark = "Введите цену";
            this.BuyPriceTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.BuyPriceTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 407);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.BuyPriceTextBox);
            this.Controls.Add(this.SalePriceTextBox);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddDetail";
            this.Text = "AddDetail";
            this.Load += new System.EventHandler(this.AddDetail_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox SalePriceTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox CountTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox CodeTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox BuyPriceTextBox;
    }
}