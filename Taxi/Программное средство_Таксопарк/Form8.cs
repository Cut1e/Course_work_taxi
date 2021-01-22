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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'KursachDataSet.Водитель' table. You can move, or remove it, as needed.
            this.водительTableAdapter.Fill(this.KursachDataSet.Водитель);
            // TODO: This line of code loads data into the 'KursachDataSet.Марка' table. You can move, or remove it, as needed.
            this.маркаTableAdapter.Fill(this.KursachDataSet.Марка);
            // TODO: This line of code loads data into the 'KursachDataSet.Отчёт_ремонт' table. You can move, or remove it, as needed.
            this.Отчёт_ремонтTableAdapter.Fill(this.KursachDataSet.Отчёт_ремонт);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Программное_средство_Таксопарк.Report11.rdlc";
            this.Отчёт_ремонтTableAdapter.FillBy(this.KursachDataSet.Отчёт_ремонт, comboBox2.Text);
            reportViewer1.RefreshReport();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Программное_средство_Таксопарк.Report13.rdlc";
            this.Отчёт_ремонтTableAdapter.FillBy2(this.KursachDataSet.Отчёт_ремонт, comboBox4.Text);
            reportViewer1.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Программное_средство_Таксопарк.Report3.rdlc";
            this.Отчёт_ремонтTableAdapter.Fill(this.KursachDataSet.Отчёт_ремонт);
            reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Программное_средство_Таксопарк.Report12.rdlc";
            DateTime data = Convert.ToDateTime(String.Format(dateTimePicker1.Value.ToShortDateString()));
            DateTime data2 = Convert.ToDateTime(String.Format(dateTimePicker2.Value.ToShortDateString()));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("da", Convert.ToString(dateTimePicker1.Value.ToShortDateString())));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("da2", Convert.ToString(dateTimePicker2.Value.ToShortDateString())));
            this.Отчёт_ремонтTableAdapter.FillBy1(this.KursachDataSet.Отчёт_ремонт, data,data2);
            reportViewer1.RefreshReport();
        }
    }
}
