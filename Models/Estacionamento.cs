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
    public List<Carros> Carros { get; set; } = new List<Carros>();
    
        public Estacionamento(decimal precoInicial, decimal precoPorHora, List<Carros> carros)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora; 
            Carros = carros; 
        }

        public void AdicionaVeiculos(Carros carros)
        {
           Carros.Add(carros); 
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