using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Программное_средство_Таксопарк
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/id237021687");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/vladikshokoladik_/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("popelizaxar@mail.ru", " Почта");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.автомобилиTableAdapter.Fill(this.kursachDataSet.Автомобили);
            this.модельTableAdapter.Fill(this.kursachDataSet1.Модель);
            this.маркаTableAdapter.Fill(this.kursachDataSet1.Марка);
            this.водительTableAdapter.Fill(this.kursachDataSet.Водитель);
            this.заказыTableAdapter.Fill(this.kursachDataSet.Заказы);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            дата_и_времяDateTimePicker.Format = DateTimePickerFormat.Short;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    if (MessageBox.Show("Вы уверены что хотите закрыть программу?", "Выйти?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Упс!");
            }        
        }
        private void button2_Click_1(object sender, EventArgs e)
        {

                Form4 form4 = new Form4();
                form4.Show();
        }
        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
        private void водителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "") MessageBox.Show("Введите пожалуйста откуда забирать клиента", " Внимание!");
                else
                if (textBox2.Text == "") MessageBox.Show("Введите пожалуйста куда доставить клиента", " Внимание!");
                else
                if (textBox3.Text == "") MessageBox.Show("Введите пожалуйста цену поездки", " Внимание!");
                else
                {
                    if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = (int)comboBox1.SelectedValue;
                        int id2 = (int)модельComboBox.SelectedValue;
                        DateTime data = Convert.ToDateTime(String.Format(dateTimePicker1.Value.ToShortDateString()));
                        this.заказыTableAdapter.InsertQuery(data, textBox1.Text, textBox2.Text, textBox3.Text, id, (Convert.ToBoolean(checkBox1.Checked)), id2);
                        this.заказыTableAdapter.Fill(this.kursachDataSet.Заказы);
                        this.заказыTableAdapter.Adapter.Update(this.kursachDataSet.Заказы);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Неверный формат данных", " Внимание!");
            }                       
        }
        private void удалитьВыбраннуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.заказыTableAdapter.DeleteQuery(System.Convert.ToInt32(заказыDataGridView.SelectedCells[0].Value));
                    this.заказыTableAdapter.Fill(this.kursachDataSet.Заказы);
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }
        private void button1_Click_4(object sender, EventArgs e)
        {
            try
            {
                if (улица_дом_откудаTextBox.Text == "") MessageBox.Show("Введите пожалуйста откуда забирать клиента", " Внимание!");
                else
               if (улица_дом_кудаTextBox.Text == "") MessageBox.Show("Введите пожалуйста куда доставить клиента", " Внимание!");
                else
               if (цена_поездкиTextBox.Text == "") MessageBox.Show("Введите пожалуйста цену поездки", " Внимание!");
                else
                {
                    if (MessageBox.Show("Вы уверены что хотите обновить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = (int)comboBox2.SelectedValue;
                        int id2 = (int)comboBox4.SelectedValue;
                        DateTime data = Convert.ToDateTime(String.Format(дата_и_времяDateTimePicker.Value.ToShortDateString()));
                        this.заказыTableAdapter.UpdateQuery(data, улица_дом_откудаTextBox.Text, улица_дом_кудаTextBox.Text, Convert.ToDecimal(цена_поездкиTextBox.Text), id, (Convert.ToBoolean(выполненCheckBox.Checked)), id2, Convert.ToInt32(заказыDataGridView.Rows[заказыDataGridView.CurrentCell.RowIndex].Cells[0].Value));
                        this.заказыTableAdapter.Fill(this.kursachDataSet.Заказы);
                        this.заказыTableAdapter.Adapter.Update(this.kursachDataSet.Заказы);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат данных", " Внимание!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                заказыBindingSource.Filter = null;
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Упс!");
                заказыBindingSource.Filter = null;
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                заказыBindingSource.Filter = "[ФИО] LIKE'" + textBox5.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Упс!");
                заказыBindingSource.Filter = null;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                заказыBindingSource.Filter = "[Улица_дом_откуда] LIKE'" + textBox7.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Упс!");
                заказыBindingSource.Filter = null;
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                заказыBindingSource.Filter = "[Улица_дом_куда] LIKE'" + textBox6.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Упс!");
                заказыBindingSource.Filter = null;
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                заказыBindingSource.Filter = "[Цена_поездки] =" + "'" + Convert.ToDouble(textBox4.Text) + "'";
            }
            catch
            {
                заказыBindingSource.Filter = null;
            }
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                заказыBindingSource.Filter = "[Марка] LIKE'" + textBox9.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Упс!");
                заказыBindingSource.Filter = null;
            }
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                заказыBindingSource.Filter = "[Модель] LIKE'" + textBox10.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Упс!");
                заказыBindingSource.Filter = null;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                заказыBindingSource.Filter = "[Дата_и_время] =\'" + dateTimePicker2.Text + "\'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Упс!");
                заказыBindingSource.Filter = null;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                заказыBindingSource.Filter = "[Выполнен]=\'" + Convert.ToBoolean(checkBox2.Checked) + "\'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Упс!");
                заказыBindingSource.Filter = null;
            }
        }

        private void заказыDataGridView_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((Convert.ToBoolean(заказыDataGridView.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn1"].Value) == true))
                    e.CellStyle.BackColor = Color.LightGreen;
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Упс!");
            }
        }

        private void очиститьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите очистить таблицу?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.заказыTableAdapter.DeleteQuery1();
                    this.заказыTableAdapter.Fill(this.kursachDataSet.Заказы);
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Упс!");
            }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form6 form6 = new Form6();
                form6.Show();
                form6.reportViewer2.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Упс!");
                заказыBindingSource.Filter = null;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if((e.KeyChar<=47 || e.KeyChar >=56)&& number !=8 && number !=44)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 56) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void цена_поездкиTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 56) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void цена_поездкиTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 56) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process SysInfo = new Process();
                SysInfo.StartInfo.ErrorDialog = true;
                SysInfo.StartInfo.FileName = "NewProject.chm";
                SysInfo.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
