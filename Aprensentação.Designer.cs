
namespace WindowsFormsApp1
{
    partial class frm_video
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_video));
            this.Timer_video = new System.Windows.Forms.Timer(this.components);
            this.Wmp_Corinthians = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Wmp_Corinthians)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_video
            // 
            this.Timer_video.Enabled = true;
            this.Timer_video.Interval = 85000;
            this.Timer_video.Tick += new System.EventHandler(this.Timer_video_Tick);
            // 
            // Wmp_Corinthians
            // 
            this.Wmp_Corinthians.Enabled = true;
            this.Wmp_Corinthians.Location = new System.Drawing.Point(0, 0);
            this.Wmp_Corinthians.Name = "Wmp_Corinthians";
            this.Wmp_Corinthians.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Wmp_Corinthians.OcxState")));
            this.Wmp_Corinthians.Size = new System.Drawing.Size(800, 451);
            this.Wmp_Corinthians.TabIndex = 0;
            // 
            // frm_video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.sanguecorinthiano;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Wmp_Corinthians);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_video";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sangue Corinthiano";
            this.Load += new System.EventHandler(this.frm_video_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wmp_Corinthians)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer_video;
        private AxWMPLib.AxWindowsMediaPlayer Wmp_Corinthians;
    }
}

