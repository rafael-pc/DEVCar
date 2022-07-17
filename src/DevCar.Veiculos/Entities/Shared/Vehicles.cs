using DevCar.Vehicle.Interfaces;

namespace DevCar.Vehicle.Entities.Shared
{
    public class Vehicles : IVehicles
    {
        public int Chassi { get; set; }
        public DateTime DataDeFabricacao { get; set; }
        public string? Nome { get; set; }
        public string? Placa { get; set; }
        public decimal Valor { get; set; }
        public string? Cpf { get; set; }
        public string? Cor { get; set; }
    }
}
