using DevCar.Vehicle.Entities.Shared;

namespace DevCar.Vehicle.Entities
{
    public class Car : Vehicles
    {
        public decimal Potencia { get; set; }
        public CombustivelCarEnum Combustivel{ get; set; }
        public int Portas { get; set; }

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
        }

        public List<Car> Carro { get; set; }

        public Car(List<Car> carro)
        {
            Carro = carro;
        }
    }

    public enum CombustivelCarEnum
    {
        Flex, Gasolina
    }
}
