using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using test_delivery.Conexão;
using System.Windows.Forms;

namespace test_delivery
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
     
        public Cadastro(String login, String senha, String cargo)
        {
            StringBuilder errorMessages = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            //Comando SQL --- SqlCommand
            cmd.CommandText = "INSERT INTO usuario(login, senha, cargo) values(@login,@senha,@cargo)";
            

            //Parâmetros
            cmd.Parameters.AddWithValue("@login", login) ;
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@cargo", cargo);   

            //Conectar com banco
            try
            {
                //conectar com banco -- Conexao
                cmd.Connection = conexao.conectar();
                //Executar comando
                cmd.ExecuteNonQuery();
                //Desconectar com o banco
                conexao.desconectar();
                //Mensagens de erro/sucesso
                MessageBox.Show("Usuário cadastrado com sucesso", "Mensagem de êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                StringBuilder Errors = new StringBuilder();

                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                MessageBox.Show("Erro ao se conectar com o banco." + ex.Message + "\n\n" + errorMessages.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            

             

            
        }
    }

