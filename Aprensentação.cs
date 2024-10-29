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
    public partial class frm_video : Form
    {
        public frm_video()
        {
            InitializeComponent();
        }

        private void frm_video_Load(object sender, EventArgs e)
        {
            Wmp_Corinthians.URL = "#vivemosdecorinthians.mp4";//Buscando o vídeo
        }

        private void Timer_video_Tick(object sender, EventArgs e)
        {
            Timer_video.Start();
            Timer_video.Stop();
            Frm_Telaprincipal telaprincipal = new Frm_Telaprincipal();
            telaprincipal.Show();
            Hide();
        }
    }
}
