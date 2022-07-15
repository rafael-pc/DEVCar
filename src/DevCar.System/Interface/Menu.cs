using DevCar.Vehicle.Entities;
using DevCar.Vehicle.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine(" 6. Sair");
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

        readonly List<Car> Carro = new();
        readonly List<Pickup> Camionete = new();
        readonly List<Motorcycle> Motorcycle = new();

        public void CadastrarVeiculo()
        {
            try
            {
                Console.WriteLine("\n ----------------------------------\n");
                Console.WriteLine(" 1. Cadastrar carro");
                Console.WriteLine(" 2. Cadastrar camionete");
                Console.WriteLine(" 3. Cadastrar moto/triciclo");
                Console.Write("\n Selecione uma opção: ");
                string sel = Console.ReadLine();

                if (sel == "1")
                {
                    var reiniciar = true;
                    while (reiniciar)
                    {
                        Random ranNum = new Random();
                        int chassi = ranNum.Next(100000000, 999999999);

                        Console.WriteLine("\n ----------------------------------\n");
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
                        string fuel = Console.ReadLine();

                        if (fuel == "1")
                        {
                            CombustivelCarEnum combustivel = CombustivelCarEnum.Flex;
                            Console.Write($"\n Combustivel: {combustivel}");
                            Carro.Add(new Car(chassi, dataDeFabricacao, nome, placa, valor, cpf, cor, potencia, combustivel, portas));
                            Console.WriteLine("\n\n Veiculo adicionado");
                            Console.ReadLine();
                        }
                        if (fuel == "2")
                        {
                            CombustivelCarEnum combustivel = CombustivelCarEnum.Gasolina;
                            Console.Write($"\n Combustivel: {combustivel}");
                            Carro.Add(new Car(chassi, dataDeFabricacao, nome, placa, valor, cpf, cor, potencia, combustivel, portas));
                            Console.WriteLine("\n\n Veiculo adicionado");
                            Console.ReadLine();
                        }

                        // Teste
                        Console.WriteLine(" ----------------------------------\n");
                        Console.Write(" Deseja continuar? S/N: ");
                        if (Console.ReadLine() == "N")
                        {
                            Console.WriteLine(" Encerrando...");
                            reiniciar = false;
                        }
                        else
                        {
                            Console.WriteLine(" Reiniciando...");
                            Console.WriteLine();
                        }
                    }
                }
                if (sel == "2")
                {
                    var reiniciar = true;
                    while (reiniciar)
                    {
                        Random ranNum = new Random();
                        int chassi = ranNum.Next(100000000, 999999999);

                        Console.WriteLine("\n ----------------------------------\n");
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
                        string fuel = Console.ReadLine();

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
                        Console.WriteLine(" ----------------------------------\n");
                        Console.Write(" Deseja continuar? S/N: ");
                        if (Console.ReadLine() == "N")
                        {
                            Console.WriteLine(" Encerrando...");
                            reiniciar = false;
                        }
                        else
                        {
                            Console.WriteLine(" Reiniciando...");
                            Console.WriteLine();
                        }
                    }
                }
                if (sel == "3")
                {
                    var reiniciar = true;
                    while (reiniciar)
                    {
                        Random ranNum = new Random();
                        int chassi = ranNum.Next(100000000, 999999999);

                        Console.WriteLine("\n ----------------------------------\n");
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

                        Motorcycle.Add(new Motorcycle(chassi, dataDeFabricacao, nome, placa, valor, cpf, cor, potencia, rodas));
                        Console.WriteLine("\n\n Veiculo adicionado");

                        // Teste
                        Console.WriteLine(" ----------------------------------\n");
                        Console.Write(" Deseja continuar? S/N: ");
                        if (Console.ReadLine() == "N")
                        {
                            Console.WriteLine(" Encerrando...");
                            reiniciar = false;
                        }
                        else
                        {
                            Console.WriteLine(" Reiniciando...");
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
                foreach (var i in Carro)
                {
                    Console.WriteLine("\n ----------------------------------");
                    Console.Write("\n Carro ");
                    Console.WriteLine("\n Chassi: {0}\n Data de Fabricação: {1}\n Nome: {2}\n Placa: {3}\n Valor: {4}\n CPF: {5}\n Cor: {6}\n Potencia: {7}\n Combustivel: {8}\n Portas: {9}",
                                        i.Chassi, i.DataDeFabricacao, i.Nome, i.Placa, i.Valor, i.Cpf, i.Cor, i.Potencia, i.Combustivel, i.Portas);
                }
                foreach (var i in Camionete)
                {
                    Console.WriteLine("\n ----------------------------------");
                    Console.Write("\n Camionete ");
                    Console.WriteLine("\n Chassi: {0}\n Data de Fabricação: {1}\n Nome: {2}\n Placa: {3}\n Valor: {4}\n CPF: {5}\n Cor: {6}\n Carregamento: {7}\n Potencia: {8}\n Combustivel: {9}\n Portas: {10}",
                                        i.Chassi, i.DataDeFabricacao, i.Nome, i.Placa, i.Valor, i.Cpf, i.Cor, i.Carregamento, i.Potencia, i.Combustivel, i.Portas);
                }
                foreach (var i in Motorcycle)
                {
                    Console.WriteLine("\n ----------------------------------");
                    Console.Write("\n Moto/Triciclo ");
                    Console.WriteLine("\n Chassi: {0}\n Data de Fabricação: {1}\n Nome: {2}\n Placa: {3}\n Valor: {4}\n CPF: {5}\n Cor: {6}\n Potencia: {7}\n Rodas: {8}",
                                        i.Chassi, i.DataDeFabricacao, i.Nome, i.Placa, i.Valor, i.Cpf, i.Cor, i.Potencia, i.Rodas);
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
                foreach (var i in Carro)
                {
                    Console.WriteLine("\n ----------------------------------");
                    Console.Write("\n Carro ");
                    Console.WriteLine("\n Chassi: {0}\n Data de Fabricação: {1}\n Nome: {2}\n Placa: {3}\n Valor: {4}\n CPF: {5}\n Cor: {6}\n Potencia: {7}\n Combustivel: {8}\n Portas: {9}",
                                        i.Chassi, i.DataDeFabricacao, i.Nome, i.Placa, i.Valor, i.Cpf, i.Cor, i.Potencia, i.Combustivel, i.Portas);
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
                foreach (var i in Camionete)
                {
                    Console.WriteLine("\n ----------------------------------");
                    Console.Write("\n Camionete ");
                    Console.WriteLine("\n Chassi: {0}\n Data de Fabricação: {1}\n Nome: {2}\n Placa: {3}\n Valor: {4}\n CPF: {5}\n Cor: {6}\n Carregamento: {7}\n Potencia: {8}\n Combustivel: {9}\n Portas: {10}",
                                        i.Chassi, i.DataDeFabricacao, i.Nome, i.Placa, i.Valor, i.Cpf, i.Cor, i.Carregamento, i.Potencia, i.Combustivel, i.Portas);
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
                foreach (var i in Motorcycle)
                {
                    Console.WriteLine("\n ----------------------------------");
                    Console.Write("\n Moto/Triciclo ");
                    Console.WriteLine("\n Chassi: {0}\n Data de Fabricação: {1}\n Nome: {2}\n Placa: {3}\n Valor: {4}\n CPF: {5}\n Cor: {6}\n Potencia: {7}\n Rodas: {8}",
                                        i.Chassi, i.DataDeFabricacao, i.Nome, i.Placa, i.Valor, i.Cpf, i.Cor, i.Potencia, i.Rodas);
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
