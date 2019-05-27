using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Подпись текстбоксов на событие 
            textBoxc.KeyPress += InputKey;
            textBoxL.KeyPress += InputKey;
            textBoxt.KeyPress += InputKey;
            textBoxc.TextChanged += TextChanged;
            textBoxL.TextChanged += TextChanged;
            textBoxt.TextChanged += TextChanged;
            textBoxc.MouseEnter += MouseEnter;
            textBoxL.MouseEnter += MouseEnter;
            textBoxt.MouseEnter += MouseEnter;

        }

        //ввод только цифр и запятой 
         void InputKey(object sender, KeyPressEventArgs e)
        {
            //передача элемента управления 
            TextBox tb = (TextBox)sender;
            // проверка -ввод только цифр и Backspace
            if (e.KeyChar >= '0' && e.KeyChar <= '9'|| (e.KeyChar == (char)8)) return;
            //замена точки на запятую
            if (e.KeyChar == '.') e.KeyChar = ',';
            // проверка, что запятая только одна. И она не первый символ
            if (e.KeyChar == ',')
            {
                if (tb.Text.Length == 0 || tb.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }

        new void TextChanged(object sender, EventArgs e)
        { 
            //передача элемента управления 
            TextBox tb = (TextBox)sender;
            tb.ShortcutsEnabled = false;
           
        }


      new  void MouseEnter(object sender, EventArgs e)
        {
            //передача элемента управления 
            TextBox tb = (TextBox)sender;
            tb.ShortcutsEnabled = false;
        }

        private void buttonvv_Click(object sender, EventArgs e) // ввод граничных условий и построение графика 
        {
            try
            {
                //проверка вводв ивда граничных условий 

                if (checkBox2.Checked == false && checkBox3.Checked == false)
                    throw new ApplicationException("Выберите вид граничных условий!");

                if (checkBox2.Checked == true && checkBox3.Checked == true)
                    throw new ApplicationException("Выберите только один вид граничных условий");

                if (checkBox2.Checked == true) // Граничные условия второго рода 
                {
                    /*if (y1 == 0 && y2 == 0 && y3 == 0)
                    {
                        throw new Exception("Система не имеет решений.");
                    }
                    double y_1 = 0.0, y_2 = 0.0, y_3 = 0.0; ;*/

                }
                if (checkBox3.Checked == true) // Граничные условия третьего рода 
                {
                    /*if (y1 == 0 && y2 == 0 && y3 == 0)
                    {
                        throw new Exception("Система не имеет решений.");
                    }
                    double y_1 = 0.0, y_2 = 0.0, y_3 = 0.0; ;*/

                }

            }

            catch (ApplicationException mes)
            {
                MessageBox.Show(mes.Message);
            }

        }
    }
}
