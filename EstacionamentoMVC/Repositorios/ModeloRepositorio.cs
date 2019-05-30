using System.Collections.Generic;
using System.IO;
using EstacionamentoMVC.Models;

namespace EstacionamentoMVC.Repositorios
{
    public class ModeloRepositorio
    {
        private const string PATH = "Database/Modelo.csv";
        private List<Modelo> modelos = new List<Modelo>();   
        public List<Modelo> Listar(){
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros)
            {
                var valores = item.Split(";");
                Modelo modelo = new Modelo();
                modelo.Nome = valores[1];

                modelos.Add(modelo);
            }
            return modelos;
        }
    }
}