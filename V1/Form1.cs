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
            textBoxf.KeyPress += InputKey;
            textBoxUa.KeyPress += InputKey;
            textBoxt.KeyPress += InputKey;
            textBoxM.KeyPress += InputKey;
            textBoxL1.KeyPress += InputKey;
            textBoxL2.KeyPress += InputKey;
            textBoxC1.KeyPress += InputKey;
            textBoxC2.KeyPress += InputKey;
            textBoxR1.KeyPress += InputKey;
            textBoxR2.KeyPress += InputKey;

            textBoxf.TextChanged += TextChanged;
            textBoxUa.TextChanged += TextChanged;
            textBoxt.TextChanged += TextChanged;
            textBoxM.TextChanged += TextChanged;
            textBoxL1.TextChanged += TextChanged;
            textBoxL2.TextChanged += TextChanged;
            textBoxR1.TextChanged += TextChanged;
            textBoxR2.TextChanged += TextChanged;
            textBoxC1.TextChanged += TextChanged;
            textBoxC2.TextChanged += TextChanged;

            textBoxf.MouseEnter += MouseEnter;
            textBoxUa.MouseEnter += MouseEnter;
            textBoxt.MouseEnter += MouseEnter;
            textBoxM.MouseEnter += MouseEnter;
            textBoxL1.MouseEnter += MouseEnter;
            textBoxL2.MouseEnter += MouseEnter;
            textBoxC1.MouseEnter += MouseEnter;
            textBoxC2.MouseEnter += MouseEnter;
            textBoxR1.MouseEnter += MouseEnter;
            textBoxR2.MouseEnter += MouseEnter;

        }
      
        GraphPane pane; // Графическая панель
        LineItem Curve1, Curve2; // Создаем кривые для графиков
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

        private void buttonvv_Click(object sender, EventArgs e) // ввод метода
        {
            try
            {
                //проверка выбора метода 

                if (checkBox2.Checked == false)
                {

                    throw new ApplicationException("Выберите метод решения!");

                }

                //считывание информации из текстбоксов 

                // время конечное 
                double tend;
                // параметры сигнала 
                double Ua, f;
                //параметры цепи
                double R1, R2, C1, C2, L1, L2, M;

                // считывание начальных данных
                Ua = Convert.ToDouble(textBoxUa.Text);
                f = Convert.ToDouble(textBoxf.Text);
                tend = Convert.ToDouble(textBoxt.Text);
                R1 = Convert.ToDouble(textBoxR1.Text);
                R2 = Convert.ToDouble(textBoxR2.Text);
                C1 = Convert.ToDouble(textBoxC1.Text);
                C2 = Convert.ToDouble(textBoxC2.Text);
                L1 = Convert.ToDouble(textBoxL1.Text);
                L2 = Convert.ToDouble(textBoxL2.Text);
                M = Convert.ToDouble(textBoxM.Text);

                C1 = C1 * (Math.Pow(10, -6));
                C2 = C2 * (Math.Pow(10, -6));


                //Проверка введённых данных
                if (tend == 0)
                {
                    throw new Exception("Конечное время должно быть больше 0");
                }

           /*   if (tend>1000)
                {
                    throw new Exception("Значение переменной выходит за границы типа double");
                }*/
                if (M == 0)
                {
                    throw new Exception("Значение взаимоиндукции должно быть больше 0");
                }
                if (f == 0)
                {
                    throw new Exception("Значение частоты должно быть больше 0");
                }
                if (Ua == 0)
                {
                    throw new Exception("Значение амплитуды входного сигнала должно быть больше 0");
                }
                if (R2 == 0 || C2 ==0||C1==0||R1==0||R2==0||L1==0||L2==0)
                {
                    throw new Exception("Невозможно рассчитать значения. Измените входные данные для параметров схемы!");
                }


                if (tend == 0 && f == 0 && Ua == 0)
                {
                    MessageBox.Show("Вы не ввели начальные условия. Поэтому Конечное время - 10с, f=50 Гц, Амплитуда 10 В");
                    tend = 10;
                    f = 50;
                    Ua = 10;

                }
                //Настройка панели для построения графика
                //Настройка осей
                pane = Zone.GraphPane;
                //Установка масштаба 
                pane.XAxis.Scale.Min = 0;
                pane.XAxis.Scale.Max = tend;
                Zone.AxisChange();

                Zone.Refresh();
                pane.XAxis.Scale.Format = "F3";
                pane.XAxis.Scale.FontSpec.Size = 12;
                pane.YAxis.Scale.FontSpec.Size = 12;

                //Коэффициенты для расчёта характеристического уравнения 
               
                double a, b, c, d, s;
                a = (R1 * C1 * (M * M - L1 * L2)) / (R2 * M);
                b = (M * M - R1 * R2 * L1 - L1 * L2) / (R2 * M);
                c = ((-1) * L2 * R1 * C2 - R1 * C1 * L1 - R2 * C2 * L1) / (R2 * C2 * M);
                d = ((-1) * R1 * R2 * C2 - L1) / (R2 * C2 * M);
                s = R1 / (R2 * C2 * M);


                //Решение однородного уравнения
                //массив значений характеристического уравнения 
                double[] l = new double[4];
                double F, F1,x1,x2;
                //приближение
                int k = -2;
                int i = 0;
                int coef = 0;
                //точность
                double eps = 0.001;
          
                //Проверить цикл как работает 
                while (k < 1)
                {
                    x2 = k;
                    do
                    {
                        x1 = x2;
                        F = a * Math.Pow(x1, 4) + b * Math.Pow(x1, 3) + c * Math.Pow(x1, 2) + d * x1 - s;
                        F1 = 4 * a * Math.Pow(x1, 3) + 3 * b * Math.Pow(x1, 2) + 2 * c * x1 + d;
                        x2 = x1 - F / F1;
                        i++;
                    }
                    while (x2 - x1 > eps && i < 2000);
                    
                    l[coef] = x2;
                    k++;
                    coef++;
                }
                if (i >= 2000)
                {
                    throw new ApplicationException("Слишком много итераций при нахождении корней характеристического уравнения. Проверьте входные данные!");
                }

                // кол-во временных промежутков 
                int N = 100;

                // шаг 
                double h = tend / (N - 1);

                double[] U2 = new double[N];
               
                double w = 2 * 3.14 * f;
                double A, B,z;

                //Расчёт коэффициентов C1 C2 C3 C4 для уравнения 

                double c1, c2, c3, c4;

                if (checkBox2.Checked == true)
                {

                    //чистка массива точек 
                    points_Gr2.Clear();   
                    z = (Math.Pow((a * Math.Pow(w, 4) - c * w * w + s), 2) + Math.Pow((b * Math.Pow(w, 3) - d * w), 2));
                    A =(-w*w*Ua*(b*Math.Pow(w,3)-d*w))/z;
                    B = (-w * w * Ua * Math.Pow((a * Math.Pow(w, 4) - c * w * w + s), 2)) / z;

                    c1 = c3 = -A - ((l[0] * A - B * w) / (l[1] - l[0]));
                    c2 = c4 = (l[0] * A - B * w) / (l[1] - l[0]);

                    //Расчёт коэффициентов 

                    /*  c1=l[1]*Math.Pow(l[2],2)* Math.Pow(l[3], 3)+l[2]* Math.Pow(l[3], 2)* Math.Pow(l[1], 3)+l[3]* Math.Pow(l[1], 2)*Math.Pow(l[2], 3) - l[3] * Math.Pow(l[2], 2) * Math.Pow(l[1], 3) - l[1] * Math.Pow(l[3], 2) * Math.Pow(l[2], 3) - l[2] * Math.Pow(l[1], 2) * Math.Pow(l[3], 3);
                        c2 = (-1) * (l[0] * Math.Pow(l[2], 2) * Math.Pow(l[3], 3) + l[2] * Math.Pow(l[3], 2) * Math.Pow(l[2], 3) + l[3] * Math.Pow(l[0], 2) * Math.Pow(l[2], 3) - l[3] * Math.Pow(l[2], 2) * Math.Pow(l[0], 3) - l[0] * Math.Pow(l[3], 2) * Math.Pow(l[2], 3) - l[2] * Math.Pow(l[0], 2) * Math.Pow(l[3], 3));
                        c3 = l[0] * Math.Pow(l[1], 2) * Math.Pow(l[3], 3) + l[1] * Math.Pow(l[3], 2) * Math.Pow(l[0], 3) + l[3] * Math.Pow(l[0], 2) * Math.Pow(l[1], 3) - l[3] * Math.Pow(l[1], 2) * Math.Pow(l[0], 3) - l[0] * Math.Pow(l[3], 2) * Math.Pow(l[1], 3) - l[1] * Math.Pow(l[0], 2) * Math.Pow(l[3], 3);
                        c4 = (-1) * (l[0]* Math.Pow(l[1], 2)* Math.Pow(l[2], 3)+l[1]* Math.Pow(l[2], 2)* Math.Pow(l[0], 3)+l[2]* Math.Pow(l[0], 2)* Math.Pow(l[1], 3)-l[2]* Math.Pow(l[1], 3)* Math.Pow(l[0], 3)-l[0]* Math.Pow(l[2], 2)* Math.Pow(l[1], 3)-l[1]* Math.Pow(l[0], 2)* Math.Pow(l[3], 3));

                       */


                  
                  
                    int g = 0;
                    U2[g] = 0;
                    points_Gr2.Add(g, U2[g]);
                    g++;
   
                    while (g < N - 1)
                    {
                        U2[g] = c1 * Math.Exp((l[0]) * g*h) + c2 * Math.Exp(l[1] * g * h) + c3 * Math.Exp((l[2]) * g * h) + c4 * Math.Exp((l[3])* g * h) + A * Math.Cos(w * g * h) + B * Math.Sin(w * g * h);
                        points_Gr2.Add(g * h, U2[g]);
                        if (double.IsNaN(U2[g]))
                        {
                            throw new OverflowException("Значение переменной выходит за границы типа double");
                        }
                        g++;

                    }

                    U2[N - 1] = c1 * Math.Exp((l[0]) * tend) + c2 * Math.Exp(l[1] * tend) + c3 * Math.Exp((l[2]) * tend) + c4 * Math.Exp((l[3]) * tend) + A * Math.Cos(w * tend) + B * Math.Sin(w * tend);
                    points_Gr2.Add(tend, U2[N - 1]);
                    
                    //Очищаем список кривых
                    pane.CurveList.Clear();

                    points_Gr2.TrimExcess();
                    pane.Title.Text = "Зависимость U2(U1) по методу Неопределённых коэффициентов";
                    Curve1 = pane.AddCurve("U2(U1)", points_Gr2, Color.Green, SymbolType.None);
                    Curve1.Symbol.Size = 3; // Размер точки
                    Curve1.Line.IsVisible = true;
                    Curve1.Line.Width = 3;
                    //pane.XAxis.Scale.Max = L;
                    SetSize();


                }

               
            }

            catch (OverflowException mes)
            {
                MessageBox.Show(mes.Message);
            }

            catch (ApplicationException mes)
            {
                MessageBox.Show(mes.Message);
            }

            catch (FormatException)
            {
                MessageBox.Show("Ошибка преобразования. Проверьте введенные значения");

            }
          
            catch (Exception mes)
            {
                MessageBox.Show(mes.Message);
            }

                       

        }

        //Настройка осей графика
        private void PaneSettings()
        {
            // Получим панель для рисования
            GraphPane pane = Zone.GraphPane;
            // По оси X установим автоматический подбор масштаба
            pane.XAxis.Scale.MinAuto = true;
            pane.XAxis.Scale.MaxAuto = true;
            // По оси Y установим автоматический подбор масштаба
            pane.YAxis.Scale.MinAuto = true;
            pane.YAxis.Scale.MaxAuto = true;
            // Вызываем метод AxisChange (), чтобы обновить данные об осях.
            Zone.AxisChange();
            // Обновляем график
            Zone.Invalidate();
            //Подпись осей
            pane.XAxis.Title.Text = "t, c";
            pane.YAxis.Title.Text = "U2, B";
            pane.Title.Text = "График зависимости U2(U1)";
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.XAxis.MajorGrid.IsZeroLine = false;
            pane.YAxis.MajorGrid.IsZeroLine = false;
            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Scale.FontSpec.Size = 12;
            pane.YAxis.Scale.FontSpec.Size = 12;
        }






        public void SetSize()
        {
           // Включаем отображение сетки напротив крупных рисок по оси X
           // pane.XAxis.MajorGrid.IsVisible = true;
            // Задаем вид пунктирной линии для крупных рисок по оси X:
            // Длина штрихов равна 10 пикселям
            pane.XAxis.MajorGrid.DashOn = 10;
            // затем 5 пикселей - пропуск
            pane.XAxis.MajorGrid.DashOff = 5;
            // Включаем отображение сетки напротив крупных рисок по оси Y
         //   pane.YAxis.MajorGrid.IsVisible = true;
            // Аналогично задаем вид пунктирной линии для крупных рисок по оси Y
            pane.YAxis.MajorGrid.DashOn = 10;
            pane.YAxis.MajorGrid.DashOff = 5;
            // Регулировка размера точки
            pane.YAxis.Scale.MaxAuto = true;
            pane.YAxis.Scale.MinAuto = true;
            pane.IsBoundedRanges = true;
            Zone.AxisChange();
            
            Zone.Refresh();
            
        }

    }
}
