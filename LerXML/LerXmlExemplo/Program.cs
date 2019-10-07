using System;

namespace LerXmlExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Escolha uma opção (digite o número correspondente):");
                Console.WriteLine("1 - CADASTRAR CLIENTE 2 - IMPORTAR CADASTRO; 0 - SAIR");
                Console.WriteLine("--------------------");
                string opc = Console.ReadLine();
                switch (opc)
                {
                    case "1":
                        Cliente novoCliente = new Cliente();
                        Console.Write("Nome: ");
                        novoCliente.Nome = Console.ReadLine();
                        Console.Write("Email: ");
                        novoCliente.Email = Console.ReadLine();
                        Console.WriteLine("Informe o caminho do arquivo para exportar o cadastro do cliente: ");
        
                        string caminhoExportacao = Console.ReadLine();
                        if (novoCliente.Exportar(caminhoExportacao))
                            Console.WriteLine("Cadastro exportado com sucesso.");
                        break;
                    case "2":
                        Console.WriteLine("Informe o caminho do arquivo para importar o cadastro do cliente: ");
        
                        string caminhoImportacao = Console.ReadLine();
                        Cliente cliente = Cliente.Importar(caminhoImportacao);
                        if (cliente != null)
                        {
                            Console.WriteLine("Nome: " + cliente.Nome);
                            Console.WriteLine("Email: " + cliente.Email);
                        }
                        break;
                    default:
                        return;
                }
            }
        }


    }
}
