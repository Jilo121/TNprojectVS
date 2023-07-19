namespace Taotranon_ny_Nosy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            logoPic.SizeMode = PictureBoxSizeMode.CenterImage;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Champ à remplire!!");
            }
            else
            {
                if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    Home home = new Home();
                    this.Hide();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou Mot de passe DISO!! ");
                }
            }
        }
    }
}