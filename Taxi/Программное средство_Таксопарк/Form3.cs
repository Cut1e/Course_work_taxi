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
    public partial class Form3 : Form
    {
        public Form3()
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
        private void Form3_Load(object sender, EventArgs e)
        {
            this.отчёт_ремонтTableAdapter.Fill(this.kursachDataSet.Отчёт_ремонт);
            this.автомобилиTableAdapter.Fill(this.kursachDataSet.Автомобили);
            this.модельTableAdapter.Fill(this.kursachDataSet1.Модель);
            this.автомобилиTableAdapter.Fill(this.kursachDataSet1.Автомобили);
            this.модельTableAdapter.Fill(this.kursachDataSet1.Модель);
            this.модельTableAdapter.Fill(this.kursachDataSet1.Модель);
            this.автомобилиTableAdapter.Fill(this.kursachDataSet1.Автомобили);
            this.автомобилиTableAdapter.Fill(this.kursachDataSet1.Автомобили);
            this.автомобилиTableAdapter.Fill(this.kursachDataSet1.Автомобили);
            this.ремонтTableAdapter.Fill(this.kursachDataSet.Ремонт);
            this.ремонтTableAdapter.Fill(this.kursachDataSet1.Ремонт);
            this.модельTableAdapter.Fill(this.kursachDataSet1.Модель);
            this.маркаTableAdapter.Fill(this.kursachDataSet1.Марка);
            this.водительTableAdapter.Fill(this.kursachDataSet1.Водитель);
            this.автомобилиTableAdapter.Fill(this.kursachDataSet.Автомобили);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            дата_начDateTimePicker.Format = DateTimePickerFormat.Short;
           дат_конDateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Format = DateTimePickerFormat.Short;
        }

        private void удалитьВыбраннуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.автомобилиTableAdapter.DeleteQuery(System.Convert.ToInt32(автомобилиDataGridView.SelectedCells[6].Value));
                    this.автомобилиTableAdapter.Fill(this.kursachDataSet.Автомобили);
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
                if (textBox1.Text == "") MessageBox.Show("Введите пожалуйста цвет автомобиля", " Внимание!");
                else
                   if (textBox2.Text == "") MessageBox.Show("Введите пожалуйста год выпуска автомобиля", " Внимание!");
                else
                   if (textBox3.Text == "") MessageBox.Show("Введите пожалуйста год номер автомобиля", " Внимание!");
                else
                {
                    if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = (int)comboBox1.SelectedValue;
                        int id3 = (int)comboBox3.SelectedValue;
                        this.автомобилиTableAdapter.InsertQuery(id, id3, textBox1.Text, textBox2.Text, textBox3.Text);
                        this.автомобилиTableAdapter.Fill(this.kursachDataSet.Автомобили);
                        this.автомобилиTableAdapter.Adapter.Update(this.kursachDataSet.Автомобили);
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

        private void удалитьВыбраннуюЗаписьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.ремонтTableAdapter.DeleteQuery(System.Convert.ToInt32(ремонтDataGridView.SelectedCells[0].Value));
                    this.ремонтTableAdapter.Fill(this.kursachDataSet.Ремонт);
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text == "") MessageBox.Show("Введите пожалуйста описание ремонта", " Внимание!");
                else
                {
                    if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = (int)comboBox4.SelectedValue;
                        DateTime data = Convert.ToDateTime(String.Format(dateTimePicker1.Value.ToShortDateString()));
                        DateTime data1 = Convert.ToDateTime(String.Format(dateTimePicker2.Value.ToShortDateString()));
                        this.ремонтTableAdapter.InsertQuery(data, data1, textBox4.Text, id);
                        this.ремонтTableAdapter.Fill(this.kursachDataSet.Ремонт);
                        this.ремонтTableAdapter.Adapter.Update(this.kursachDataSet.Ремонт);
                        textBox4.Text = "";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат данных", " Внимание!");
            }
        }
        private void удалитьВыбраннуюЗаписьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите удалить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.ремонтTableAdapter.DeleteQuery(System.Convert.ToInt32(ремонтDataGridView.SelectedCells[6].Value));
                    this.ремонтTableAdapter.Fill(this.kursachDataSet.Ремонт);
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (цветTextBox.Text == "") MessageBox.Show("Введите пожалуйста цвет автомобиля", " Внимание!");
                else
                   if (год_выпускаTextBox.Text == "") MessageBox.Show("Введите пожалуйста год выпуска автомобиля", " Внимание!");
                else
                   if (госНомерTextBox.Text == "") MessageBox.Show("Введите пожалуйста год номер автомобиля", " Внимание!");
                else
                if (MessageBox.Show("Вы уверены что хотите обновить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = (int)фИОComboBox.SelectedValue;
                    int id2 = (int)comboBox5.SelectedValue;
                    this.автомобилиTableAdapter.UpdateQuery(госНомерTextBox.Text, id2, id, цветTextBox.Text, год_выпускаTextBox.Text, Convert.ToInt32(автомобилиDataGridView.Rows[автомобилиDataGridView.CurrentCell.RowIndex].Cells[6].Value));
                    this.автомобилиTableAdapter.Fill(this.kursachDataSet.Автомобили);
                    this.автомобилиTableAdapter.Adapter.Update(this.kursachDataSet.Автомобили);
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат данных", " Внимание!");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                автомобилиBindingSource.Filter = "[ФИО] LIKE'" + textBox8.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            автомобилиBindingSource.Filter = null;
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                автомобилиBindingSource.Filter = "[Цвет] LIKE'" + textBox7.Text + "%'";
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
                автомобилиBindingSource.Filter = "[Год_выпуска] LIKE'" + textBox6.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                автомобилиBindingSource.Filter = "[ГосНомер] LIKE'" + textBox5.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (вид_поломкиTextBox.Text == "") MessageBox.Show("Введите пожалуйста описание ремонта", " Внимание!");
                else
                {
                    if (MessageBox.Show("Вы уверены что хотите обновить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = (int)comboBox9.SelectedValue;
                        DateTime data = Convert.ToDateTime(String.Format(дата_начDateTimePicker.Value.ToShortDateString()));
                        DateTime data1 = Convert.ToDateTime(String.Format(дат_конDateTimePicker.Value.ToShortDateString()));
                        this.ремонтTableAdapter.UpdateQuery(data, data1, вид_поломкиTextBox.Text, id, Convert.ToInt32(ремонтDataGridView.Rows[ремонтDataGridView.CurrentCell.RowIndex].Cells[0].Value));
                        this.ремонтTableAdapter.Fill(this.kursachDataSet.Ремонт);
                        this.ремонтTableAdapter.Adapter.Update(this.kursachDataSet.Ремонт);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                автомобилиBindingSource.Filter = "[Марка] LIKE'" + textBox9.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                автомобилиBindingSource.Filter = "[Expr1] LIKE'" + textBox10.Text + "%'";
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
            Form4 form4 = new Form4();
            form4.Show();
            if (form4.Enabled)
            {
                this.Hide();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            автомобилиРемонтBindingSource.Filter = null;
            textBox11.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                автомобилиРемонтBindingSource.Filter = "[Дата_нач] =\'" + dateTimePicker4.Text + "\'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                автомобилиРемонтBindingSource.Filter = "[Дат_кон] =\'" + dateTimePicker3.Text + "\'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }

        private void textBox11_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                автомобилиРемонтBindingSource.Filter = "[Вид_поломки] LIKE'" + textBox11.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }

        private void очиститьТаблицуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите очистить таблицу?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.автомобилиTableAdapter.DeleteQuery1();
                    this.автомобилиTableAdapter.Fill(this.kursachDataSet.Автомобили);
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }

        private void очиститьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы уверены что хотите очистить таблицу?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.ремонтTableAdapter.DeleteQuery1();
                    this.ремонтTableAdapter.Fill(this.kursachDataSet.Ремонт);
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }

        private void печатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Form7 form7 = new Form7();
                form7.Show();
                this.автомобилиTableAdapter.Fill(this.kursachDataSet.Автомобили);
                form7.reportViewer1.RefreshReport();
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
                Form8 form8 = new Form8();
                form8.Show();
                this.отчёт_ремонтTableAdapter.Fill(this.kursachDataSet.Отчёт_ремонт);
                form8.reportViewer1.RefreshReport();
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
