using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class pass : Form
    {
        //переменая содержащая количство попыток ввода пароля
        int pastry;
        public pass()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            //увелечние количтва ввода пароля
            pastry++;
            //проврека количтсва ввода пароля
            if (pastry <= 2)
            {
                if (textBox1.Text == "пас")
                {
                    //открытие основной формы
                    Form l = new Form1();
                    l.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный пароль, осталось попыток : " + Convert.ToString(3 - pastry));
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Превышено маскимальное количество попыток ввода пароля","Выход из программы", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                    Application.Exit();
            }
        }

        private void pass_Load(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
