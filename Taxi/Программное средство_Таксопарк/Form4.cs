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
    public partial class Form4 : Form
    {
        public Form4()
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
        private void водительBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.водительBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            this.отчёт_водительTableAdapter.Fill(this.kursachDataSet.Отчёт_водитель);
            this.отпускTableAdapter.Fill(this.kursachDataSet.Отпуск);
            this.отпускTableAdapter.Fill(this.kursachDataSet.Отпуск);
            this.водительTableAdapter.Fill(this.kursachDataSet.Водитель);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker5.Format = DateTimePickerFormat.Short;
            dateTimePicker6.Format = DateTimePickerFormat.Short;
            dateTimePicker7.Format = DateTimePickerFormat.Short;
            dateTimePicker8.Format = DateTimePickerFormat.Short;
            dateTimePicker9.Format = DateTimePickerFormat.Short;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.Enabled)
            {
                this.Hide();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = (int)comboBox4.SelectedValue;
                    DateTime data = Convert.ToDateTime(String.Format(dateTimePicker1.Value.ToShortDateString()));
                    DateTime data1 = Convert.ToDateTime(String.Format(dateTimePicker2.Value.ToShortDateString()));
                    this.отпускTableAdapter.InsertQuery(data, data1, textBox4.Text, id);
                    this.отпускTableAdapter.Fill(this.kursachDataSet.Отпуск);
                    this.отпускTableAdapter.Adapter.Update(this.kursachDataSet.Отпуск);
                    textBox4.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }
        private void удалитьВыбраннуюЗаписьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.отпускTableAdapter.DeleteQuery(System.Convert.ToInt32(отпускDataGridView.SelectedCells[0].Value));
                    this.отпускTableAdapter.Fill(this.kursachDataSet.Отпуск);
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime data = Convert.ToDateTime(String.Format(dateTimePicker3.Value.ToShortDateString()));
                if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.водительTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, data);
                    this.водительTableAdapter.Fill(this.kursachDataSet.Водитель);
                    this.водительTableAdapter.Adapter.Update(this.kursachDataSet.Водитель);
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }

        private void удалитьВыбраннуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.водительTableAdapter.DeleteQuery(System.Convert.ToInt32(водительDataGridView.SelectedCells[0].Value));
                    this.водительTableAdapter.Fill(this.kursachDataSet.Водитель);
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }
        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.Enabled)
            {
                this.Hide();
            }
        }
        private void водителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            if (form3.Enabled)
            {
                this.Hide();
            }
        }
        private void очиститьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите очистить таблицу?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.водительTableAdapter.DeleteQuery1();
                    this.водительTableAdapter.Fill(this.kursachDataSet.Водитель);
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Упс!");
            }
        }
        private void очиститьТаблицуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите очистить таблицу?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.отпускTableAdapter.DeleteQuery1();
                    this.отпускTableAdapter.Fill(this.kursachDataSet.Отпуск);
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Упс!");
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text == "") MessageBox.Show("Введите пожалуйста ФИО водителя", " Внимание!");
                else
                 if (textBox3.Text == "") MessageBox.Show("Введите пожалуйста номер паспорта", " Внимание!");
                else
                {
                    if (MessageBox.Show("Вы уверены что хотите обновить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DateTime data = Convert.ToDateTime(String.Format(dateTimePicker4.Value.ToShortDateString()));
                        this.водительTableAdapter.UpdateQuery(textBox5.Text, textBox3.Text, data, Convert.ToInt32(водительDataGridView.Rows[водительDataGridView.CurrentCell.RowIndex].Cells[0].Value));
                        this.водительTableAdapter.Fill(this.kursachDataSet.Водитель);
                        this.водительTableAdapter.Adapter.Update(this.kursachDataSet.Водитель);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                водительBindingSource.Filter = "[ФИО] LIKE'" + textBox7.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                водительBindingSource.Filter = "[НомерПаспор] LIKE'" + textBox6.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                водительBindingSource.Filter = "[Дата_приема] =\'" + dateTimePicker5.Text + "\'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox7.Text = "";
            водительBindingSource.Filter = null;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.водительОтпускBindingSource.Filter = null;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox9.Text == "") MessageBox.Show("Введите пожалуйста описание ремонта", " Внимание!");
                else
                {
                    if (MessageBox.Show("Вы уверены что хотите обновить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = (int)comboBox1.SelectedValue;
                        DateTime data = Convert.ToDateTime(String.Format(dateTimePicker8.Value.ToShortDateString()));
                        DateTime data1 = Convert.ToDateTime(String.Format(dateTimePicker9.Value.ToShortDateString()));
                        this.отпускTableAdapter.UpdateQuery(data1, data, textBox9.Text, id, Convert.ToInt32(отпускDataGridView.Rows[отпускDataGridView.CurrentCell.RowIndex].Cells[0].Value));
                        this.отпускTableAdapter.Fill(this.kursachDataSet.Отпуск);
                        this.отпускTableAdapter.Adapter.Update(this.kursachDataSet.Отпуск);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                водительОтпускBindingSource.Filter = "[Описание] LIKE'" + textBox8.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                водительОтпускBindingSource.Filter = "[Дата_нач] =\'" + dateTimePicker7.Text + "\'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");

            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                водительОтпускBindingSource.Filter = "[Дата_кон] =\'" + dateTimePicker6.Text + "\'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form9 form9 = new Form9();
                form9.Show();
                this.водительTableAdapter.Fill(this.kursachDataSet.Водитель);
                form9.reportViewer1.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Упс!");
            }
        }

        private void печатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Form10 form10 = new Form10();
                form10.Show();
                this.отчёт_водительTableAdapter.Fill(this.kursachDataSet.Отчёт_водитель);
                form10.reportViewer1.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Упс!");
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
