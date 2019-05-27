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
    }
}
