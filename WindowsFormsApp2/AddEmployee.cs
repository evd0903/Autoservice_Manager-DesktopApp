using EntityFrameworkSqliteCodeFirst.Data;
using EntityFrameworkSqliteCodeFirst.Data.Tables;
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
    public partial class AddEmployee : MetroFramework.Forms.MetroForm
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

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
                    var employee = new Employee
                    {
                        Name = metroTextBox1.Text
                        ,
                        Role = metroTextBox2.Text
                        ,
                        Salary = Convert.ToInt32 (metroTextBox3.Text)
                    };

                    cont.Employees.Add(employee);
                    cont.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            MessageBox.Show("Сотрудник успешно добавлен!");
            this.Close();
        }
    }
}
