using DevCar.Vehicle.Entities;

namespace DevCar.Vehicle.Interfaces
{
    public interface ISales
    {
        public DateTime DataTransacao { get; }
        public IList<Sales>? VendasCarro { get; set; }
    }
}