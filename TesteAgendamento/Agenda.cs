using System;
using System.Collections;
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
        public DateTime completo { get; private set; }

        public Agenda()
        {
            Dia = DateTime.Now.Day;
            Ano = DateTime.Now.Year;
            Hora = DateTime.Now.Hour;
            Mes = DateTime.Now.Month;

            completo = new DateTime(2019, 8, 14, 10, 30, 22);
        }

        public void getData()
        {
            // Console.WriteLine($"Dia {Dia} do mes {Mes} de {Ano} horario {Hora}") ;

            Console.WriteLine(completo);

        }

        public void validaData(List<DateTime> lista, DateTime desejado, DateTime horasDesejadas)
        {

            foreach(var item in lista)
            {
                // 8:20:22 < 9:30:22 
                //https://pt.stackoverflow.com/questions/256030/l%C3%B3gica-para-validar-hor%C3%A1rios-livres-em-agenda
                
                
            }



        }

        public DateTime calcularHora (DateTime desejado, int horas)
        {

            DateTime horaSaida = desejado.AddHours(horas);

            

            return horaSaida;
        }

       
    }
}

