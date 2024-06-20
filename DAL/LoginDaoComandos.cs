using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_delivery.Conexão
{
    class LoginDaoComandos
    {
        StringBuilder errorMessages = new StringBuilder();
        public bool tem = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(string login, string senha, string cargo)
        {
            cmd.CommandText = "SELECT * FROM usuario WHERE login = @login AND senha = @senha AND cargo = @cargo";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@cargo", cargo);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    tem = true;
                }
                
                
            }
            catch (SqlException ex) 

            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }



            return tem;
        }
    }
}
