namespace DesafioProjetoHospedagem.Models

{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (Suite.Capacidade>= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
              throw new Exception("A capacidade é maior que o limite estabelecido");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospedes= Hospedes.Count;
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
           if(DiasReservados>= 10) {
              
            decimal valor = DiasReservados*Suite.ValorDiaria;
            valor = valor - (valor*0.1M);
            return valor;
           }
            else {
                decimal valor = DiasReservados*Suite.ValorDiaria;
                return valor;
            }
           
        }
    }
}