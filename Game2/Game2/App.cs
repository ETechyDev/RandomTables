class App
{
    public static Base BaseGame = new Base();
    static void Main(string[] args)
    {
        BaseGame.Start();
        Console.WriteLine("Sum: " + BaseGame.sum);
        Console.WriteLine("Rapport: " + BaseGame.rapport);
    }
}