// instanciar um veiculo 

using sistema_para_um_estacionamento.Models;



Console.WriteLine("insira o modelo do carro:");

string modelo = Console.ReadLine() ?? "";

Console.WriteLine("insira a placa do veiculo:");
string placa = Console.ReadLine() ?? "";

Carros Veiculo1 = new Carros(modelo, placa);

Console.WriteLine($"aqui está o modelo cadastrado:{modelo}");

// criar um estacionamento para receber veiculos estacionados 

