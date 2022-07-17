using DevCar.Vehicle.Interfaces;

namespace DevCar.Vehicle.Entities
{
    public class Sales : Car, ISales
    {
        public DateTime DataTransacao { get; set; }
        public IList<Sales>? VendasCarro { get; set; }

        public Sales(int chassi, DateTime dataDeFabricacao, string? nome, string? placa, decimal valor, string cpf, string? cor, decimal potencia, CombustivelCarEnum combustivel, int portas, DateTime dataTransacao) : base(nome)
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
            DataTransacao = dataTransacao;
            VendasCarro = new List<Sales>();
        }
    }
}
