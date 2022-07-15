using DevCar.System.Interface;
using DevCar.Vehicle.Entities;


namespace DevCar.System
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu App = new();
            App.MainMenu();
        }
    }
}
/*class Program
{
    public static void Main(string[] args)
    {
        List<Car> carro = new();
        List<Pickup> camionete = new();

        try
        {
            while (true)
            {
                Console.WriteLine("DevCar\n");
                Console.Write("1. Cadastrar veículos\n2. Listar veiculos\n\nSelecione uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.WriteLine("\n----------------------------------");
                    Console.Write("\n1. Cadastrar carro\n2. Cadastrar camionete\n\nSelecione uma opção: ");
                    string sel = Console.ReadLine();

                    if (sel == "1")
                    {
                        Random ranNum = new Random();
                        int chassi = ranNum.Next(100000000, 999999999);

                        Console.WriteLine("\n----------------------------------");
                        Console.Write($"\nChassi: {chassi}");
                        Console.Write("\nInsira data de fabricação (dd/mm/aaaa): ");
                        DateTime dataDeFabricacao = DateTime.Parse(Console.ReadLine());
                        Console.Write("Insira Nome: ");
                        string? nome = Console.ReadLine();
                        Console.Write("Insira placa: ");
                        string? placa = Console.ReadLine();
                        Console.Write("Insira valor: ");
                        double valor = double.Parse(Console.ReadLine());

                        if (valor < 0)
                        {
                            Console.WriteLine("\nValor invalido");
                            Environment.Exit(0);
                        }
                        Console.Write("Insira cpf: ");
                        string? cpf = Console.ReadLine();
                        Console.Write("Insira cor: ");
                        string? cor = Console.ReadLine();
                        Console.Write("Insira potencia (em cavalos): ");
                        double potencia = double.Parse(Console.ReadLine());
                        Console.Write("Insira portas: ");
                        int portas = int.Parse(Console.ReadLine());

                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\n1. Flex\n2. Gasolina\n\nSelecione uma opção: ");
                        //CombustivelCarEnum combustivel;
                        string fuel = Console.ReadLine();

                        if (fuel == "1")
                        {
                            CombustivelCarEnum combustivel = CombustivelCarEnum.Flex;
                            Console.Write($"\nCombustivel: {combustivel}");

                            carro.Add(new Car(chassi,
                                          dataDeFabricacao,
                                          nome,
                                          placa,
                                          valor,
                                          cpf,
                                          cor,
                                          potencia,
                                          combustivel,
                                          portas));
                            Console.WriteLine("\n\nVeiculo adicionado");
                            Console.ReadLine();
                        }
                        if (fuel == "2")
                        {
                            CombustivelCarEnum combustivel = CombustivelCarEnum.Gasolina;
                            Console.Write($"\nCombustivel: {combustivel}");

                            carro.Add(new Car(chassi,
                                     dataDeFabricacao,
                                     nome,
                                     placa,
                                     valor,
                                     cpf,
                                     cor,
                                     potencia,
                                     combustivel,
                                     portas));
                            Console.WriteLine("\n\nVeiculo adicionado");
                            Console.ReadLine();
                        }
                    }

                    if (sel == "2")
                    {
                        Random ranNum = new Random();
                        int chassi = ranNum.Next(100000000, 999999999);

                        Console.WriteLine("\n----------------------------------");
                        Console.Write($"\nChassi: {chassi}");
                        Console.Write("\nInsira data de fabricação (dd/mm/aaaa): ");
                        DateTime dataDeFabricacao = DateTime.Parse(Console.ReadLine());
                        Console.Write("Insira Nome: ");
                        string? nome = Console.ReadLine();
                        Console.Write("Insira placa: ");
                        string? placa = Console.ReadLine();
                        Console.Write("Insira valor: ");
                        double valor = double.Parse(Console.ReadLine());

                        if (valor < 0)
                        {
                            Console.WriteLine("\nValor invalido");
                            Environment.Exit(0);
                        }
                        Console.Write("Insira cpf: ");
                        string? cpf = Console.ReadLine();
                        Console.Write("Insira cor: ");
                        string? cor = Console.ReadLine();
                        Console.Write("Insira potencia (em cavalos): ");
                        double potencia = double.Parse(Console.ReadLine());
                        Console.Write("Insira portas: ");
                        int portas = int.Parse(Console.ReadLine());
                        Console.Write("Insira capacidade de carregamento (em litros): ");
                        int carregamento = int.Parse(Console.ReadLine());

                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\n1. Flex\n2. Gasolina\n\nSelecione uma opção: ");
                        string fuel = Console.ReadLine();

                        if (fuel == "1")
                        {
                            CombustivelPickupEnum combustivel = CombustivelPickupEnum.Diesel;
                            Console.Write($"\nCombustivel: {combustivel}");

                            camionete.Add(new Pickup(chassi,
                                          dataDeFabricacao,
                                          nome,
                                          placa,
                                          valor,
                                          cpf,
                                          cor,
                                          potencia,
                                          portas,
                                          carregamento,
                                          combustivel));

                            Console.WriteLine("\n\nVeiculo adicionado");
                            Console.ReadLine();
                        }
                        if (fuel == "2")
                        {
                            CombustivelPickupEnum combustivel = CombustivelPickupEnum.Gasolina;
                            Console.Write($"\nCombustivel: {combustivel}");

                            camionete.Add(new Pickup(chassi,
                                          dataDeFabricacao,
                                          nome,
                                          placa,
                                          valor,
                                          cpf,
                                          cor,
                                          potencia,
                                          portas,
                                          carregamento,
                                          combustivel));

                            Console.WriteLine("\n\nVeiculo adicionado");
                            Console.ReadLine();
                        }
                    }
                }
                else if (opcao == "2")
                {
                    foreach (var i in carro)
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\nCarro: ");
                        Console.WriteLine("\nChassi: {0}\nData de Fabricação: {1}\nNome: {2}\nPlaca: {3}\nValor: {4}\nCPF: {5}\nCor: {6}\nPotencia: {7}\nCombustivel: {8}\nPortas: {9}", i.Chassi, i.DataDeFabricacao, i.Nome, i.Placa, i.Valor, i.Cpf, i.Cor, i.Potencia, i.Combustivel, i.Portas);
                    }
                    foreach (var i in camionete)
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\nCamionete: ");
                        Console.WriteLine("\nChassi: {0}\nData de Fabricação: {1}\nNome: {2}\nPlaca: {3}\nValor: {4}\nCPF: {5}\nCor: {6}\nCarregamento: {7}\nPotencia: {8}\nCombustivel: {9}\nPortas: {10}", i.Chassi, i.DataDeFabricacao, i.Nome, i.Placa, i.Valor, i.Cpf, i.Cor, i.Carregamento, i.Potencia, i.Combustivel, i.Portas);
                    }
                    //foreach (var i in contaInvestimento)
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\nConta Investimento: ");
                        Console.WriteLine("\nConta: {0}\nAgencia: {1}\nNome: {2}\nCPF: {3}\nEndereco: {4}\nRenda Mensal: {5}\nSaldo: {6}", i.numConta, i.agencia, i.name, i.cpf, i.endereco, i.rendaMensal, i.saldo);
                    }
                    Console.ReadLine();
                }

                Console.Clear();
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}*/
