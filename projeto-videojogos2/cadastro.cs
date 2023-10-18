using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_videojogos2
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos de cadastro.", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string nomeUsuario = textBox1.Text;
                    string senha = textBox2.Text;

                    string String_Conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                    using (SqlConnection conexao = new SqlConnection(String_Conexao))
                    {
                        string inserirAcao = "INSERT INTO Usuarios (NomeUsuario, Senha) VALUES (@NomeUsuario, @Senha)";
                        using (SqlCommand comando = new SqlCommand(inserirAcao, conexao))
                        {
                            comando.Parameters.AddWithValue("@NomeUsuario", nomeUsuario);
                            comando.Parameters.AddWithValue("@Senha", senha);

                            conexao.Open();
                            comando.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                // Trate exceções de forma adequada, exibindo uma mensagem de erro.
                MessageBox.Show("Ocorreu um erro durante o cadastro: " + ex.Message, "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cadastro_Load(object sender, EventArgs e)
        {

        }

        private void cadastro_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
