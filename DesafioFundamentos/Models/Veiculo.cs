namespace DesafioFundamentos.Models
{
    public class Veiculo
    {
        public string placa {get; set;}
        public string modelo {get; set;}
        public string nomeProprietario {get; set;}
        public int ano {get; set;}

        public Veiculo (string placa, string modelo, int ano, string nomeProprietario ){
            this.placa = placa;
            this.modelo = modelo;
            this.ano = ano;
            this.nomeProprietario = nomeProprietario;
            
        }

    }
}
