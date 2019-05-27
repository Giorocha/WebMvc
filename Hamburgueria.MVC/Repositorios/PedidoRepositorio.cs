using System;
using System.IO;
using Hamburgueria.MVC.Models;

namespace Hamburgueria.MVC.Repositorios {
    public class PedidoRepositorio {

        private const string PATH = "Database/Pedido.csv";
        public bool Inserir (Pedido pedido) {
            try {

                if (!File.Exists (PATH)) {
                    //Criarmos um arquivo
                    File.Create (PATH).Close();
                }

                var registro = $"{pedido.Id};{pedido.Cliente.Nome};{pedido.Cliente.Endereco};{pedido.Cliente.Telefone};{pedido.Cliente.Email};{pedido.Hamburguer.Nome};{pedido.Hamburguer.Preco};{pedido.Shake.Nome};{pedido.Shake};{pedido.DataPedido};{pedido.PrecoTotal}\n";

                //Gravamos o arqivo
                File.AppendAllText (PATH, registro);
            } catch (Exception e) {
                System.Console.WriteLine("Chegou no catch");
                System.Console.WriteLine(e.StackTrace);
                
            }

            return true;

        }
    }
}