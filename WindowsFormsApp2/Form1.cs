using EntityFrameworkSqliteCodeFirst.Data.Tables;
using EntityFrameworkSqliteCodeFirst.Data;
using MetroFramework;
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
using System.Runtime.InteropServices;
using System.Globalization;
using System.ComponentModel.Design;

namespace WindowsFormsApp2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private WorkHours wh = new WorkHours();
        private bool changed = false;
        private Dictionary<string, List<Detail>> details_by_code_ = new Dictionary<string, List<Detail>>();
        private Dictionary<int, List<SaledDetail>> saled_details_ = new Dictionary<int, List<SaledDetail>>();
        private Dictionary<string, bool> metrogrid2_rows_status_ = new Dictionary<string, bool>();
        private Dictionary<int, bool> metrogrid4_rows_status_ = new Dictionary<int, bool>();

        public Form1()
        {
            InitializeComponent();
            UpdGrids();

            var customButton = new Button
            {
                Width = 30,
                Height = textBox1.ClientSize.Height,
                Location = new System.Drawing.Point(textBox1.ClientSize.Width - 30, -1),
                Cursor = Cursors.Default,
                BackgroundImage = Properties.Resources.search_icon,
                BackgroundImageLayout = ImageLayout.Zoom,
                FlatStyle = FlatStyle.Flat
            };

            textBox1.Controls.Add(customButton);

            customButton.Click += searchButton_CLick;
        }

        private void UpdGrids()
        {
            metroGrid1.Rows.Clear();
            metroGrid2.Rows.Clear();
            metroGrid3.Rows.Clear();
            metroGrid4.Rows.Clear();

            details_by_code_.Clear();
            saled_details_.Clear();
            try
            {
                using (var cont = new MyDbContext())
                {
                    // Получаем текущий месяц
                    int currentMonth = DateTime.Now.Month;

                    // Получаем текущий год
                    int currentYear = DateTime.Now.Year;

                    // Получаем начало и конец текущего месяца
                    DateTime startOfMonth = new DateTime(currentYear, currentMonth, 1);
                    DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

                    foreach (var p in cont.Employees)
                    {
                        var workedHours = cont.WorkHours.Where(w => w.EmployeeId == p.Id && w.Date >= startOfMonth && w.Date <= endOfMonth).ToList();
                        int totalHoursWorked = workedHours.Sum(w => (  w.EndTime.TimeOfDay - w.StartTime.TimeOfDay).Hours);

                        totalHoursWorked = 200;

                        if (p.Name == "Иванов Иван")
                        {
                           totalHoursWorked = 221;
                        }

                        int bonus = 200 * Math.Max(0, (totalHoursWorked - 180));

                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(metroGrid1, p.Id, p.Name, p.Role, p.Salary, totalHoursWorked, bonus);

                        if (totalHoursWorked < 180)
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                            
                        }

                        if (totalHoursWorked > 220)
                        {
                            row.DefaultCellStyle.BackColor = Color.Green;
                            
                        }

                        metroGrid1.Rows.Add(row);
                        

                    }

                    foreach (var p in cont.Details)
                    {
                        //metroGrid2.Rows.Add(p.Id, p.Name, p.Code, p.Count, p.Price);
                        if (!details_by_code_.ContainsKey(p.Code))
                        {
                            details_by_code_[p.Code] = new List<Detail>();
                        }
                        details_by_code_[p.Code].Add(p);

                    }

                    foreach (var item in details_by_code_)
                    {
                        if (item.Value.Count() > 1)
                        {
                            metroGrid2.Rows.Add(item.Value[0].Id, item.Value[0].Name, item.Value[0].Code);
                            //metroGrid2.Rows.Add(item.Value[0].Id, item.Value[0].Name, item.Value[0].Code, item.Value[0].Count, item.Value[0].Price);
                        }
                        else
                        {
                            metroGrid2.Rows.Add(item.Value[0].Id, item.Value[0].Name, item.Value[0].Code, item.Value[0].Count, item.Value[0].BuyPrice, item.Value[0].SalePrice);
                        }
                    }

                    foreach (var p in cont.SaledDetails)
                    {
                        if (!saled_details_.ContainsKey(p.SaleDateTime.Month)) {
                            saled_details_[p.SaleDateTime.Month] = new List<SaledDetail>(); 
                        }
                        saled_details_[p.SaleDateTime.Month].Add(p);

                        var client = cont.Clients.Find(p.ClientId);
                        if (client != null)
                        {
                            var detail = cont.Details.Find(p.DetailId);
                            var vehicle = cont.Vehicles.Find(p.VehicleId);
                            metroGrid3.Rows.Add(p.Id, cont.Details.Find(p.DetailId).Name, detail.Code, p.SaleCount, p.SaleDateTime, client.Name, client.INN, vehicle.Name);
                        } 
                    }

                    foreach (var p in saled_details_.Keys)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(metroGrid4, saled_details_[p][0].Id, new DateTime(DateTime.Now.Year, p, 1).ToString("MMMM"), "", "", "", saled_details_[p].Sum(s => s.Income));
                        metroGrid4.Rows.Add(row);
                    }
                   

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

      

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddEmployee formEmployee = new AddEmployee();
            formEmployee.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            UpdGrids();
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            UpdGrids();
        }

        private void metroButton5_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = metroGrid2.SelectedRows[0];

            Detail detail = new Detail()
            {
                Name = row.Cells[1].Value.ToString(),
                Count = Convert.ToInt32(row.Cells[3].Value),
                Code = row.Cells[2].Value.ToString(),
                BuyPrice = Convert.ToDouble(row.Cells[4].Value),
                SalePrice = Convert.ToDouble(row.Cells[5].Value)
               
            };

            

            foreach (var d in details_by_code_[detail.Code])
            {
                if (d.Name == detail.Name && d.Count == detail.Count && d.SalePrice == detail.SalePrice)
                {
                    detail.Id = d.Id;
                    break;
                }
            }

            AddSale form = new AddSale(detail);
            form.Show();
        }    
        private void metroButton3_Click(object sender, EventArgs e)
        {
            AddDetail form = new AddDetail();
            form.Show();
            
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            ChangeWorkHours form = new ChangeWorkHours(wh);
            form.Show();
            
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            UpdGrids();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Id = Convert.ToInt32(metroGrid1.SelectedRows[0].Cells[0].Value);
            employee.Name = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
            employee.Role = metroGrid1.SelectedRows[0].Cells[2].Value.ToString();
            employee.Salary =  Convert.ToInt32(metroGrid1.SelectedRows[0].Cells[3].Value);

            DeleteEmployee form = new DeleteEmployee(employee);
            form.Show();
        }

        private void deleteButton_CLick(object sender, EventArgs e)
        {
            int cnt = metroGrid2.SelectedRows.Count;

            for (int i = 0; i< cnt;++i)
            {
                Detail detail = new Detail();
                detail.Id = Convert.ToInt32(metroGrid2.SelectedRows[i].Cells[0].Value);
                //detail.Name = metroGrid2.SelectedRows[i].Cells[1].Value.ToString();
                //detail.Code = metroGrid2.SelectedRows[i].Cells[2].Value.ToString();
                //detail.Count = Convert.ToInt32(metroGrid2.SelectedRows[i].Cells[3].Value);
                //detail.BuyPrice = Convert.ToDouble(metroGrid2.SelectedRows[i].Cells[4].Value);
                //detail.SalePrice = Convert.ToDouble(metroGrid2.SelectedRows[i].Cells[5].Value);

                try
                {
                    using (var cont = new MyDbContext())
                    {
                        Detail detail_to_remove = cont.Details.Find(detail.Id);

                        if (detail_to_remove != null)
                        {
                            cont.Details.Remove(detail_to_remove);
                        }
                        else
                        {
                            MessageBox.Show("Детель не найдена/сбой системы");
                        }

                        cont.SaveChanges();
                        MessageBox.Show("Детали успешно удалены!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

               

            }

        }


        private void searchButton_CLick(object sender, EventArgs e)
        {
            metroGrid2.Rows.Clear();

            foreach (var item in details_by_code_)
            {
                if (item.Value[0].Name.Contains(textBox1.Text))
                {
                    if (item.Value.Count() > 1)
                    {
                        metroGrid2.Rows.Add(item.Value[0].Id, item.Value[0].Name, item.Value[0].Code);
                        //metroGrid2.Rows.Add(item.Value[0].Id, item.Value[0].Name, item.Value[0].Code, item.Value[0].Count, item.Value[0].Price);
                    }
                    else
                    {
                        metroGrid2.Rows.Add(item.Value[0].Id, item.Value[0].Name, item.Value[0].Code, item.Value[0].Count, item.Value[0].BuyPrice, item.Value[0].SalePrice);
                    }
                }
            }

        }

        private void metroGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                return;
            }

            int pos = e.RowIndex + 1;
            string key = metroGrid2.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (metroGrid2.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                if (!metrogrid2_rows_status_.ContainsKey(key) || metrogrid2_rows_status_[key] == false)
                {
                    if (details_by_code_[key].Count > 1)
                    {
                        foreach (var p in details_by_code_[key])
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(metroGrid2, "", p.Name, p.Code, p.Count, p.BuyPrice, p.SalePrice);
                            //row.Cells[0].Style.BackColor = Color.White; 
                            metroGrid2.Rows.Insert(pos++, row);
                            
                        }
                    }
                    metrogrid2_rows_status_[key] = true;
                }
                else
                {
                    int cnt = details_by_code_[key].Count == 1 ? 0 : details_by_code_[key].Count;

                    for (int i = 0; i < cnt; i++)
                    {
                        if (pos < metroGrid2.Rows.Count)
                        {
                            metroGrid2.Rows.RemoveAt(pos);
                        }
                    }
                    metrogrid2_rows_status_[key] = false;
                }
            }
        }

        private void metroGrid4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                return;
            }

            int pos = e.RowIndex + 1;

            DateTimeFormatInfo dateTimeFormat = new CultureInfo("ru-RU").DateTimeFormat;

            int key = DateTime.ParseExact(metroGrid4.Rows[e.RowIndex].Cells[1].Value.ToString(), "MMMM", dateTimeFormat).Month;

            if (metroGrid4.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                if (!metrogrid4_rows_status_.ContainsKey(key) || metrogrid4_rows_status_[key] == false)
                {
                    if (saled_details_[key].Count > 1)
                    {
                        foreach (var p in saled_details_[key])
                        {
                            DataGridViewRow row = new DataGridViewRow();

                            Detail detail = new Detail();

                            try
                            {
                                using (var cont = new MyDbContext())
                                {
                                    detail = cont.Details.Find(p.DetailId);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);

                            }

                            row.CreateCells(metroGrid4, "", "", detail.Name, detail.Code, p.SaleDateTime, p.Income);
                            //row.Cells[0].Style.BackColor = Color.White; 
                            metroGrid4.Rows.Insert(pos++, row);

                        }
                    }
                    metrogrid4_rows_status_[key] = true;
                }
                else
                {
                    int cnt = saled_details_[key].Count == 1 ? 0 : saled_details_[key].Count;

                    for (int i = 0; i < cnt; i++)
                    {
                        if (pos < metroGrid4.Rows.Count)
                        {
                            metroGrid4.Rows.RemoveAt(pos);
                        }
                    }
                    metrogrid4_rows_status_[key] = false;
                }
            }
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroPanel1.Visible)
            {
                metroPanel1.Visible = false;
            }
            else
            {
                metroPanel1.Visible = true;
            }
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            SearchINN form = new SearchINN();
            form.ShowDialog();
        }
    }
}
