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
    public partial class Form3 : Form
    {   
        public Form3()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //демонстрация выбранного значения
            label3.Text = Convert.ToString("Выбранное значение :" + trackBar1.Value);
        }

        private void Form3_Load(object sender, EventArgs e)
        { 
            //увеличиваем индекс переключения форм на 1 
            Form1.i++;
            //добавляем menuStrip
            Staff.Mainmenu(menuStrip1);
            //добавления текста на кнопку переключения формы и номера вопроса
            Staff.other(button1, groupBox1, Form1.i);
            //заполенение формы вопросами и вариантами ответов
            Question.trackq(label1,Form1.i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //добавления в массив ответа пользователя
            Question.polzAns[Form1.i-2] = Convert.ToString(trackBar1.Value);
            //переключения формы
            Staff.Accept(Form1.i, this);
        }

      
    }
        
}

