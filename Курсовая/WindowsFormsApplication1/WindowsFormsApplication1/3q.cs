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
    public partial class Form4 : Form
    {
       
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //обработка введения цифр
            char ch = e.KeyChar;
            if (Char.IsDigit(ch))
            {
                e.Handled = true;
                MessageBox.Show("Цифры к вводу не допустимы", "Ошибка");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //увеличиваем индекс переключения форм на 1 
            Form1.i++;
            //добавляем menuStrip
            Staff.Mainmenu(menuStrip1);
            //добавления текста на кнопку переключения формы и номера вопроса
            Staff.other(button1, groupBox1, Form1.i);
            //заполенение формы вопросами и вариантами ответов
            Question.textboxq(label1, Form1.i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //обработка ошибки при которой пользователь не отвечает
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите ответ!");
            }
            else
            {
                //добавление в массив ответа пользователя
                Question.polzAns[Form1.i-2] = textBox1.Text.ToLower();
                //переключение формы
                Staff.Accept(Form1.i, this);
            }
                   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
