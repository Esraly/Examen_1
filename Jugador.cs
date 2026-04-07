namespace juego;
class Jugador{

<<<<<<< HEAD
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
=======
        public int DineroAhorrado = 300;
        int NdApuesta = 0; 
        public int dineroGanado =0;  
         Estadisticas est = new Estadisticas(300);
        Juego j = new Juego();

    public int Balance(int multiplicador, int NdApuesta){
        this.NdApuesta = NdApuesta;
        dineroGanado = NdApuesta * multiplicador;
>>>>>>> 7222fcbaeccc6cd92747286567e5ec77b1ad17a9
        return dineroGanado;
    }

    public int Ganar(int dineroGanado){
        this.dineroGanado = dineroGanado;
<<<<<<< HEAD
        _E.Balance += dineroGanado;
        return _E.Balance;
=======
        DineroAhorrado = DineroAhorrado+dineroGanado;
        return DineroAhorrado;
>>>>>>> 7222fcbaeccc6cd92747286567e5ec77b1ad17a9
    }

    public override string ToString()
    {
<<<<<<< HEAD
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
=======
        return ("Balance: " + dineroGanado);
    }
    public int Numeros(){
        DineroAapostar();
        Console.WriteLine("Ingrese el numero con el que va a apostar: ");
        int num = int.Parse(Console.ReadLine());

        if(j.NumAleatorio(num) == true){
>>>>>>> 7222fcbaeccc6cd92747286567e5ec77b1ad17a9
            Console.WriteLine("Ganaste");
            Balance(10,NdApuesta);
            Ganar(dineroGanado);
        }else{
            Console.WriteLine("Oh no, has perdido");
<<<<<<< HEAD
        }
        Console.WriteLine(ToString());
        Console.WriteLine("Presione enter para continuar...");
        return _E.Balance;
=======
            DineroAhorrado = DineroAhorrado - NdApuesta;
        }
        Console.WriteLine(ToString());
        return DineroAhorrado;
>>>>>>> 7222fcbaeccc6cd92747286567e5ec77b1ad17a9
    }

    public int Color(){
        DineroAapostar();
<<<<<<< HEAD
        Console.WriteLine("Ingrese el numero del color con el que va a apostar:");
        Console.WriteLine("1. Negro");
        Console.WriteLine("2. Rojo");
        int numC = int.Parse(Console.ReadLine());
        if(_J.Color(numC) == true){
            Console.WriteLine("Bien!, ganaste");
=======
        Console.WriteLine("Ingrese el color con el que va a apostar:");
        Console.WriteLine("1. Negro");
        Console.WriteLine("2. Rojo");
        Console.WriteLine("3. Sin color");
        int color = int.Parse(Console.ReadLine());
        if(j.CA(color) == true){
>>>>>>> 7222fcbaeccc6cd92747286567e5ec77b1ad17a9
            Balance(5,NdApuesta);
            Ganar(dineroGanado);
        }else{
            Console.WriteLine("Oh no, has perdido");
<<<<<<< HEAD
        }
        Console.WriteLine(ToString());
        Console.WriteLine("Presione enter para continuar...");
        return _E.Balance;
=======
            DineroAhorrado= DineroAhorrado-NdApuesta;
        }
        Console.WriteLine(ToString());
        return DineroAhorrado;
>>>>>>> 7222fcbaeccc6cd92747286567e5ec77b1ad17a9
    }

    public int ParImpar(){
        DineroAapostar();
        Console.WriteLine("Ingrese por cual quiere apostar:");
        Console.WriteLine("1.- Par");
        Console.WriteLine("2.- Impar");
        int num = int.Parse(Console.ReadLine());
<<<<<<< HEAD
        if(_J.ParOImpar(num) == true){
=======
        if(j.ParOImpar(num) == true){
>>>>>>> 7222fcbaeccc6cd92747286567e5ec77b1ad17a9
            Console.WriteLine("Bien!, ganaste");
            Balance(2,NdApuesta);
            Ganar(dineroGanado);
            Console.WriteLine(ToString());
        }else{
<<<<<<< HEAD
            Console.WriteLine("Oh no, has perdido");
            Console.WriteLine(ToString());
    }
        Console.WriteLine("Presione enter para continuar...");
        return _E.Balance;
=======
            DineroAhorrado = DineroAhorrado - NdApuesta;
            Console.WriteLine("Oh no, has perdido");
            Console.WriteLine(ToString());
    }
        return DineroAhorrado;
>>>>>>> 7222fcbaeccc6cd92747286567e5ec77b1ad17a9
    }
    public int DineroAapostar(){
        do{
        Console.WriteLine("¿Cuanto dinero quiere apostar?");
        NdApuesta = int.Parse(Console.ReadLine());
<<<<<<< HEAD
        _E.Balance -= NdApuesta;
        dineroPerdido += NdApuesta; 
=======
        DineroAhorrado = DineroAhorrado - NdApuesta;
>>>>>>> 7222fcbaeccc6cd92747286567e5ec77b1ad17a9
        if(NdApuesta%10 != 0){
            Console.WriteLine("La cantidad tiene que ser multiplo de 10.");
            Console.WriteLine("Intentelo de nuevo.");
        }
        }while(NdApuesta%10 != 0);
        return NdApuesta;
    }
}