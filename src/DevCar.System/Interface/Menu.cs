using DevCar.Vehicle.Entities;
using DevCar.Vehicle.Interfaces;
using DevCar.Vehicle.Validation;

namespace DevCar.System.Interface
{
    public class Menu
    {
        public void MainMenu()
        {
            bool sair = false;
            do
            {
                Console.WriteLine("\n ------------------DevCar-------------------\n");
                Console.WriteLine(" 1. Cadastrar veículos");
                Console.WriteLine(" 2. Listar veiculos");
                Console.WriteLine(" 3. Listar carros");
                Console.WriteLine(" 4. Listar camionetes");
                Console.WriteLine(" 5. Listar motos");
                Console.WriteLine(" 6. Vender carro");
                Console.WriteLine(" 7. Carros vendidos");
                Console.WriteLine(" 8. Carro vendido com o maior preço");
                Console.WriteLine(" 9. Carro vendido com o menor preço");
                Console.WriteLine(" 10. Sair");
                Console.Write("\n Selecione uma opção: ");
                string? opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        CadastrarVeiculo();
                        break;
                    case "2":
                        ListarVeiculos();
                        break;
                    case "3":
                        ListarCarros();
                        break;
                    case "4":
                        ListarCamionetes();
                        break;
                    case "5":
                        ListarMotos();
                        break;
                    case "6":
                        VenderCarro();
                        break;
                    case "7":
                        CarrosVendidos();
                        break;
                    case "8":
                        MaiorPrecoCarro();
                        break;
                    case "9":
                        MenorPrecoCarro();
                        break;
                    case "10":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("\n Opção invalida");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (!sair);
        }

        public List<Car> Carros { get; set; } = new();
        public List<Pickup> Camionete { get; set; } = new();
        public List<Motorcycle> Motos { get; set; } = new();
        public List<Sales> VendasCarro { get; set; } = new();

        public Car? Car { get; set; }

        public void CadastrarVeiculo()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\n ------------------DevCar-------------------\n");
                Console.WriteLine(" 1. Cadastrar carro");
                Console.WriteLine(" 2. Cadastrar camionete");
                Console.WriteLine(" 3. Cadastrar moto/triciclo");
                Console.Write("\n Selecione uma opção: ");
                string? sel = Console.ReadLine();

                if (sel == "1")
                {
                    Console.Clear();
                    Console.WriteLine("\n ------------------DevCar-------------------\n");
                    var reiniciar = true;
                    while (reiniciar)
                    {
                        Random ranNum = new();
                        int chassi = ranNum.Next(100000000, 999999999);

                        Console.Write($" Chassi: {chassi}");
                        Console.Write("\n Insira data de fabricação (dd/mm/aaaa): ");
                        DateTime dataDeFabricacao = DateTime.Parse(Console.ReadLine());
                        Console.Write(" Insira Nome: ");
                        string? nome = Validation.ValidaString(Console.ReadLine());
                        Console.Write(" Insira placa: ");
                        string? placa = Validation.ValidaString(Console.ReadLine());
                        Console.Write(" Insira valor: ");
                        decimal valor = Validation.ValidaDecimal(decimal.Parse(Console.ReadLine()));
                        Console.Write(" Insira cpf: ");
                        string? cpf = Validation.ValidaString(Console.ReadLine());
                        Console.Write(" Insira cor: ");
                        string? cor = Validation.ValidaString(Console.ReadLine());
                        Console.Write(" Insira potencia (em cavalos): ");
                        decimal potencia = Validation.ValidaDecimal(decimal.Parse(Console.ReadLine()));
                        Console.Write(" Insira portas: ");
                        int portas = Validation.ValidaInt(int.Parse(Console.ReadLine()));

                        Console.WriteLine("\n ----------------------------------\n");
                        Console.WriteLine(" 1. Flex");
                        Console.WriteLine(" 2. Gasolina");
                        Console.Write("\n Selecione uma opção: ");
                        string? fuel = Console.ReadLine();

                        if (fuel == "1")
                        {
                            CombustivelCarEnum combustivel = CombustivelCarEnum.Flex;
                            Console.Write($"\n Combustivel: {combustivel}");
                            Carros.Add(new Car(chassi, dataDeFabricacao, nome, placa, valor, cpf, cor, potencia, combustivel, portas));
                            Console.WriteLine("\n\n Veiculo adicionado");
                            Console.ReadLine();
                        }
                        if (fuel == "2")
                        {
                            CombustivelCarEnum combustivel = CombustivelCarEnum.Gasolina;
                            Console.Write($"\n Combustivel: {combustivel}");
                            Carros.Add(new Car(chassi, dataDeFabricacao, nome, placa, valor, cpf, cor, potencia, combustivel, portas));
                            Console.WriteLine("\n\n Veiculo adicionado");
                            Console.ReadLine();
                        }

                        // Teste
                        Console.Clear();
                        Console.WriteLine("\n ------------------DevCar-------------------\n");
                        Console.Write(" Deseja continuar? S/N: ");
                        if (Console.ReadLine() == "N")
                        {
                            Console.WriteLine(" Encerrando...");
                            reiniciar = false;
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                    }
                }
                if (sel == "2")
                {
                    Console.Clear();
                    Console.WriteLine("\n ------------------DevCar-------------------\n");
                    var reiniciar = true;
                    while (reiniciar)
                    {
                        Random ranNum = new();
                        int chassi = ranNum.Next(100000000, 999999999);

                        Console.Write($" Chassi: {chassi}");
                        Console.Write("\n Insira data de fabricação (dd/mm/aaaa): ");
                        DateTime dataDeFabricacao = DateTime.Parse(Console.ReadLine());
                        Console.Write(" Insira Nome: ");
                        string? nome = Validation.ValidaString(Console.ReadLine());
                        Console.Write(" Insira placa: ");
                        string? placa = Validation.ValidaString(Console.ReadLine());
                        Console.Write(" Insira valor: ");
                        decimal valor = Validation.ValidaDecimal(decimal.Parse(Console.ReadLine()));
                        Console.Write(" Insira cpf: ");
                        string? cpf = Validation.ValidaString(Console.ReadLine());
                        Console.Write(" Insira cor: ");
                        string? cor = Validation.ValidaString(Console.ReadLine());
                        Console.Write(" Insira potencia (em cavalos): ");
                        decimal potencia = Validation.ValidaDecimal(decimal.Parse(Console.ReadLine()));
                        Console.Write(" Insira portas: ");
                        int portas = Validation.ValidaInt(int.Parse(Console.ReadLine()));
                        Console.Write(" Insira capacidade de carregamento (em litros): ");
                        int carregamento = Validation.ValidaInt(int.Parse(Console.ReadLine()));

                        Console.WriteLine("\n ----------------------------------\n");
                        Console.WriteLine(" 1. Diesel");
                        Console.WriteLine(" 2. Gasolina");
                        Console.Write("\n Selecione uma opção: ");
                        string? fuel = Console.ReadLine();

                        if (fuel == "1")
                        {
                            CombustivelPickupEnum combustivel = CombustivelPickupEnum.Diesel;
                            Console.Write($"\n Combustivel: {combustivel}");
                            Camionete.Add(new Pickup(chassi, dataDeFabricacao, nome, placa, valor, cpf, cor, potencia, portas, carregamento, combustivel));
                            Console.WriteLine("\n\n Veiculo adicionado");
                            Console.ReadLine();
                        }
                        if (fuel == "2")
                        {
                            CombustivelPickupEnum combustivel = CombustivelPickupEnum.Gasolina;
                            Console.Write($"\n Combustivel: {combustivel}");
                            Camionete.Add(new Pickup(chassi, dataDeFabricacao, nome, placa, valor, cpf, cor, potencia, portas, carregamento, combustivel));
                            Console.WriteLine("\n\n Veiculo adicionado");
                        }

                        // Teste
                        Console.Clear();
                        Console.WriteLine("\n ------------------DevCar-------------------\n");
                        Console.Write(" Deseja continuar? S/N: ");
                        if (Console.ReadLine() == "N")
                        {
                            Console.WriteLine(" Encerrando...");
                            reiniciar = false;
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                    }
                }
                if (sel == "3")
                {
                    Console.Clear();
                    Console.WriteLine("\n ------------------DevCar-------------------\n");
                    var reiniciar = true;
                    while (reiniciar)
                    {
                        Random ranNum = new();
                        int chassi = ranNum.Next(100000000, 999999999);

                        Console.Write($" Chassi: {chassi}");
                        Console.Write("\n Insira data de fabricação (dd/mm/aaaa): ");
                        DateTime dataDeFabricacao = DateTime.Parse(Console.ReadLine());
                        Console.Write(" Insira Nome: ");
                        string? nome = Validation.ValidaString(Console.ReadLine());
                        Console.Write(" Insira placa: ");
                        string? placa = Validation.ValidaString(Console.ReadLine());
                        Console.Write(" Insira valor: ");
                        decimal valor = Validation.ValidaDecimal(decimal.Parse(Console.ReadLine()));
                        Console.Write(" Insira cpf: ");
                        string? cpf = Validation.ValidaString(Console.ReadLine());
                        Console.Write(" Insira cor: ");
                        string? cor = Validation.ValidaString(Console.ReadLine());
                        Console.Write(" Insira potencia (em cavalos): ");
                        decimal potencia = Validation.ValidaDecimal(decimal.Parse(Console.ReadLine()));
                        Console.Write(" Insira rodas: ");
                        int rodas = Validation.ValidaInt(int.Parse(Console.ReadLine()));

                        Motos.Add(new Motorcycle(chassi, dataDeFabricacao, nome, placa, valor, cpf, cor, potencia, rodas));
                        Console.WriteLine("\n\n Veiculo adicionado");

                        // Teste
                        Console.Clear();
                        Console.WriteLine("\n ------------------DevCar-------------------\n");
                        Console.Write(" Deseja continuar? S/N: ");
                        if (Console.ReadLine() == "N")
                        {
                            Console.WriteLine(" Encerrando...");
                            reiniciar = false;
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                    }
                }
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ListarVeiculos()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\n ------------------DevCar-------------------\n");
                foreach (var i in Carros)
                {
                    Console.Write(" Carro ");
                    Console.WriteLine("\n Chassi: {0}\n Data de Fabricação: {1}\n Nome: {2}\n Placa: {3}\n Valor: {4}\n CPF: {5}\n Cor: {6}\n Potencia: {7}\n Combustivel: {8}\n Portas: {9}",
                                        i.Chassi, i.DataDeFabricacao, i.Nome, i.Placa, i.Valor, i.Cpf, i.Cor, i.Potencia, i.Combustivel, i.Portas);
                    Console.WriteLine("\n ----------------------------------");

                }
                foreach (var i in Camionete)
                {
                    Console.Write(" Camionete ");
                    Console.WriteLine("\n Chassi: {0}\n Data de Fabricação: {1}\n Nome: {2}\n Placa: {3}\n Valor: {4}\n CPF: {5}\n Cor: {6}\n Carregamento: {7}\n Potencia: {8}\n Combustivel: {9}\n Portas: {10}",
                                        i.Chassi, i.DataDeFabricacao, i.Nome, i.Placa, i.Valor, i.Cpf, i.Cor, i.Carregamento, i.Potencia, i.Combustivel, i.Portas);
                    Console.WriteLine("\n ----------------------------------");

                }
                foreach (var i in Motos)
                {
                    Console.Write(" Moto/Triciclo ");
                    Console.WriteLine("\n Chassi: {0}\n Data de Fabricação: {1}\n Nome: {2}\n Placa: {3}\n Valor: {4}\n CPF: {5}\n Cor: {6}\n Potencia: {7}\n Rodas: {8}",
                                        i.Chassi, i.DataDeFabricacao, i.Nome, i.Placa, i.Valor, i.Cpf, i.Cor, i.Potencia, i.Rodas);
                    Console.WriteLine("\n ----------------------------------");
                }
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ListarCarros()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\n ------------------DevCar-------------------\n");
                foreach (var i in Carros)
                {
                    Console.Write(" Carro ");
                    Console.WriteLine("\n Chassi: {0}\n Data de Fabricação: {1}\n Nome: {2}\n Placa: {3}\n Valor: {4}\n CPF: {5}\n Cor: {6}\n Potencia: {7}\n Combustivel: {8}\n Portas: {9}",
                                        i.Chassi, i.DataDeFabricacao, i.Nome, i.Placa, i.Valor, i.Cpf, i.Cor, i.Potencia, i.Combustivel, i.Portas);
                    Console.WriteLine("\n ----------------------------------");
                }
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ListarCamionetes()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\n ------------------DevCar-------------------\n");
                foreach (var i in Camionete)
                {
                    Console.Write(" Camionete ");
                    Console.WriteLine("\n Chassi: {0}\n Data de Fabricação: {1}\n Nome: {2}\n Placa: {3}\n Valor: {4}\n CPF: {5}\n Cor: {6}\n Carregamento: {7}\n Potencia: {8}\n Combustivel: {9}\n Portas: {10}",
                                        i.Chassi, i.DataDeFabricacao, i.Nome, i.Placa, i.Valor, i.Cpf, i.Cor, i.Carregamento, i.Potencia, i.Combustivel, i.Portas);
                    Console.WriteLine("\n ----------------------------------");
                }
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ListarMotos()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\n ------------------DevCar-------------------\n");
                foreach (var i in Motos)
                {
                    Console.Write(" Moto/Triciclo ");
                    Console.WriteLine("\n Chassi: {0}\n Data de Fabricação: {1}\n Nome: {2}\n Placa: {3}\n Valor: {4}\n CPF: {5}\n Cor: {6}\n Potencia: {7}\n Rodas: {8}",
                                        i.Chassi, i.DataDeFabricacao, i.Nome, i.Placa, i.Valor, i.Cpf, i.Cor, i.Potencia, i.Rodas);
                    Console.WriteLine("\n ----------------------------------");
                }
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void VenderCarro()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\n ------------------DevCar-------------------\n");
                Console.Write("\n Insira nome do carro: ");
                string? name = Console.ReadLine();

                int index = -1;
                for (int i = 0; i < Carros.Count; i++)
                {
                    if (Carros[i].Nome == name)
                    {
                        index = i;
                    }
                }
                if (index != -1)
                {
                    Console.Write(" Insira valor do carro: ");
                    decimal valor = Validation.ValidaDecimal(decimal.Parse(Console.ReadLine()));
                    Console.Write(" Insira CPF do comprador: ");
                    string? cpf = Validation.ValidaString(Console.ReadLine());

                    string? nome = Carros[index].Nome;
                    int chassi = Carros[index].Chassi;
                    DateTime dataDeFabricacao = Carros[index].DataDeFabricacao;
                    string? placa = Carros[index].Placa;
                    string? cor = Carros[index].Cor;
                    decimal potencia = Carros[index].Potencia;
                    CombustivelCarEnum combustivel = Carros[index].Combustivel;
                    int portas = Carros[index].Portas;
                    DateTime dataTransacao = DateTime.Now;
                    dataTransacao.ToShortDateString();

                    VendasCarro.Add(new Sales(chassi, dataDeFabricacao, nome, placa, valor, cpf, cor, potencia, combustivel, portas, dataTransacao));

                    Console.Write("\n Venda concluida");
                }
                else { Console.WriteLine("\n Veiculo não encontrado"); }
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void CarrosVendidos()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\n ------------------DevCar-------------------\n");
                foreach (var i in VendasCarro)
                {
                    Console.Write(" Carro ");
                    Console.WriteLine("\n Chassi: {0}\n Data de Fabricação: {1}\n Nome: {2}\n Placa: {3}\n Valor: {4}\n CPF: {5}\n Cor: {6}\n Potencia: {7}\n Combustivel: {8}\n Portas: {9}\n Data de venda: {10}",
                                        i.Chassi, i.DataDeFabricacao, i.Nome, i.Placa, i.Valor, i.Cpf, i.Cor, i.Potencia, i.Combustivel, i.Portas, i.DataTransacao);
                    Console.WriteLine("\n ----------------------------------");
                }
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void MaiorPrecoCarro()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\n ------------------DevCar-------------------\n");
                decimal maiorValor = 0;

                foreach (var i in VendasCarro)
                {
                    if (i.Valor > maiorValor)
                    {
                        maiorValor = i.Valor;
                    }
                }
                int index = -1;
                for (int i = 0; i < VendasCarro.Count; i++)
                {
                    if (VendasCarro[i].Valor == maiorValor)
                    {
                        index = i;
                    }
                }
                if (index != -1)
                {
                    string? nome = Carros[index].Nome;

                    Console.WriteLine($"\n Carro vendido com o maior preço ");
                    Console.WriteLine($"\n Nome: {nome}");
                    Console.WriteLine($" Valor: {maiorValor}");
                }
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void MenorPrecoCarro()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\n ------------------DevCar-------------------\n");
                decimal menorValor = 10000000000000;

                foreach (var i in VendasCarro)
                {
                    if (i.Valor < menorValor)
                    {
                        menorValor = i.Valor;
                    }
                }
                int index = -1;
                for (int i = 0; i < VendasCarro.Count; i++)
                {
                    if (VendasCarro[i].Valor == menorValor)
                    {
                        index = i;
                    }
                }
                if (index != -1)
                {
                    string? nome = Carros[index].Nome;

                    Console.WriteLine($"\n Carro vendido com o maior preço ");
                    Console.WriteLine($"\n Nome: {nome}");
                    Console.WriteLine($" Valor: {menorValor}");
                }
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
