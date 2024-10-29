using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class banco
    {
        //criando a string de conexão com a localição do banco de dados

        string bd = "SERVER=localhost;USER=root;DATABASE=sangue_corinthiano";

        //Criando a conexão com o Banco Dados

        public MySqlConnection conexao;

        //criando o métoda conectar
        public void Conectar()
        {
            //Se a tentativa de conexão for verdadeira

            try
            {
                //Recebendo a localização do nosso banco de dados

                conexao = new MySqlConnection(bd);
                conexao.Open(); //Abrindo o banco Dados 
            }
            catch //se ocorrer falha de conexão
            {
                MessageBox.Show("Erro ao Tentar Fazer Conexão com o Banco de Dados!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Desconectar()
        {
            try
            {
                conexao = new MySqlConnection(bd);
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao Tentar Desconectar o Banco de Dados!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
