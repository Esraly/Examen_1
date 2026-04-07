namespace juego;
class Program{
    static void Main(string[] args){
<<<<<<< HEAD
        Estadisticas estadisticas = new Estadisticas(300);
        Juego juego = new Juego(estadisticas);
        Jugador jugador = new Jugador(estadisticas, juego);
        Menu menu = new Menu(estadisticas, jugador);
=======
        Menu menu = new Menu();
>>>>>>> 7222fcbaeccc6cd92747286567e5ec77b1ad17a9
        bool MostrarMenu=true;
        while(MostrarMenu){
            MostrarMenu = menu.ShowMenu();
        }
    }
}