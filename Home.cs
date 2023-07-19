using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Taotranon_ny_Nosy
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void ouvrierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ajouterEmployerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void employerBtnLeftClick(object sender, EventArgs e)
        {
            barSelect.Height = emplBtnLeft.Height;
            barSelect.Top = emplBtnLeft.Top;
            chantierList1.Hide();
        }

        private void chantierLeft_Click(object sender, EventArgs e)
        {
            barSelect.Top = chantBtnLeft.Top;
            barSelect.Height = chantBtnLeft.Height;
            chantierList1.Show();
        }

        private void barSelect_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chantierList1_Load(object sender, EventArgs e)
        {

        }

        private void repartitionLeft(object sender, EventArgs e)
        {
            barSelect.Top = repartBtnLeft.Top;
            barSelect.Height = repartBtnLeft.Height;
        }

        private void salaireBtnClick(object sender, EventArgs e)
        {
            barSelect.Top = salaireBtnLeft.Top;
            barSelect.Height = salaireBtnLeft.Height;
        }
    }
}
