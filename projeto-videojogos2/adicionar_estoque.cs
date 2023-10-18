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
    public partial class adicionar_estoque : Form
    {
        public adicionar_estoque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeJogo = textBox1.Text;
                string categoria = textBox4.Text;
                decimal preco;
                int quantidadeDisponivel;

                // Tratamento de erros de conversão para decimal e int
                if (!decimal.TryParse(textBox2.Text, out preco))
                {
                    MessageBox.Show("Preço inválido. Certifique-se de inserir um valor numérico válido.", "Erro de Preço", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(textBox3.Text, out quantidadeDisponivel))
                {
                    MessageBox.Show("Quantidade inválida. Certifique-se de inserir um valor numérico válido.", "Erro de Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string String_Conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;";
                using (SqlConnection conexao = new SqlConnection(String_Conexao))
                {
                    conexao.Open();
                    string comando = "INSERT INTO Estoque (NomeJogo, Categoria, Preco, QuantidadeDisponivel) VALUES (@NomeJogo, @Categoria, @Preco, @QuantidadeDisponivel)";

                    using (SqlCommand command = new SqlCommand(comando, conexao))
                    {
                        command.Parameters.AddWithValue("@NomeJogo", nomeJogo);
                        command.Parameters.AddWithValue("@Categoria", categoria);
                        command.Parameters.AddWithValue("@Preco", preco);
                        command.Parameters.AddWithValue("@QuantidadeDisponivel", quantidadeDisponivel);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Item cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                // Trate exceções específicas do SQL Server
                MessageBox.Show("Ocorreu um erro durante a inserção no banco de dados: " + ex.Message, "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Trate outras exceções gerais
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
