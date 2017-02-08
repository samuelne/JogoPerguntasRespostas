using System;
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
    public partial class Pergunta4 : Form
    {

        public int id_jogador_banco;

        public Pergunta4(int id_jogador)
        {
            InitializeComponent();
            id_jogador_banco = id_jogador;
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {

            if (rdbResposta3.Checked == true)
            {
                MessageBox.Show("ACERTOUUU");

                //Cadastrar no banco de dados a pergunta e a resposta correta.

                string path = "Server=AME0556341W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes";
                SqlConnection conexao = new SqlConnection(path);

                SqlCommand comando = new SqlCommand();

                comando.Connection = conexao;



                //CRIA A VARIAVEL DE INSERCAO
                string insert = "INSERT INTO tb_perguntas ";
                insert += "(pergunta, resposta_correta, id_jogador)";
                insert += " VALUES ";
                insert += " ( ";

                insert += " '" + lblPergunta4.Text + "' ,";
                insert += " '" + rdbResposta3.Text + "' ,";
                insert += " '" + id_jogador_banco + "' ";


                insert += " ) ";

                //ABRE A CONEXAO
                conexao.Open();

                //PASSA O COMANDO INSERT COMPLETO
                comando.CommandText = insert;

                //EXECUTA O INSERT
                comando.ExecuteNonQuery();

                //Mensagem Salvo no banco
                MessageBox.Show("Salvo no banco");

                //FECHA A CONEXAO
                conexao.Close();

                this.Close();
            }

        }
    }
}
