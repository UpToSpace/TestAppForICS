using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Models;

namespace TestApp
{
    public partial class Form1 : Form
    {
        private BindingList<Employee> employees;
        private EmployeesDB model;

        public EmployeesDB Model { get => model; set => model = value; }

        public Form1()
        {
            model = new EmployeesDB();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            model.Employees.Load();
            if (model.Employees.Local.Count() == 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    string position = "manager";
                    switch (i % 3)
                    {
                        case 0:
                            position = "shop assistant";
                            break;
                        case 1:
                            position = "cashier";
                            break;
                        default:
                            break;
                    }
                    Employee employee = new Employee
                    {
                        Name = "Employee" + i,
                        Surname = "Surname" + i,
                        Position = position,
                        YearOfBirth = 1990 + i,
                        Salary = 50000 + i * 1000
                    };
                    model.Employees.Local.Add(employee);
                    model.SaveChanges();
                }
            }
            employees = model.Employees.Local.ToBindingList();
            dataGridView1.DataSource = employees;
        }

        private void PositionFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = PositionFilterTextBox.Text.Trim().ToLower();
            dataGridView1.DataSource = new BindingList<Employee>(employees.Where(em => em.Position != null && em.Position.ToLower().Contains(text)).ToList());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            model.Dispose();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(model);
            addEmployeeForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить сотрудников?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                    {
                        var removingItem = item.DataBoundItem as Employee;
                        if (removingItem != null)
                        {
                            dataGridView1.Rows.RemoveAt(item.Index);
                            model.Employees.Local.Remove(removingItem);
                            model.SaveChanges();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите строки для удаления!");
            }
        }

        private void Report_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(model);
            reportForm.ShowDialog();
        }
    }
}
