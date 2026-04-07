namespace juego;

class Estadisticas {
    public int Tgiros = 0;
    public int[] Contador = new int[37];
    public int R;
    public int N;
    public int Par;
    public int Impar;
    public int Balance;

    public Estadisticas(int dineroInicial) {
        Balance = dineroInicial;
    }

    public void MostrarStats() {
        // 1. Inicializamos aquí adentro para que tomen los valores actuales del arreglo
        int valorMax = Contador[0];
        int valorMin = Contador[0];

        // 2. Buscamos los valores reales en el arreglo
        for (int i = 0; i < Contador.Length; i++) {
            if (Contador[i] > valorMax) {
                valorMax = Contador[i];
            }
            if (Contador[i] < valorMin) {
                valorMin = Contador[i];
            }
        }

        Console.WriteLine("\n--- ESTADÍSTICAS ---");
        Console.WriteLine($"Balance actual: ${Balance}");
        Console.WriteLine($"Giros totales: {Tgiros}");
        
        // Usamos Array.IndexOf para encontrar qué número (índice) tiene ese valor
        Console.WriteLine($"Número que más salió: {Array.IndexOf(Contador, valorMax)} ({valorMax} veces)");
        Console.WriteLine($"Número que menos salió: {Array.IndexOf(Contador, valorMin)} ({valorMin} veces)");
        
        Console.WriteLine($"Rojos: {R} | Negros: {N}");
        Console.WriteLine($"Pares: {Par} | Impares: {Impar}");
        Console.WriteLine("--------------------\n");
    }
}