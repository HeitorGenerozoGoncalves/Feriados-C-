using System;

namespace csv;
{
    public class feriados;
    {
        public feriados (DateTime data, string1 dia ,string2 descrição)
        {
            Data = data;
            Dia = dia;
            Descrição = descrição;
        }

        public DateTime Data {get; set;}

        public string1 Dia {get; set;}

        public string2 Descrição {get; set;}

        public string DataInteira => Data.ToString("dd/mm/yyyy");
    }
}