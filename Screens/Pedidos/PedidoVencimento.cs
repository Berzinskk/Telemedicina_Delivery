using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace test_delivery.Screens.Pedidos
{
    public class PedidoVencimento

    {
        private string connectionString;

        public PedidoVencimento(string connectionString)
        {
            // Atribuir o valor do parâmetro ao campo de instância connectionString
            this.connectionString = connectionString;
        }

        public void AtualizarStatusPedidosAtrasados()
        {
            // Usar o connectionString armazenado na instância da classe
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryAtualizarStatus = "UPDATE pedido SET pedido_status = 'Atrasado' WHERE data_consulta < @dataAtual AND pedido_status NOT IN ('Concluído', 'Em trânsito')";
                using (SqlCommand commandAtualizarStatus = new SqlCommand(queryAtualizarStatus, connection))
                {
                    commandAtualizarStatus.Parameters.AddWithValue("@dataAtual", DateTime.Now);
                    commandAtualizarStatus.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }

}

