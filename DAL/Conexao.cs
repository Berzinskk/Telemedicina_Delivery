using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_delivery.Conexão
{
    public class Conexao
    {
        SqlConnection cn = new SqlConnection();

        //CONSTRUTOR
        public Conexao() 
        {
            cn.ConnectionString = @"Data Source=DESKTOP_ERICK; Initial Catalog=test_delivery;Integrated Security=true;TrustServerCertificate=True";      
        }
        //MÉTODO CONECTAR

        public SqlConnection conectar() 
        {
            if(cn.State == System.Data.ConnectionState.Closed) 
            {
                cn.Open();
            
            }
            return cn;
        }
        public void desconectar() 
        {
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();

            }
        }
    }
}
