using DevCar.Vehicle.Entities.Shared;

namespace DevCar.Vehicle.Entities
{
    public class Car : Vehicles
    {
        public int Potencia { get; set; }
        public CombustivelCarEnum Combustivel{ get; set; }
        public int Portas { get; set; }
        

        public Car(int chassi, DateTime dataDeFabricacao, string nome, int placa, int valor, int cpf, string cor, int potencia, CombustivelCarEnum combustivel, int portas)
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
    }

    public enum CombustivelCarEnum
    {
        Flex, Gasolina
    }

}
