using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static public class Staff
    {
        public static void Mainmenu(MenuStrip l)
        {
            
            ToolStripMenuItem menu = new ToolStripMenuItem("Файл");

            ToolStripMenuItem exit = new ToolStripMenuItem("Выход");
            //доваления вкладки файл в меню
            exit.Click += Exit_Click;

            menu.DropDownItems.Add(exit);

            l.Items.Add(menu);
        }

        private static void Exit_Click(object sender, EventArgs e)
        {
            //выключение программы
            Application.ExitThread();
        }
        //метод демонстрации диалогового окна и перехода на другоую форму
        public static void Accept(int i, Form l)
        {   
            //демонстрация диалогового окна
          //  DialogResult result = MessageBox.Show("Продолжить?","Потдверждение",MessageBoxButtons.YesNo);
          //  if (result == DialogResult.Yes)
              //  {
                    Staff.nextform(i,l);
                   
              //  }    
        }
        //метод закртия текущей и переход к необходимой форме
        public static void vibor(Form p,Form l)
        {
                    p.Show();
                    l.Hide();
        }
        //метод переключения форм в зависимости от индекса 
        public static int nextform (int i,Form l)
        {
            switch (i)
            {
                case 1:
                    Staff.vibor(new Form2(), l);
                    break;
                case 2:
                    Staff.vibor(new Form3(), l);
                    break;
                case 3:
                    Staff.vibor(new Form4(), l);
                    break;
                case 4:
                    Staff.vibor(new Form5(), l);
                    break;
                case 5:
                    Staff.vibor(new Form6(), l);
                    break;
                case 6:
                    Staff.vibor(new Form7(), l);
                    break;
                case 7:
                    Staff.vibor(new Form8(), l);
                    break;
                case 8:
                    Staff.vibor(new Form9(), l);
                    break;
                case 9:
                    Staff.vibor(new Form2(), l);
                    break;
                case 10:
                    Staff.vibor(new Form3(), l);
                    break;
                case 11:
                    Staff.vibor(new Form4(), l);
                    break;
                case 12:
                    Staff.vibor(new Form5(), l);
                    break;
                case 13:
                    Staff.vibor(new Form6(), l);
                    break;
                case 14:
                    Staff.vibor(new Form7(), l);
                    break;
                case 15:
                    Staff.vibor(new Form8(), l);
                    break;
                case 16:
                    Staff.vibor(new Form9(), l);
                    break;
                default:
                    Staff.vibor(new result(), l);
                    break;
            }
            return i;

               
        }
        
       
        //метод заполенения окна с вопросом необходимым текстом
        public static void other(Button a, GroupBox b,int index)
        {
            a.Text = "Далее";
            b.Text = "Вопрос № " + Convert.ToString(index-1);
  
            
        }


    }
}
