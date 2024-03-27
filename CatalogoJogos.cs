public class CatalogoJogos
{
    public CatalogoJogos(string categoria)
    {
        Categoria = categoria;
    }
    public string Categoria;
    public List<string> jogos = new List<string>();
    public void AddJogo(string jogo)
    {
        jogos.Add(jogo);
    }
    public void removerJogo(string jogo)
    {
        jogos.Remove(jogo);
    }
    public void ExibirLista()
    {
        System.Console.WriteLine($"Jogos da categoia {Categoria}:");
        foreach (string jogo in jogos)
        {
            System.Console.WriteLine(jogo);
        }
        System.Console.WriteLine("\n");
    }
}
