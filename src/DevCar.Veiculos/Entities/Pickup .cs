using DevCar.Vehicle.Entities.Shared;
using DevCar.Vehicle.Interfaces;

namespace DevCar.Vehicle.Entities
{
    public class Pickup : Vehicles, IPickup
    {
        public decimal Potencia { get; set; }
        public int Portas { get; set; }
        public int Carregamento { get; set; }
        public CombustivelPickupEnum Combustivel { get; set; }
        public IList<Pickup> Camionete { get; set; }

        public Pickup(int chassi, DateTime dataDeFabricacao, string nome, string placa, decimal valor, string cpf, string cor, decimal potencia, int portas, int carregamento, CombustivelPickupEnum combustivel)
        {
            Chassi = chassi;
            DataDeFabricacao = dataDeFabricacao;
            Nome = nome;
            Placa = placa;
            Valor = valor;
            Cpf = cpf;
            Cor = cor;
            Potencia = potencia;
            Portas = portas;
            Carregamento = carregamento;
            Combustivel = combustivel;
            Camionete = new List<Pickup>();
        }
    }
    public enum CombustivelPickupEnum
    {
        Gasolina, Diesel
    }
}
