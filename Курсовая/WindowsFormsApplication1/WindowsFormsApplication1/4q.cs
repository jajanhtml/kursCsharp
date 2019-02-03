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
    public partial class Form5 : Form
    {
        //переменная содержащие количестов выбранных ответов
        int chek;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //увеличиваем индекс переключения форм на 1 
            Form1.i++;
            //добавляем menuStrip
            Staff.Mainmenu(menuStrip1);
            //добавления текста на кнопку переключения формы и номера вопроса
            Staff.other(button1, groupBox1, Form1.i);
            //заполенение формы вопросами и вариантами ответов
            Question.checkboxq(label2, checkBox1, checkBox2, checkBox3, checkBox4, Form1.i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //обработка ошибки при которой пользователь не выбрал ответ
            if ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == false) && (checkBox4.Checked == false))
            {
                MessageBox.Show("Ответ не выбран");
            }
            else if (chek == 1)
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
                //перключение формы
                Staff.Accept(Form1.i,this);
            }
            else
                MessageBox.Show("Можно только 1");

        }
        //проверка количества выбранных ответов
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                chek++;
            else
                chek--;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                chek++;
            else
                chek--;

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                chek++;
            else
                chek--;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                chek++;
            else
                chek--;
        }

    }
}
