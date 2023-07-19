using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taotranon_ny_Nosy
{
    public partial class AddNewChantier : Form
    {
        public AddNewChantier()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void pictNouvChant_Click(object sender, EventArgs e)
        {

        }

        void addPicsClick(object sender, EventArgs e)
        {
            String imageLocalisation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpeg files(*.jpeg)|*.jpeg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocalisation = dialog.FileName;
                    pictNouvChant.ImageLocation = imageLocalisation;
                    pictNouvChant.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void annulerBtn(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
