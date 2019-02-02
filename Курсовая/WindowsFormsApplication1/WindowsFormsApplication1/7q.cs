using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            //увеличиваем индекс переключения форм на 1 
            Form1.i++;
            //добавляем menuStrip
            Staff.Mainmenu(menuStrip1);
            //добавления текста на кнопку переключения формы и номера вопроса
            Staff.other(button1, groupBox1, Form1.i);
            //заполенение формы вопросами и вариантами ответов
            Question.listboxq(label1, label2, label3, listBox1, Form1.i);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //доавление в массив ответов пользователя
            Question.polzAns[Form1.i - 2] = listBox2.Items[0] + "," + listBox3.Items[0] + "," + listBox4.Items[0];
            //перключение формы
            Staff.Accept(Form1.i, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //добавление выбранного ответа в листбокс
            listBox2.Items.Clear();
            listBox2.Items.Insert(0, Convert.ToString(listBox1.SelectedItem));
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            button2.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //добавление выбранного ответа в листбокс
            listBox3.Items.Clear();
            listBox3.Items.Insert(0, Convert.ToString(listBox1.SelectedItem));
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //добавление выбранного ответа в листбокс
            listBox4.Items.Clear();
            listBox4.Items.Insert(0, Convert.ToString(listBox1.SelectedItem));
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            button4.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //перезаполнение формы
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            Question.listboxq(label1, label2, label3, listBox1, Form1.i);

        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {

            //закрытие программы
            DialogResult result = MessageBox.Show("Вы уверены?", "Потдверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }    
        }
    }
}
