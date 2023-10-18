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
    public partial class Editar_cliente : Form
    {
        public Editar_cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if(comboBox1.SelectedItem == null) 
                { 
                    if (!string.IsNullOrEmpty(textBox2.Text)) 
                    {
                        if (string.IsNullOrEmpty(textBox3.Text))
                        {
                            if (string.IsNullOrEmpty(textBox4.Text))
                            {
                                var id = textBox1.Text;
                                var estado = comboBox1.SelectedItem.ToString();
                                var cidade = textBox2.Text;
                                var rua = textBox3.Text;
                                var numero = textBox4.Text;
                                try
                                {
                                    string String_Conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;";
                                    using (SqlConnection conexao = new SqlConnection(String_Conexao))
                                    {
                                        conexao.Open();
                                        String command = "UPDATE Clientes SET Estado, Cidade, Rua, Numero = @Estado, @Cidade, @Rua, @Numero WHERE Id = @Id";
                                        using (SqlCommand sqlCommand = new SqlCommand(command, conexao))
                                        {
                                            sqlCommand.Parameters.AddWithValue("@Estado", estado);
                                            sqlCommand.Parameters.AddWithValue("@Cidade", cidade);
                                            sqlCommand.Parameters.AddWithValue("@Rua", rua);
                                            sqlCommand.Parameters.AddWithValue("@Numero", numero);
                                            sqlCommand.Parameters.AddWithValue("@Id", id);

                                        }
                                    }
                                }catch(Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("O campo numero está vazio");
                            }
                        }
                        else
                        {
                            MessageBox.Show("O campo rua está vazio");
                        }
                    }
                    else
                    {
                        MessageBox.Show("O campo cidade está vazio");
                    }
                }
                else
                {
                    MessageBox.Show("O campo Estado está vazio");
                }
            }
            else
            {
                MessageBox.Show("O campo Id está vazio");
            }
        }
    }
}
