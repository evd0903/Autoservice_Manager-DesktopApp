using EntityFrameworkSqliteCodeFirst.Data;
using MetroFramework.Controls;
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
    public partial class SearchINN : MetroFramework.Forms.MetroForm
    {
        public SearchINN()
        {
            InitializeComponent();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            var client_inn = ClientINN.Text;

            try
            {
                using (var cont = new MyDbContext())
                {
                    var clients = cont.Clients.Where(w => w.INN == client_inn).ToList();

                    if (clients.Count != 1)
                    {
                        MessageBox.Show("Клиент не найден!");
                    }
                    else
                    {
                        MessageBox.Show("Клиент найден!");
                        ClientName.Text = clients[0].Name;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            ClientInfo form = new ClientInfo(ClientName.Text, client_inn);
            form.Show();
        }
    }
}
