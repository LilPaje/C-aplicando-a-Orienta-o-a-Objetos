class Episodio{
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo { get; }

    public List<string> convidados = new List<string>();

    public Episodio(string titulo, int duracao, string resumo){
        Titulo = titulo;
        Duracao = duracao;
        Resumo = resumo;   
    }

    public void AdicionarConvidados(string convidado){
        convidados.Add(convidado);
    }
}
