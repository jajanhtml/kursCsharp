using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Question
    {
        //массив правельных ответов
        public static string[] trueAns = new string[16] 
        { "трансивер,фотодиоды,электроабсорбации", "40", "нелинейного", "гомодийный", 
           "Оптический усилитель", "ITU-T", "Брегга-Вульфа,MZM,электроскопическйи кристалл", "узкого", 
           "Блок в поддон,Отдельный модуль,Компактно размещён на плате", "50", "транспондер", "элект.управления током", 
           "Пельте", "велечина элект.поля", "Управление разностью фаз,Совпадают,каскадная цифровая обработка", "Высокий" };
        //массив ответов пользователя
        public static string[] polzAns = new string[17];
        //заполение вопроса с ComboBox
       public static void comboboxq(Label a1, Label a2, Label a3, ComboBox c1, ComboBox c2, ComboBox c3, int index)
        {
            if (index <= 8)
            {
                a1.Text = "Современный оптические приёмники выполненные в виде модуля это";
                a2.Text = "Что относится к приёмника трансивера?";
                a3.Text = "На основе какого эффекта строятся решения для большинства оптических трансиверов?";

                c1.Items.Add("трансивер");
                c1.Items.Add("фотодиоды");
                c1.Items.Add("электроабсорбации");

                c2.Items.Add("трансивер");
                c2.Items.Add("фотодиоды");
                c2.Items.Add("электроабсорбации");

                c3.Items.Add("трансивер");
                c3.Items.Add("фотодиоды");
                c3.Items.Add("электроабсорбации");
            }
            else
            {
                a1.Text = "В виде чего выполнен усилитель EDFA";
                a2.Text = "В виде чего выполнен усилитель Raman";
                a3.Text = "В виде чего выполнен усилитель SOA";

                c1.Items.Add("Компактно размещён на плате");
                c1.Items.Add("Отдельный модуль");
                c1.Items.Add("Блок в поддон");

                c2.Items.Add("Компактно размещён на плате");
                c2.Items.Add("Отдельный модуль");
                c2.Items.Add("Блок в поддон");

                c3.Items.Add("Компактно размещён на плате");
                c3.Items.Add("Отдельный модуль");
                c3.Items.Add("Блок в поддон");
            }
        }
       //заполение вопроса с TrackBar
        public static void trackq(Label a1, int index)
        {
            if (index <= 8)
            {
                a1.Text = "Приборы с чувствительностью выше 0,5 А/Вт обеспечивают полосу частот от 30 до ... ГГц";
            }
            else
            {
                a1.Text = "Коэфициент усиления усилителя EDFA от 30 до ...ДБ ";
            }
        }
        public static void textboxq(Label a1, int index)
        {
            if (index >= 8)
            {
                a1.Text = "Оптические системы на основе какого эффекта пригодны для увелечения мощности оптического сигнала";
            }
            else
            {
                a1.Text = "Что такое TPD?";
            }
        }
        //заполение вопроса с CheckBox
        public static void checkboxq(Label a1, CheckBox q1, CheckBox q2, CheckBox q3, CheckBox q4, int index)
        {
            if (index <= 8)
            {
                a1.Text = "Для повышения чувствительности фотоприёмников используется когорентный ... приём";
                q1.Text = "лунический";
                q2.Text = "гомодийный";
                q3.Text = "сферический";
                q4.Text = "геоцентральный";
            }
            else
            {
                a1.Text = "Чем поддерживается долговременная стабильность излучения?";
                q1.Text = "элект.управления током";
                q2.Text = "креплением проводов";
                q3.Text = "сверхмодуляцией";
                q4.Text = "компиляцией сигнала";
            }
        }
        //заполение вопроса с CheckBox и ListBox
        public static void checklistboxq(Label a1, CheckBox q1, CheckBox q2, CheckBox q3, CheckBox q4, int index)
        {
            if (index <= 8)
            {
                a1.Text = "Что как правило включается в структору оптических передатчиков?";
                q1.Text = "Провода";
                q2.Text = "Сеть";
                q3.Text = "Оптический усилитель";
                q4.Text = "Корпус";
            }
            else
            {
                a1.Text = "На каком эффекте основывается работа стабилизирующей схемы с микрохолодильником";
                q1.Text = "Германа-Вахта";
                q2.Text = "Пельте";
                q3.Text = "Шоггота";
                q4.Text = "Гринвича";
            }
        }
        //заполение вопроса с CheckedListBox
        public static void checkedlistboxq(Label a1, CheckedListBox q1, int index)
        {
            if (index <= 8)
            {
                a1.Text = "Набор стнадартов для оптических трансиверов?";
                q1.Items.Clear();
                q1.Items.Add("ITU-T");
                q1.Items.Add("TUT-2");
                q1.Items.Add("TAM-T1");
                q1.Items.Add("IPB");
            }
            else
            {
                a1.Text = "От чего зависят оптические свойста элекетрооптических кристаллов?";
                q1.Items.Clear();
                q1.Items.Add("колличество передатчиков");
                q1.Items.Add("изолированность цепи");
                q1.Items.Add("велечина элект.поля");
                q1.Items.Add("сила мгнит.поля");
            }
        }
        //заполение вопроса с ListBox
        public static void listboxq(Label a1, Label a2, Label a3, ListBox q1, int index)
        {

            if (index <= 8)
            {
                a1.Text = "Шаг решётки Брегга определяется фундаментальным соотношением...";
                a2.Text = "Более сложными решениями для передатчиков принято считать использование отдельных внешних модуляторов...";
                a3.Text = "На чём выполняются модёляторы MZM?";
                q1.Items.Clear();
                q1.Items.Add("электроскопическйи кристалл");
                q1.Items.Add("MZM");
                q1.Items.Add("Брегга-Вульфа");

            }
            else
            {
                a1.Text = "Что является ключевым эллементом MZM?";
                a2.Text = "Что делают частоты при гомодийном детектировании?";
                a3.Text = "Что используется для компенсации дисперсионных изображений?";
                q1.Items.Clear();
                q1.Items.Add("каскадная цифровая обработка");
                q1.Items.Add("Управление разностью фаз");
                q1.Items.Add("Совпадают");
            }
        }
        public static void radiobuttonq(Label a1, RadioButton q1, RadioButton q2, RadioButton q3, RadioButton q4, int index)
        {
            //заполение вопроса с RaddioButton
            if (index <= 9)
            {
                a1.Text = "Какого диапазона волны испускает CW лазер";
                q1.Text = "широго";
                q2.Text = "узкого";
                q3.Text = "длинного";
                q4.Text = "короткого";
            }
            else
            {
                a1.Text = "Стоимостной фактор оптического усилителя Raman";
                q1.Text = "Высокий";
                q2.Text = "Низкий";
                q3.Text = "Средний";
                q4.Text = "Огромный";
            }
        }
    }
}

