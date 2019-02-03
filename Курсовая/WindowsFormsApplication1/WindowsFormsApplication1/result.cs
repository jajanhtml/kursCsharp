using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class result : Form
    {
        public result()
        {
            InitializeComponent();
        }

        private void result_Load(object sender, EventArgs e)
        {
            //добавляем menuStrip
            Staff.Mainmenu(menuStrip1);
            for (int i = 0; i <= 15; i++)
            {
                //доавление строк в таблицу
                dataGridView1.Rows.Add(); 
            }
            //переменная хранящия переменную порядковый номер вопроса
            int count = 1;
            for (int j = 0; j <= 15; j++)
            {
                //заполение таблицы результатов теста
               dataGridView1.Rows[j].Cells[0].Value = "№" + count ;
               dataGridView1.Rows[j].Cells[2].Value = Question.trueAns[j];
               dataGridView1.Rows[j].Cells[1].Value = Question.polzAns[j];
                //закраска верных и не верных ответов на тест
               if (Convert.ToString(dataGridView1.Rows[j].Cells[2].Value) == Convert.ToString(dataGridView1.Rows[j].Cells[1].Value))
               {
                   dataGridView1.Rows[j].Cells[0].Style.BackColor = Color.Green;
                   dataGridView1.Rows[j].Cells[1].Style.BackColor = Color.Green;
                   dataGridView1.Rows[j].Cells[2].Style.BackColor = Color.Green;
               }
               else
               {
                   dataGridView1.Rows[j].Cells[0].Style.BackColor = Color.Red;
                   dataGridView1.Rows[j].Cells[1].Style.BackColor = Color.Red;
                   dataGridView1.Rows[j].Cells[2].Style.BackColor = Color.Red;
               }
               count++;


            }
            string path = @"D:\test.txt";
            using (StreamWriter sw = new StreamWriter(path, true, Encoding.Default))
            {
                for (int j = 0; j <= 15; j++)
                {      
                    string value = "Номер вопроса " + (j + 1) + " правельный ответ: " + Question.trueAns[j] + " ответ пользователя: " + Question.polzAns[j];
                    sw.WriteLine(value);
                }
                sw.Close();

            }

           /* using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Document (*.pdf)|*.pdf";
                sfd.FileName = "exportDOCX.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Export(dataGridView1, sfd.FileName);
                }
            }*/
        }

    }
}
