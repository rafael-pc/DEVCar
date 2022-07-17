using DevCar.Vehicle.Entities;

namespace DevCar.Vehicle.Interfaces
{
    public interface IPickup
    {
        public decimal Potencia { get; }
        public int Portas { get; }
        public int Carregamento { get; }
        public CombustivelPickupEnum Combustivel { get; }

        public IList<Pickup> Camionete { get; set; }
    }
}
