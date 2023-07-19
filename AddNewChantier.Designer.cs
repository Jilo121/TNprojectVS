namespace Taotranon_ny_Nosy
{
    partial class AddNewChantier
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
            panel1 = new Panel();
            pictNouvChant = new PictureBox();
            annulerBtnChant = new Button();
            enregistrerNouvChant = new Button();
            ajouterphotos = new Button();
            enCoursChant = new CheckBox();
            dateFinChant = new DateTimePicker();
            dateDebutChant = new DateTimePicker();
            photoIabel = new Label();
            dateFinChantInput = new Label();
            dateDebutChantInput = new Label();
            idProprioIabel = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            LieuLabelChant = new Label();
            chantLieuInput = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictNouvChant).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictNouvChant);
            panel1.Controls.Add(annulerBtnChant);
            panel1.Controls.Add(enregistrerNouvChant);
            panel1.Controls.Add(ajouterphotos);
            panel1.Controls.Add(enCoursChant);
            panel1.Controls.Add(dateFinChant);
            panel1.Controls.Add(dateDebutChant);
            panel1.Controls.Add(photoIabel);
            panel1.Controls.Add(dateFinChantInput);
            panel1.Controls.Add(dateDebutChantInput);
            panel1.Controls.Add(idProprioIabel);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LieuLabelChant);
            panel1.Controls.Add(chantLieuInput);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(563, 325);
            panel1.TabIndex = 0;
            // 
            // pictNouvChant
            // 
            pictNouvChant.BackgroundImageLayout = ImageLayout.Stretch;
            pictNouvChant.Location = new Point(312, 18);
            pictNouvChant.Name = "pictNouvChant";
            pictNouvChant.Size = new Size(240, 240);
            pictNouvChant.TabIndex = 5;
            pictNouvChant.TabStop = false;
            pictNouvChant.Click += pictNouvChant_Click;
            // 
            // annulerBtnChant
            // 
            annulerBtnChant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            annulerBtnChant.Location = new Point(312, 289);
            annulerBtnChant.Name = "annulerBtnChant";
            annulerBtnChant.Size = new Size(169, 29);
            annulerBtnChant.TabIndex = 4;
            annulerBtnChant.Text = "Annuler";
            annulerBtnChant.UseVisualStyleBackColor = true;
            annulerBtnChant.Click += annulerBtn;
            // 
            // enregistrerNouvChant
            // 
            enregistrerNouvChant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            enregistrerNouvChant.Location = new Point(121, 289);
            enregistrerNouvChant.Name = "enregistrerNouvChant";
            enregistrerNouvChant.Size = new Size(169, 29);
            enregistrerNouvChant.TabIndex = 4;
            enregistrerNouvChant.Text = "Enregistrer";
            enregistrerNouvChant.UseVisualStyleBackColor = true;
            enregistrerNouvChant.Click += button1_Click;
            // 
            // ajouterphotos
            // 
            ajouterphotos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ajouterphotos.Location = new Point(121, 229);
            ajouterphotos.Name = "ajouterphotos";
            ajouterphotos.Size = new Size(169, 29);
            ajouterphotos.TabIndex = 4;
            ajouterphotos.Text = "Ajouter photo";
            ajouterphotos.UseVisualStyleBackColor = true;
            ajouterphotos.Click += addPicsClick;
            // 
            // enCoursChant
            // 
            enCoursChant.AutoSize = true;
            enCoursChant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            enCoursChant.Location = new Point(120, 198);
            enCoursChant.Name = "enCoursChant";
            enCoursChant.Size = new Size(88, 25);
            enCoursChant.TabIndex = 3;
            enCoursChant.Text = "En cours";
            enCoursChant.UseVisualStyleBackColor = true;
            // 
            // dateFinChant
            // 
            dateFinChant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateFinChant.Location = new Point(120, 165);
            dateFinChant.Name = "dateFinChant";
            dateFinChant.Size = new Size(169, 29);
            dateFinChant.TabIndex = 2;
            // 
            // dateDebutChant
            // 
            dateDebutChant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateDebutChant.Location = new Point(120, 128);
            dateDebutChant.Name = "dateDebutChant";
            dateDebutChant.Size = new Size(169, 29);
            dateDebutChant.TabIndex = 2;
            // 
            // photoIabel
            // 
            photoIabel.AutoSize = true;
            photoIabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            photoIabel.ForeColor = SystemColors.ButtonFace;
            photoIabel.Location = new Point(12, 237);
            photoIabel.Name = "photoIabel";
            photoIabel.Size = new Size(51, 21);
            photoIabel.TabIndex = 1;
            photoIabel.Text = "Photo";
            photoIabel.Click += label1_Click;
            // 
            // dateFinChantInput
            // 
            dateFinChantInput.AutoSize = true;
            dateFinChantInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateFinChantInput.ForeColor = SystemColors.ButtonFace;
            dateFinChantInput.Location = new Point(12, 171);
            dateFinChantInput.Name = "dateFinChantInput";
            dateFinChantInput.Size = new Size(64, 21);
            dateFinChantInput.TabIndex = 1;
            dateFinChantInput.Text = "Date fin";
            dateFinChantInput.Click += label1_Click;
            // 
            // dateDebutChantInput
            // 
            dateDebutChantInput.AutoSize = true;
            dateDebutChantInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateDebutChantInput.ForeColor = SystemColors.ButtonFace;
            dateDebutChantInput.Location = new Point(12, 132);
            dateDebutChantInput.Name = "dateDebutChantInput";
            dateDebutChantInput.Size = new Size(107, 21);
            dateDebutChantInput.TabIndex = 1;
            dateDebutChantInput.Text = "Date de début";
            dateDebutChantInput.Click += label1_Click;
            // 
            // idProprioIabel
            // 
            idProprioIabel.AutoSize = true;
            idProprioIabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idProprioIabel.ForeColor = SystemColors.ButtonFace;
            idProprioIabel.Location = new Point(12, 96);
            idProprioIabel.Name = "idProprioIabel";
            idProprioIabel.Size = new Size(92, 21);
            idProprioIabel.TabIndex = 1;
            idProprioIabel.Text = "Proprietaire";
            idProprioIabel.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(120, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 29);
            textBox2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 37);
            label1.TabIndex = 1;
            label1.Text = "Nouveau chantier";
            label1.Click += label1_Click;
            // 
            // LieuLabelChant
            // 
            LieuLabelChant.AutoSize = true;
            LieuLabelChant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LieuLabelChant.ForeColor = SystemColors.ButtonFace;
            LieuLabelChant.Location = new Point(12, 61);
            LieuLabelChant.Name = "LieuLabelChant";
            LieuLabelChant.Size = new Size(39, 21);
            LieuLabelChant.TabIndex = 1;
            LieuLabelChant.Text = "Lieu";
            LieuLabelChant.Click += label1_Click;
            // 
            // chantLieuInput
            // 
            chantLieuInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chantLieuInput.Location = new Point(120, 53);
            chantLieuInput.Name = "chantLieuInput";
            chantLieuInput.Size = new Size(169, 29);
            chantLieuInput.TabIndex = 0;
            // 
            // AddNewChantier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 55, 77);
            ClientSize = new Size(565, 325);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNewChantier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewChantier";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictNouvChant).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LieuLabelChant;
        private TextBox chantLieuInput;
        private Label photoIabel;
        private Label dateFinChantInput;
        private Label dateDebutChantInput;
        private Label idProprioIabel;
        private TextBox textBox2;
        private DateTimePicker dateDebutChant;
        private DateTimePicker dateFinChant;
        private CheckBox enCoursChant;
        private Button ajouterphotos;
        private PictureBox pictNouvChant;
        private Button annulerBtnChant;
        private Button enregistrerNouvChant;
        private Label label1;
    }
}