using System.Collections.Generic;
using EstacionamentoMVC.Models;

namespace EstacionamentoMVC.ViewModels
{
    public class CarroViewModel
    {
        public List<Marca> Marcas { get; set;}
        public List<Modelo> Modelos { get; set;}
    }
}