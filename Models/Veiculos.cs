using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_para_um_estacionamento.Models
{
    public class Carros
    {
        public string Model { get; set; }
        public string LicencePlate { get; set; }

        public Carros(string model, string licencePlate)
        {
            Model = model; 
            LicencePlate = licencePlate;
        }
    }
}