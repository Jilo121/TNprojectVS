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
    public partial class ChantierList : UserControl
    {
        public ChantierList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtnChant_Click(object sender, EventArgs e)
        {

        }

        private void addBtnChant_Click(object sender, EventArgs e)
        {
            AddNewChantier ajouterNouveau = new AddNewChantier();
            ajouterNouveau.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
