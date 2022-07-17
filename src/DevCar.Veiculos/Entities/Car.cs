using DevCar.Vehicle.Entities.Shared;
using DevCar.Vehicle.Interfaces;

namespace DevCar.Vehicle.Entities
{
    public class Car : Vehicles, ICar
    {
        public decimal Potencia { get; set; }
        public CombustivelCarEnum Combustivel{ get; set; }
        public int Portas { get; set; }

        public IList<Car> Carros { get; set; }

        public Car(int chassi, DateTime dataDeFabricacao, string nome, string placa, decimal valor, string cpf, string cor, decimal potencia, CombustivelCarEnum combustivel, int portas)
        {
            Chassi = chassi;
            DataDeFabricacao = dataDeFabricacao;
            Nome = nome;
            Placa = placa;
            Valor = valor;
            Cpf = cpf;
            Cor = cor;
            Potencia = potencia;
            Combustivel = combustivel;
            Portas = portas;
            Carros = new List<Car>();
        }
        public Car(string nome)
        {
            Nome = nome;
        }
    }

    public enum CombustivelCarEnum
    {
        Flex, Gasolina
    }
}
