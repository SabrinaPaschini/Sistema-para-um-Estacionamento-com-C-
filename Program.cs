using sistema_para_um_estacionamento.Models;

Console.WriteLine("Início do Sistema");

Estacionamento estacionamento = new Estacionamento(12, 2);

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    string entrada = Console.ReadLine();

    if (entrada != "1" && entrada != "2" && entrada != "3" && entrada != "4")
    {
        Console.WriteLine("Opcao invalida!");
        continue;
    }
    
    int opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();

            estacionamento.AdicionarVeiculosEstacionamento(placa);
            break;

        case 2:
            Console.WriteLine("Digite a placa do veículo:");
            string placaRemover = Console.ReadLine();
            
            if (estacionamento.ListarVeiculo().Contains(placaRemover))
            {
                bool removido = estacionamento.RemoverVeiculos(placaRemover);
            
                Console.WriteLine("Quantas horas o veículo ficou estacionado?");
                int horas = Convert.ToInt32(Console.ReadLine());
                
                decimal valor = estacionamento.CalcularValor(horas);
                Console.WriteLine($"Valor a pagar: {valor}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado!");
            }
            break;

        case 3:
            Console.WriteLine("Lista de veículos estacionados: ");

            var lista = estacionamento.ListarVeiculo();

            if (lista.Count > 0)
            {
                foreach (var v in lista)
                {
                    Console.WriteLine(v);
                }
                
            }else
            {
                Console.WriteLine("Não há veiculos estacionados!");
            }
            break;

        case 4:
            Console.WriteLine("Programa Encerrado.");
            continuar = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}