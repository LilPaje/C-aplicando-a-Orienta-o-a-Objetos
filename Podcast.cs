class Podcast {
    public string Nome { get; }
    public string Host { get; }
    public List<Episodio> Episodios = new List<Episodio>();

    public Podcast(string nome, string host){
        Nome = nome;
        Host = host;

    }

    public void AdicionarEpisodio(Episodio episodio){
        Episodios.Add(episodio);

    }

    public void ExibirDetalhes(){
        Console.WriteLine($"Nome: {Nome}, Host: {Host}");
        Console.WriteLine("Episódios: ");
        foreach (Episodio ep in Episodios){
            Console.WriteLine($"'{ep.Titulo}'. Duração: {ep.Duracao}; Resumo: {ep.Resumo}");
        }
        Console.WriteLine($"Total de episódios: {Episodios.Count}");


    }
}
