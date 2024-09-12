namespace AulaPOO
{
    public class ContaBancaria
    {
        private string nomeDoTitular;
        private int Saldo;
        private string agencia;

        public ContaBancaria(string nomeDoTitular, int Saldo, string agencia)
        {
            this.nomeDoTitular = nomeDoTitular;
            this.Saldo = Saldo;
            this.agencia = agencia;
        }

    }
}