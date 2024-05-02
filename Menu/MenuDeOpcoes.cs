namespace ClassBank.Menu
{
    internal class MenuDeOpcoes
    {
        public virtual void Executar(Dictionary<int, Correntista> contas)
        {
            Console.Clear();
        }

        public static int Index()
        {
            int option;

            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("  ********   CLASS  BANK   ********");
            Console.WriteLine("=====================================");
            Console.WriteLine("  1 - Criar Nova Conta");
            Console.WriteLine("  2 - Realizar um Depósito");
            Console.WriteLine("  3 - Realizar um Saque");
            Console.WriteLine("  4 - Realizar uma Transferencia");
            Console.WriteLine("  5 - Consultar o Saldo");
            Console.WriteLine();
            Console.WriteLine("  0 - Encerrar o programa");
            Console.WriteLine("=====================================");
            Console.Write("  Selecione a opção desejada -> ");
            option = int.Parse(Console.ReadLine());

            return option;
        }

        public static void Erro()
        {
            Console.Clear();
            Console.WriteLine("Inserção errônea de informações. Operação invalidada.");
            Thread.Sleep(4000);
        }

        public static void PressionarTecla()
        {
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
