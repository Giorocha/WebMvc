using System;
using System.Collections.Generic;
using System.IO;
using EstacionamentoMVC.Models;

namespace EstacionamentoMVC.Repositorios {
    public class CarroRepositorio {
        private const string PATH = "Database/Cadastros.csv";

        public bool Inserir (Registro cadastro) {
            try {

                if (!File.Exists (PATH)) {
                    File.Create (PATH).Close ();
                }
                var registro = $"{cadastro.Id};{cadastro.NomeUsuario};{cadastro.PlacaCarro};{cadastro.MarcaCarro.Nome};{cadastro.ModeloCarro.Nome};{cadastro.DataHorárioEntrada}\n";

                File.AppendAllText (PATH, registro);

            } catch (Exception e) {

                System.Console.WriteLine ("Chegou no catch!");
                System.Console.WriteLine (e.StackTrace);
            }

            return true;
        }

        public List<Registro> Listar () {

            List<Registro> listaDeRegistros = new List<Registro> ();

            string[] linhas = File.ReadAllLines ("Cadastro.csv");
            Registro registro;

            foreach (var item in linhas) {
                if (string.IsNullOrEmpty (item)) {
                    continue;
                }

                string[] linha = item.Split (";");

                registro = new Registro (
                    id: int.Parse (linha[0]),
                    nome: linha[1],
                    placa: linha[2],
                    marca: linha[3],
                    modelo: linha[4],
                    data: DateTime.Parse (linha[5])

                );
                listaDeRegistros.Add (registro);
            }
            return listaDeRegistros;

        }
    }
}