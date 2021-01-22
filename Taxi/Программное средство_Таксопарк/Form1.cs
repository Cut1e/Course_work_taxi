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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        int max = 3500;
        private void Form1_Load(object sender, EventArgs e)
        {
       
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            progressBar1.Value = i;
            i += 200;
            if (i > max)
            {
                timer1.Enabled = false;
                form2.Show();
                this.Hide();
            }
        
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);  
            progressBar1.Maximum = max;
        }
    }
    
}
