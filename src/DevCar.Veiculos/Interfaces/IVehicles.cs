using DevCar.Vehicle.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCar.Vehicle.Interfaces
{
    public interface IVehicles
    {
        public int Chassi { get; }
        public DateTime DataDeFabricacao { get; }
        public string? Nome { get; }
        public string? Placa { get; }
        public decimal Valor { get; }
        public string? Cpf { get; }
        public string? Cor { get; }
    }
}
