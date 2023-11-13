using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Models;
using static System.Net.WebRequestMethods;

namespace TestApp
{
    public partial class ReportForm : Form
    {
        private EmployeesDB model;
        public ReportForm(EmployeesDB model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            List<Employee> employees = model.Employees.ToList();
            var rds = new ReportDataSource("DataSet1", employees);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
