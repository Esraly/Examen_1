namespace juego;
class Program{
    static void Main(string[] args){
        Estadisticas estadisticas = new Estadisticas(300);
        Juego juego = new Juego(estadisticas);
        Jugador jugador = new Jugador(estadisticas, juego);
        Menu menu = new Menu(estadisticas, jugador);
        bool MostrarMenu=true;
        while(MostrarMenu){
            MostrarMenu = menu.ShowMenu();
        }
    }
}