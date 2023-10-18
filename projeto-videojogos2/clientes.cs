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
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            try
            {
                string conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    conn.Open();
                    string comand = "SELECT id, nome, data_nasc, cpf, estado, cidade, rua, numero FROM Cliente";
                    using (SqlDataAdapter adapt = new SqlDataAdapter(comand, conn))
                    {
                        DataTable tabela = new DataTable();
                        adapt.Fill(tabela);
                        dataGridView1.DataSource = tabela;

                        dataGridView1.Columns["id"].Width = 100;
                        dataGridView1.Columns["nome"].Width = 200;
                        dataGridView1.Columns["data_nasc"].Width = 100;
                        dataGridView1.Columns["cpf"].Width = 200;
                        dataGridView1.Columns["estado"].Width = 100;
                        dataGridView1.Columns["cidade"].Width = 100;
                        dataGridView1.Columns["rua"].Width = 200;
                        dataGridView1.Columns["numero"].Width = 150;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    conn.Open();
                    string comand = "SELECT id, nome, data_nasc, cpf, estado, cidade, rua, numero FROM Cliente";
                    using (SqlDataAdapter adapt = new SqlDataAdapter(comand, conn))
                    {
                        DataTable tabela = new DataTable();
                        adapt.Fill(tabela);
                        dataGridView1.DataSource = tabela;

                        dataGridView1.Columns["id"].Width = 100;
                        dataGridView1.Columns["nome"].Width = 200;
                        dataGridView1.Columns["data_nasc"].Width = 100;
                        dataGridView1.Columns["cpf"].Width = 200;
                        dataGridView1.Columns["estado"].Width = 100;
                        dataGridView1.Columns["cidade"].Width = 100;
                        dataGridView1.Columns["rua"].Width = 200;
                        dataGridView1.Columns["numero"].Width = 150;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var adicionar = new Adicionar_cliente();
            adicionar.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editar = new Editar_cliente();
            editar.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pedidos = new pedidos();
            pedidos.Show();
            this.Close();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                using (SqlConnection conn = new SqlConnection(conexao))
                {
                    conn.Open();
                    string comand = "SELECT id, nome, data_nasc, cpf, estado, cidade, rua, numero FROM Cliente";
                    using (SqlDataAdapter adapt = new SqlDataAdapter(comand, conn))
                    {
                        DataTable tabela = new DataTable();
                        adapt.Fill(tabela);
                        dataGridView1.DataSource = tabela;

                        dataGridView1.Columns["id"].Width = 100;
                        dataGridView1.Columns["nome"].Width = 200;
                        dataGridView1.Columns["data_nasc"].Width = 100;
                        dataGridView1.Columns["cpf"].Width = 200;
                        dataGridView1.Columns["estado"].Width = 100;
                        dataGridView1.Columns["cidade"].Width = 100;
                        dataGridView1.Columns["rua"].Width = 200;
                        dataGridView1.Columns["numero"].Width = 150;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var estoque = new estoque();
            estoque.Show();
            this.Close();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_inicial tela_Inicial = new tela_inicial();
            tela_Inicial.Show();
            this.Close();
        }
    }
}
