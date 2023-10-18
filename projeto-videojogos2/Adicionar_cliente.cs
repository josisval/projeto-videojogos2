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
    public partial class Adicionar_cliente : Form
    {
        public Adicionar_cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    if (!string.IsNullOrEmpty(textBox4.Text))
                    {
                        if (!string.IsNullOrEmpty(maskedTextBox1.Text))
                        {
                            var cpf = maskedTextBox1.Text;
                            var nasc = dateTimePicker1.Value;
                            var estado = textBox2.Text;
                            var cidade = textBox3.Text;
                            var rua = Convert.ToInt32(textBox4.Text);
                                string String_Conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sistema-jogos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

                            using (SqlConnection conexao = new SqlConnection(String_Conexao))
                            {

                                try
                                {
                                    conexao.Open();
                                    string command = "INSERT INTO Clientes ";
                                }
                                catch (Exception ex)
                                {

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("O campo CPF está vazio", "erro", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("O campo numero está vazio", "erro", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("O campo rua está vazio", "erro", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("O campo cidade está vazio", "erro", MessageBoxButtons.OK);
            }
        }
    }
}
