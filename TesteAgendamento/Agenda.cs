using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAgendamento
{
    public class Agenda
    {
       

        public int Dia { get; private set; }
        public int Ano { get; private set; }
        public int Hora { get; private set; }
        public int Mes { get; private set; }
        public Agenda()
        {
            Dia = DateTime.Now.Day;
            Ano = DateTime.Now.Year;
            Hora = DateTime.Now.Hour;
            Mes = DateTime.Now.Month;
        }

        public void getData()
        {
            Console.WriteLine($"Dia {Dia} do mes {Mes} de {Ano} horario {Hora}") ;

        }

        public void enviarData(int dia, int mes, int hora)
        {
            if (dia < Dia | hora < 10.00 | hora >23.00| mes < Mes)
            {
                Console.WriteLine("Por favor verifique a hora e data se está de acordo com nossa agenda!");
            }
            else
            {
                Console.WriteLine("Cadastrado com sucesso");
            }
            

        }

    }
}
