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
    public partial class pedidos : Form
    {
        public pedidos()
        {
            InitializeComponent();
        }



        private void pedidos_Load(object sender, EventArgs e)
        {
            string String_Conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;";

            using (SqlConnection conexao = new SqlConnection(String_Conexao))
            {
                conexao.Open();
                string comando = "SELECT Id, Data, Estado, Produto, Quantidade, ValorUnitario, NomeComprador, FormadePagamento, ValorTotal FROM Pedidos";

                using (SqlDataAdapter adapt = new SqlDataAdapter(comando, conexao))
                {
                    DataTable data_tabela = new DataTable();
                    adapt.Fill(data_tabela);

                    dataGridView1.DataSource = data_tabela;

                    dataGridView1.Columns["Id"].Width = 50;
                    dataGridView1.Columns["Data"].Width = 100;
                    dataGridView1.Columns["Estado"].Width = 80;
                    dataGridView1.Columns["Produto"].Width = 200;
                    dataGridView1.Columns["Quantidade"].Width = 80;
                    dataGridView1.Columns["ValorUnitario"].Width = 100;
                    dataGridView1.Columns["NomeComprador"].Width = 150;
                    dataGridView1.Columns["FormadePagamento"].Width = 120;
                    dataGridView1.Columns["ValorTotal"].Width = 100;

                }
            }
        }


        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            adicionar_pedido novoForm = new adicionar_pedido();
            novoForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tela_inicial novoForm = new tela_inicial();
            novoForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AtualizarDados();
        }

        private void AtualizarDados()
        {
            try
            {
                string String_Conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;";

                using (SqlConnection conexao = new SqlConnection(String_Conexao))
                {
                    conexao.Open();
                    string comando = "SELECT Id, Data, Estado, Produto, Quantidade, ValorUnitario, NomeComprador, FormadePagamento, ValorTotal FROM Pedidos";

                    using (SqlDataAdapter adapt = new SqlDataAdapter(comando, conexao))
                    {
                        DataTable data_tabela = new DataTable();
                        adapt.Fill(data_tabela);

                        dataGridView1.DataSource = data_tabela;

                        dataGridView1.Columns["Id"].Width = 50;
                        dataGridView1.Columns["Data"].Width = 100;
                        dataGridView1.Columns["Estado"].Width = 80;
                        dataGridView1.Columns["Produto"].Width = 200;
                        dataGridView1.Columns["Quantidade"].Width = 80;
                        dataGridView1.Columns["ValorUnitario"].Width = 100;
                        dataGridView1.Columns["NomeComprador"].Width = 150;
                        dataGridView1.Columns["FormadePagamento"].Width = 120;
                        dataGridView1.Columns["ValorTotal"].Width = 100;

                    }
                }
            }
            catch (Exception ex)
            {
                // Trate exceções de forma adequada, exibindo uma mensagem de erro.
                MessageBox.Show("Ocorreu um erro durante a consulta ao banco de dados: " + ex.Message, "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var estoque = new estoque();
            estoque.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var clientes = new clientes();
            clientes.Show();
            this.Close();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            var estoque = new estoque();
            estoque.Show();
            this.Close();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            editar_pedidos novoform = new editar_pedidos();
            novoform.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            adicionar_pedido novoForm = new adicionar_pedido();
            novoForm.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var novoform = new tela_inicial();
            novoform.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AtualizarDados();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            adicionar_pedido adicionar_Pedido = new adicionar_pedido();
            adicionar_Pedido.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editar_pedidos editar_pedidos = new editar_pedidos();
            editar_pedidos.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estoque estoque = new estoque();
            estoque.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientes clientes = new clientes();
            clientes.Show();
        }
    }
}