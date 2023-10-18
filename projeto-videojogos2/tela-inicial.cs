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
    public partial class tela_inicial : Form
    {
        public tela_inicial()
        {
            InitializeComponent();
        }

        private void tela_inicial_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //Abrir pagina 'ESTOQUE'
            estoque novoForm = new estoque();
            novoForm.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


            //Abrir pagina 'CLIENTES'
            clientes novoForm = new clientes();
            novoForm.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Abrir pagina 'PEDIDOS'
            pedidos novoForm = new pedidos();
            novoForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Voltar um FORMS 
            login novoForm = new login();
            novoForm.Show();
            this.Close();
        }

        private void tela_inicial_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            pedidos novoForm = new pedidos();
            novoForm.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Voltar um FORMS 
            login novoForm = new login();
            novoForm.Show();
            this.Close();
        }

        private void tela_inicial_Load_1(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //Abrir pagina 'CLIENTES'
            clientes novoForm = new clientes();
            novoForm.Show();
            this.Close();
        }
    }
}
