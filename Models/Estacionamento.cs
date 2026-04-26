using System;
using System.Collections.Generic;
using System.Linq;

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

        public bool RemoverVeiculos(string placa)
        {
            if (Veiculos.Contains(placa))
            {
                Veiculos.Remove(placa);
                return true;
            }

            return false;
        }

        public List<string> ListarVeiculo()
        {
            return Veiculos;
        }

        public decimal CalcularValor(int horas)
        {
            return PrecoInicial + (PrecoPorHora * horas);
        }
    }
}