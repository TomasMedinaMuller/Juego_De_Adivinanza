
public class Juego
{
    public Random random = new Random();
    public int nroRandom; 
    public int AdivinarNro;
    
    public void Comienzo(Validacion validacion)
    {
        
        Console.WriteLine("¡El juego ha comenzado!");
        Console.WriteLine("");
        Console.WriteLine("Adivine el número oculto 1 del al 10: ");
        Console.WriteLine("");
        Console.Write("Ingrese el número: ");
        validacion.validar();
        
    }

}
