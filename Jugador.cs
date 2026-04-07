namespace juego;
class Jugador{

        int NdApuesta = 0; 
        public int dineroGanado;  
        public int dineroPerdido;
    private Juego _J;

    private Estadisticas _E;
    public Jugador(Estadisticas E, Juego J){
        _E = E;
        _J = J;
    }

    public int Balance(int multiplicador, int apuesta){
        this.NdApuesta = apuesta;
        dineroGanado = apuesta * multiplicador;
        return dineroGanado;
    }

    public int Ganar(int dineroGanado){
        this.dineroGanado = dineroGanado;
        _E.Balance += dineroGanado;
        return _E.Balance;
    }

    public override string ToString()
    {
        return ("Balance: " + _E.Balance);
    }
    public int Numeros(){
        DineroAapostar();
        int num;
        do{
            Console.WriteLine("Ingrese  un numero del 0 al 36 para apostar:");
            num = int.Parse(Console.ReadLine());
            if(num>36 || num<0){
                Console.WriteLine("Numero no valido, intentelo de nuevo.");
            }
        }while(num>36 || num<0);
        
        if(_J.NumAleatorio(num) == true){
            Console.WriteLine("Ganaste");
            Balance(10,NdApuesta);
            Ganar(dineroGanado);
        }else{
            Console.WriteLine("Oh no, has perdido");
        }
        Console.WriteLine(ToString());
        Console.WriteLine("Presione enter para continuar...");
        return _E.Balance;
    }

    public int Color(){
        DineroAapostar();
        Console.WriteLine("Ingrese el numero del color con el que va a apostar:");
        Console.WriteLine("1. Negro");
        Console.WriteLine("2. Rojo");
        int numC = int.Parse(Console.ReadLine());
        if(_J.Color(numC) == true){
            Console.WriteLine("Bien!, ganaste");
            Balance(5,NdApuesta);
            Ganar(dineroGanado);
        }else{
            Console.WriteLine("Oh no, has perdido");
        }
        Console.WriteLine(ToString());
        Console.WriteLine("Presione enter para continuar...");
        return _E.Balance;
    }

    public int ParImpar(){
        DineroAapostar();
        Console.WriteLine("Ingrese por cual quiere apostar:");
        Console.WriteLine("1.- Par");
        Console.WriteLine("2.- Impar");
        int num = int.Parse(Console.ReadLine());
        if(_J.ParOImpar(num) == true){
            Console.WriteLine("Bien!, ganaste");
            Balance(2,NdApuesta);
            Ganar(dineroGanado);
            Console.WriteLine(ToString());
        }else{
            Console.WriteLine("Oh no, has perdido");
            Console.WriteLine(ToString());
    }
        Console.WriteLine("Presione enter para continuar...");
        return _E.Balance;
    }
    public int DineroAapostar(){
        do{
        Console.WriteLine("¿Cuanto dinero quiere apostar?");
        NdApuesta = int.Parse(Console.ReadLine());
        _E.Balance -= NdApuesta;
        dineroPerdido += NdApuesta; 
        if(NdApuesta%10 != 0){
            Console.WriteLine("La cantidad tiene que ser multiplo de 10.");
            Console.WriteLine("Intentelo de nuevo.");
        }
        }while(NdApuesta%10 != 0);
        return NdApuesta;
    }
}