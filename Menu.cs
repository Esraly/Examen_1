using System.Reflection.Metadata.Ecma335;

namespace juego;
class Menu{
    private Estadisticas _E;
    private Jugador _J;
    public Menu(Estadisticas E, Jugador J){
        _E = E;
        _J = J;
    }
    public bool ShowMenu(){
        while(_E.Balance>0)
        {        
            Console.Clear();
            Console.WriteLine("Balance inicial es de: " + _E.Balance);
            Console.WriteLine("¿Como quieres apostar? ");
            Console.WriteLine("1.- Por numero (x10)");        
            Console.WriteLine("2.- Por color (x5)");                
            Console.WriteLine("3.- Por par o impar (x2)");       
            Console.WriteLine("4.- Estadisticas");
            Console.WriteLine("5.- Salir ");
            Console.Write("Opcion: ");
            switch(Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    _J.Numeros();
                    _E.Tgiros++;
                    Console.ReadLine();
                    return true;
    
                case "2":
                    Console.Clear();
                    _J.Color();
                    _E.Tgiros++;
                    Console.ReadLine();
                    return true;
            
                case "3":
                    Console.Clear();
                    _J.ParImpar();
                    _E.Tgiros++;
                    Console.ReadLine();
                    return true;

                case "4":
                    Console.Clear();
                    _E.MostrarStats();
                    Console.ReadLine();
                    return true;

                case "5":
                    Console.Clear();
                    Console.WriteLine("Hasta la proxima!");
                    return false;
                
                default:
                    return true;
                }
            }

            Console.WriteLine("Oh no, te has quedado sin dinero!");
            Console.WriteLine($"Ganaste {_J.dineroGanado}");
            Console.WriteLine($"Perdiste {_J.dineroPerdido}");
            Console.ReadLine();
            Console.WriteLine("¿Quieres volver a intentarlo? (s/n)");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta == "s")            {
                _E.Balance = 300; // Reiniciar el balance
                _E.Tgiros = 0; // Reiniciar giros
                _E.R = 0; // Reiniciar rojos
                _E.N = 0; // Reiniciar negros
                _E.Par = 0; // Reiniciar pares
                _E.Impar = 0; // Reiniciar impares
                ShowMenu(); // Volver a mostrar el menú
            }
            else
            {
                Console.WriteLine("Gracias por jugar, ¡hasta la próxima!");
                return false;
            }
            return true;
        } 
        
}