namespace ClassBank.Menu;

internal class MenuRealizarDeposito : MenuDeOpcoes
{
    public override void Executar(Dictionary<int, Correntista> contas)
    {
        base.Executar(contas);
        try
        {
            Console.Write("Informe o Código de sua conta ->    ");
            int numeroConta = int.Parse(Console.ReadLine());
            contas[numeroConta].Deposito();
            Thread.Sleep(4000);
        }
        catch
        {
            Erro();
        }
    }
}
