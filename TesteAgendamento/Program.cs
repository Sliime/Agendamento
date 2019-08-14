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

            hora.getData();
            hora.enviarData(14, 8, 22);

           

            Console.ReadLine();
        }
    }
}
