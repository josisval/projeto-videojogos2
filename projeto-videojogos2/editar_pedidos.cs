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
    public partial class editar_pedidos : Form
    {
        public editar_pedidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(textBox1.Text, out id))
            {
                // Obtém o novo estado selecionado na ComboBox
                string novoEstado = comboBox1.SelectedItem.ToString();

                if (novoEstado != null)
                {
                    try
                    {
                        string String_Conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;";
                        using (SqlConnection conexao = new SqlConnection(String_Conexao))
                        {
                            conexao.Open();
                            string comando = "UPDATE Pedidos SET Estado = @NovoEstado WHERE Id = @Id";

                            using (SqlCommand sqlCommand = new SqlCommand(comando, conexao))
                            {
                                sqlCommand.Parameters.AddWithValue("@NovoEstado", novoEstado);
                                sqlCommand.Parameters.AddWithValue("@Id", id);

                                int linhasAfetadas = sqlCommand.ExecuteNonQuery();

                                if (linhasAfetadas > 0)
                                {
                                    MessageBox.Show("Estado atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Nenhum registro foi atualizado. Verifique o ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao atualizar o estado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um novo estado na ComboBox.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Digite um ID válido na TextBox.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }