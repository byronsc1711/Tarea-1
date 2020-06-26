//Byron Guaygua

using System;

namespace ConsoleTarea1
{
    class Cuadrado
    {
        private int lado;
        public void Inicializar()
        {
            Console.Write("Ingrese el valor numérico de el lado :");
            string linea;
            linea = Console.ReadLine();
            lado = int.Parse(linea);
        }

        //uso del metodo para que imprima el valor del perimetro del cuadrado
        public void ImprimirPerimetro()
        {
            int perimetro;
            perimetro = lado * 4;
            Console.WriteLine("El perímetro del cuadrado es:" + perimetro);
        }

        //uso del metodo para que imprima el valor de la superficie del cuadrado
        public void ImprimirSuperficie()
        {
            int superficie;
            superficie = lado * lado;
            Console.WriteLine("La superficie del cuadrado es:" + superficie);
        }

        static void Main(string[] args)
        {
            Cuadrado cuadradoFinal = new Cuadrado();
            cuadradoFinal.Inicializar();
            cuadradoFinal.ImprimirPerimetro();
            cuadradoFinal.ImprimirSuperficie();
            Console.ReadKey();
        }
    }
}

