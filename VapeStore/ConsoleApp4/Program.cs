using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoqueVapeStore
{
    class Program
    {
        static void Main(string[] args)
        {

            int op;
            int idProd;

            Console.WriteLine("==Roque Vape Store==\n\n");
            Console.WriteLine("0 - SAIR");
            Console.WriteLine("1 - VENDER");
            Console.WriteLine("2 - LISTAR PRODUTOS\n");
            Console.Write("Escolha a opção desejada: ");
            op = Convert.ToInt16(Console.ReadLine());
            do
            {
                switch (op)
                {
                    case 0:

                        break;

                    case 1:
                        CalculosCaixa calc = new CalculosCaixa();

                        Console.Clear();

                        Console.WriteLine("=========VENDAS========= \n");
                        Console.WriteLine("1 - Vaporesso Pod Zenova Zero        R$200,00");
                        Console.WriteLine("2 - VooPoo Mod Drag      R$350,00");
                        Console.WriteLine("3 - Bateria Samsung 30q      R$50,00");
                        Console.WriteLine("4 - Carregador NiteCore IW4 New  R$120,00\n\n");

                        Console.WriteLine("Escolha o produto: ");
                        idProd = Convert.ToInt16(Console.ReadLine());

                        if (idProd == 1)
                        {
                            calc.Valor = 200m;
                        }
                        else if (idProd == 2)
                        {
                            calc.Valor = 350m;

                        }
                        else if (idProd == 3)
                        {
                            calc.Valor = 50m;

                        }
                        else
                        {
                            calc.Valor = 120m;

                        }




                        Console.Write("Quantidade de produtos: ");
                        calc.Qtd = Convert.ToInt16(Console.ReadLine());

                        decimal total = calc.Total();
                        Console.WriteLine("Total: {0}", total);
                        Console.Write("Dinheiro recebido: R$ ");
                        calc.Dinheiro = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine();
                        decimal troco = calc.Troco();
                        Console.Write("Troco: {0}", troco);

                        Console.ReadKey();

                        break;

                    case 2:

                        Console.WriteLine("=========PRODUTOS========= \n");
                        Console.WriteLine("1 - Vaporesso Pod Zenova Zero        R$200,00");
                        Console.WriteLine("2 - VooPoo Mod Drag      R$350,00");
                        Console.WriteLine("3 - Bateria Samsung 30q      R$50,00");
                        Console.WriteLine("4 - Carregador NiteCore IW4 New  R$120,00\n");

                        Console.WriteLine("Pressione uma tecla para voltar.");
                        Console.ReadKey();

                        break;
                }

            } while (op != 0);
        }

    }
}

