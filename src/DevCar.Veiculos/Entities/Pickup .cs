using DevCar.Vehicle.Entities.Shared;

namespace DevCar.Vehicle.Entities
{
    public class Pickup : Vehicles
    {
        public int Potencia { get; set; }
        public int Portas { get; set; }
        public int Carregamento { get; set; }
        public CombustivelPickupEnum Combustivel { get; set; }

        public Pickup(int chassi, DateTime dataDeFabricacao, string nome, int placa, int valor, int cpf, string cor, int potencia, int portas, int carregamento, CombustivelPickupEnum combustivel)
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
        }
    }

    public enum CombustivelPickupEnum
    {
        Gasolina, Diesel
    }
}
