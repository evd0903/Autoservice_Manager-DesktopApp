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
    public partial class DeleteEmployee : MetroFramework.Forms.MetroForm
    {
        private Employee employee_;

        public DeleteEmployee(Employee employee)
        {
            InitializeComponent();
            employee_ = employee;
            metroTextBox1.Text = employee_.Name;
            metroTextBox2.Text = employee_.Role;
            metroTextBox3.Text = employee_.Salary.ToString();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            try
            {
                using (var cont = new MyDbContext())
                {
                    Employee employee_to_remove = cont.Employees.Find(employee_.Id);

                    if (employee_to_remove != null)
                    {
                        cont.Employees.Remove(employee_to_remove);
                    }
                    else
                    {
                        MessageBox.Show("Сотрудник не найден/сбой системы");
                    }

                    
                    cont.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            MessageBox.Show("Сотрудник успешно удален!");
            this.Close();
        }
    }
}
