using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CartãoVisitas
{


    public partial class frmCartao : Form
    {
        string nome;
        string telefone;
        string idade;
        string email;
        string endereco;

        public frmCartao(string _nome, string _telefone, string _idade, string _email, string _endereco)
        {
            InitializeComponent();
            nome = _nome;
            telefone = _telefone;
            idade = _idade;
            email = _email;
            endereco = _endereco;
        }

        private void frmCartao_Load(object sender, EventArgs e)
        {
            lblNome.Text = nome;
            lblTelefone.Text = telefone;
            lblIdade.Text = idade;
            lblEmail.Text = email;
            lblEndereco.Text = endereco;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {

        }
    }
}
