using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Validacion : Juego
{
    public int[] NroCargados = new int[100000000];
    public int contador;

    public void validar()
    {

        nroRandom = random.Next(1, 10);

        AdivinarNro = int.Parse(Console.ReadLine());
        NroCargados[contador] = AdivinarNro;
        contador++;

        Rango();

        Console.Clear();

        do
        {
           
            if (AdivinarNro > nroRandom)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Estuviste cerca, elnúmero oculto es menor que: " + AdivinarNro);

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Vuelve a ingresar el número: ");
                AdivinarNro = int.Parse(Console.ReadLine());

                NroCargados[contador] = AdivinarNro;
                contador++;

                Rango();
                Console.Clear();
            }
        
            else if (AdivinarNro < nroRandom)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Estuviste cerca, elnúmero oculto es mayor que: " + AdivinarNro);
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Vuelve a ingresar el número: ");
                AdivinarNro = int.Parse(Console.ReadLine());

                NroCargados[contador] = AdivinarNro;
                contador++;

                Rango();
                Console.Clear();
            }
            
        } while (AdivinarNro != nroRandom);

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("GANASTE EL NUMERO ERA: " + AdivinarNro);
        Console.WriteLine(" ");

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Los números ingresados fueron: ");
        for (int i = 0; i < contador; i++)
        {
            Console.Write(NroCargados[i] + " ");
        }
        Console.WriteLine();
    }
    private void Rango()
    {
        while (AdivinarNro < 1 || AdivinarNro > 10)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El número ingresado debe estar entre 1 y 10, ambos inclusive.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Vuelva a ingresar el número: ");
            AdivinarNro = int.Parse(Console.ReadLine());
            NroCargados[contador] = AdivinarNro;
            contador++;
        }
    }
}
