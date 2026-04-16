using sistema_para_um_estacionamento.Models;

Console.WriteLine("insira o modelo do carro:");

string modelo = Console.ReadLine() ?? "";

Console.WriteLine("insira a placa do veiculo:");

string placa = Console.ReadLine() ?? "";

Veiculo Veiculo1 = new Veiculo(modelo, placa);

Console.WriteLine($"Carro no estacionamento:{modelo} Placa: {placa}");

var Estacionamento = new Estacionamento(12, 2);

Estacionamento.AdicionarVeiculosEstacionamento(placa);

Estacionamento.RemoverVeiculos("efg-6789");

Estacionamento.ListarVeiculo();