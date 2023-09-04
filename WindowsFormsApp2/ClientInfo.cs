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
using System.CodeDom;

namespace WindowsFormsApp2
{
    public partial class ClientInfo : MetroFramework.Forms.MetroForm
    {
        private string client_name_;
        private string client_INN_;


        public ClientInfo(string client_name, string client_INN)
        {
            InitializeComponent();
            this.client_name_ = client_name;
            this.client_INN_ = client_INN;
            this.Text = "Информация по " + client_name_;

            try
            {
                using (var cont = new MyDbContext())
                {
                    var purchases = cont.SaledDetails
                        .Include("ClientById")
                        .Where(w => w.ClientById.Name == client_name_ && w.ClientById.INN == client_INN_).ToList();

                    foreach (var p in purchases) {
                        metroGrid3.Rows.Add(p.Id, cont.Details.Find(p.DetailId).Name, cont.Details.Find(p.DetailId).Code, p.SaleCount, 
                            p.SaleDateTime, cont.Vehicles.Find(p.VehicleId).Name);
                    }

                    var vehilces = cont.Vehicles
                        .Include("ClientById")
                        .Where(w => w.ClientById.Name == client_name_ && w.ClientById.INN == client_INN_).ToList();

                    foreach (var v in vehilces) 
                    {
                        metroGrid1.Rows.Add(v.Id, v.Name);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
