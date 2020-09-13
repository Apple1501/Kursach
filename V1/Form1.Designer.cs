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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUa = new System.Windows.Forms.TextBox();
            this.textBoxf = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.buttonvv = new System.Windows.Forms.Button();
            this.Zone = new ZedGraph.ZedGraphControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxC1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxR2 = new System.Windows.Forms.TextBox();
            this.textBoxR1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxC2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxL2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxL1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(265, 9);
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
            this.label2.Location = new System.Drawing.Point(13, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ua(B) =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "f(Гц) =";
            // 
            // textBoxUa
            // 
            this.textBoxUa.Location = new System.Drawing.Point(83, 231);
            this.textBoxUa.Name = "textBoxUa";
            this.textBoxUa.Size = new System.Drawing.Size(251, 28);
            this.textBoxUa.TabIndex = 5;
            this.textBoxUa.TextChanged += new System.EventHandler(this.TextChanged);
            this.textBoxUa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputKey);
            this.textBoxUa.MouseEnter += new System.EventHandler(this.MouseEnter);
            // 
            // textBoxf
            // 
            this.textBoxf.Location = new System.Drawing.Point(81, 292);
            this.textBoxf.Name = "textBoxf";
            this.textBoxf.Size = new System.Drawing.Size(250, 28);
            this.textBoxf.TabIndex = 6;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(21, 504);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(303, 25);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Неопределённых коэффициентов ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // buttonvv
            // 
            this.buttonvv.Location = new System.Drawing.Point(17, 589);
            this.buttonvv.Name = "buttonvv";
            this.buttonvv.Size = new System.Drawing.Size(666, 40);
            this.buttonvv.TabIndex = 12;
            this.buttonvv.Text = "Рассчитать";
            this.buttonvv.UseVisualStyleBackColor = true;
            this.buttonvv.Click += new System.EventHandler(this.buttonvv_Click);
            // 
            // Zone
            // 
            this.Zone.Location = new System.Drawing.Point(692, 14);
            this.Zone.Margin = new System.Windows.Forms.Padding(5);
            this.Zone.Name = "Zone";
            this.Zone.ScrollGrace = 0D;
            this.Zone.ScrollMaxX = 0D;
            this.Zone.ScrollMaxY = 0D;
            this.Zone.ScrollMaxY2 = 0D;
            this.Zone.ScrollMinX = 0D;
            this.Zone.ScrollMinY = 0D;
            this.Zone.ScrollMinY2 = 0D;
            this.Zone.Size = new System.Drawing.Size(772, 615);
            this.Zone.TabIndex = 30;
            this.Zone.UseExtendedPrintDialog = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Амплитуда входного сигнала";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = "Частота входного сигнала";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Метод решения ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Время ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(22, 350);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "t(c) =";
            // 
            // textBoxt
            // 
            this.textBoxt.Location = new System.Drawing.Point(81, 347);
            this.textBoxt.Name = "textBoxt";
            this.textBoxt.Size = new System.Drawing.Size(250, 28);
            this.textBoxt.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 159);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(533, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 21);
            this.label9.TabIndex = 48;
            this.label9.Text = "Ёмкости";
            // 
            // textBoxC1
            // 
            this.textBoxC1.Location = new System.Drawing.Point(433, 350);
            this.textBoxC1.Name = "textBoxC1";
            this.textBoxC1.Size = new System.Drawing.Size(250, 28);
            this.textBoxC1.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(341, 353);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 21);
            this.label10.TabIndex = 46;
            this.label10.Text = "С1(мкФ) =";
            // 
            // textBoxR2
            // 
            this.textBoxR2.Location = new System.Drawing.Point(433, 292);
            this.textBoxR2.Name = "textBoxR2";
            this.textBoxR2.Size = new System.Drawing.Size(250, 28);
            this.textBoxR2.TabIndex = 43;
            // 
            // textBoxR1
            // 
            this.textBoxR1.Location = new System.Drawing.Point(433, 234);
            this.textBoxR1.Name = "textBoxR1";
            this.textBoxR1.Size = new System.Drawing.Size(251, 28);
            this.textBoxR1.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(352, 292);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 21);
            this.label13.TabIndex = 41;
            this.label13.Text = "R2(Oм) =";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(352, 238);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 21);
            this.label14.TabIndex = 40;
            this.label14.Text = "R1(Oм) =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(505, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 21);
            this.label11.TabIndex = 49;
            this.label11.Text = "Сопротивления";
            // 
            // textBoxC2
            // 
            this.textBoxC2.Location = new System.Drawing.Point(433, 409);
            this.textBoxC2.Name = "textBoxC2";
            this.textBoxC2.Size = new System.Drawing.Size(250, 28);
            this.textBoxC2.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(341, 412);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 21);
            this.label15.TabIndex = 51;
            this.label15.Text = "С2(мкФ) =";
            // 
            // textBoxL2
            // 
            this.textBoxL2.Location = new System.Drawing.Point(433, 540);
            this.textBoxL2.Name = "textBoxL2";
            this.textBoxL2.Size = new System.Drawing.Size(250, 28);
            this.textBoxL2.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(358, 543);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 21);
            this.label12.TabIndex = 56;
            this.label12.Text = "L2(Гн) =";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(506, 453);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 21);
            this.label16.TabIndex = 55;
            this.label16.Text = "Индуктивности";
            // 
            // textBoxL1
            // 
            this.textBoxL1.Location = new System.Drawing.Point(433, 489);
            this.textBoxL1.Name = "textBoxL1";
            this.textBoxL1.Size = new System.Drawing.Size(250, 28);
            this.textBoxL1.TabIndex = 54;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(358, 492);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 21);
            this.label17.TabIndex = 53;
            this.label17.Text = "L1(Гн) =";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(134, 379);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(147, 21);
            this.label18.TabIndex = 60;
            this.label18.Text = "Взаимоиндукция";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(81, 409);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(250, 28);
            this.textBoxM.TabIndex = 59;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(32, 412);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 21);
            this.label19.TabIndex = 58;
            this.label19.Text = "M =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 650);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxL2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxL1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxC2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxC1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxR2);
            this.Controls.Add(this.textBoxR1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Zone);
            this.Controls.Add(this.buttonvv);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBoxf);
            this.Controls.Add(this.textBoxUa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "решение дифференциальных уравнений";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUa;
        private System.Windows.Forms.TextBox textBoxf;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button buttonvv;
        private ZedGraph.ZedGraphControl Zone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxC1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxR2;
        private System.Windows.Forms.TextBox textBoxR1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxC2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxL2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxL1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label19;
    }
}

