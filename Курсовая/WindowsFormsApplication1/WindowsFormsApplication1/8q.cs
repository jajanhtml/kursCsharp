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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //обработка ошибки пользователя при которой он не ответил на все вопросы
            if ((radioButton1.Checked == false) && (radioButton2.Checked == false) && (radioButton3.Checked == false) && (radioButton4.Checked == false))
                MessageBox.Show("Выбирите ответ!");
            else
            {
                //добавление в массив ответов пользователя
                if (radioButton1.Checked == true)
                    Question.polzAns[Form1.i - 2] = radioButton1.Text;
                if (radioButton2.Checked == true)
                    Question.polzAns[Form1.i - 2] = radioButton2.Text;
                if (radioButton3.Checked == true)
                    Question.polzAns[Form1.i - 2] = radioButton3.Text;
                if (radioButton4.Checked == true)
                    Question.polzAns[Form1.i - 2] = radioButton4.Text;
                Staff.Accept(Form1.i, this);

            }
            
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //увеличиваем индекс переключения форм на 1 
            Form1.i++;
            //добавляем menuStrip
            Staff.Mainmenu(menuStrip1);
            //добавления текста на кнопку переключения формы и номера вопроса
            Staff.other(button1, groupBox1, Form1.i);
            //заполенение формы вопросами и вариантами ответов
            Question.radiobuttonq(label1, radioButton1, radioButton2, radioButton3, radioButton4, Form1.i);
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {

            //закрытие программы
            DialogResult result = MessageBox.Show("Вы уверены?", "Потдверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }    
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
