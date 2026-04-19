using sistema_para_um_estacionamento.Models;

Console.WriteLine("Início do Sistema");

Estacionamento estacionamento = new Estacionamento(12, 2);

bool continuar = true;

while (continuar)
{

        Console.WriteLine("1 - Cadastrar veículo");
        Console.WriteLine("2 - Remover veículo");
        Console.WriteLine("3 - Listar veículos");
        Console.WriteLine("4 - Encerrar");

        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
                case 1:
                        estacionamento.AdicionarVeiculosEstacionamento();
                        break;
                case 2:
                        estacionamento.RemoverVeiculos();
                        break;
                case 3:
                        estacionamento.ListarVeiculo();
                        break;
                case 4:
                        continuar = false;
                        break;
                default:
                        Console.WriteLine("Opção invalida!");
        }
}
