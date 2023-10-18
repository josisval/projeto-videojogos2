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
    public partial class estoque : Form
    {
        public estoque()
        {
            InitializeComponent();
        }

        private void estoque_Load_1(object sender, EventArgs e)
        {
            try
            {
                string String_Conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;";

                using (SqlConnection conexao = new SqlConnection(String_Conexao))
                {
                    conexao.Open();
                    string comando = "SELECT ID, NomeJogo, Categoria, Preco, QuantidadeDisponivel FROM Estoque";

                    using (SqlDataAdapter adapt = new SqlDataAdapter(comando, conexao))
                    {
                        DataTable data_tabela = new DataTable();
                        adapt.Fill(data_tabela);

                        dataGridView1.DataSource = data_tabela;

                        dataGridView1.Columns["NomeJogo"].Width = 220;
                        dataGridView1.Columns["Categoria"].Width = 220;
                        dataGridView1.Columns["Preco"].Width = 150;
                        dataGridView1.Columns["QuantidadeDisponivel"].Width = 150;
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate exceções de forma adequada, exibindo uma mensagem de erro.
                MessageBox.Show("Ocorreu um erro durante a consulta ao banco de dados: " + ex.Message, "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            adicionar_estoque adicionar_Estoque = new adicionar_estoque();
            adicionar_Estoque.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editar_estoque editar_Estoque = new editar_estoque();
            editar_Estoque.Show();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string String_Conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;";

                using (SqlConnection conexao = new SqlConnection(String_Conexao))
                {
                    conexao.Open();
                    string comando = "SELECT ID, NomeJogo, Categoria, Preco, QuantidadeDisponivel FROM Estoque";

                    using (SqlDataAdapter adapt = new SqlDataAdapter(comando, conexao))
                    {
                        DataTable data_tabela = new DataTable();
                        adapt.Fill(data_tabela);

                        dataGridView1.DataSource = data_tabela;

                        dataGridView1.Columns["NomeJogo"].Width = 220;
                        dataGridView1.Columns["Categoria"].Width = 220;
                        dataGridView1.Columns["Preco"].Width = 150;
                        dataGridView1.Columns["QuantidadeDisponivel"].Width = 150;
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate exceções de forma adequada, exibindo uma mensagem de erro.
                MessageBox.Show("Ocorreu um erro durante a consulta ao banco de dados: " + ex.Message, "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

