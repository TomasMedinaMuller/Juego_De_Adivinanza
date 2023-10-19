class Program : Juego
{
    static void Main(string[] args)
    {
        Program app = new Program();
        Validacion validacion = new Validacion();
        app.Comienzo(validacion);
    }
}
