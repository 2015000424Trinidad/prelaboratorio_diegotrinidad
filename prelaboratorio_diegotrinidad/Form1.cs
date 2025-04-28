namespace prelaboratorio_diegotrinidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "donbosco")
            {
                crud v1 = new crud();
                v1.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("La contraseña es incorrecta");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            creditos v2 =new creditos();
            v2.Show();
            this.Hide();
        }
    }
}
