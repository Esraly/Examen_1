namespace juego;
class Menu{
        Juego j = new Juego();
        Jugador jug = new Jugador();
        Estadisticas est = new Estadisticas(300);
        int NdApuesta;
        public bool ShowMenu(){
        Console.Clear();
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
                jug.Numeros();
                est.Tgiros++;
                Console.ReadLine();
                return true;
            case "2":
                Console.Clear();
                jug.Color();
                est.Tgiros++;
                Console.ReadLine();
                return true;
            case "3":
                Console.Clear();
                jug.ParImpar();
                est.Tgiros++;
                Console.ReadLine();
                return true;
            case "4":
                Console.Clear();
                est.MostrarStats();
                Console.ReadLine();
                return true;
            case "5":
                Console.Clear();
                Console.WriteLine("Muy bien, que le vaya bien!");
                return false;
            default:
                return true;
        }
        
    }

}