using DevCar.Vehicle.Entities.Shared;
using DevCar.Vehicle.Interfaces;

namespace DevCar.Vehicle.Entities
{
    public class Motorcycle : Vehicles, IMotorcycle
    {
        public int Rodas { get; set; }
        public decimal Potencia { get; set; }

        public IList<Motorcycle> Motos { get; set; }

        public Motorcycle(int chassi, DateTime dataDeFabricacao, string nome, string placa, decimal valor, string cpf, string cor, decimal potencia, int rodas)
        {
            Chassi = chassi;
            DataDeFabricacao = dataDeFabricacao;
            Nome = nome;
            Placa = placa;
            Valor = valor;
            Cpf = cpf;
            Cor = cor;
            Potencia = potencia;
            Rodas = rodas;
            Motos = new List<Motorcycle>();
        }
    }
}
