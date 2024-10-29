
namespace WindowsFormsApp1
{
    partial class Frm_parabens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_parabens));
            this.Wmp_Corinthians = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer_timao = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Wmp_Corinthians)).BeginInit();
            this.SuspendLayout();
            // 
            // Wmp_Corinthians
            // 
            this.Wmp_Corinthians.Enabled = true;
            this.Wmp_Corinthians.Location = new System.Drawing.Point(-1, 0);
            this.Wmp_Corinthians.Name = "Wmp_Corinthians";
            this.Wmp_Corinthians.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Wmp_Corinthians.OcxState")));
            this.Wmp_Corinthians.Size = new System.Drawing.Size(802, 452);
            this.Wmp_Corinthians.TabIndex = 0;
            // 
            // timer_timao
            // 
            this.timer_timao.Enabled = true;
            this.timer_timao.Interval = 24000;
            this.timer_timao.Tick += new System.EventHandler(this.timer_timao_Tick);
            // 
            // Frm_parabens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Wmp_Corinthians);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_parabens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sangue Corinthiano";
            this.Load += new System.EventHandler(this.Frm_parabens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wmp_Corinthians)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Wmp_Corinthians;
        private System.Windows.Forms.Timer timer_timao;
    }
}