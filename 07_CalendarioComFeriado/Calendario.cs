using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace _07_CalendarioComFeriado

{

    internal class Calendario

    {

        private int ano;

        private int mes;

        private DateTime primeiroDiaMes;

        private int[,] calendario;

        public Calendario(int ano, int mes)

        {

            this.ano = ano;

            this.mes = mes;

            primeiroDiaMes = new DateTime(ano, mes, 1);

            calendario = new int[6, 7];

            gerarCalendario();

        }

        private void gerarCalendario()

        {

            //Descobre a quantidade de dias de um mês

            int diasDoMes = DateTime.DaysInMonth(ano, mes);


            // primeiroDiaMes = new DateTime(ano, mes, 1);

            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;

            //Matriz de 6 semanas e 7 dias

            calendario = new int[6, 7];

            int dia = 1;

            //Preenche a matriz com os dias do mês

            for (int semana = 0; semana < 6; semana++)

            {

                for (int diaSemana = 0; diaSemana < 7; diaSemana++)

                {

                    if (semana == 0 && diaSemana < diaSemanaInicio)

                    {

                        calendario[semana, diaSemana] = 0;

                    }

                    else if (dia <= diasDoMes)

                    {

                        calendario[semana, diaSemana] = dia;

                        dia++;

                    }

                }

            }

        }

        public void imprimirCalendario()

        {

            Console.WriteLine($"\nCalendário de " +

                                $"{primeiroDiaMes.ToString("MMMM")} de {ano}");

            Console.WriteLine("DOM\tSEG\tTER\tQUA\tQUI\tSEX\tSAB");


            Feriado[] diasFeriados = RetornaFeriados();
          //  bool ehFeriado;

            //impressão do calendário

            for (int semana = 0; semana < 6; semana++)

            {

                for (int diaSemana = 0; diaSemana < 7; diaSemana++)

                {

                    if (calendario[semana, diaSemana] != 0)

                    {
                        //ehFeriado = false;

                        //for (int posicaoFeriados = 0; posicaoFeriados < diasFeriados.Length; posicaoFeriados++)
                        //{
                        //    if (diasFeriados[posicaoFeriados] != null && diasFeriados[posicaoFeriados].Dia == calendario[semana,diaSemana])
                        //    {
                        //        ehFeriado = true;
                        //        break;
                        //    }
                        //}

                        // if (diasFeriados.Contains(calendario[semana, diaSemana]) || diaSemana == 0)
                       // if (ehFeriado || diaSemana == 0)
                            if (diasFeriados.Any(feriado => feriado != null && feriado.Dia == calendario[semana, diaSemana] ) || diaSemana == 0)
                            

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write(calendario[semana, diaSemana].ToString("D2") + "\t");

                        Console.ResetColor();

                    }

                    else

                    {

                        Console.Write("\t");

                    }

                }

                Console.WriteLine();

            }

            Console.Write("\nFeriados: ");

            /*for (int i = 0; i < diasFeriados.Length; i++)

            {

                if (diasFeriados[i] > 0)

                {

                    Console.Write($"{diasFeriados[i].ToString("D2")}\t");

                }

            }*/
            foreach(Feriado diaFeriado in diasFeriados)
            {
                if(diaFeriado != null)
                Console.Write($"{diaFeriado.Dia:D2}-{diaFeriado.Descricao}\t");
            }

        }

        private Feriado[] RetornaFeriados()

        {

            Feriado[] feriados = new Feriado[15];

            int indice = 0;

            //feriados[indice++] = 11;

            //feriados[indice++] = 21;

            if (mes == 1)

                feriados[indice++] = new Feriado(1, "Confraternização Universal");

            else if (mes == 4)

            {

                feriados[indice++] = new Feriado(4, "Aniversário de marilia");

                feriados[indice++] = new Feriado(21, "Tiradentes");

            }

            else if (mes == 5)

                feriados[indice++] = new Feriado(1, "Dia do Trabalho");

            else if (mes == 7)

                feriados[indice++] = new Feriado(9, "Revolução Constitucionalista de SP");

            else if (mes == 9)

                feriados[indice++] = new Feriado(7, "Independência do Brasil");

            else if (mes == 10)

                feriados[indice++] = new Feriado(12, "Nossa Senhora Aparecida");

            else if (mes == 11)

            {

                feriados[indice++] = new Feriado(2, "Finados");

                feriados[indice++] = new Feriado(15, "Proclamação da República");

                feriados[indice++] = new Feriado(20, "Consciência Negra");

            }

            else if (mes == 12)
            {

                feriados[indice++] = new Feriado(8, "Padroeira da Cidade");

                feriados[indice++] = new Feriado(25, "Natal");
            }
            DateTime pascoa = DomingoDePascoa();

            if (pascoa.Month == mes)

            {

                feriados[indice++] = new Feriado (pascoa.Day, "Páscoa");

            }

            DateTime carnaval = pascoa.AddDays(-47);

            if (carnaval.Month == mes)

            {

                feriados[indice++] = new Feriado(carnaval.Day, "Carnaval");

            }

            DateTime sextaFeiraSanta = pascoa.AddDays(-2);

            if (sextaFeiraSanta.Month == mes)

            {

                feriados[indice++] = new Feriado(sextaFeiraSanta.Day, "Sexta feira Santa");

            }

            DateTime corpusChristi = pascoa.AddDays(60);

            if (corpusChristi.Month == mes)

            {

                feriados[indice++] = new Feriado(corpusChristi.Day, "Corpus Christi");

            }

            //Console.WriteLine($"Pascoa: {pascoa.ToString("dd/MM/yyyy")} Carnaval {carnaval.ToString("dd/MM/yyyy")} " +

            //    $"sextaSanta {sextaSanta.ToString("dd/MM/yyyy")} corpusChristi {corpusChristi.ToString("dd/MM/yyyy")}");

           // Array.Sort(feriados);

            return feriados;

        }

        public DateTime DomingoDePascoa()

        {

            DateTime domingoDePascoa;

            int X = 24, Y = 5;

            if (ano <= 1699)

            {

                X = 22;

                Y = 2;

            }

            else if (ano <= 1799)

            {

                X = 23;

                Y = 3;

            }

            else if (ano <= 1899)

            {

                X = 24;

                Y = 4;

            }

            else if (ano <= 2099)

            {

                X = 24;

                Y = 5;

            }

            else if (ano <= 2199)

            {

                X = 24;

                Y = 6;

            }

            else if (ano <= 2299)

            {

                X = 24;

                Y = 7;

            }

            int a = ano % 19;

            int b = ano % 4;

            int c = ano % 7;

            int d = (19 * a + X) % 30;

            int g = (2 * b + 4 * c + 6 * d + Y) % 7;

            int dia, mes;

            if (d + g > 9)

            {

                dia = d + g - 9;

                mes = 4; // Abril

            }

            else

            {

                dia = d + g + 22;

                mes = 3; // Março

            }

            // cria a variável e atribui

            domingoDePascoa = new DateTime(ano, mes, dia);

            return domingoDePascoa;


        }

    }

}





