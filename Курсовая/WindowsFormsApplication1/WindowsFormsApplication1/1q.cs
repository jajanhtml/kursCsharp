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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {   
            //увеличиваем индекс переключения форм на 1 
            Form1.i++;
            //добавляем menuStrip
            Staff.Mainmenu(menuStrip1);
            //добавления текста на кнопку переключения формы и номера вопроса
            Staff.other(button1, groupBox1, Form1.i);
            //заполенение формы вопросами и вариантами ответов
            Question.comboboxq(label2,label3,label4,comboBox1,comboBox2,comboBox3,Form1.i);
            
        }

       private void button1_Click(object sender, EventArgs e)
        {
           //обработка ошибки при которой пользователь не отвечает на все вопросы
            if ((comboBox1.SelectedIndex < 0) || (comboBox2.SelectedIndex < 0) || (comboBox3.SelectedIndex < 0))
            {
                MessageBox.Show("Не все ответы выбраны");
            }
            else
            {
                //добавление ответа в массив ответов пользователя
                Question.polzAns[Form1.i - 2] = comboBox1.Text + "," + comboBox2.Text + "," + comboBox3.Text;
                //переключенение формы
                Staff.Accept(Form1.i,this);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
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
