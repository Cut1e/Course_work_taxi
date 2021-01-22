using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Программное_средство_Таксопарк
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'KursachDataSet.Водитель' table. You can move, or remove it, as needed.
            this.водительTableAdapter.Fill(this.KursachDataSet.Водитель);
            // TODO: This line of code loads data into the 'KursachDataSet.Отчёт_водитель' table. You can move, or remove it, as needed.
            this.Отчёт_водительTableAdapter.Fill(this.KursachDataSet.Отчёт_водитель);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Программное_средство_Таксопарк.Report14.rdlc";
            this.Отчёт_водительTableAdapter.FillBy(this.KursachDataSet.Отчёт_водитель, comboBox2.Text);
            reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Программное_средство_Таксопарк.Report15.rdlc";
            DateTime data = Convert.ToDateTime(String.Format(dateTimePicker1.Value.ToShortDateString()));
            DateTime data2 = Convert.ToDateTime(String.Format(dateTimePicker2.Value.ToShortDateString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("da", Convert.ToString(dateTimePicker1.Value.ToShortDateString())));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("da2", Convert.ToString(dateTimePicker2.Value.ToShortDateString())));
            this.Отчёт_водительTableAdapter.FillBy1(this.KursachDataSet.Отчёт_водитель, data, data2);
            reportViewer1.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Программное_средство_Таксопарк.Report5.rdlc";
            this.Отчёт_водительTableAdapter.Fill(this.KursachDataSet.Отчёт_водитель);
            reportViewer1.RefreshReport();
        }
    }
}
