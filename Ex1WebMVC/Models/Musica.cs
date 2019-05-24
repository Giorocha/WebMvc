using System;

namespace WebMVC.Models
{
    public class Musica
    {
        public string Titulo {get;set;}
        public string Compositor {get;set;}
        public string Estilo {get;set;}

        public Musica(){

        }

        public Musica(string titulo, string compositor, string estilo){

            this.Titulo = titulo;
            this.Compositor = compositor;
            this.Estilo = estilo;
        }

    }
}