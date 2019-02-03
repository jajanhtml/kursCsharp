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
    public partial class Form6 : Form
    {
        int chek;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //увеличиваем индекс переключения форм на 1 
            Form1.i++;
            //добавляем menuStrip
            Staff.Mainmenu(menuStrip1);
            //добавления текста на кнопку переключения формы и номера вопроса
            Staff.other(button1, groupBox1, Form1.i);
            //заполенение формы вопросами и вариантами ответов
            Question.checklistboxq(label1, checkBox1, checkBox2, checkBox3, checkBox4, Form1.i);
        }
        //добавление выбранного ответа в ListBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add(checkBox1.Text);
                chek++;
            }
            else
            {
                listBox1.Items.Clear();
                chek--;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add(checkBox2.Text);
                chek++;
            }
            else
            {
                chek--;
                listBox1.Items.Clear();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                chek++;
                listBox1.Items.Add(checkBox3.Text);
            }
            else
            {
                chek--;
                listBox1.Items.Clear();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                chek++;
                listBox1.Items.Add(checkBox4.Text);
            }
            else
            {
                chek--;
                listBox1.Items.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //обработка ошибки пользователя при которой он не ответил на все вопросы
            if ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == false) && (checkBox4.Checked == false))
            {
                MessageBox.Show("Выберете ответ!");
            }
            else if (chek>1)
            {
                MessageBox.Show("Можно только 1");
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                listBox1.Items.Clear();
            }
            else
            {
                //добавление в массив ответов пользователя
                if (checkBox1.Checked == true)
                    Question.polzAns[Form1.i-2] = checkBox1.Text;

                if (checkBox2.Checked == true)
                    Question.polzAns[Form1.i-2] = checkBox2.Text;

                if (checkBox3.Checked == true)
                    Question.polzAns[Form1.i-2] = checkBox3.Text;

                if (checkBox4.Checked == true)
                    Question.polzAns[Form1.i-2] = checkBox4.Text;
                //переключение формы
                Staff.Accept(Form1.i, this);
            }
        }

      
    }
}
