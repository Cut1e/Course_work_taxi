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
    public partial class Form5 : Form
    {
        public Form5()
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

        private void маркаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.маркаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursachDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.модельTableAdapter.Fill(this.kursachDataSet.Модель);
            this.маркаTableAdapter.Fill(this.kursachDataSet.Марка);

        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "") MessageBox.Show("Введите пожалуйста марку автомобиля", " Внимание!");
                else
             if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.маркаTableAdapter.InsertQuery(textBox1.Text);
                    this.маркаTableAdapter.Fill(this.kursachDataSet.Марка);
                    this.маркаTableAdapter.Adapter.Update(this.kursachDataSet.Марка);
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
                    this.маркаTableAdapter.DeleteQuery(System.Convert.ToInt32(маркаDataGridView.SelectedCells[0].Value));
                    this.маркаTableAdapter.Fill(this.kursachDataSet.Марка);
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
                    this.маркаTableAdapter.DeleteQuery1();
                    this.маркаTableAdapter.Fill(this.kursachDataSet.Марка);
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "") MessageBox.Show("Введите пожалуйста марку автомобиля", " Внимание!");
                else
             if (MessageBox.Show("Вы уверены что хотите добавить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = (int)comboBox1.SelectedValue;
                    this.модельTableAdapter.InsertQuery(textBox2.Text, id);
                    this.модельTableAdapter.Fill(this.kursachDataSet.Модель);
                    this.модельTableAdapter.Adapter.Update(this.kursachDataSet.Модель);
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
                    this.модельTableAdapter.DeleteQuery(System.Convert.ToInt32(модельDataGridView.SelectedCells[0].Value));
                    this.модельTableAdapter.Fill(this.kursachDataSet.Модель);
                }
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
                    this.модельTableAdapter.DeleteQuery1();
                    this.модельTableAdapter.Fill(this.kursachDataSet.Модель);
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "") MessageBox.Show("Введите пожалуйста марку автомобиля", " Внимание!");
                else
                {
                    if (MessageBox.Show("Вы уверены что хотите обновить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.маркаTableAdapter.UpdateQuery(textBox3.Text, Convert.ToInt32(маркаDataGridView.Rows[маркаDataGridView.CurrentCell.RowIndex].Cells[0].Value));
                        this.маркаTableAdapter.Fill(this.kursachDataSet.Марка);
                        this.маркаTableAdapter.Adapter.Update(this.kursachDataSet.Марка);
                    }
                }
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
                if (textBox4.Text == "") MessageBox.Show("Введите пожалуйста модель автомобиля", " Внимание!");
                else
                {
                    if (MessageBox.Show("Вы уверены что хотите обновить?", "Уверены?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = (int)comboBox2.SelectedValue;
                        this.модельTableAdapter.UpdateQuery(textBox4.Text, id, Convert.ToInt32(модельDataGridView.Rows[модельDataGridView.CurrentCell.RowIndex].Cells[0].Value));
                        this.модельTableAdapter.Fill(this.kursachDataSet.Модель);
                        this.модельTableAdapter.Adapter.Update(this.kursachDataSet.Модель);
                    }
                }
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
                маркаBindingSource.Filter = "[Марка] LIKE'" + textBox5.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            маркаBindingSource.Filter = null;
            textBox5.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            модельМаркаBindingSource.Filter = null;
            textBox6.Text = "";
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                модельМаркаBindingSource.Filter = "[Модель] LIKE'" + textBox6.Text + "%'";
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", " Внимание!");
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                модельDataGridView.ClearSelection();
                for (int _i = 0; _i < модельDataGridView.Rows.Count; _i++)
                {
                    bool _n = false;

                    if (модельDataGridView.Rows[_i].Cells[1].Value.ToString().Contains(textBox7.Text)) _n = true;
                    else if (textBox7.Text == "") _n = true;
                    if (textBox7.Text != "")
                    {
                        if (_n) модельDataGridView.Rows[_i].Selected = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                маркаDataGridView.ClearSelection();
                for (int _i = 0; _i < маркаDataGridView.Rows.Count; _i++)
                {
                    bool _n = false;

                    if (маркаDataGridView.Rows[_i].Cells[1].Value.ToString().Contains(textBox8.Text)) _n = true;
                    else if (textBox8.Text == "") _n = true;
                    if (textBox8.Text != "")
                    {
                        if (_n) маркаDataGridView.Rows[_i].Selected = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Упс!");
            }
        }

    }
    }
