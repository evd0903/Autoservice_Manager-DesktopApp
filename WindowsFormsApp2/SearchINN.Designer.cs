namespace WindowsFormsApp2
{
    partial class SearchINN
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
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.ClientName = new MetroFramework.Controls.MetroTextBox();
            this.ClientINN = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton5
            // 
            this.metroButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton5.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton5.Highlight = true;
            this.metroButton5.Location = new System.Drawing.Point(322, 280);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(165, 37);
            this.metroButton5.TabIndex = 7;
            this.metroButton5.Text = "Поиск";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.UseStyleColors = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(23, 93);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(140, 25);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Наименование ";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(23, 160);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(51, 25);
            this.metroLabel9.TabIndex = 13;
            this.metroLabel9.Text = "ИНН";
            // 
            // ClientName
            // 
            // 
            // 
            // 
            this.ClientName.CustomButton.Image = null;
            this.ClientName.CustomButton.Location = new System.Drawing.Point(264, 1);
            this.ClientName.CustomButton.Name = "";
            this.ClientName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ClientName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ClientName.CustomButton.TabIndex = 1;
            this.ClientName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ClientName.CustomButton.UseSelectable = true;
            this.ClientName.CustomButton.Visible = false;
            this.ClientName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ClientName.Lines = new string[0];
            this.ClientName.Location = new System.Drawing.Point(201, 93);
            this.ClientName.MaxLength = 32767;
            this.ClientName.Name = "ClientName";
            this.ClientName.PasswordChar = '\0';
            this.ClientName.ReadOnly = true;
            this.ClientName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ClientName.SelectedText = "";
            this.ClientName.SelectionLength = 0;
            this.ClientName.SelectionStart = 0;
            this.ClientName.ShortcutsEnabled = true;
            this.ClientName.Size = new System.Drawing.Size(286, 23);
            this.ClientName.TabIndex = 15;
            this.ClientName.UseSelectable = true;
            this.ClientName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ClientName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ClientINN
            // 
            // 
            // 
            // 
            this.ClientINN.CustomButton.Image = null;
            this.ClientINN.CustomButton.Location = new System.Drawing.Point(264, 1);
            this.ClientINN.CustomButton.Name = "";
            this.ClientINN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ClientINN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ClientINN.CustomButton.TabIndex = 1;
            this.ClientINN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ClientINN.CustomButton.UseSelectable = true;
            this.ClientINN.CustomButton.Visible = false;
            this.ClientINN.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ClientINN.Lines = new string[0];
            this.ClientINN.Location = new System.Drawing.Point(201, 162);
            this.ClientINN.MaxLength = 32767;
            this.ClientINN.Name = "ClientINN";
            this.ClientINN.PasswordChar = '\0';
            this.ClientINN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ClientINN.SelectedText = "";
            this.ClientINN.SelectionLength = 0;
            this.ClientINN.SelectionStart = 0;
            this.ClientINN.ShortcutsEnabled = true;
            this.ClientINN.Size = new System.Drawing.Size(286, 23);
            this.ClientINN.TabIndex = 15;
            this.ClientINN.UseSelectable = true;
            this.ClientINN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ClientINN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SearchINN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 340);
            this.Controls.Add(this.ClientINN);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroButton5);
            this.Name = "SearchINN";
            this.Text = "SearchINN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox ClientName;
        private MetroFramework.Controls.MetroTextBox ClientINN;
    }
}