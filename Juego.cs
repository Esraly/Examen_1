namespace juego;
class Juego{
    Random rnd = new Random();
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
        if(numA == num){
            return true;
        }else{
            return false;
        }
    }

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
            return false;
        }
    }
}