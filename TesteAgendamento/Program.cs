using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TesteAgendamento
{
    class Program
    {
        static void Main(string[] args)
        {


            Agenda hora = new Agenda();
            DateTime now = DateTime.Now;
            DateTime later = new DateTime(2019,8,14,10,20,22);
            DateTime desejado = new DateTime(2019, 8, 14, 7, 30, 22);


            var lista = new List<DateTime>()
            {
                new DateTime(2019,8,14,9,30,22),
                new DateTime(2019,8,14,16,30,22),
                new DateTime(2019,8,14,14,30,22)
            };

            DateTime terminoHora = hora.calcularHora(later, 1);


            hora.validaData(lista, later, terminoHora);

            

           
           

            Console.ReadLine();
        }
    }
}
