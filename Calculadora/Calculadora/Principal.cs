using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Principal
    {
        public void Bienvenida()
        {
            Console.WriteLine("Calculadora aritmetica: ");
            Console.WriteLine("Daniel Alejandro Silva Ramirez");
            Menu();
        }
        public void Menu()
        {
            Operaciones op = new Operaciones();
            Valores x = new Valores();
            int n;
            double Res;
            Console.WriteLine("Escoja una opcion: " +
                "1.-Sumar " +
                "2.-Restar " +
                "3.-Multiplicar " +
                "4.-Dividir " +
                "5.-Salir ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un valor: ");
            x.Valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese otro valor: ");
            x.Valor2 = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case 1: 
                    Res = op.Sumar(x.Valor, x.Valor2);
                    Console.WriteLine(Res);
                    break;
                case 2:
                    Res = op.Restar(x.Valor, x.Valor2);
                    Console.WriteLine(Res);
                    break;
                case 3:
                    Res = op.Multiplicar(x.Valor, x.Valor2);
                    Console.WriteLine(Res);
                    break;
                case 4:
                    Res = op.Dividir(x.Valor, x.Valor2);
                    Console.WriteLine(Res);
                    break;
                default:
                    Console.WriteLine("Ingrese un numero valido ");
                    break;
            }
        }
    }
}
