namespace ClassBank.Menu
{
    internal class MenuRealizarTransferencia : MenuDeOpcoes
    {
        public override void Executar(Dictionary<int, Correntista> contas)
        {
            base.Executar(contas);
            try
            {
                Console.Write("Informe o Código de sua conta     -> ");
                int numeroConta = int.Parse(Console.ReadLine());
                Console.Write("Informe o Código da conta-destino -> ");
                int contaDestino = int.Parse(Console.ReadLine());
                contas[numeroConta].Transferencia(contas[contaDestino]);
                Thread.Sleep(4000);
            }
            catch
            {
                Erro();
            }
        }
    }
}
