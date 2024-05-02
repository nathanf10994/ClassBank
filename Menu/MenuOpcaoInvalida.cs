namespace ClassBank.Menu;

internal class MenuOpcaoInvalida : MenuDeOpcoes
{
    public override void Executar(Dictionary<int, Correntista> contas)
    {
        base.Executar(contas);
        Console.WriteLine("Opção inválida. Tente novamente.");
        Thread.Sleep(4000);

    }
}
