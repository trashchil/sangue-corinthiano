﻿using System;
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
    public partial class Frm_cadastrorecptores : Form
    {
        public Frm_cadastrorecptores()
        {
            InitializeComponent();
        }

        private void Variaveis_Receptores()
        {
            Variaveis.email = Txt_Email.Text;
            Variaveis.nome = Txt_nome.Text;
            Variaveis.idade = int.Parse(txt_Idade.Text);
            Variaveis.endereco = Txt_endereco.Text;
            Variaveis.bairro = Txt_bairro.Text;
            Variaveis.cep = Msk_Cep.Text;
            Variaveis.rg = Msk_Rg.Text;
            Variaveis.cpf = Msk_Cpf.Text;
            Variaveis.celular = Msk_Celular.Text;
            Variaveis.tiposangue = Txt_Sangue.Text;
        }

        public void Adicionar_Receptor()//Criando método para cadastrar socio
        {
            try
            {
                banco banco = new banco(); //instanciando o objeto banco da classe
                banco.Conectar();

                string sql = "INSERT INTO tb_recptores(id_codigo, email, nome, idade, endereco, bairro, cep, celular, rg, cpf, tipo_sanguineo)" +
                    "VALUES (DEFAULT, @email, @nome, @idade, @endereco, @bairro, @cep, @celular, @rg, @cpf, @tipo_sanguineo);";

                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

                cmd.Parameters.AddWithValue("@email", Variaveis.email);
                cmd.Parameters.AddWithValue("@nome", Variaveis.nome);
                cmd.Parameters.AddWithValue("@idade", Variaveis.idade);
                cmd.Parameters.AddWithValue("@endereco", Variaveis.endereco);
                cmd.Parameters.AddWithValue("@bairro", Variaveis.bairro);
                cmd.Parameters.AddWithValue("@cep", Variaveis.cep);
                cmd.Parameters.AddWithValue("@celular", Variaveis.celular);
                cmd.Parameters.AddWithValue("@rg", Variaveis.rg);
                cmd.Parameters.AddWithValue("@cpf", Variaveis.cpf);
                cmd.Parameters.AddWithValue("@tipo_sanguineo", Variaveis.tiposangue);

                cmd.ExecuteNonQuery();//Execultando as linhas de código do banco de dados
                banco.Desconectar();

                MessageBox.Show("Receptor cadastrado com sucesso!!!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar o Receptor...\n" + ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txt_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (Txt_Email.Text.Contains("@gmail.com") || Txt_Email.Text.Contains("@hotmail.com") || Txt_Email.Text.Contains("@outlook.com") || Txt_Email.Text.Contains("@yahoo.com"))//Aceitar somente esses emails
                {
                    Variaveis_Receptores();//usando metodo
                    Variaveis.email = Txt_Email.Text;
                    Txt_nome.Focus();
                }
                else
                {
                    MessageBox.Show("Digite um email válido!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_Email.Clear();
                    Txt_Email.Focus();
                }
            }

        }
        private void Frm_cadastrorecptores_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Email.Clear();
            Txt_nome.Clear();
            txt_Idade.Clear();
            Txt_endereco.Clear();
            Txt_bairro.Clear();
            Msk_Cep.Clear();
            Msk_Celular.Clear();
            Msk_Rg.Clear();
            Msk_Cpf.Clear();
            Txt_Sangue.Clear();
        }

        private void Txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13)
            {
                if (Txt_nome.Text != "")
                {
                    Variaveis_Receptores();
                    Variaveis.nome = Txt_nome.Text;
                    txt_Idade.Clear();
                    txt_Idade.Focus();

                }
                else
                {
                    MessageBox.Show("Digite seu Nome!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_Idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas Números!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13)
            {
                if (txt_Idade.Text != "")
                {

                    Variaveis_Receptores();
                    if ((Variaveis.idade >= 10) && (Variaveis.idade <= 99))
                    {
                        Txt_endereco.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Você não tem a idade minima permitida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Idade.Clear();
                        txt_Idade.Focus();


                    }
                }
            }
        }

        private void Txt_endereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsSymbol(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (Txt_endereco.Text != "")
                {

                    Variaveis_Receptores();
                    Variaveis.endereco = Txt_endereco.Text;
                    Txt_bairro.Focus();

                }
                else
                {
                    MessageBox.Show("Digite seu Endereço e o Número!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Txt_bairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (!char.IsSeparator(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (Txt_bairro.Text != "")
                {
                    Variaveis_Receptores();
                    Variaveis.bairro = Txt_bairro.Text;
                    Msk_Cep.Focus();

                }
                else
                {
                    MessageBox.Show("Digite seu Bairro!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Msk_Cep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Msk_Cep.MaskCompleted == true)
            {
                if (e.KeyChar == 13)
                {
                    if (Msk_Cep.Text != "")
                    {
                        Variaveis_Receptores();
                        Variaveis.cep = Msk_Cep.Text;
                        Msk_Celular.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Digite seu CEP!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Msk_Celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Msk_Celular.MaskCompleted == true)
            {



                if (e.KeyChar == 13)
                {
                    if (Msk_Celular.Text != "")
                    {
                        Variaveis_Receptores();
                        Variaveis.celular = Msk_Celular.Text;
                        Msk_Rg.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Digite seu Número!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Msk_Rg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Msk_Rg.MaskCompleted == true)
            {
                if (e.KeyChar == 13)
                {
                    if (Msk_Rg.Text != "")
                    {
                        Variaveis_Receptores();
                        Variaveis.rg = Msk_Rg.Text;
                        Msk_Cpf.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Digite seu RG!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Msk_Cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Msk_Cpf.MaskCompleted == true)
            {


                if (e.KeyChar == 13)
                {
                    if (Msk_Cpf.Text != "")
                    {
                        Variaveis_Receptores();
                        Variaveis.cpf = Msk_Cpf.Text;
                        Txt_Sangue.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Digite seu CPF!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Txt_Sangue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSymbol(e.KeyChar) && !(e.KeyChar == '-'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (Txt_Sangue.Text != "")
                {
                    Variaveis_Receptores();
                    Variaveis.endereco = Txt_Sangue.Text;
                    Btn_Salvar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Digite seu Tipo Sanguíneo, se é positivo ou negativo!!! (ex. A+)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_Sangue.Focus();
                }
            }
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
           Variaveis_Receptores();
            Adicionar_Receptor();
            Frm_parabens Parabens = new Frm_parabens();
            Parabens.Show();
            Hide();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_receptores receptores = new Frm_receptores();
            receptores.Show();
            Hide();
        }
    }
}

