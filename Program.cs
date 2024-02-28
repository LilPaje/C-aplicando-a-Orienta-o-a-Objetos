Banda tigerJaws = new Banda("Tiger Jaws");


Album albumDoTigerJaws = new Album("TigerJaws");


Musica musica1 = new Musica(tigerJaws, "The Sun")
{
    Duracao = 123,
    Disponivel = true
};

Musica musica2 = new Musica(tigerJaws, "Plane vs Tank vs Submarine")
{
    Duracao = 456,
    Disponivel = true
};


albumDoTigerJaws.AdicionarMusica(musica1);
albumDoTigerJaws.AdicionarMusica(musica2);
tigerJaws.AdicionarAlbum(albumDoTigerJaws);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoTigerJaws.ExibirMusicasDoAlbum();
tigerJaws.ExibirDiscografia();

//Desafio Final
Console.WriteLine("\n\n--------------");
Episodio ep1 = new Episodio("Ep da Mônica", 10, "Ola, eu sou a Mônica");
Podcast podcast1 = new Podcast("Podcast 1", "Z");
podcast1.AdicionarEpisodio(ep1);
podcast1.ExibirDetalhes();
Console.WriteLine("--------------");