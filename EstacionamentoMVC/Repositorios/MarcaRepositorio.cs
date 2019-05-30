using System.Collections.Generic;
using System.IO;
using EstacionamentoMVC.Models;

namespace EstacionamentoMVC.Repositorios
{
    public class MarcaRepositorio
    {
        private const string PATH = "Database/Marca.csv";
        private List<Marca> marcas = new List<Marca>();   
        public List<Marca> Listar(){
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros)
            {
                var valores = item.Split(";");
                Marca marca = new Marca();
                marca.Nome = valores[1];

                marcas.Add(marca);
            }
            return marcas;
        }
    }
}