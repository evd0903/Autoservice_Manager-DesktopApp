
using EntityFrameworkSqliteCodeFirst.Data;
using EntityFrameworkSqliteCodeFirst.Data.Tables;
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
    public partial class ChangeWorkHours : MetroFramework.Forms.MetroForm
    {
        private WorkHours wh_;

        

        List<Employee> employees = new List<Employee>();
        public ChangeWorkHours(WorkHours wh)
        {
            InitializeComponent();
            wh_ = wh;
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            wh_.Date = DateTime.Now.Date;
            wh_.StartTime = DateTime.Now;
            wh_.EmployeeId = employees[comboBox1.SelectedIndex].Id;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           wh_.EndTime = DateTime.Now;
            try
            {
                using (var cont = new MyDbContext())
                {
                    cont.WorkHours.Add(wh_);
                    cont.SaveChanges();
                }
                wh_ = new WorkHours();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ChangeWorkHours_Load(object sender, EventArgs e)
        {
            try
            {
                using (var cont = new MyDbContext())
                {
                    foreach (var p in cont.Employees)
                    {
                        comboBox1.Items.Add(p.Name);
                        employees.Add(p);

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
