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
            textBoxq2.KeyPress += InputKey2;
            textBoxT2.KeyPress += InputKey2;
            textBoxT1.KeyPress += InputKey2;
            textBoxk1.KeyPress += InputKey2;
            textBoxk2.KeyPress += InputKey2;

            textBoxc.TextChanged += TextChanged;
            textBoxL.TextChanged += TextChanged;
            textBoxt.TextChanged += TextChanged;
            textBoxT1.TextChanged += TextChanged;
            textBoxq2.TextChanged += TextChanged;
            textBoxq1.TextChanged += TextChanged;
            textBoxT2.TextChanged += TextChanged;
            textBoxk1.TextChanged += TextChanged;
            textBoxk2.TextChanged += TextChanged;

            textBoxc.MouseEnter += MouseEnter;
            textBoxL.MouseEnter += MouseEnter;
            textBoxt.MouseEnter += MouseEnter;
            textBoxT1.MouseEnter += MouseEnter;
            textBoxq1.MouseEnter += MouseEnter;
            textBoxq2.MouseEnter += MouseEnter;
            textBoxk1.MouseEnter += MouseEnter;
            textBoxk2.MouseEnter += MouseEnter;
            textBoxT2.MouseEnter += MouseEnter;
            

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
        //ввод только цифр, запятой и минуса  
        void InputKey2(object sender, KeyPressEventArgs e)
        {
            //передача элемента управления 
            TextBox tb = (TextBox)sender;
            // проверка -ввод только цифр и Backspace
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || (e.KeyChar == (char)8) || (e.KeyChar == (char)45)) return;
            //замена точки на запятую
            if (e.KeyChar == '.') e.KeyChar = ',';

           if (e.KeyChar == (char)45)
            {
                if (tb.Text.Length != 0 || tb.Text.IndexOf('-') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            

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
                {
                    labelT1.Visible = false;
                    labelT2.Visible = false;
                    labelK.Visible = false;
                    labelteplook.Visible = false;
                    textBoxk1.Visible = false;
                    textBoxk2.Visible = false;
                    textBoxT1.Visible = false;
                    textBoxT2.Visible = false;
                    buttonPost3.Visible = false;
                    labelq1.Visible = false;
                    labelq2.Visible = false;
                    labelteplo.Visible = false;
                    textBoxq1.Visible = false;
                    textBoxq2.Visible = false;
                    buttonPost2.Visible = false;

                    throw new ApplicationException("Выберите вид граничных условий!");
                                     
                }

                if (checkBox2.Checked == true && checkBox3.Checked == true)
                    throw new ApplicationException("Выберите только один вид граничных условий");

                if (checkBox2.Checked == true) // Граничные условия второго рода 
                {
                    labelq1.Visible = true;
                    labelq2.Visible = true;
                    labelteplo.Visible = true;
                    textBoxq1.Visible = true;
                    textBoxq2.Visible = true;
                    buttonPost2.Visible = true;

                    labelT1.Visible = false;
                    labelT2.Visible = false;
                    labelK.Visible = false;
                    labelteplook.Visible = false;
                    textBoxk1.Visible = false;
                    textBoxk2.Visible = false;
                    textBoxT1.Visible = false;
                    textBoxT2.Visible = false;
                    buttonPost3.Visible = false;

                }
                if (checkBox3.Checked == true) // Граничные условия третьего рода 
                {

                    labelT1.Visible = true;
                    labelT2.Visible = true;
                    labelK.Visible = true;
                    labelteplook.Visible = true;
                    textBoxk1.Visible = true;
                    textBoxk2.Visible = true;
                    textBoxT1.Visible = true;
                    textBoxT2.Visible = true;
                    buttonPost3.Visible = true;

                    labelq1.Visible = false;
                    labelq2.Visible = false;
                    labelteplo.Visible = false;
                    textBoxq1.Visible = false;
                    textBoxq2.Visible = false;
                    buttonPost2.Visible = false;

                }

            }

            catch (ApplicationException mes)
            {
                MessageBox.Show(mes.Message);
            }

        }

       
    }
}
