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
    public partial class Frm_Doadores : Form
    {
        public Frm_Doadores()
        {
            InitializeComponent();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Telaprincipal telaprincipal = new Frm_Telaprincipal();
            telaprincipal.Show();
            Hide();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Frm_cadastrodoadores doadores = new Frm_cadastrodoadores();
            doadores.Show();
            Hide();
        }
        public void Carregar_Doador()
        {
            try
            {
                banco banco = new banco();
                banco.Conectar();

                string sql = "SELECT * FROM tb_doadores;";

                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

                MySqlDataAdapter dados = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                dados.Fill(dt);

                Dvg_Doadores.DataSource = dt;

                banco.Desconectar();
            }
            catch
            {
                MessageBox.Show("Erro ao Carregar a Lista de Doadores...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Doadores_Load(object sender, EventArgs e)
        {
            Carregar_Doador();
        }
    }
}
