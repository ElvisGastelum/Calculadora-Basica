using System;

namespace suma
{
    class Engine
    {
        
            public void Sumar(){

                Console.Clear();
                int x = 0, y = 0, res = 0;
                Console.WriteLine("Suma de 2 numeros.");
                Console.Write("Escriba primer numero: ");
                try{
                    x = Convert.ToInt32(Console.ReadLine());  
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                
                Console.Write("Escriba segundo numero: ");
                try{
                    y = Convert.ToInt32(Console.ReadLine());  
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                
                try{
                    res = x+y;
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                Console.Write("La suma de {0} y {1} es: {2}",x,y,res);
                Console.ReadKey();
                Console.Clear();
            }
        public void Restar(){

                Console.Clear();
                int x = 0, y = 0, res = 0;
                Console.WriteLine("Resta de 2 numeros.");
                Console.Write("Escriba primer numero: ");
                try{
                    x = Convert.ToInt32(Console.ReadLine());  
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                
                Console.Write("Escriba segundo numero: ");
                try{
                    y = Convert.ToInt32(Console.ReadLine());  
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                
                try{
                    res = x-y;
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                Console.Write("La resta de {0} y {1} es: {2}",x,y,res);
                Console.ReadKey();
                Console.Clear();
        }

        public void Dividir(){

                Console.Clear();
                int x = 0, y = 0, res = 0;
                Console.WriteLine("Division de 2 numeros.");
                Console.Write("Escriba primer numero: ");
                try{
                    x = Convert.ToInt32(Console.ReadLine());  
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                
                Console.Write("Escriba segundo numero: ");
                try{
                    y = Convert.ToInt32(Console.ReadLine());  
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                
                try{
                    res = x/y;
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                Console.Write("La division de {0} y {1} es: {2}",x,y,res);
                Console.ReadKey();
                Console.Clear();
        }

        public void Multiplicar(){

                Console.Clear();
                int x = 0, y = 0, res = 0;
                Console.WriteLine("Multiplicacion de 2 numeros.");
                Console.Write("Escriba primer numero: ");
                try{
                    x = Convert.ToInt32(Console.ReadLine());  
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                
                Console.Write("Escriba segundo numero: ");
                try{
                    y = Convert.ToInt32(Console.ReadLine());  
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                
                try{
                    res = x*y;
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                Console.Write("La multiplicacion de {0} y {1} es: {2}",x,y,res);
                Console.ReadKey();
                Console.Clear();
        }

    }
}