using System;

namespace EstacionamentoMVC.Models
{
    public class Registro
    {
        public int Id { get; set;}
        public string NomeUsuario { get; set;}

        public Marca MarcaCarro { get; set;}
        public Modelo ModeloCarro { get; set;}
        public string PlacaCarro { get; set;}
        public DateTime DataHorárioEntrada { get; set;}


        public Registro(string nome, string marca, string modelo, string placa){
            this.NomeUsuario = nome;
            this.MarcaCarro = new Marca();
            this.MarcaCarro.Nome = marca;
            this.ModeloCarro = new Modelo();
            this.ModeloCarro.Nome = modelo;
            this.PlacaCarro = placa;
           
        }
        public Registro(int id, string nome, string marca, string modelo, string placa, DateTime data){
            this.Id = id;
            this.NomeUsuario = nome;
            this.MarcaCarro = new Marca();
            this.MarcaCarro.Nome = marca;
            this.ModeloCarro = new Modelo();
            this.ModeloCarro.Nome = modelo;
            this.PlacaCarro = placa;
            this.DataHorárioEntrada = data;
           
        }
    }
}