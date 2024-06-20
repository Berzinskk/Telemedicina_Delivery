using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_delivery.Conexão;


namespace test_delivery.Modelo
{
    public class CadastroPaciente
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        public CadastroPaciente(String nome, String telefone, String cpf, String rua, String numero, String bairro, String complemento, String cidade, String estado, String cep)
        {
            SqlCommand cmd = new SqlCommand();
            //Comando SQL --- SqlCommand
            cmd.CommandText = "INSERT INTO pacientes(nome, telefone, cpf, rua, numero, bairro, complemento, cidade, estado, cep) values(@nome,@telefone,@cpf,@rua,@numero,@bairro,@complemento,@cidade,@estado,@cep)";


            //Parâmetros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone",telefone );
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@rua",rua );
            cmd.Parameters.AddWithValue("@numero",numero );
            cmd.Parameters.AddWithValue("@bairro",bairro );
            cmd.Parameters.AddWithValue("@complemento",complemento );
            cmd.Parameters.AddWithValue("@cidade",cidade );
            cmd.Parameters.AddWithValue("@estado",estado );
            cmd.Parameters.AddWithValue("@cep",cep );

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
                this.mensagem = "Cadastrado com sucesso!";
                
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao se conectar com o banco de Dados, entre em contato com o administrador do sistema.";
            }
        }


    }
}
    

