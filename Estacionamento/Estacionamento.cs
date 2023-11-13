using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEstacionamento
{
    internal class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos = new List<string>();


        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaVeiculo = Console.ReadLine();
            veiculos.Add(placaVeiculo);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placaVeiculo = Console.ReadLine();
            veiculos.Add(placaVeiculo);

            if(veiculos.Any(x => x.ToUpper() == placaVeiculo.ToUpper())){
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu no estacionamento:");
                int estacionamentoHoras = int.Parse(Console.ReadLine());
                decimal valorEstacionamento = (precoInicial + precoPorHora) * estacionamentoHoras;
                veiculos.Remove(placaVeiculo);
                Console.WriteLine($"O veículo {placaVeiculo} foi removido e o preço total é de R${valorEstacionamento}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa correta.");
            }
        }
        
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados aqui são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
