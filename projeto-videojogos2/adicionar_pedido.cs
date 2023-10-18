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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projeto_videojogos2
{
    public partial class adicionar_pedido : Form
    {
        public adicionar_pedido()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifique se todos os campos necessários estão preenchidos
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) ||
                comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos do pedido.", "Erro de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string String_Conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

            using (SqlConnection conexao = new SqlConnection(String_Conexao))
            {
                try
                {
                    conexao.Open();
                    string comando = "INSERT INTO Pedidos (Data, Estado, Produto, Quantidade, ValorUnitario, NomeComprador, FormadePagamento, ValorTotal) " +
                                     "VALUES (@Data, @Estado, @Produto, @Quantidade, @ValorUnitario, @NomeComprador, @FormaPagamento, @ValorTotal)";

                    using (SqlCommand cmd = new SqlCommand(comando, conexao))
                    {
                        // Parâmetros para a consulta SQL
                        cmd.Parameters.AddWithValue("@Data", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@Estado", comboBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Produto", comboBox2.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Quantidade", textBox1.Text);
                        cmd.Parameters.AddWithValue("@ValorUnitario", Convert.ToDecimal(textBox2.Text));
                        cmd.Parameters.AddWithValue("@NomeComprador", textBox4.Text);
                        cmd.Parameters.AddWithValue("@FormaPagamento", textBox3.Text);

                        // Calcular o valor total
                        decimal quantidade = Convert.ToDecimal(textBox1.Text);
                        decimal valorUnitario = Convert.ToDecimal(textBox2.Text);
                        decimal total = quantidade * valorUnitario;

                        cmd.Parameters.AddWithValue("@ValorTotal", total);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Pedido cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar o pedido: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CarregarProdutos()
        {
            try
            {
                string String_Conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;";

                using (SqlConnection conexao = new SqlConnection(String_Conexao))
                {
                    conexao.Open();
                    string comando = "SELECT NomeJogo FROM Estoque";

                    using (SqlCommand cmd = new SqlCommand(comando, conexao))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox2.Items.Add(reader["NomeJogo"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos do estoque: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adicionar_pedido_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }


    }
}
