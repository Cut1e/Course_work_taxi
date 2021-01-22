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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'KursachDataSet.Водитель' table. You can move, or remove it, as needed.
            this.водительTableAdapter.Fill(this.KursachDataSet.Водитель);
            this.ЗаказыTableAdapter.FillBy2(this.KursachDataSet.Заказы);
           dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Format = DateTimePickerFormat.Short;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportViewer2.LocalReport.ReportEmbeddedResource = "Программное_средство_Таксопарк.Report6.rdlc";
            DateTime data = Convert.ToDateTime(String.Format(dateTimePicker1.Value.ToShortDateString()));
            DateTime data2= Convert.ToDateTime(String.Format(dateTimePicker2.Value.ToShortDateString()));
            reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("da", Convert.ToString(dateTimePicker1.Value.ToShortDateString())));
            reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("da2", Convert.ToString(dateTimePicker2.Value.ToShortDateString())));
            this.ЗаказыTableAdapter.FillBy(this.KursachDataSet.Заказы, фИОComboBox.Text, data,data2);
                reportViewer2.RefreshReport();       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer2.LocalReport.ReportEmbeddedResource = "Программное_средство_Таксопарк.Report7.rdlc";
            DateTime data = Convert.ToDateTime(String.Format(dateTimePicker1.Value.ToShortDateString()));
            DateTime data2 = Convert.ToDateTime(String.Format(dateTimePicker2.Value.ToShortDateString()));
            reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("da", Convert.ToString(dateTimePicker4.Value.ToShortDateString())));
            reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("da2", Convert.ToString(dateTimePicker3.Value.ToShortDateString())));
            this.ЗаказыTableAdapter.FillBy1(this.KursachDataSet.Заказы, data, data2);
            reportViewer2.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reportViewer2.LocalReport.ReportEmbeddedResource = "Программное_средство_Таксопарк.Report1.rdlc";
            this.ЗаказыTableAdapter.FillBy2(this.KursachDataSet.Заказы);
            reportViewer2.RefreshReport();
        }
    }
}
