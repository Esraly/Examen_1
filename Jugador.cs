namespace juego;
class Jugador{

        public int DineroAhorrado = 300;
        int NdApuesta = 0; 
        public int dineroGanado =0;  
         Estadisticas est = new Estadisticas(300);
        Juego j = new Juego();

    public int Balance(int multiplicador, int NdApuesta){
        this.NdApuesta = NdApuesta;
        dineroGanado = NdApuesta * multiplicador;
        return dineroGanado;
    }

    public int Ganar(int dineroGanado){
        this.dineroGanado = dineroGanado;
        DineroAhorrado = DineroAhorrado+dineroGanado;
        return DineroAhorrado;
    }

    public override string ToString()
    {
        return ("Balance: " + dineroGanado);
    }
    public int Numeros(){
        DineroAapostar();
        Console.WriteLine("Ingrese el numero con el que va a apostar: ");
        int num = int.Parse(Console.ReadLine());

        if(j.NumAleatorio(num) == true){
            Console.WriteLine("Ganaste");
            Balance(10,NdApuesta);
            Ganar(dineroGanado);
        }else{
            Console.WriteLine("Oh no, has perdido");
            DineroAhorrado = DineroAhorrado - NdApuesta;
        }
        Console.WriteLine(ToString());
        return DineroAhorrado;
    }

    public int Color(){
        DineroAapostar();
        Console.WriteLine("Ingrese el color con el que va a apostar:");
        Console.WriteLine("1. Negro");
        Console.WriteLine("2. Rojo");
        Console.WriteLine("3. Sin color");
        int color = int.Parse(Console.ReadLine());
        if(j.CA(color) == true){
            Balance(5,NdApuesta);
            Ganar(dineroGanado);
        }else{
            Console.WriteLine("Oh no, has perdido");
            DineroAhorrado= DineroAhorrado-NdApuesta;
        }
        Console.WriteLine(ToString());
        return DineroAhorrado;
    }

    public int ParImpar(){
        DineroAapostar();
        Console.WriteLine("Ingrese por cual quiere apostar:");
        Console.WriteLine("1.- Par");
        Console.WriteLine("2.- Impar");
        int num = int.Parse(Console.ReadLine());
        if(j.ParOImpar(num) == true){
            Console.WriteLine("Bien!, ganaste");
            Balance(2,NdApuesta);
            Ganar(dineroGanado);
            Console.WriteLine(ToString());
        }else{
            DineroAhorrado = DineroAhorrado - NdApuesta;
            Console.WriteLine("Oh no, has perdido");
            Console.WriteLine(ToString());
    }
        return DineroAhorrado;
    }
    public int DineroAapostar(){
        do{
        Console.WriteLine("¿Cuanto dinero quiere apostar?");
        NdApuesta = int.Parse(Console.ReadLine());
        DineroAhorrado = DineroAhorrado - NdApuesta;
        if(NdApuesta%10 != 0){
            Console.WriteLine("La cantidad tiene que ser multiplo de 10.");
            Console.WriteLine("Intentelo de nuevo.");
        }
        }while(NdApuesta%10 != 0);
        return NdApuesta;
    }
}