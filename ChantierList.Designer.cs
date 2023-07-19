namespace Taotranon_ny_Nosy
{
    partial class ChantierList
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            SearchBtnChant = new Button();
            addBtnChant = new Button();
            aboutBtnChant = new Button();
            delBtnChantL = new Button();
            button4 = new Button();
            textBoxSearchChant = new TextBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            viewChant1 = new viewChant();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SearchBtnChant
            // 
            SearchBtnChant.FlatStyle = FlatStyle.Flat;
            SearchBtnChant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchBtnChant.ForeColor = SystemColors.ButtonFace;
            SearchBtnChant.Location = new Point(752, 34);
            SearchBtnChant.Margin = new Padding(4);
            SearchBtnChant.Name = "SearchBtnChant";
            SearchBtnChant.Size = new Size(132, 39);
            SearchBtnChant.TabIndex = 1;
            SearchBtnChant.Text = "Rechercher";
            SearchBtnChant.UseVisualStyleBackColor = true;
            SearchBtnChant.Click += SearchBtnChant_Click;
            // 
            // addBtnChant
            // 
            addBtnChant.FlatStyle = FlatStyle.Flat;
            addBtnChant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addBtnChant.ForeColor = SystemColors.ButtonFace;
            addBtnChant.Location = new Point(4, 80);
            addBtnChant.Margin = new Padding(4);
            addBtnChant.Name = "addBtnChant";
            addBtnChant.Size = new Size(132, 39);
            addBtnChant.TabIndex = 1;
            addBtnChant.Text = "Nouveau";
            addBtnChant.UseVisualStyleBackColor = true;
            addBtnChant.Click += addBtnChant_Click;
            // 
            // aboutBtnChant
            // 
            aboutBtnChant.FlatStyle = FlatStyle.Flat;
            aboutBtnChant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aboutBtnChant.ForeColor = SystemColors.ButtonFace;
            aboutBtnChant.Location = new Point(4, 127);
            aboutBtnChant.Margin = new Padding(4);
            aboutBtnChant.Name = "aboutBtnChant";
            aboutBtnChant.Size = new Size(132, 39);
            aboutBtnChant.TabIndex = 1;
            aboutBtnChant.Text = "Proprieté";
            aboutBtnChant.UseVisualStyleBackColor = true;
            // 
            // delBtnChantL
            // 
            delBtnChantL.FlatStyle = FlatStyle.Flat;
            delBtnChantL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            delBtnChantL.ForeColor = SystemColors.ButtonFace;
            delBtnChantL.Location = new Point(4, 223);
            delBtnChantL.Margin = new Padding(4);
            delBtnChantL.Name = "delBtnChantL";
            delBtnChantL.Size = new Size(132, 39);
            delBtnChantL.TabIndex = 1;
            delBtnChantL.Text = "Supprimer";
            delBtnChantL.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(4, 175);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(132, 39);
            button4.TabIndex = 1;
            button4.Text = "Ouvrier";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBoxSearchChant
            // 
            textBoxSearchChant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearchChant.Location = new Point(391, 40);
            textBoxSearchChant.Margin = new Padding(4);
            textBoxSearchChant.Name = "textBoxSearchChant";
            textBoxSearchChant.Size = new Size(338, 29);
            textBoxSearchChant.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(228, 48);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 3;
            label1.Text = "Entrer nom ou lieu :";
            label1.Click += label1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(viewChant1);
            flowLayoutPanel1.Location = new Point(164, 84);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(787, 500);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // viewChant1
            // 
            viewChant1.Location = new Point(4, 4);
            viewChant1.Margin = new Padding(4, 4, 4, 4);
            viewChant1.Name = "viewChant1";
            viewChant1.Size = new Size(306, 139);
            viewChant1.TabIndex = 0;
            // 
            // ChantierList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 55, 77);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(textBoxSearchChant);
            Controls.Add(button4);
            Controls.Add(delBtnChantL);
            Controls.Add(aboutBtnChant);
            Controls.Add(addBtnChant);
            Controls.Add(SearchBtnChant);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ChantierList";
            Size = new Size(973, 602);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchBtnChant;
        private Button addBtnChant;
        private Button aboutBtnChant;
        private Button delBtnChantL;
        private Button button4;
        private TextBox textBoxSearchChant;
        private Label label1;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private viewChant viewChant1;
    }
}
