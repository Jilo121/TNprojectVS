namespace Taotranon_ny_Nosy
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            barSelect = new Panel();
            repartBtnLeft = new Button();
            salaireBtnLeft = new Button();
            chantBtnLeft = new Button();
            emplBtnLeft = new Button();
            panel2 = new Panel();
            button10 = new Button();
            button9 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            containerDon = new Panel();
            chantierList1 = new ChantierList();
            panel5 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            containerDon.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Forte", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(140, 44);
            label1.TabIndex = 0;
            label1.Text = "Taotranon'ny\r\nNosy";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 26, 35);
            panel1.Controls.Add(barSelect);
            panel1.Controls.Add(repartBtnLeft);
            panel1.Controls.Add(salaireBtnLeft);
            panel1.Controls.Add(chantBtnLeft);
            panel1.Controls.Add(emplBtnLeft);
            panel1.Location = new Point(0, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 602);
            panel1.TabIndex = 1;
            // 
            // barSelect
            // 
            barSelect.BackColor = Color.Teal;
            barSelect.Location = new Point(3, 3);
            barSelect.Name = "barSelect";
            barSelect.Size = new Size(10, 38);
            barSelect.TabIndex = 1;
            barSelect.Paint += barSelect_Paint;
            // 
            // repartBtnLeft
            // 
            repartBtnLeft.FlatAppearance.BorderSize = 0;
            repartBtnLeft.FlatStyle = FlatStyle.Flat;
            repartBtnLeft.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            repartBtnLeft.ForeColor = Color.White;
            repartBtnLeft.Location = new Point(1, 94);
            repartBtnLeft.Name = "repartBtnLeft";
            repartBtnLeft.Size = new Size(164, 41);
            repartBtnLeft.TabIndex = 0;
            repartBtnLeft.Text = "REPARTITION";
            repartBtnLeft.UseVisualStyleBackColor = true;
            repartBtnLeft.Click += repartitionLeft;
            // 
            // salaireBtnLeft
            // 
            salaireBtnLeft.FlatAppearance.BorderSize = 0;
            salaireBtnLeft.FlatStyle = FlatStyle.Flat;
            salaireBtnLeft.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            salaireBtnLeft.ForeColor = Color.White;
            salaireBtnLeft.Location = new Point(3, 132);
            salaireBtnLeft.Name = "salaireBtnLeft";
            salaireBtnLeft.Size = new Size(162, 41);
            salaireBtnLeft.TabIndex = 0;
            salaireBtnLeft.Text = "SALAIRE";
            salaireBtnLeft.UseVisualStyleBackColor = true;
            salaireBtnLeft.Click += salaireBtnClick;
            // 
            // chantBtnLeft
            // 
            chantBtnLeft.FlatAppearance.BorderSize = 0;
            chantBtnLeft.FlatStyle = FlatStyle.Flat;
            chantBtnLeft.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chantBtnLeft.ForeColor = Color.White;
            chantBtnLeft.Location = new Point(1, 0);
            chantBtnLeft.Name = "chantBtnLeft";
            chantBtnLeft.Size = new Size(164, 41);
            chantBtnLeft.TabIndex = 0;
            chantBtnLeft.Text = "CHANTIER";
            chantBtnLeft.UseVisualStyleBackColor = true;
            chantBtnLeft.Click += chantierLeft_Click;
            // 
            // emplBtnLeft
            // 
            emplBtnLeft.FlatAppearance.BorderSize = 0;
            emplBtnLeft.FlatStyle = FlatStyle.Flat;
            emplBtnLeft.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emplBtnLeft.ForeColor = Color.White;
            emplBtnLeft.Location = new Point(1, 47);
            emplBtnLeft.Name = "emplBtnLeft";
            emplBtnLeft.Size = new Size(164, 41);
            emplBtnLeft.TabIndex = 0;
            emplBtnLeft.Text = "EMPLOYER";
            emplBtnLeft.UseVisualStyleBackColor = true;
            emplBtnLeft.Click += employerBtnLeftClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(197, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(809, 43);
            panel2.TabIndex = 2;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = Color.White;
            button10.Location = new Point(624, -2);
            button10.Name = "button10";
            button10.Size = new Size(149, 41);
            button10.TabIndex = 0;
            button10.Text = "AIDE";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(469, -2);
            button9.Name = "button9";
            button9.Size = new Size(149, 41);
            button9.TabIndex = 0;
            button9.Text = "SALAIRE";
            button9.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(314, 0);
            button5.Name = "button5";
            button5.Size = new Size(149, 41);
            button5.TabIndex = 0;
            button5.Text = "REPARTITION";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(159, 0);
            button4.Name = "button4";
            button4.Size = new Size(149, 41);
            button4.TabIndex = 0;
            button4.Text = "EMPLOYER";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(4, 0);
            button3.Name = "button3";
            button3.Size = new Size(149, 41);
            button3.TabIndex = 0;
            button3.Text = "CHANTIER";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(1030, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(142, 41);
            panel3.TabIndex = 3;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(39, 55, 77);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Unicode MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.PowderBlue;
            button2.Location = new Point(13, -4);
            button2.Name = "button2";
            button2.Size = new Size(58, 42);
            button2.TabIndex = 0;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(39, 55, 77);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 30, 41);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Unicode MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.LightCoral;
            button1.Location = new Point(77, -4);
            button1.Name = "button1";
            button1.Size = new Size(58, 42);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // containerDon
            // 
            containerDon.Controls.Add(chantierList1);
            containerDon.Location = new Point(199, 66);
            containerDon.Name = "containerDon";
            containerDon.Size = new Size(973, 602);
            containerDon.TabIndex = 4;
            containerDon.Paint += panel4_Paint;
            // 
            // chantierList1
            // 
            chantierList1.BackColor = Color.FromArgb(39, 55, 77);
            chantierList1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chantierList1.Location = new Point(4, 0);
            chantierList1.Margin = new Padding(4);
            chantierList1.Name = "chantierList1";
            chantierList1.Size = new Size(973, 602);
            chantierList1.TabIndex = 0;
            chantierList1.Load += chantierList1_Load;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(18, 26, 35);
            panel5.Location = new Point(1, 667);
            panel5.Name = "panel5";
            panel5.Size = new Size(1185, 32);
            panel5.TabIndex = 5;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 55, 77);
            ClientSize = new Size(1184, 700);
            Controls.Add(panel5);
            Controls.Add(containerDon);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1200, 700);
            MinimumSize = new Size(1000, 700);
            Name = "Home";
            Text = "home";
            Load += home_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            containerDon.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel containerDon;
        private Panel panel5;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button repartBtnLeft;
        private Button chantBtnLeft;
        private Button emplBtnLeft;
        private Button salaireBtnLeft;
        private Button button10;
        private Button button9;
        private Panel barSelect;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ChantierList chantierList1;
    }
}