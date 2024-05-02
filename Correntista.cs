namespace ClassBank
{
    public class Correntista
    {
        private int codigo;
        private string nome;
        private float saldo;

        public static int numeroConta = 1001;

        public Correntista(string nome)
        {
            this.nome = nome;
            this.saldo = 0;
            this.codigo = numeroConta++;
        }

        public static Correntista addCorrentista(string nome)
        {
            Correntista novo = new Correntista(nome);

            Console.WriteLine("Nova conta criada");
            Console.WriteLine("---------------------");
            novo.Saldo();
            
            return novo;
        }

        public void Deposito()
        {
            Console.Write("Informe o valor a ser depositado -> R$");
            float valor = float.Parse(Console.ReadLine());
            Console.Clear();

            if (valor > 0)
            {
                this.saldo += valor;
                Console.WriteLine("Depósito de R${0} realizado com sucesso.", valor);
                Console.WriteLine("------------------------------");
                Console.WriteLine("Saldo Atual : R${0}.", this.saldo);
            }
            else
            {
                Console.WriteLine("Valor inválido.Não foi possível realizar o Depósito.");
            }
        }

        public void Saque()
        {
            Console.Write("Informe o valor a ser retirado -> R$");
            float valor = float.Parse(Console.ReadLine());
            Console.Clear();

            if (valor < this.saldo)
            {
                if (valor > 0)
                {
                    this.saldo -= valor;
                    Console.WriteLine("Saque de R${0} realizado com sucesso.", valor);
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Saldo Atual : R${0}.", this.saldo);
                }
                else
                {
                    Console.WriteLine("Valor inválido.Não foi possível realizar o Saque.");
                }
                
            }
            else
            {
                Console.WriteLine("Saldo Atual : R${0}.", this.saldo);
                Console.WriteLine("------------------------------");
                Console.WriteLine("Valor insuficiente na conta. Não foi possível realizar o Saque.");
            }
        }

        public void Transferencia(Correntista destino)
        {
            Console.Write("Informe o valor a ser transferido -> R$");
            float valor = float.Parse(Console.ReadLine());
            Console.Clear();

            if (valor < this.saldo)
            {
                if (valor > 0)
                {
                    destino.saldo += valor;
                    this.saldo -= valor;
                    Console.WriteLine("Transferência de R${0} para a conta do correntista {1} realizada com sucesso!", valor, destino.nome);
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Saldo Atual : R${0}.", this.saldo);
                }
                else
                {
                    Console.WriteLine("Valor inválido.Não foi possível realizar a Transferência.");
                }
            }
            else
            {
                Console.WriteLine("Saldo Atual : R${0}.", this.saldo);
                Console.WriteLine("------------------------------");
                Console.WriteLine("Valor insuficiente na conta. Não foi possível realizar a Transferencia.");
            }
        }

        public void Saldo()
        {
            Console.WriteLine("Código...: {0}", this.codigo);
            Console.WriteLine("Nome.....: {0}", this.nome);
            Console.WriteLine("Saldo....: R${0}", this.saldo);
        }
    }
}
