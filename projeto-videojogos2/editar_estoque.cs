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
    public partial class editar_estoque : Form
    {
        public editar_estoque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idParaAdicionar;
            int quantidadeParaAdicionar;

            if (int.TryParse(textBox1.Text, out idParaAdicionar) &&
                int.TryParse(textBox2.Text, out quantidadeParaAdicionar))
            {
                string String_Conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;";

                using (SqlConnection conexao = new SqlConnection(String_Conexao))
                {
                    conexao.Open();

                    // Verifica se o registro com o ID especificado existe
                    string idExistir = "SELECT COUNT(*) FROM Estoque WHERE Id = @Id";
                    using (SqlCommand comando = new SqlCommand(idExistir, conexao))
                    {
                        comando.Parameters.AddWithValue("@Id", idParaAdicionar);
                        int count = (int)comando.ExecuteScalar();

                        if (count > 0)
                        {
                            // Atualiza a quantidade no registro existente
                            string comando_estoque = "UPDATE Estoque SET QuantidadeDisponivel = QuantidadeDisponivel + @Adicionar WHERE Id = @Id";
                            using (SqlCommand updateCommand = new SqlCommand(comando_estoque, conexao))
                            {
                                updateCommand.Parameters.AddWithValue("@Adicionar", quantidadeParaAdicionar);
                                updateCommand.Parameters.AddWithValue("@Id", idParaAdicionar);

                                int tabafetada = updateCommand.ExecuteNonQuery();

                                if (tabafetada > 0)
                                {
                                    MessageBox.Show($"Quantidade adicionada com sucesso ao registro com ID {idParaAdicionar}.");
                                }
                                else
                                {
                                    MessageBox.Show("Não foi possível atualizar a quantidade.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado com o ID especificado.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID e uma quantidade válida.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idParaRemover;
            int quantidadeParaRemover;

            if (!int.TryParse(textBox1.Text, out idParaRemover) ||
                !int.TryParse(textBox2.Text, out quantidadeParaRemover))
            {
                MessageBox.Show("Por favor, insira um ID e uma quantidade válida.");
                return;
            }

            string String_Conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;";
            using (SqlConnection conexao = new SqlConnection(String_Conexao))
            {
                conexao.Open();

                string idExistir = "SELECT COUNT(*) FROM Estoque WHERE Id = @Id";
                using (SqlCommand comando = new SqlCommand(idExistir, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", idParaRemover);
                    int count = (int)comando.ExecuteScalar();
                    if (count > 0)
                    {
                        string comando_estoque = "UPDATE Estoque SET QuantidadeDisponivel = QuantidadeDisponivel - @Remover WHERE Id = @Id";
                        using (SqlCommand updateCommand = new SqlCommand(comando_estoque, conexao))
                        {
                            updateCommand.Parameters.AddWithValue("@Remover", quantidadeParaRemover);
                            updateCommand.Parameters.AddWithValue("@Id", idParaRemover);

                            int tabafeta = updateCommand.ExecuteNonQuery();

                            if (tabafeta > 0)
                            {
                                MessageBox.Show($"Quantidade removida com sucesso do registro com ID {idParaRemover}.");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Não foi possível atualizar a quantidade.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado com o ID especificado.");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idParaDeletar;

            if (int.TryParse(textBox1.Text, out idParaDeletar))
            {
                string String_Conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;";

                using (SqlConnection conexao = new SqlConnection(String_Conexao))
                {
                    conexao.Open();

                    string comando = "DELETE FROM Estoque WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(comando, conexao))
                    {
                        command.Parameters.AddWithValue("@Id", idParaDeletar);
                        int tabafetada = command.ExecuteNonQuery();

                        if (tabafetada > 0)
                        {
                            MessageBox.Show("Registro excluído com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado com o ID especificado.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID válido.");
            }
        }
    }
}
