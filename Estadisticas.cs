namespace juego;
class Estadisticas{
    public int Balance;
    public int Tgiros;
    public int R;
    public int N;
    public int Par;
    public int Impar;

    public Estadisticas(int Balance)
    {
        this.Balance = Balance;
        Tgiros = 0;
        R = 0;
        N = 0;
        Par = 0;
        Impar = 0;
    }

    public void MostrarStats(){
        Console.WriteLine($"Balance:{Balance}");
        Console.WriteLine($"Giros de ruleta: {Tgiros}");
        Console.WriteLine($"Rojos:{R}");
        Console.WriteLine($"Negros:{N}");
        Console.WriteLine($"Par:{Par}");
        Console.WriteLine($"Impar:{Impar}");
    }
}