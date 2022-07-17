using DevCar.Vehicle.Entities;

namespace DevCar.Vehicle.Interfaces
{
    public interface IMotorcycle
    {
        public int Rodas { get; }
        public decimal Potencia { get; }

        public IList<Motorcycle> Motos { get; }
    }
}
