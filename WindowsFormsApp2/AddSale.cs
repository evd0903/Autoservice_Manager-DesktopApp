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

using System.Data.Entity.Migrations;

namespace WindowsFormsApp2
{
    public partial class AddSale : MetroFramework.Forms.MetroForm
    {
        
        List<Client> clients_ = new List<Client>();
        private Detail detail_ = new Detail();

        public AddSale(Detail detail)
        {
            InitializeComponent();

            NewClientTextBox.Visible = false;
            NewVehicleTextBox.Visible = false;

            this.detail_ = detail;
            detailName.Text = detail.Name;
            availableCount.Text = detail.Count.ToString();
            vendorCode.Text = detail.Code;
            price.Text = detail.SalePrice.ToString();
        }

        private void AddSale_Load(object sender, EventArgs e)
        {
            try
            {
                using (var cont = new MyDbContext())
                {
                    foreach (var p in cont.Details)
                    {
                        detailName.Items.Add(p.Name);
                        
                    }

                    foreach (var c in cont.Clients)
                    {
                        Clients.Items.Add(c.Name);
                        clients_.Add(c);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void detailName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //vendorCode.Text = details[detailName.SelectedIndex].Code.ToString();
            //availableCount.Text = details[detailName.SelectedIndex].Count.ToString();
            //price.Text = details[detailName.SelectedIndex].Price.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            INNTextBox.Text = clients_[Clients.SelectedIndex].INN.ToString();

            List<Vehicle> vehicles = new List<Vehicle>();
            var clientid = clients_[Clients.SelectedIndex].Id;


            try
            {
                using (var cont = new MyDbContext())
                {
                    vehicles = cont.Vehicles.Where(w => w.ClientId == clientid).ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            foreach (var v in vehicles)
            {
                Vehicles.Items.Add(v.Name);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(saleCount.Text))
            {
                MessageBox.Show("Не все поля заполнены!");
                return;
            }

            if (!int.TryParse(saleCount.Text, out int result))
            {
                MessageBox.Show("Неверный аргумент поля количество!");
                return;
            }

            if (result > int.Parse(availableCount.Text))
            {
                MessageBox.Show("Количество для продажи больше доступного количества!");
                return;
            }

            try
            {
                using (var cont = new MyDbContext())
                {
                    var part = cont.Details.Find(detail_.Id);
                    part.Count -= result;

                    int salecount = Convert.ToInt32(saleCount.Text);

                    var sale = new SaledDetail
                    {
                        DetailId = detail_.Id,
                        SaleCount = salecount,
                        SaleDateTime = metroDateTime1.Value,
                        Income = (detail_.SalePrice - detail_.BuyPrice) * salecount
                    };

                    Client client = new Client();

                    if (!Clients.Visible)
                    {
                        client.Name = NewClientTextBox.Text;
                        client.INN = INNTextBox.Text;
                        client.Id = clients_.Count() + 1;

                        sale.ClientId = client.Id;
                        cont.Clients.Add(client);
                    }
                    else 
                    { 
                        sale.ClientId = clients_[Clients.SelectedIndex].Id;
                        client = clients_[Clients.SelectedIndex];
                    }

                    Vehicle vehicle = new Vehicle();
                    

                    if (!Vehicles.Visible)
                    {

                        vehicle.Name = NewVehicleTextBox.Text;
                        vehicle.ClientId = client.Id;
                        vehicle.Id = cont.Vehicles.Count() + 1;

                        sale.VehicleId = vehicle.Id;
                        cont.Vehicles.Add(vehicle);
                    }

                    else
                    {
                        vehicle.Name = Vehicles.SelectedItem.ToString();
                        vehicle.ClientId = client.Id;
                        sale.VehicleId = cont.Vehicles.Where(w => w.Name == vehicle.Name && w.ClientId == vehicle.ClientId).ToList()[0].Id;
                    }

                    cont.SaledDetails.Add(sale);
                    cont.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            MessageBox.Show("Деталь успешно продана!");
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Clients.Visible = false;
            Vehicles.Visible = false;
            NewClientTextBox.Visible = true;
            NewVehicleTextBox.Visible = true;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Vehicles.Visible = false;
            NewVehicleTextBox.Visible = true;
        }
    }
}
