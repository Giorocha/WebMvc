using System.Collections.Generic;
using WebMVC.Models;

namespace WebMVC.Repositorios
{
    public class MusicaRepositorio
    {
        public static List<Musica> Musicas = new List<Musica>(){

            new Musica("Juntos e Shallow Now", "Paula Fernandes", "Sertanejo"),
            new Musica("Hello", "Adelle", "Pop"),
            new Musica("Baby Shark", "Capeta", "Infantil"),
            new Musica("Me refez", "Priscilla Alcântara", "Gospel"),
            new Musica("Biridim", "Maicon Jaqueson", "MEME")
        };

    }
}