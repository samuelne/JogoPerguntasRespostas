﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDesktop
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {

            if(txtNome.Text == "")
            {
                txtNome.Text = "Digite seu nome";
            }

        }

        private void frmInicial_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "Digite seu nome")
            {
                MessageBox.Show("Você deve informar seu nome", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }else{

                //início do código para inserir o jogador na tabela
                //using System.Data.SqlClient;
                using (SqlConnection conexao = new SqlConnection("Server=AME0556341W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
                {

                    // OUTPUT INSERTED.ID pega o id da tabela tb_jogador
                    using(SqlCommand comando = new SqlCommand("insert into tb_jogador(nome) OUTPUT INSERTED.ID values(@NOME)",conexao))
                    {
                        comando.Parameters.AddWithValue("NOME", txtNome.Text);
                        conexao.Open();
                        int id_jogador;
                        id_jogador = (int)comando.ExecuteScalar();
                        

                        

                        if (id_jogador > 0)
                        {


                            //MessageBox.Show("O id do jogador inserido foi: " + id_jogador);

                            MessageBox.Show("Olá " + txtNome.Text.ToUpper() + ". Você está pronto para continuar!!!", "PLAYYYY", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



                            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                            player.SoundLocation = "c:\\vm\\teste\\som.wav";
                            player.Play();

                            Pergunta1 p1 = new Pergunta1(id_jogador);
                            p1.ShowDialog();

                            Pergunta2 p2 = new Pergunta2(id_jogador);
                            p2.ShowDialog();

                            Pergunta3 p3 = new Pergunta3(id_jogador);
                            p3.ShowDialog();
                           

                        }
                        else
                        {
                            MessageBox.Show("DEU RUIMMMM!!!! Algo aconteceu durante o insert");
                        }
                    }
                }
                //fim do código para inserir o jogador na tabela
            }
        }
    }
}
