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


            // GravarUsandoEntity();
            AutenticacaoDados();





            Console.ReadLine();
        }

        private static void RetornarTabela()
        {
            using (var repo = new EstudioContext())
            {

                IList<Agenda> produtos = repo.Produtos.ToList();


                foreach (var item in produtos)
                {

                    Console.WriteLine(item.Nome);

                }


            }
        }

            private static void GravarUsandoEntity()
        {
            Agenda p = new Agenda();
            p.Nome = "Himos";
            p.horaEntrada = new DateTime(2019, 08, 16, 14, 20, 00);
            p.horaSaida = new DateTime(2019,08,16,15,20,00);

            DateTime teste = new DateTime(2019, 08, 16, 13, 20, 00);

            using (var contexto = new EstudioContext())
            {


                Console.WriteLine(p.horaEntrada);


            }


        }

        private static void AutenticacaoDados()
        {
            Agenda p = new Agenda();
            p.Nome = "Himos";
            p.horaEntrada = new DateTime(2019, 08, 16, 9, 30, 00);
            p.horaSaida = new DateTime(2019, 08, 16, 23, 20, 00);

            using (var repo = new EstudioContext())
            {
                // logica para aplicar(https://pt.stackoverflow.com/questions/256030/l%C3%B3gica-para-validar-hor%C3%A1rios-livres-em-agenda)



                IList<Agenda> produtos = repo.Produtos
                       .Where(c => p.horaEntrada <= c.horaSaida && p.horaSaida >= c.horaEntrada).ToList();
                
                
                                
                if (produtos.Count==0)
                {
                   // repo.Produtos.Add(p);
                   // repo.SaveChanges();
                    Console.WriteLine("gravamos");
                }
                else
                {
                    foreach (var item in produtos)
                    {

                        Console.WriteLine(item.horaEntrada);
                        Console.WriteLine(item.horaSaida);

                    }
                }


            }
            
        }

        private static void removerProduto()
        {
            using (var repo = new EstudioContext())
            {

            }

        }

    }
}
