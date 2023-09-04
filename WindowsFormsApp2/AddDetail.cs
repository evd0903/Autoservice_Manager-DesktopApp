using EntityFrameworkSqliteCodeFirst.Data.Tables;
using EntityFrameworkSqliteCodeFirst.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AddDetail : MetroFramework.Forms.MetroForm
    {

        private List<Detail> details = new List<Detail>();

        public AddDetail()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var cont = new MyDbContext())
                {
                    double saleprice = Convert.ToDouble(SalePriceTextBox.Text);
                    double buyprice = Convert.ToDouble(BuyPriceTextBox.Text);


                    var detail = cont.Details.FirstOrDefault(d => d.Code == CodeTextBox.Text && d.Name == comboBox1.Text
                        && d.SalePrice == saleprice && d.BuyPrice == buyprice);

                    if (detail != null)
                    {
                        detail.Count += Convert.ToInt32(CountTextBox.Text);
                    }
                    else
                    {
                        var newDetail = new Detail()
                        {
                            Name = comboBox1.Text,
                            Count = Convert.ToInt32(CountTextBox.Text),
                            Code = CodeTextBox.Text,
                            BuyPrice = Convert.ToDouble(BuyPriceTextBox.Text),
                            SalePrice = Convert.ToDouble(SalePriceTextBox.Text)
                        };

                        cont.Details.Add(newDetail);
                    }
                    
                    cont.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            MessageBox.Show("Деталь успешно добавлена!");
            this.Close();
        }

        private void AddDetail_Load(object sender, EventArgs e)
        {
            try
            {
                using (var cont = new MyDbContext())
                {
                    foreach (var p in cont.Details)
                    {
                        comboBox1.Items.Add(p.Name);
                        details.Add(p);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Contains(comboBox1.Text))
            {
                CodeTextBox.Text = details[comboBox1.SelectedIndex].Code;
                BuyPriceTextBox.Text = details[comboBox1.SelectedIndex].BuyPrice.ToString();
                SalePriceTextBox.Text = details[comboBox1.SelectedIndex].SalePrice.ToString();
            }

        }

        private void comboBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (!comboBox1.Items.Contains(comboBox1.Text))
            {
                CodeTextBox.Text = string.Empty;
                SalePriceTextBox.Text = string.Empty;
            }
        }        
    }
}
