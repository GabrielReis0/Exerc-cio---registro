namespace Exercício___registro
{
    public partial class Form1 : Form
    {
        private Utilizador utilizador;
        public Form1()
        {
            InitializeComponent();
            utilizador = new Utilizador();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utilizador.Nome = textBox1.Text;
            Utilizador.Email = textBox2.Text;
            Utilizador.Password = textBox3.Text;
            MessageBox.Show("Utilizador Guardado!"); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox3.PasswordChar = '•';
            }
        }
    }
}