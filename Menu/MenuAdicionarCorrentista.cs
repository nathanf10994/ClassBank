namespace ClassBank.Menu;

internal class MenuAdicionarCorrentista : MenuDeOpcoes
{
    public override void Executar(Dictionary<int, Correntista> contas)
    {
        base.Executar(contas);
        Console.Write("Informe o nome do novo correntista -> ");
        string nome = Console.ReadLine();
        Console.Clear();
        contas.Add(Correntista.numeroConta, Correntista.addCorrentista(nome));
        PressionarTecla();
    }
}
