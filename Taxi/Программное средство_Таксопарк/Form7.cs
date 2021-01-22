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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'KursachDataSet.Марка' table. You can move, or remove it, as needed.
            this.маркаTableAdapter.Fill(this.KursachDataSet.Марка);
            // TODO: This line of code loads data into the 'kursachDataSet1.Водитель' table. You can move, or remove it, as needed.
            this.водительTableAdapter.Fill(this.kursachDataSet1.Водитель);
            // TODO: This line of code loads data into the 'KursachDataSet.Автомобили' table. You can move, or remove it, as needed.
            this.АвтомобилиTableAdapter.Fill(this.KursachDataSet.Автомобили);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Программное_средство_Таксопарк.Report8.rdlc";
            this.АвтомобилиTableAdapter.FillBy(this.KursachDataSet.Автомобили, comboBox1.Text);
            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Программное_средство_Таксопарк.Report9.rdlc";
            this.АвтомобилиTableAdapter.FillBy1(this.KursachDataSet.Автомобили, comboBox2.Text);
            reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Программное_средство_Таксопарк.Report10.rdlc";
            this.АвтомобилиTableAdapter.FillBy2(this.KursachDataSet.Автомобили, textBox1.Text);
            reportViewer1.RefreshReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Программное_средство_Таксопарк.Report2.rdlc";
            this.АвтомобилиTableAdapter.Fill(this.KursachDataSet.Автомобили);
            this.reportViewer1.RefreshReport();
        }
    }
}
