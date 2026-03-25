using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_para_um_estacionamento.Models
{
    public class Veiculos
    {
        public string Marca { get; set; }
        public string Placa { get; set; }

        public Veiculos(string marca, string placa)
        {
            Marca = marca; 
            Placa = placa;
        }
    }
}