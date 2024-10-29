
namespace WindowsFormsApp1
{
    partial class Frm_receptores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_receptores));
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Dvg_Recptores = new System.Windows.Forms.DataGridView();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Recptores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-7, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(809, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.AutoSize = true;
            this.Btn_Fechar.BackColor = System.Drawing.Color.Black;
            this.Btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fechar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fechar.ForeColor = System.Drawing.Color.Red;
            this.Btn_Fechar.Location = new System.Drawing.Point(713, 12);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(75, 33);
            this.Btn_Fechar.TabIndex = 7;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = false;
            this.Btn_Fechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(-7, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(809, 60);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Dvg_Recptores
            // 
            this.Dvg_Recptores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_Recptores.Location = new System.Drawing.Point(-4, 52);
            this.Dvg_Recptores.Name = "Dvg_Recptores";
            this.Dvg_Recptores.Size = new System.Drawing.Size(806, 348);
            this.Dvg_Recptores.TabIndex = 9;
            this.Dvg_Recptores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvg_Recptores_CellContentClick);
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.Black;
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.ForeColor = System.Drawing.Color.SeaShell;
            this.Btn_Add.Location = new System.Drawing.Point(160, 406);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(100, 38);
            this.Btn_Add.TabIndex = 10;
            this.Btn_Add.Text = "Adicionar";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.Color.Black;
            this.Btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Voltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.ForeColor = System.Drawing.Color.SeaShell;
            this.Btn_Voltar.Location = new System.Drawing.Point(545, 406);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(100, 38);
            this.Btn_Voltar.TabIndex = 11;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Frm_receptores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Dvg_Recptores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_receptores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sangue Corinthiano";
            this.Load += new System.EventHandler(this.Frm_receptores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_Recptores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dvg_Recptores;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Voltar;
    }
}