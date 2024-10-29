using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_Telaprincipal : Form
    {
        public Frm_Telaprincipal()
        {
            InitializeComponent();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Doadores_Click(object sender, EventArgs e)
        {
            Frm_Doadores doadores = new Frm_Doadores();
            doadores.Show();
            Hide();
        }

        private void Btn_Recptores_Click(object sender, EventArgs e)
        {
            Frm_receptores receptores = new Frm_receptores();
            receptores.Show();
            Hide();
        }
    }
}
