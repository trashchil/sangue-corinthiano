
namespace WindowsFormsApp1
{
    partial class Frm_cadastrorecptores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cadastrorecptores));
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Sangue = new System.Windows.Forms.TextBox();
            this.Txt_bairro = new System.Windows.Forms.TextBox();
            this.Txt_endereco = new System.Windows.Forms.TextBox();
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Msk_Cep = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Msk_Celular = new System.Windows.Forms.MaskedTextBox();
            this.Msk_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.Msk_Rg = new System.Windows.Forms.MaskedTextBox();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fechar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fechar.ForeColor = System.Drawing.Color.Red;
            this.Btn_Fechar.Location = new System.Drawing.Point(679, 12);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(75, 33);
            this.Btn_Fechar.TabIndex = 5;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = false;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(90, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(577, 318);
            this.label3.TabIndex = 8;
            this.label3.Text = "                                                                                 " +
    "         ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Receptores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "De Sangue";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Sangue
            // 
            this.Txt_Sangue.Location = new System.Drawing.Point(375, 335);
            this.Txt_Sangue.MaxLength = 5;
            this.Txt_Sangue.Name = "Txt_Sangue";
            this.Txt_Sangue.Size = new System.Drawing.Size(76, 20);
            this.Txt_Sangue.TabIndex = 51;
            this.Txt_Sangue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Sangue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Sangue_KeyPress);
            // 
            // Txt_bairro
            // 
            this.Txt_bairro.Location = new System.Drawing.Point(176, 243);
            this.Txt_bairro.Name = "Txt_bairro";
            this.Txt_bairro.Size = new System.Drawing.Size(352, 20);
            this.Txt_bairro.TabIndex = 50;
            this.Txt_bairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_bairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_bairro_KeyPress);
            // 
            // Txt_endereco
            // 
            this.Txt_endereco.Location = new System.Drawing.Point(176, 200);
            this.Txt_endereco.Name = "Txt_endereco";
            this.Txt_endereco.Size = new System.Drawing.Size(453, 20);
            this.Txt_endereco.TabIndex = 49;
            this.Txt_endereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_endereco_KeyPress);
            // 
            // Txt_nome
            // 
            this.Txt_nome.Location = new System.Drawing.Point(176, 156);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(365, 20);
            this.Txt_nome.TabIndex = 48;
            this.Txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nome_KeyPress);
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(176, 116);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(275, 20);
            this.Txt_Email.TabIndex = 47;
            this.Txt_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Email_KeyPress);
            // 
            // Msk_Cep
            // 
            this.Msk_Cep.Location = new System.Drawing.Point(572, 243);
            this.Msk_Cep.Mask = "00000-000";
            this.Msk_Cep.Name = "Msk_Cep";
            this.Msk_Cep.Size = new System.Drawing.Size(56, 20);
            this.Msk_Cep.TabIndex = 45;
            this.Msk_Cep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Msk_Cep_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(496, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 19);
            this.label13.TabIndex = 41;
            this.label13.Text = "CPF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(330, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 19);
            this.label12.TabIndex = 40;
            this.label12.Text = "RG";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(117, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 19);
            this.label11.TabIndex = 39;
            this.label11.Text = "Celular";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(534, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 19);
            this.label10.TabIndex = 38;
            this.label10.Text = "CEP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(547, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 37;
            this.label9.Text = "Idade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(251, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "tipo Sanguíneo ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(119, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(104, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(126, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(126, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nome";
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Salvar.Enabled = false;
            this.Btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salvar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salvar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Salvar.Location = new System.Drawing.Point(93, 404);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(92, 38);
            this.Btn_Salvar.TabIndex = 52;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = false;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Limpar.Location = new System.Drawing.Point(334, 404);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(92, 38);
            this.Btn_Limpar.TabIndex = 53;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = false;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Voltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Voltar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Voltar.Location = new System.Drawing.Point(575, 404);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(92, 38);
            this.Btn_Voltar.TabIndex = 54;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = false;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Msk_Celular
            // 
            this.Msk_Celular.Location = new System.Drawing.Point(176, 287);
            this.Msk_Celular.Mask = "(00) 00000-0000";
            this.Msk_Celular.Name = "Msk_Celular";
            this.Msk_Celular.Size = new System.Drawing.Size(85, 20);
            this.Msk_Celular.TabIndex = 55;
            this.Msk_Celular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Msk_Celular_KeyPress);
            // 
            // Msk_Cpf
            // 
            this.Msk_Cpf.Location = new System.Drawing.Point(546, 287);
            this.Msk_Cpf.Mask = "000,000,000-00";
            this.Msk_Cpf.Name = "Msk_Cpf";
            this.Msk_Cpf.Size = new System.Drawing.Size(83, 20);
            this.Msk_Cpf.TabIndex = 56;
            this.Msk_Cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Msk_Cpf_KeyPress);
            // 
            // Msk_Rg
            // 
            this.Msk_Rg.Location = new System.Drawing.Point(375, 288);
            this.Msk_Rg.Mask = "00,000,000->a";
            this.Msk_Rg.Name = "Msk_Rg";
            this.Msk_Rg.Size = new System.Drawing.Size(76, 20);
            this.Msk_Rg.TabIndex = 57;
            this.Msk_Rg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Msk_Rg_KeyPress);
            // 
            // txt_Idade
            // 
            this.txt_Idade.Location = new System.Drawing.Point(607, 156);
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(22, 20);
            this.txt_Idade.TabIndex = 58;
            this.txt_Idade.Text = "0";
            this.txt_Idade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Idade_KeyPress);
            // 
            // Frm_cadastrorecptores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._8242a365e85bd00ecde5bea2b53e8100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 454);
            this.Controls.Add(this.txt_Idade);
            this.Controls.Add(this.Msk_Rg);
            this.Controls.Add(this.Msk_Cpf);
            this.Controls.Add(this.Msk_Celular);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Txt_Sangue);
            this.Controls.Add(this.Txt_bairro);
            this.Controls.Add(this.Txt_endereco);
            this.Controls.Add(this.Txt_nome);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Msk_Cep);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Fechar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_cadastrorecptores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sangue Corinthiano";
            this.Load += new System.EventHandler(this.Frm_cadastrorecptores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Sangue;
        private System.Windows.Forms.TextBox Txt_bairro;
        private System.Windows.Forms.TextBox Txt_endereco;
        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.MaskedTextBox Msk_Cep;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.MaskedTextBox Msk_Celular;
        private System.Windows.Forms.MaskedTextBox Msk_Cpf;
        private System.Windows.Forms.MaskedTextBox Msk_Rg;
        private System.Windows.Forms.TextBox txt_Idade;
    }
}