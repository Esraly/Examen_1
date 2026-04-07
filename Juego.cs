namespace juego;
class Juego{
    Random rnd = new Random();
<<<<<<< HEAD
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
=======
    Estadisticas est = new Estadisticas(300);
        int min = 0; 
        int max = 36;
    public int NumParImpar(int num){
        if((num % 2) == 0){
            //numero par
            return 1;
        }else if(num == 0){
            //numero 0
            return 2;
        }else{
            //numero impar
            return 3;
        }
    }
    public bool NumAleatorio(int numA){

        int num = rnd.Next(min,max+1);
        
        Console.WriteLine("Numero de ruleta: " + num);
>>>>>>> 7222fcbaeccc6cd92747286567e5ec77b1ad17a9
        if(numA == num){
            return true;
        }else{
            return false;
        }
    }
<<<<<<< HEAD
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
=======

    public bool CA(int colorA){
        int num = rnd.Next(min,max+1);
        
        if(NumParImpar(num) == 1){
            Console.WriteLine("Color de la ruleta es negro ");
            est.N++;
            if(NumParImpar(num)==1 && colorA ==  1){
                return true;
            }else{
                return false;
            }
        }else if(NumParImpar(num) == 3){
            est.R++;
            Console.WriteLine("Color de la ruleta es rojo");
            
            if(NumParImpar(num)==3 && colorA ==  2){
                return true;
            }else{
                return false;
            }
        }else if(NumParImpar(num) == 2){
            Console.WriteLine("Color de la ruleta es Sin color");
            if(NumParImpar(num)==2 && colorA ==  3){
                return true;
            }else{
                return false;
            }
        }
        return false;
    }

    public bool ParOImpar(int numA){
        int num = rnd.Next(min+1,max+1);
        
        Console.WriteLine("Numero de ruleta: " + num);
        if(NumParImpar(num) == 1 && numA == 1){
            est.Par++;
            return true;
        }else if(NumParImpar(num) == 2 && numA == 2){
            est.Impar++;
            return true;
        }else{
>>>>>>> 7222fcbaeccc6cd92747286567e5ec77b1ad17a9
            return false;
        }
    }
}