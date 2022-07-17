using DevCar.Vehicle.Entities;

namespace DevCar.Vehicle.Interfaces
{
    public interface ICar
    {
        public decimal Potencia { get; }
        public CombustivelCarEnum Combustivel { get; }
        public int Portas { get; set; }
        public IList<Car> Carros { get; }
    }
}
