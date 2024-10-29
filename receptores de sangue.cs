using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Frm_receptores : Form
    {
        public Frm_receptores()
        {
            InitializeComponent();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Frm_cadastrorecptores recptores = new Frm_cadastrorecptores();
            recptores.Show();
            Hide();
        }

        private void Dvg_Recptores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Telaprincipal telaprincipal = new Frm_Telaprincipal();
            telaprincipal.Show();
            Hide();

        }

        public void Carregar_receptor()
        {
            try
            {
                banco banco = new banco();
                banco.Conectar();

                string sql = "SELECT * FROM tb_recptores;";

                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

                MySqlDataAdapter dados = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                dados.Fill(dt);

                Dvg_Recptores.DataSource = dt;

                banco.Desconectar();
            }
            catch
            {
                MessageBox.Show("Erro ao Carregar a Lista de Receptores...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_receptores_Load(object sender, EventArgs e)
        {
            Carregar_receptor();
        }
    }
}
