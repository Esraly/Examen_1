namespace juego;
class Juego{
    Random rnd = new Random();
    int[] negros = new int[] {2,4,6,8,10,11,13,15,17,20,22,24,26,28,29,31,33,35};
    int[] rojos = new int[] {1,3,5,7,9,12,14,16,18,19,21,23,25,27,30,32,34,36};
    private Estadisticas _E;
    public Juego(Estadisticas E)
    {
        _E = E;
    }
    public bool Color(int numC){
        int num = rnd.Next(0,37);
        Console.WriteLine("Numero de ruleta: " + num);
        if (num == 0)
        {
            Console.WriteLine("Color: Sin color");
            return false;
        }
        else if (Array.Exists(negros, x => x == num))
        {        
            if(numC == 1)
            {
                 Console.WriteLine("Color: Negro");
                _E.N++;
                return true;
            }
            else
            {
                 Console.WriteLine("Color: Negro");
                _E.N++;
                return false;
            }
           
        }
        else
        {
            if(numC == 2)
            {
                 Console.WriteLine("Color: Rojo");
                _E.R++;
                return true;
            }
            else
            {
                 Console.WriteLine("Color: Rojo");
                _E.R++;
                return false;
            }
        }
    }

    public bool NumAleatorio(int numA){
        int num = rnd.Next(0,37);
        
        Console.WriteLine("Numero de ruleta: " + num);
        _E.Contador[num]++;
        if(numA == num){
            return true;
        }else{
            return false;
        }
    }
    public bool ParOImpar(int numA){
        int num = rnd.Next(0,37);
        Console.WriteLine("Numero de ruleta: " + num);
        _E.Contador[num]++;
        if(numA == 1){
            if(NumParImpar(num) == true){
                _E.Par++;
                return true;
            }else{
                _E.Par++;
                return false;
            }
        }else if(numA == 2){
             if(NumParImpar(num) == false){
                _E.Impar++;
                return true;
            }else{
                _E.Impar++;
                return false;
            }
        }else{
            return false;
        }

    }

    public bool NumParImpar(int num){
        if((num % 2) == 0){ //Par
            return true;
        }else{              //impar
            return false;
        }
    }
}