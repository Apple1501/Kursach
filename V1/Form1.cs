using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZedGraph;

namespace V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PaneSettings();

            // Подпись текстбоксов на событие 
            textBoxc.KeyPress += InputKey;
            textBoxL.KeyPress += InputKey;
            textBoxt.KeyPress += InputKey;
            textBoxKOTE.KeyPress += InputKey;
            textBoxq2.KeyPress += InputKey2;
            textBoxT2.KeyPress += InputKey2;
            textBoxT1.KeyPress += InputKey2;
            textBoxk1.KeyPress += InputKey2;
            textBoxk2.KeyPress += InputKey2;
            textBoxT0.KeyPress += InputKey2;

            textBoxc.TextChanged += TextChanged;
            textBoxL.TextChanged += TextChanged;
            textBoxt.TextChanged += TextChanged;
            textBoxT1.TextChanged += TextChanged;
            textBoxq2.TextChanged += TextChanged;
            textBoxq1.TextChanged += TextChanged;
            textBoxT2.TextChanged += TextChanged;
            textBoxk1.TextChanged += TextChanged;
            textBoxk2.TextChanged += TextChanged;
            textBoxKOTE.TextChanged += TextChanged;
            textBoxT0.TextChanged += TextChanged;

            textBoxc.MouseEnter += MouseEnter;
            textBoxL.MouseEnter += MouseEnter;
            textBoxt.MouseEnter += MouseEnter;
            textBoxT1.MouseEnter += MouseEnter;
            textBoxq1.MouseEnter += MouseEnter;
            textBoxq2.MouseEnter += MouseEnter;
            textBoxk1.MouseEnter += MouseEnter;
            textBoxk2.MouseEnter += MouseEnter;
            textBoxT2.MouseEnter += MouseEnter;
            textBoxKOTE.MouseEnter += MouseEnter;
            textBoxT0.MouseEnter += MouseEnter;


            
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
                    throw new ApplicationException("Выберите только один вид граничных условий");
                }

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

        //Настройка осей графика
        private void PaneSettings()
        {
            // Получим панель для рисования
            GraphPane pane = zedGraphControl1.GraphPane;
            // По оси X установим автоматический подбор масштаба
            pane.XAxis.Scale.MinAuto = true;
            pane.XAxis.Scale.MaxAuto = true;
            // По оси Y установим автоматический подбор масштаба
            pane.YAxis.Scale.MinAuto = true;
            pane.YAxis.Scale.MaxAuto = true;
            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            zedGraphControl1.AxisChange();
            // Обновляем график
            zedGraphControl1.Invalidate();
            //Подпись осей
            pane.XAxis.Title.Text = "Ось X";
            pane.YAxis.Title.Text = "Ось T";
            pane.Title.Text = "График зависимости T(x)";
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.XAxis.MajorGrid.IsZeroLine = false;
            pane.YAxis.MajorGrid.IsZeroLine = false;
            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Scale.FontSpec.Size = 12;
            pane.YAxis.Scale.FontSpec.Size = 12;
        }

        private void buttonPost2_Click(object sender, EventArgs e)// вычисление зависимости T(х) с граничными условиями второго рода
        {
            //считывание информации из текстбоксов 
            // кол-во пространнственных узлов 
            int N = 20;
            // время 
            double tend;
            // физические параметры объекта 
            double lamda, ro, q1, q2, T0, c;
            //геометрические параметры объекта
            double L;
            try
            {
                // считывание начальных данных
                ro = Convert.ToDouble(textBoxp.Text);
                c = Convert.ToDouble(textBoxc.Text);
                lamda = Convert.ToDouble(textBoxKOTE.Text);
                L = Convert.ToDouble(textBoxL.Text);
                tend = Convert.ToDouble(textBoxt.Text);
                T0 = Convert.ToDouble(textBoxT0.Text);
                double time = 0.0;

                if (textBoxq1.Text == "" && textBoxq2.Text == "")
                {
                    MessageBox.Show("Вы не ввели значения тепловых потоков. Поэтому q1=10^4,q2=10^3");
                    q1 = 10000.0;
                    q2 = 1000.0;
                }
                else
                {
                    // считывание значений тепловых потоков 
                    q1 = Convert.ToDouble(textBoxq1.Text);
                    q2 = Convert.ToDouble(textBoxq2.Text);
                }
                // шаг 
               double h = L / (N - 1);
                //коэффициент теплопроводности 
                double a = lamda / (ro * c);
                // шаг по времени
                double tau = tend / 100;
                double[] T=null;
                double[] alfa = null;
                double[] beta = null;
                double ai, ci, bi, fi;

                for (int i = 0; i < N; i++)
                {
                    T[i] = T0;
                }
                while (time >= tend)
                {
                    time = time + tau;
                    //расчёт коэффициентов с учётом левого граничного условия 
                    alfa[0] = (2.0 * a * tau) / (h * h + 2.0 * a * tau);
                    beta[0] = (h * h * T[0] + ((2.0 * a * tau * h * q1) / lamda)) / (h * h + 2.0 * a * tau);

                    for (int i = 1; i < N - 1; i++)
                    {
                        // расчёт прогоночных коэфициентов 
                        ai = lamda / (h * h);
                        ci = lamda / (h * h);
                        bi = 2.0 * lamda / (h * h) + ro * c / tau;
                        fi = (-1.0) * ro * c * T[i] / tau;
                        // прогоночные коэффициенты 
                        alfa[i] = ai / (bi - ci * alfa[i - 1]);
                        beta[i] = (ci * beta[i - 1] - fi) / (bi - ci * alfa[i - 1]);

                    }


                }


            }

            catch (FormatException )
            {
                MessageBox.Show("Ошибка преобразования. Проверьте введенные значения");
                
            }
            catch (OverflowException)
            {
                MessageBox.Show("Значение переменной выходит за границы типа double");
            }

        }
    }
}
