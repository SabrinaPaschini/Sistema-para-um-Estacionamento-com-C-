using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace sistema_para_um_estacionamento.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial { get; set; }
        private decimal PrecoPorHora { get; set; }
        private List<string> Veiculos { get; set; } = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculosEstacionamento(string placa)
        {
            Veiculos.Add(placa);
        }

        public void RemoverVeiculos(string placa, int horas)
        {
            if (Veiculos.Contains(placa))
            {
                decimal valorTotal = PrecoInicial * horas;

                Veiculos.Remove(placa);
                Console.WriteLine($"Veiculo {placa} removido com sucesso!");
                Console.WriteLine($"Valor a pagar {valorTotal}");
            }
            else
            {
                Console.WriteLine($"Veículo não encontrado.");
            }
        }

        public void ListarVeiculo()
        {
            foreach (var placa in Veiculos)
            {
                Console.WriteLine(placa);
            }
        }
    }
}