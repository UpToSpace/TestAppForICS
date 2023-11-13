using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Models;

namespace TestApp
{
    public partial class AddEmployeeForm : Form
    {
        private EmployeesDB model;
        public AddEmployeeForm(EmployeesDB model)
        {
            InitializeComponent();
            this.model = model;
            string[] positions = { "manager", "shop assistant", "cashier", "bookkeeper", "chief" };
            PositionListBox.Items.AddRange(positions);
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                Name = NameTextBox.Text,
                Surname = SurnameTextBox.Text,
                Position = PositionListBox.SelectedItem as string,
                Salary = (int)SalaryNumericUpDown.Value,
                YearOfBirth = (int)YearOfBirthNumericUpDown.Value
            };

            ValidationContext contex = new ValidationContext(employee, null, null);
            List<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(employee, contex, errors, true))
            {
                foreach (var item in errors)
                {
                    MessageBox.Show(item.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                model.Employees.Add(employee);
                model.SaveChanges();
                Close();
            }
        }
    }
}
