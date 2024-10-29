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
    public partial class Frm_parabens : Form
    {
        public Frm_parabens()
        {
            InitializeComponent();
        }

        private void Frm_parabens_Load(object sender, EventArgs e)
        {
            Wmp_Corinthians.URL = "corinthians/timao1.mp4";//Buscando o vídeo
        }

        private void timer_timao_Tick(object sender, EventArgs e)
        {
            timer_timao.Start();
            timer_timao.Stop();
            Frm_Telaprincipal telaprincipal = new Frm_Telaprincipal();
            telaprincipal.Show();
            Hide();
        }
    }
}
