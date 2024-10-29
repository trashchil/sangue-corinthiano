
namespace WindowsFormsApp1
{
    partial class Frm_Telaprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Telaprincipal));
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Btn_Doadores = new System.Windows.Forms.Button();
            this.Btn_Recptores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fechar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fechar.ForeColor = System.Drawing.Color.Red;
            this.Btn_Fechar.Location = new System.Drawing.Point(713, 12);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(75, 33);
            this.Btn_Fechar.TabIndex = 5;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = false;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Btn_Doadores
            // 
            this.Btn_Doadores.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Doadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Doadores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Doadores.ForeColor = System.Drawing.Color.White;
            this.Btn_Doadores.Location = new System.Drawing.Point(361, 156);
            this.Btn_Doadores.Name = "Btn_Doadores";
            this.Btn_Doadores.Size = new System.Drawing.Size(88, 33);
            this.Btn_Doadores.TabIndex = 6;
            this.Btn_Doadores.Text = "Doador";
            this.Btn_Doadores.UseVisualStyleBackColor = false;
            this.Btn_Doadores.Click += new System.EventHandler(this.Btn_Doadores_Click);
            // 
            // Btn_Recptores
            // 
            this.Btn_Recptores.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Recptores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Recptores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Recptores.ForeColor = System.Drawing.Color.Black;
            this.Btn_Recptores.Location = new System.Drawing.Point(361, 271);
            this.Btn_Recptores.Name = "Btn_Recptores";
            this.Btn_Recptores.Size = new System.Drawing.Size(88, 33);
            this.Btn_Recptores.TabIndex = 7;
            this.Btn_Recptores.Text = "Receptor";
            this.Btn_Recptores.UseVisualStyleBackColor = false;
            this.Btn_Recptores.Click += new System.EventHandler(this.Btn_Recptores_Click);
            // 
            // Frm_Telaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ec156c027f7dfcb824c93479265d96ba5296acef1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Recptores);
            this.Controls.Add(this.Btn_Doadores);
            this.Controls.Add(this.Btn_Fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Telaprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sangue Corinthiano";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Button Btn_Doadores;
        private System.Windows.Forms.Button Btn_Recptores;
    }
}