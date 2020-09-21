using System;
using System.Linq;
using Loja.Controllers;
using Microsoft.EntityFrameworkCore;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new Data.ApplicationContext();

            //Variavel que retorna um boolean caso exista migraçoes pendentes.
            var existe = db.Database.GetPendingMigrations().Any();

            //Caso contenha migraçoes pendentes devera ser tratado se necessario.
            // if (existe)
            // {
            //     // Função responsavel por dar Update da Migration
            //     db.Database.Migrate();

            // }

            // CreateHostBuilder(args).Build().Run();


            //LojaController.InserirDados();
            //LojaController.InserirDadosEmMassa();
            // LojaController.ConsultarDados();
            //LojaController.CadastrarPedido();
            //LojaController.ConsultarPedidoCarregamentoAdiantado();
            //LojaController.AtualizarDados();
            LojaController.RemoverRegistro();
        }
    }
}
