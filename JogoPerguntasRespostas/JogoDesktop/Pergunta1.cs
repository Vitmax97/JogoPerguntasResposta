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
    public partial class Pergunta1 : Form

    {
        public int id_jogador_banco;

        public Pergunta1(int id_jogador)
        {
            InitializeComponent();
            id_jogador_banco = id_jogador;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdbResposta3_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbResposta3.Checked == true)
            {
                MessageBox.Show("Acertou!");
                //início do código para inserir o jogador na tabela
                //using System.Data.SqlClient;
                using (SqlConnection conexao = new SqlConnection("Server=AME0556318W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
                {
                    using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(pergunta, resposta_correta, id_jogador) values(@PERGUNTA, @RESPOSTA3, @ID_JOGADOR)", conexao))
                    {
                        comando.Parameters.AddWithValue("PERGUNTA", lblPergunta.Text);
                        comando.Parameters.AddWithValue("RESPOSTA3", rdbResposta3.Text);
                        comando.Parameters.AddWithValue("ID_JOGADOR", id_jogador_banco);
                        conexao.Open();
                        comando.ExecuteNonQuery();



                    }
                }

            }
            else
            {
                MessageBox.Show("Errou");

            }
            
        }
    }
}
