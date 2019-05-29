namespace V1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxp = new System.Windows.Forms.TextBox();
            this.textBoxc = new System.Windows.Forms.TextBox();
            this.textBoxL = new System.Windows.Forms.TextBox();
            this.textBoxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.buttonvv = new System.Windows.Forms.Button();
            this.labelteplo = new System.Windows.Forms.Label();
            this.labelq1 = new System.Windows.Forms.Label();
            this.labelq2 = new System.Windows.Forms.Label();
            this.textBoxq1 = new System.Windows.Forms.TextBox();
            this.textBoxq2 = new System.Windows.Forms.TextBox();
            this.labelteplook = new System.Windows.Forms.Label();
            this.labelT1 = new System.Windows.Forms.Label();
            this.labelT2 = new System.Windows.Forms.Label();
            this.textBoxT1 = new System.Windows.Forms.TextBox();
            this.textBoxT2 = new System.Windows.Forms.TextBox();
            this.labelK = new System.Windows.Forms.Label();
            this.labelk1 = new System.Windows.Forms.Label();
            this.labelk2 = new System.Windows.Forms.Label();
            this.textBoxk1 = new System.Windows.Forms.TextBox();
            this.textBoxk2 = new System.Windows.Forms.TextBox();
            this.buttonPost2 = new System.Windows.Forms.Button();
            this.buttonPost3 = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKOTE = new System.Windows.Forms.TextBox();
            this.labelT0 = new System.Windows.Forms.Label();
            this.textBoxT0 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(158, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходные данные ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "p(кг/м^3) =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "c(Дж/кг*С) =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(65, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "L(м) =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(73, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "t(c) =";
            // 
            // textBoxp
            // 
            this.textBoxp.Location = new System.Drawing.Point(134, 60);
            this.textBoxp.Name = "textBoxp";
            this.textBoxp.Size = new System.Drawing.Size(251, 28);
            this.textBoxp.TabIndex = 5;
            this.textBoxp.TextChanged += new System.EventHandler(this.TextChanged);
            this.textBoxp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputKey);
            this.textBoxp.MouseEnter += new System.EventHandler(this.MouseEnter);
            // 
            // textBoxc
            // 
            this.textBoxc.Location = new System.Drawing.Point(134, 102);
            this.textBoxc.Name = "textBoxc";
            this.textBoxc.Size = new System.Drawing.Size(250, 28);
            this.textBoxc.TabIndex = 6;
            // 
            // textBoxL
            // 
            this.textBoxL.Location = new System.Drawing.Point(134, 203);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new System.Drawing.Size(250, 28);
            this.textBoxL.TabIndex = 7;
            // 
            // textBoxt
            // 
            this.textBoxt.Location = new System.Drawing.Point(134, 246);
            this.textBoxt.Name = "textBoxt";
            this.textBoxt.Size = new System.Drawing.Size(251, 28);
            this.textBoxt.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(754, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Граничные условия ";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(509, 39);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(83, 25);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "2 рода";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(1121, 39);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(83, 25);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "3 рода";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // buttonvv
            // 
            this.buttonvv.Location = new System.Drawing.Point(679, 64);
            this.buttonvv.Name = "buttonvv";
            this.buttonvv.Size = new System.Drawing.Size(351, 35);
            this.buttonvv.TabIndex = 12;
            this.buttonvv.Text = "Ввести граничные условия ";
            this.buttonvv.UseVisualStyleBackColor = true;
            this.buttonvv.Click += new System.EventHandler(this.buttonvv_Click);
            // 
            // labelteplo
            // 
            this.labelteplo.AutoSize = true;
            this.labelteplo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelteplo.Location = new System.Drawing.Point(477, 104);
            this.labelteplo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelteplo.Name = "labelteplo";
            this.labelteplo.Size = new System.Drawing.Size(166, 23);
            this.labelteplo.TabIndex = 13;
            this.labelteplo.Text = "Тепловые потоки";
            this.labelteplo.Visible = false;
            // 
            // labelq1
            // 
            this.labelq1.AutoSize = true;
            this.labelq1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelq1.Location = new System.Drawing.Point(408, 139);
            this.labelq1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelq1.Name = "labelq1";
            this.labelq1.Size = new System.Drawing.Size(45, 21);
            this.labelq1.TabIndex = 14;
            this.labelq1.Text = "q1 =";
            this.labelq1.Visible = false;
            // 
            // labelq2
            // 
            this.labelq2.AutoSize = true;
            this.labelq2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelq2.Location = new System.Drawing.Point(408, 178);
            this.labelq2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelq2.Name = "labelq2";
            this.labelq2.Size = new System.Drawing.Size(45, 21);
            this.labelq2.TabIndex = 15;
            this.labelq2.Text = "q2 =";
            this.labelq2.Visible = false;
            // 
            // textBoxq1
            // 
            this.textBoxq1.Location = new System.Drawing.Point(452, 136);
            this.textBoxq1.Name = "textBoxq1";
            this.textBoxq1.Size = new System.Drawing.Size(202, 28);
            this.textBoxq1.TabIndex = 16;
            this.textBoxq1.Visible = false;
            this.textBoxq1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputKey2);
            // 
            // textBoxq2
            // 
            this.textBoxq2.Location = new System.Drawing.Point(451, 174);
            this.textBoxq2.Name = "textBoxq2";
            this.textBoxq2.Size = new System.Drawing.Size(203, 28);
            this.textBoxq2.TabIndex = 17;
            this.textBoxq2.Visible = false;
            // 
            // labelteplook
            // 
            this.labelteplook.AutoSize = true;
            this.labelteplook.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelteplook.Location = new System.Drawing.Point(770, 107);
            this.labelteplook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelteplook.Name = "labelteplook";
            this.labelteplook.Size = new System.Drawing.Size(260, 23);
            this.labelteplook.TabIndex = 18;
            this.labelteplook.Text = "Темпер. окружающей среды";
            this.labelteplook.Visible = false;
            // 
            // labelT1
            // 
            this.labelT1.AutoSize = true;
            this.labelT1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelT1.Location = new System.Drawing.Point(674, 136);
            this.labelT1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelT1.Name = "labelT1";
            this.labelT1.Size = new System.Drawing.Size(47, 21);
            this.labelT1.TabIndex = 19;
            this.labelT1.Text = "T1 =";
            this.labelT1.Visible = false;
            // 
            // labelT2
            // 
            this.labelT2.AutoSize = true;
            this.labelT2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelT2.Location = new System.Drawing.Point(674, 171);
            this.labelT2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelT2.Name = "labelT2";
            this.labelT2.Size = new System.Drawing.Size(47, 21);
            this.labelT2.TabIndex = 20;
            this.labelT2.Text = "T2 =";
            this.labelT2.Visible = false;
            // 
            // textBoxT1
            // 
            this.textBoxT1.Location = new System.Drawing.Point(728, 132);
            this.textBoxT1.Name = "textBoxT1";
            this.textBoxT1.Size = new System.Drawing.Size(265, 28);
            this.textBoxT1.TabIndex = 21;
            this.textBoxT1.Visible = false;
            // 
            // textBoxT2
            // 
            this.textBoxT2.Location = new System.Drawing.Point(729, 168);
            this.textBoxT2.Name = "textBoxT2";
            this.textBoxT2.Size = new System.Drawing.Size(263, 28);
            this.textBoxT2.TabIndex = 22;
            this.textBoxT2.Visible = false;
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelK.Location = new System.Drawing.Point(1061, 107);
            this.labelK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(286, 23);
            this.labelK.TabIndex = 23;
            this.labelK.Text = "Коэффициенты теплоотдачи ";
            this.labelK.Visible = false;
            // 
            // labelk1
            // 
            this.labelk1.AutoSize = true;
            this.labelk1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelk1.Location = new System.Drawing.Point(1005, 139);
            this.labelk1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelk1.Name = "labelk1";
            this.labelk1.Size = new System.Drawing.Size(44, 21);
            this.labelk1.TabIndex = 24;
            this.labelk1.Text = "k1 =";
            this.labelk1.Visible = false;
            // 
            // labelk2
            // 
            this.labelk2.AutoSize = true;
            this.labelk2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelk2.Location = new System.Drawing.Point(1004, 174);
            this.labelk2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelk2.Name = "labelk2";
            this.labelk2.Size = new System.Drawing.Size(44, 21);
            this.labelk2.TabIndex = 25;
            this.labelk2.Text = "k2 =";
            this.labelk2.Visible = false;
            // 
            // textBoxk1
            // 
            this.textBoxk1.Location = new System.Drawing.Point(1056, 132);
            this.textBoxk1.Name = "textBoxk1";
            this.textBoxk1.Size = new System.Drawing.Size(259, 28);
            this.textBoxk1.TabIndex = 26;
            this.textBoxk1.Visible = false;
            // 
            // textBoxk2
            // 
            this.textBoxk2.Location = new System.Drawing.Point(1056, 171);
            this.textBoxk2.Name = "textBoxk2";
            this.textBoxk2.Size = new System.Drawing.Size(259, 28);
            this.textBoxk2.TabIndex = 27;
            this.textBoxk2.Visible = false;
            // 
            // buttonPost2
            // 
            this.buttonPost2.Location = new System.Drawing.Point(759, 225);
            this.buttonPost2.Name = "buttonPost2";
            this.buttonPost2.Size = new System.Drawing.Size(203, 33);
            this.buttonPost2.TabIndex = 28;
            this.buttonPost2.Text = "Вычислить ";
            this.buttonPost2.UseVisualStyleBackColor = true;
            this.buttonPost2.Visible = false;
            this.buttonPost2.Click += new System.EventHandler(this.buttonPost2_Click);
            // 
            // buttonPost3
            // 
            this.buttonPost3.Location = new System.Drawing.Point(0, 0);
            this.buttonPost3.Name = "buttonPost3";
            this.buttonPost3.Size = new System.Drawing.Size(75, 23);
            this.buttonPost3.TabIndex = 35;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(15, 337);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1300, 487);
            this.zedGraphControl1.TabIndex = 30;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(42, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 63);
            this.label7.TabIndex = 31;
            this.label7.Text = "Коэф-т \r\nтепл-ти =\r\n(Вт/м*С)\r\n";
            // 
            // textBoxKOTE
            // 
            this.textBoxKOTE.Location = new System.Drawing.Point(134, 149);
            this.textBoxKOTE.Name = "textBoxKOTE";
            this.textBoxKOTE.Size = new System.Drawing.Size(250, 28);
            this.textBoxKOTE.TabIndex = 32;
            // 
            // labelT0
            // 
            this.labelT0.AutoSize = true;
            this.labelT0.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelT0.Location = new System.Drawing.Point(54, 289);
            this.labelT0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelT0.Name = "labelT0";
            this.labelT0.Size = new System.Drawing.Size(72, 21);
            this.labelT0.TabIndex = 33;
            this.labelT0.Text = "T0(C) =";
            // 
            // textBoxT0
            // 
            this.textBoxT0.Location = new System.Drawing.Point(134, 289);
            this.textBoxT0.Name = "textBoxT0";
            this.textBoxT0.Size = new System.Drawing.Size(251, 28);
            this.textBoxT0.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 838);
            this.Controls.Add(this.textBoxT0);
            this.Controls.Add(this.labelT0);
            this.Controls.Add(this.textBoxKOTE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.buttonPost3);
            this.Controls.Add(this.buttonPost2);
            this.Controls.Add(this.textBoxk2);
            this.Controls.Add(this.textBoxk1);
            this.Controls.Add(this.labelk2);
            this.Controls.Add(this.labelk1);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.textBoxT2);
            this.Controls.Add(this.textBoxT1);
            this.Controls.Add(this.labelT2);
            this.Controls.Add(this.labelT1);
            this.Controls.Add(this.labelteplook);
            this.Controls.Add(this.textBoxq2);
            this.Controls.Add(this.textBoxq1);
            this.Controls.Add(this.labelq2);
            this.Controls.Add(this.labelq1);
            this.Controls.Add(this.labelteplo);
            this.Controls.Add(this.buttonvv);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxt);
            this.Controls.Add(this.textBoxL);
            this.Controls.Add(this.textBoxc);
            this.Controls.Add(this.textBoxp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсовая работа ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxp;
        private System.Windows.Forms.TextBox textBoxc;
        private System.Windows.Forms.TextBox textBoxL;
        private System.Windows.Forms.TextBox textBoxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button buttonvv;
        private System.Windows.Forms.Label labelteplo;
        private System.Windows.Forms.Label labelq1;
        private System.Windows.Forms.Label labelq2;
        private System.Windows.Forms.TextBox textBoxq1;
        private System.Windows.Forms.TextBox textBoxq2;
        private System.Windows.Forms.Label labelteplook;
        private System.Windows.Forms.Label labelT1;
        private System.Windows.Forms.Label labelT2;
        private System.Windows.Forms.TextBox textBoxT1;
        private System.Windows.Forms.TextBox textBoxT2;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.Label labelk1;
        private System.Windows.Forms.Label labelk2;
        private System.Windows.Forms.TextBox textBoxk1;
        private System.Windows.Forms.TextBox textBoxk2;
        private System.Windows.Forms.Button buttonPost2;
        private System.Windows.Forms.Button buttonPost3;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxKOTE;
        private System.Windows.Forms.Label labelT0;
        private System.Windows.Forms.TextBox textBoxT0;
    }
}

