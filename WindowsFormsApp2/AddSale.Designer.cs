namespace WindowsFormsApp2
{
    partial class AddSale
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.detailName = new System.Windows.Forms.ComboBox();
            this.price = new MetroFramework.Controls.MetroTextBox();
            this.vendorCode = new MetroFramework.Controls.MetroTextBox();
            this.availableCount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.saleCount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.clientPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.NewClientTextBox = new MetroFramework.Controls.MetroTextBox();
            this.INNTextBox = new MetroFramework.Controls.MetroTextBox();
            this.Clients = new System.Windows.Forms.ComboBox();
            this.NewVehicleTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.Vehicles = new System.Windows.Forms.ComboBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.clientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(577, 510);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(145, 34);
            this.metroButton1.TabIndex = 17;
            this.metroButton1.Text = "Добавить";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(457, 78);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 25);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Артикул";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(457, 143);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 25);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Цена";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 143);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(198, 25);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Доступное количество";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(161, 25);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Выбранная деталь";
            // 
            // detailName
            // 
            this.detailName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.detailName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.detailName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detailName.FormattingEnabled = true;
            this.detailName.Location = new System.Drawing.Point(250, 78);
            this.detailName.Name = "detailName";
            this.detailName.Size = new System.Drawing.Size(161, 28);
            this.detailName.TabIndex = 18;
            this.detailName.SelectedIndexChanged += new System.EventHandler(this.detailName_SelectedIndexChanged);
            // 
            // price
            // 
            // 
            // 
            // 
            this.price.CustomButton.Image = null;
            this.price.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.price.CustomButton.Name = "";
            this.price.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.price.CustomButton.TabIndex = 1;
            this.price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.price.CustomButton.UseSelectable = true;
            this.price.CustomButton.Visible = false;
            this.price.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.price.Lines = new string[0];
            this.price.Location = new System.Drawing.Point(577, 145);
            this.price.MaxLength = 32767;
            this.price.Name = "price";
            this.price.PasswordChar = '\0';
            this.price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.price.SelectedText = "";
            this.price.SelectionLength = 0;
            this.price.SelectionStart = 0;
            this.price.ShortcutsEnabled = true;
            this.price.ShowClearButton = true;
            this.price.Size = new System.Drawing.Size(145, 23);
            this.price.TabIndex = 19;
            this.price.UseSelectable = true;
            this.price.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.price.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // vendorCode
            // 
            // 
            // 
            // 
            this.vendorCode.CustomButton.Image = null;
            this.vendorCode.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.vendorCode.CustomButton.Name = "";
            this.vendorCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.vendorCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.vendorCode.CustomButton.TabIndex = 1;
            this.vendorCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.vendorCode.CustomButton.UseSelectable = true;
            this.vendorCode.CustomButton.Visible = false;
            this.vendorCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.vendorCode.Lines = new string[0];
            this.vendorCode.Location = new System.Drawing.Point(577, 78);
            this.vendorCode.MaxLength = 32767;
            this.vendorCode.Name = "vendorCode";
            this.vendorCode.PasswordChar = '\0';
            this.vendorCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vendorCode.SelectedText = "";
            this.vendorCode.SelectionLength = 0;
            this.vendorCode.SelectionStart = 0;
            this.vendorCode.ShortcutsEnabled = true;
            this.vendorCode.ShowClearButton = true;
            this.vendorCode.Size = new System.Drawing.Size(145, 23);
            this.vendorCode.TabIndex = 20;
            this.vendorCode.UseSelectable = true;
            this.vendorCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.vendorCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // availableCount
            // 
            // 
            // 
            // 
            this.availableCount.CustomButton.Image = null;
            this.availableCount.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.availableCount.CustomButton.Name = "";
            this.availableCount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.availableCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.availableCount.CustomButton.TabIndex = 1;
            this.availableCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.availableCount.CustomButton.UseSelectable = true;
            this.availableCount.CustomButton.Visible = false;
            this.availableCount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.availableCount.Lines = new string[0];
            this.availableCount.Location = new System.Drawing.Point(250, 143);
            this.availableCount.MaxLength = 32767;
            this.availableCount.Name = "availableCount";
            this.availableCount.PasswordChar = '\0';
            this.availableCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.availableCount.SelectedText = "";
            this.availableCount.SelectionLength = 0;
            this.availableCount.SelectionStart = 0;
            this.availableCount.ShortcutsEnabled = true;
            this.availableCount.ShowClearButton = true;
            this.availableCount.Size = new System.Drawing.Size(145, 23);
            this.availableCount.TabIndex = 21;
            this.availableCount.UseSelectable = true;
            this.availableCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.availableCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(23, 203);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(219, 25);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Количество для продажи";
            // 
            // saleCount
            // 
            // 
            // 
            // 
            this.saleCount.CustomButton.Image = null;
            this.saleCount.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.saleCount.CustomButton.Name = "";
            this.saleCount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.saleCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.saleCount.CustomButton.TabIndex = 1;
            this.saleCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.saleCount.CustomButton.UseSelectable = true;
            this.saleCount.CustomButton.Visible = false;
            this.saleCount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.saleCount.Lines = new string[0];
            this.saleCount.Location = new System.Drawing.Point(250, 205);
            this.saleCount.MaxLength = 32767;
            this.saleCount.Name = "saleCount";
            this.saleCount.PasswordChar = '\0';
            this.saleCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.saleCount.SelectedText = "";
            this.saleCount.SelectionLength = 0;
            this.saleCount.SelectionStart = 0;
            this.saleCount.ShortcutsEnabled = true;
            this.saleCount.Size = new System.Drawing.Size(145, 23);
            this.saleCount.TabIndex = 22;
            this.saleCount.UseSelectable = true;
            this.saleCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.saleCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(457, 201);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(49, 25);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Дата";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(577, 197);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(145, 29);
            this.metroDateTime1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Покупатель";
            // 
            // clientPanel
            // 
            this.clientPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientPanel.Controls.Add(this.metroLabel7);
            this.clientPanel.Controls.Add(this.metroLabel8);
            this.clientPanel.Controls.Add(this.metroLabel9);
            this.clientPanel.Controls.Add(this.NewClientTextBox);
            this.clientPanel.Controls.Add(this.INNTextBox);
            this.clientPanel.Controls.Add(this.Clients);
            this.clientPanel.Controls.Add(this.NewVehicleTextBox);
            this.clientPanel.Controls.Add(this.Vehicles);
            this.clientPanel.HorizontalScrollbarBarColor = true;
            this.clientPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.clientPanel.HorizontalScrollbarSize = 10;
            this.clientPanel.Location = new System.Drawing.Point(15, 316);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(715, 149);
            this.clientPanel.TabIndex = 25;
            this.clientPanel.VerticalScrollbarBarColor = true;
            this.clientPanel.VerticalScrollbarHighlightOnWheel = false;
            this.clientPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(7, 25);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(140, 25);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Наименование ";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(3, 86);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(207, 25);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "Транспортное средство";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(441, 20);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(51, 25);
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "ИНН";
            // 
            // NewClientTextBox
            // 
            // 
            // 
            // 
            this.NewClientTextBox.CustomButton.Image = null;
            this.NewClientTextBox.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.NewClientTextBox.CustomButton.Name = "";
            this.NewClientTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NewClientTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewClientTextBox.CustomButton.TabIndex = 1;
            this.NewClientTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewClientTextBox.CustomButton.UseSelectable = true;
            this.NewClientTextBox.CustomButton.Visible = false;
            this.NewClientTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.NewClientTextBox.Lines = new string[0];
            this.NewClientTextBox.Location = new System.Drawing.Point(230, 25);
            this.NewClientTextBox.MaxLength = 32767;
            this.NewClientTextBox.Name = "NewClientTextBox";
            this.NewClientTextBox.PasswordChar = '\0';
            this.NewClientTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NewClientTextBox.SelectedText = "";
            this.NewClientTextBox.SelectionLength = 0;
            this.NewClientTextBox.SelectionStart = 0;
            this.NewClientTextBox.ShortcutsEnabled = true;
            this.NewClientTextBox.ShowClearButton = true;
            this.NewClientTextBox.Size = new System.Drawing.Size(190, 23);
            this.NewClientTextBox.TabIndex = 20;
            this.NewClientTextBox.UseSelectable = true;
            this.NewClientTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NewClientTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // INNTextBox
            // 
            // 
            // 
            // 
            this.INNTextBox.CustomButton.Image = null;
            this.INNTextBox.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.INNTextBox.CustomButton.Name = "";
            this.INNTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.INNTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.INNTextBox.CustomButton.TabIndex = 1;
            this.INNTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.INNTextBox.CustomButton.UseSelectable = true;
            this.INNTextBox.CustomButton.Visible = false;
            this.INNTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.INNTextBox.Lines = new string[0];
            this.INNTextBox.Location = new System.Drawing.Point(548, 22);
            this.INNTextBox.MaxLength = 32767;
            this.INNTextBox.Name = "INNTextBox";
            this.INNTextBox.PasswordChar = '\0';
            this.INNTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.INNTextBox.SelectedText = "";
            this.INNTextBox.SelectionLength = 0;
            this.INNTextBox.SelectionStart = 0;
            this.INNTextBox.ShortcutsEnabled = true;
            this.INNTextBox.ShowClearButton = true;
            this.INNTextBox.Size = new System.Drawing.Size(145, 23);
            this.INNTextBox.TabIndex = 20;
            this.INNTextBox.UseSelectable = true;
            this.INNTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.INNTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Clients
            // 
            this.Clients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Clients.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clients.FormattingEnabled = true;
            this.Clients.Location = new System.Drawing.Point(230, 22);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(190, 28);
            this.Clients.TabIndex = 18;
            this.Clients.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NewVehicleTextBox
            // 
            // 
            // 
            // 
            this.NewVehicleTextBox.CustomButton.Image = null;
            this.NewVehicleTextBox.CustomButton.Location = new System.Drawing.Point(441, 1);
            this.NewVehicleTextBox.CustomButton.Name = "";
            this.NewVehicleTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NewVehicleTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NewVehicleTextBox.CustomButton.TabIndex = 1;
            this.NewVehicleTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NewVehicleTextBox.CustomButton.UseSelectable = true;
            this.NewVehicleTextBox.CustomButton.Visible = false;
            this.NewVehicleTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.NewVehicleTextBox.Lines = new string[0];
            this.NewVehicleTextBox.Location = new System.Drawing.Point(230, 88);
            this.NewVehicleTextBox.MaxLength = 32767;
            this.NewVehicleTextBox.Name = "NewVehicleTextBox";
            this.NewVehicleTextBox.PasswordChar = '\0';
            this.NewVehicleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NewVehicleTextBox.SelectedText = "";
            this.NewVehicleTextBox.SelectionLength = 0;
            this.NewVehicleTextBox.SelectionStart = 0;
            this.NewVehicleTextBox.ShortcutsEnabled = true;
            this.NewVehicleTextBox.ShowClearButton = true;
            this.NewVehicleTextBox.Size = new System.Drawing.Size(463, 23);
            this.NewVehicleTextBox.TabIndex = 21;
            this.NewVehicleTextBox.UseSelectable = true;
            this.NewVehicleTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NewVehicleTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(391, 510);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(145, 34);
            this.metroButton2.TabIndex = 17;
            this.metroButton2.Text = "Новый покупатель";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Vehicles
            // 
            this.Vehicles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Vehicles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Vehicles.BackColor = System.Drawing.SystemColors.Window;
            this.Vehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vehicles.FormattingEnabled = true;
            this.Vehicles.Location = new System.Drawing.Point(230, 86);
            this.Vehicles.Name = "Vehicles";
            this.Vehicles.Size = new System.Drawing.Size(463, 28);
            this.Vehicles.TabIndex = 22;
            // 
            // metroButton3
            // 
            this.metroButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(205, 510);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(145, 34);
            this.metroButton3.TabIndex = 17;
            this.metroButton3.Text = "Новое ТС";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 567);
            this.Controls.Add(this.clientPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.saleCount);
            this.Controls.Add(this.price);
            this.Controls.Add(this.vendorCode);
            this.Controls.Add(this.availableCount);
            this.Controls.Add(this.detailName);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddSale";
            this.Text = "AddSale";
            this.Load += new System.EventHandler(this.AddSale_Load);
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox detailName;
        private MetroFramework.Controls.MetroTextBox price;
        private MetroFramework.Controls.MetroTextBox vendorCode;
        private MetroFramework.Controls.MetroTextBox availableCount;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox saleCount;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel clientPanel;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox INNTextBox;
        private System.Windows.Forms.ComboBox Clients;
        private MetroFramework.Controls.MetroTextBox NewVehicleTextBox;
        private MetroFramework.Controls.MetroTextBox NewClientTextBox;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.ComboBox Vehicles;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}