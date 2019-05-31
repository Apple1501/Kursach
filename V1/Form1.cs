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
            textBoxk1.KeyPress += InputKey;
            textBoxk2.KeyPress += InputKey;
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
        string path_ = "..\\..\\output.txt";
        GraphPane pane; // Графическая панель
        LineItem Curve1, Curve2; // Создаем кривые для графика
        PointPairList points_Gr2 = new PointPairList();
        PointPairList points_Gr3 = new PointPairList();

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
                //проверка ввода вида граничных условий 

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
                   
                    labelq1.Visible = false;
                    labelq2.Visible = false;
                    labelk1.Visible = false;
                    labelk2.Visible = false;
                    labelteplo.Visible = false;
                    textBoxq1.Visible = false;
                    textBoxq2.Visible = false;
                    buttonPost2.Visible = false;
                    buttonopen.Visible = false;

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

                    labelk1.Visible = false;
                    labelk2.Visible = false;
                    labelq1.Visible = false;
                    labelq2.Visible = false;
                    labelteplo.Visible = false;
                    textBoxq1.Visible = false;
                    textBoxq2.Visible = false;
                    buttonPost2.Visible = false;
                    buttonopen.Visible = false;
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
                    labelk1.Visible = false;
                    labelk2.Visible = false;
                    labelK.Visible = false;
                    labelteplook.Visible = false;
                    textBoxk1.Visible = false;
                    textBoxk2.Visible = false;
                    textBoxT1.Visible = false;
                    textBoxT2.Visible = false;
                    buttonopen.Visible = true;


                }
                if (checkBox3.Checked == true) // Граничные условия третьего рода 
                {

                    labelT1.Visible = true;
                    labelT2.Visible = true;
                    labelk1.Visible = true;
                    labelk2.Visible = true;
                    labelK.Visible = true;
                    labelteplook.Visible = true;
                    textBoxk1.Visible = true;
                    textBoxk2.Visible = true;
                    textBoxT1.Visible = true;
                    textBoxT2.Visible = true;
                    buttonPost2.Visible = true;
                    buttonopen.Visible = true;

                    labelq1.Visible = false;
                    labelq2.Visible = false;
                    labelteplo.Visible = false;
                    textBoxq1.Visible = false;
                    textBoxq2.Visible = false;
                   

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
            pane.XAxis.Title.Text = "х, м";
            pane.YAxis.Title.Text = "T, C";
            pane.Title.Text = "График зависимости T(x)";
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.XAxis.MajorGrid.IsZeroLine = false;
            pane.YAxis.MajorGrid.IsZeroLine = false;
            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Scale.FontSpec.Size = 12;
            pane.YAxis.Scale.FontSpec.Size = 12;
        }

      

        private void buttonPost2_Click(object sender, EventArgs e)// вычисление зависимости T(х) с граничными условиями
        { 
            //чистка массива точек 
            points_Gr2.Clear();
            points_Gr3.Clear();
            //считывание информации из текстбоксов 
            // кол-во пространнственных узлов 
            int N = 100;
            // время конечное 
            double tend;
            // физические параметры объекта 
            double lamda, ro, q1, q2, T0, c,T1,T2,k1,k2;
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
                if (tend == 0)
                {
                    throw new Exception("Конечное время должно быть больше 0");
                }
                if (L == 0)
                {
                    throw new Exception("Значение перменной L  должно быть больше 0");
                }
                if (L >100)
                {
                    throw new Exception("Значение перменной L  должно быть больше 100");
                }

                if (ro == 0 && c == 0 && lamda == 0 && T0 == 0)
                {
                    MessageBox.Show("Вы не ввели начальные условия.  Поэтому Плоность - 8800 кг/м^3, c=381 Дж/(кг*С), Начальная температура - 20 С, lamda=384 Вт/(м*С)");
                    ro = 8800;
                    c = 381;
                    T0 = 20;
                    lamda =384;

                }
                //Настройка панели для построения графика
                //Настройка осей
                pane = zedGraphControl1.GraphPane;
                //Установка масштаба 
                pane.XAxis.Scale.Min = 0;
                pane.XAxis.Scale.Max = L;
                pane.XAxis.Scale.Format = "F2";
                pane.XAxis.Scale.FontSpec.Size = 12;
                pane.YAxis.Scale.FontSpec.Size = 12;
                // шаг 
                double h = L / (N - 1);
                //коэффициент теплопроводности 
                double a = lamda / (ro * c);
                // шаг по времени
                double tau = tend / 100;
                //массивы для температуры, коэффициентов альфа и бета 
                double[] T = new double[N];
                double[] alfa = new double[N];
                double[] beta = new double[N];

                double ai, ci, bi, fi;

                if (checkBox2.Checked == true)
                {


                    points_Gr2.Clear();
                    
                    if (textBoxq1.Text == "" && textBoxq2.Text == "")
                    {
                        MessageBox.Show("Вы не ввели значения тепловых потоков.  Поэтому q1=10000, q2=1000");
                        q1 = 10000.0;
                        q2 = 1000.0;
                    }
                    else
                    {
                        // считывание значений тепловых потоков 
                        q1 = Convert.ToDouble(textBoxq1.Text);
                        q2 = Convert.ToDouble(textBoxq2.Text);
                    }                                                               

                    for (int i = 0; i < N; i++)
                    {
                        T[i] = T0;
                    }
                    while (tend >= time)
                    {
                        
                        //расчёт коэффициентов с учётом левого граничного условия 
                        alfa[0] = (2.0 * a * tau) / (h * h + 2.0 * a * tau);
                        beta[0] = (h * h * T[0] + ((2.0 * a * tau * h * q1) / lamda)) / (h * h + 2.0 * a * tau);

                         for (int i = 1; i < N; i++)
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
                        // определение значения температуры на правой границе с учётом правых граничных условий 
                        T[N - 1] = (2.0 * a * tau * lamda * beta[N - 1] - 2.0 * a * tau * h * q2 + h * h * lamda * T[N - 1]) / (lamda * h * h + 2.0 * a * lamda * tau * (1 - alfa[N - 1]));
                       
                        // определяем неизвестные температуры 
                        for (int i = N - 2; i > -1; i--)
                        {
                            T[i] = alfa[i] * T[i + 1] + beta[i];
                        }
                        time = time + tau;

                    }
                    // Запись в файл:
                    StreamWriter SW_ = new StreamWriter(path_);
                 
                   
                        SW_.WriteLine("время процесса =" + " " + tend+""+"c");
                        SW_.WriteLine("L, м" + " " + "T, C");

                    int k = 0;
                   
                    //Очищаем список кривых
                    pane.CurveList.Clear();
                     // N = 0;
                    while (k < N - 1)
                    {
                        points_Gr2.Add(k * h, T[k]);
                        SW_.WriteLine(k*h + " " + T[k]);
                        k++;
                    }
                    points_Gr2.Add(L, T[k]);
                    SW_.WriteLine(L + " " + T[k]);
                    //закрытие файла
                    SW_.Close();

                    points_Gr2.TrimExcess();
                    pane.Title.Text = "Зависимость T(х)с учётом граничных условий 2-го рода ";
                    Curve1 = pane.AddCurve("Т(х)", points_Gr2, Color.Green, SymbolType.None);
                    Curve1.Symbol.Size = 3; // Размер точки
                    Curve1.Line.IsVisible = true;
                    Curve1.Line.Width = 3;
                    SetSize();
                }

                if (checkBox3.Checked == true) // граничные условия третьего рода 
                {
                    points_Gr3.Clear();

                    if (textBoxk1.Text == "" && textBoxk2.Text == ""&& textBoxT2.Text == ""&&textBoxT1.Text == "")
                    {
                        MessageBox.Show("Вы не ввели граничные условия тертьего рода.  Поэтому T1=10, T2=12,  k1=1000, k2=500");
                        T1 = 10.0;
                        T2 = 12.0;
                        k1 = 1000.0;
                        k2 = 500.0;
                    }
                    else
                    {
                        // считывание значений тепловых потоков 
                        k1 = Convert.ToDouble(textBoxk1.Text);
                        k2 = Convert.ToDouble(textBoxk2.Text);
                        T1 = Convert.ToDouble(textBoxT1.Text);
                        T2 = Convert.ToDouble(textBoxT2.Text);
                    }
                    for (int i = 0; i < N; i++)
                    {
                        T[i] = T0;
                    }
                    while (tend >= time)
                    {
                        // time = time + tau;
                        //расчёт коэффициентов с учётом левого граничного условия 
                        alfa[0] = (2.0 * a * tau * lamda) / (lamda * h * h + 2.0 * a * tau * (lamda + h * k1));
                        beta[0] = (lamda * h * h * T[0] + 2.0 * a * tau * k1 * h * T1) / (lamda * h * h + 2.0 * a * tau * (lamda + h * k1));

                        for (int i = 1; i < N; i++)
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
                        // определение значения температуры на правой границе 
                       
                        T[N - 1] = (lamda * h * h * T[N - 1] + 2.0 * a * tau * (lamda * beta[N - 1] + h * k2 * T2)) / (lamda * h * h + 2.0 * a * tau * (h * k2 + lamda * (1 - alfa[N - 1])));                        // определяем неизвестные температуры 

                        for (int i = N - 2; i > -1; i--)
                        {
                            T[i] = alfa[i] * T[i + 1] + beta[i];
                        }
                        time = time + tau;

                    }
                    int k = 0;
                   
                    pane.CurveList.Clear();
                    //Определяем заголовки
                    // Запись в файл:
                    StreamWriter SW_ = new StreamWriter(path_);


                    SW_.WriteLine("время процесса =" + " " + tend + "" + "c");
                    SW_.WriteLine("L, м" + " " + "T, C");

                     //Очищаем список кривых
                    pane.CurveList.Clear();
                    // N = 0;
                    while (k < N - 1)
                    {
                        points_Gr3.Add(k * h, T[k]);
                        SW_.WriteLine(k * h + " " + T[k]);
                        k++;
                    }
                    points_Gr3.Add(L, T[k]);
                    SW_.WriteLine(L + " " + T[k]);
                    //закрытие файла
                    SW_.Close();

                    points_Gr3.TrimExcess();
                    pane.Title.Text = "Зависимость T(х)с учётом граничных условий 3-го рода ";
                    Curve2 = pane.AddCurve("Т(х)", points_Gr3, Color.Blue, SymbolType.None);
                    Curve2.Symbol.Size = 3; // Размер точки
                    Curve2.Line.IsVisible = true;
                    Curve2.Line.Width = 3;
                    SetSize();
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Ошибка преобразования. Проверьте введенные значения");

            }
            catch (OverflowException)
            {
                MessageBox.Show("Значение переменной выходит за границы типа double");
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }
        }
        // показать полученные данные 
        private void buttonopen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:\\0\\Доки\\Вычи.мат\\Курсовая\\V1\\V1\\output.txt");
        }

        public void SetSize()
        {
            // Включаем отображение сетки напротив крупных рисок по оси X
            pane.XAxis.MajorGrid.IsVisible = true;
            // Задаем вид пунктирной линии для крупных рисок по оси X:
            // Длина штрихов равна 10 пикселям
            pane.XAxis.MajorGrid.DashOn = 10;
            // затем 5 пикселей - пропуск
            pane.XAxis.MajorGrid.DashOff = 5;
            // Включаем отображение сетки напротив крупных рисок по оси Y
            pane.YAxis.MajorGrid.IsVisible = true;
            // Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            pane.YAxis.MajorGrid.DashOn = 10;
            pane.YAxis.MajorGrid.DashOff = 5;
            // Регулировка размера точки
            pane.YAxis.Scale.MaxAuto = true;
            pane.YAxis.Scale.MinAuto = true;
            pane.IsBoundedRanges = true;
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
            
        }

    }
}
