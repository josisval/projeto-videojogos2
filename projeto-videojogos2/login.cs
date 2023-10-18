using System;
using System.Data.SqlClient;
using System.Drawing;

namespace projeto_videojogos2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nomeUsuario = textBox1.Text;
            string senha = textBox2.Text;

            // Verifique se os campos estão vazios
            if (string.IsNullOrEmpty(nomeUsuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos de login.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string String_Conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;";

                try
                {
                    using (SqlConnection conexao = new SqlConnection(String_Conexao))
                    {
                        string comando_sele = "SELECT COUNT(*) FROM Usuarios WHERE NomeUsuario = @NomeUsuario AND Senha = @Senha";

                        using (SqlCommand comando_login = new SqlCommand(comando_sele, conexao))
                        {
                            comando_login.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);
                            comando_login.Parameters.AddWithValue("@Senha", senha);

                            conexao.Open();
                            int count = (int)comando_login.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("Logado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                tela_inicial novoForm = new tela_inicial();
                                novoForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Login não encontrado! Por favor, verifique.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Trate exceções de forma adequada, por exemplo, exibindo uma mensagem de erro.
                    MessageBox.Show("Ocorreu um erro durante o login: " + ex.Message, "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cadastro novoForm = new cadastro();
            novoForm.Show();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Tem certeza de que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; // Cancela o fechamento do formulário se o usuário escolher "Não".
            }
        }

        private void login_Load(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastro novoForm = new cadastro();
            novoForm.Show();
        }
    }
}