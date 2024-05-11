namespace CartãoVisitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string idade = txtIdade.Text;
            string telefone = maskedTXT.Text;
            string email = txtEmail.Text;
            string endereco = txtEndereco.Text;

            frmCartao frmCartao = new frmCartao(nome, telefone, idade, email, endereco);
            frmCartao.ShowDialog();


        }

    }
}