/*
	--Características de uma Música
	1- Artista
	2- Duração
	2- Disponível no plano
*/

class Musica
{
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    /*public string DescricaoResumida {
			get{
				return $"A música {Nome} pertence à banda {Artista}";
			}
		}*/
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista}";



    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Disponível: {Disponivel}");

    }

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }


}