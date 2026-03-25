using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace sistema_para_um_estacionamento.Models
{
    public class Estacionamento
    {
    public decimal PrecoInicial { get; set; }
    public decimal PrecoPorHora { get; set; }
    public List<Veiculos> Veiculos { get; set; } = new List<Veiculos>();
    
        public Estacionamento(decimal precoInicial, decimal precoPorHora, List<Veiculos> veiculos)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora; 
            Veiculos = veiculos; 
        }

        public void AdicionaVeiculos(Veiculos veiculo)
        {
           Veiculos.Add(veiculo); 
        }

         public void RemoveVeiculos()
        {
            Console.WriteLine("Removendo veículo....");
        }

        public void ListaVeiculo()
        {
            Console.WriteLine("Lista de veículos....");
        }
    
        public void Encerrar()
        {
            Console.WriteLine("Encerrando..."); 
        }
    }
}