using System.Reflection;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        public List<Veiculo> veiculos = new List<Veiculo>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            Console.WriteLine("Digite o modelo do veículo:");
            string modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano do veículo:");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome do proprietário do veículo:");
            string nomeProprietario = Console.ReadLine();
            
            Veiculo veiculo = new Veiculo(placa, modelo, ano, nomeProprietario);
            veiculos.Add(veiculo);
        }

        public void RemoverVeiculoPorPlaca()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placaDigitada = Console.ReadLine();

            var veiculoRemovido = veiculos.RemoveAll(v => v.placa.Equals(placaDigitada, StringComparison.OrdinalIgnoreCase));

            if (veiculoRemovido > 0)
            {
                int horas = 0;
                decimal valorTotal = 0; 
                
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + (precoPorHora * horas);
                Console.WriteLine($"O veículo {placaDigitada} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                foreach (var veiculo in veiculos)
                {
                    
                    Console.WriteLine($"Placa: {veiculo.placa}, Modelo: {veiculo.modelo}, Ano: {veiculo.ano}, Proprietário: {veiculo.nomeProprietario}" );

                    Console.WriteLine("---");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
