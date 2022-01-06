using System;
using System.Globalization;
using System.IO;
using csv;

namespace leituraF
{
    public static class leitor_csv
    {
        public static IEnumerable<feriados> pegarferiados()
        {
            var feriados = new List<feriados>();
            var linhas = File.ReadAllLines("./lista_f.csv");

            foreach (var linha in linhas)
            {
                var dados = linhas.Split(",");
                feriados.Add(new feriados(DateTime.ParseExact(dados [0], "dd/mm/yyyy", CultureInfo.InvarianteCulture), dados[1]));
                
            }
                return feriados;
        }
    }
}