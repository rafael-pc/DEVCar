using DevCar.Vehicle.Entities.Shared;

namespace DevCar.Vehicle.Entities
{
    public class Motorcycle : Vehicles
    {
        public int Rodas { get; set; }
        public int Potencia { get; set; }

        public Motorcycle(int chassi, DateTime dataDeFabricacao, string nome, int placa, int valor, int cpf, string cor, int potencia, int rodas)
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
        }
    }
}
