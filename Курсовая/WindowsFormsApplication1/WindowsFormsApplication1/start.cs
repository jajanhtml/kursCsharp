using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace WindowsFormsApplication1
{   
    public partial class Form1 : Form
    {
        //создание глобальной переменной индекса форомы
        public static int i = 1;
        public Form1()
        {
          

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //переход на первый вопрос теста
            Form l = new Form2();
            l.Show();
            button1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //добавление menuStrip 
            Staff.Mainmenu(menuStrip1);
            //откртыие формы с титульным листом
            Form tit = new titul();
            tit.Show();       
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //открытие документа с теорией
           /* var application = new Microsoft.Office.Interop.Word.Application();
            var document = new Microsoft.Office.Interop.Word.Document();
            var docPath = Directory.GetCurrentDirectory() + @"\..\..\..\..\";
            application.Visible = true;*/
            System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\..\..\..\..\text1.pdf");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
