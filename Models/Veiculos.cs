using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_para_um_estacionamento.Models
{
    public class Veiculo
    {
        public string Model { get; set; }
        public string LicencePlate { get; set; }

        public Veiculo(string model, string licencePlate)
        {
            Model = model; 
            LicencePlate = licencePlate;
        }
    }
}

