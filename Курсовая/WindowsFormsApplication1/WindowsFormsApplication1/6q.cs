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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
            if (checkedListBox1.CheckedItems.Count == 1)
            {
                //доавление в массив ответов пользователя
                if (checkedListBox1.GetSelected(0) == true)
                    Question.polzAns[Form1.i-2] = Convert.ToString(checkedListBox1.Items[0]);

                else if (checkedListBox1.GetSelected(1) == true)
                    Question.polzAns[Form1.i-2] = Convert.ToString(checkedListBox1.Items[1]);

                else if (checkedListBox1.GetSelected(2) == true)
                    Question.polzAns[Form1.i-2] =  Convert.ToString(checkedListBox1.Items[2]);

                else  Question.polzAns[Form1.i-2] =  Convert.ToString(checkedListBox1.Items[3]);
                Staff.Accept(Form1.i, this);
                
            }
            else
                //проверка количства ответов 
                if (checkedListBox1.CheckedItems.Count > 1)
                   
                MessageBox.Show("Можно только 1");
            else
                MessageBox.Show("Ответ не сделан");
                    
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //увеличиваем индекс переключения форм на 1 
            Form1.i++;
            //добавляем menuStrip
            Staff.Mainmenu(menuStrip1);
            //добавления текста на кнопку переключения формы и номера вопроса
            Staff.other(button1, groupBox1, Form1.i);
            //заполенение формы вопросами и вариантами ответов
            Question.checkedlistboxq(label1, checkedListBox1, Form1.i);
        }

      

      
    }
}
