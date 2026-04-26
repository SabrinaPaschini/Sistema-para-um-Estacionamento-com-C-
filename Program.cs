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

            Console.WriteLine("Quantas horas o veículo ficou estacionado?");
            int horas = Convert.ToInt32(Console.ReadLine());

            bool removido = estacionamento.RemoverVeiculos(placaRemover);

            if (removido)
            {

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

            foreach (var v in lista)
            {
                Console.WriteLine(v);
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