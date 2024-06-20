using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_delivery.Screens;
using test_delivery.Screens.Pedidos;

namespace test_delivery
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_login());
            string connectionString = @"Data Source=DESKTOP_ERICK;Initial Catalog=test_delivery;Integrated Security=true";
            PedidoVencimento pedidoVencimento = new PedidoVencimento(connectionString);
            pedidoVencimento.AtualizarStatusPedidosAtrasados();
    }
    }
}
