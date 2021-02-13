using System;
using System.Globalization;
namespace Exercício_9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double lucro,plucro, somavenda, somacompra, lucrototal;
            int c, c1, c2;
            c = 0;
            c1 = 0;
            c2 = 0;
            somacompra = 0;
            somavenda = 0;
            lucrototal = 0;
            int n = int.Parse(Console.ReadLine());

            string[] nome;
            double[] compra;
            double[] venda;

            nome = new string[n];
            compra = new double[n];
            venda = new double[n];

            
            for (int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                nome[i] = vetor[0];
                compra[i] = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                venda[i] = double.Parse(vetor[2], CultureInfo.InvariantCulture);
                somacompra += compra[i];
                somavenda += venda[i];
            }

            

            lucrototal = somavenda - somacompra;



            for (int i = 0; i < n; i++)
            {


                lucro = (venda[i] - compra[i]);

                plucro = lucro / compra[i] * 100;

                if (plucro < 10.0)
                {
                    c++;
                }
                if (plucro >= 10.0 && plucro <= 20.0)
                {
                    c1++;
                }
                if (plucro > 20.0)
                {
                    c2++;
                }


            }

            Console.WriteLine();
            Console.WriteLine("Lucro abaixo de 10% : " + c);
            Console.WriteLine();
            Console.WriteLine("Lucro entre 10% e 20% : " + c1);
            Console.WriteLine();
            Console.WriteLine("Lucro acima de 20% : " + c2);
            Console.WriteLine();
            Console.WriteLine("Valor total de compra : " + somacompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Valor total da venda : " + somavenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Lucro total : " + lucrototal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
