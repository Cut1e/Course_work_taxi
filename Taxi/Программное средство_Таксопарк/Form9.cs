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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'KursachDataSet.Водитель' table. You can move, or remove it, as needed.
            this.ВодительTableAdapter.Fill(this.KursachDataSet.Водитель);

        }
    }
}
