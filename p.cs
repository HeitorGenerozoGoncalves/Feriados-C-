using System;

namespace DiasU
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma data:  ");
            var data = Console.ReadLine();

            var dataConvertida = DateTime.ParseExact(data, "dd/mm/yyyy", CultureInfo.InvarianteCulture)

            Console.WriteLine("Esse dia é util: ${DiaUltio(dataConvertida)}");

            Console.ReadKey();
        }

        static bool DiaUltio(DateTime date)
        {
            return !FS(data) && !Fer(data);
        }

        static bool Fer(DateTime data)
        {
            var feriados = leitor_csv.pegarferiados()
            return feriados.Any(x => x.Date == date);
        }

        static bool FS(DateTime data)
        {
            return data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}

//FS = Fim de Semana
//Fer = Feriado