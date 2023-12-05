using System;

namespace TPFinal_GomezLeandro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

            //a. El mayor de los números pares.
            //b. La cantidad de números impares.
            //c. El menor de los números primos.

            //Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            int n; 

            Console.WriteLine ("Bienvenido, para empezar debe ingresar un numero: ");
            n = int.Parse (Console.ReadLine ());

            int mayor = 0, conImp = 0, menorPrim= 0;
            bool banPar = false, banPrim = false;

            while (n > 0)
            {                     
                Console.WriteLine ("Ingrese otro numero para continuar o 0 para finalizar: ");
                n = int.Parse (Console.ReadLine());

                // punto a.
                if (n % 2 == 0)
                    if (banPar == false){
                        mayor = n;
                        banPar = true;
                    }
                    else if (n > mayor)
                        mayor = n;
                    
                //punto b.
                if (n % 2 == 1)                
                    conImp++;

                //punto c.
                if (primo (n) == true)
                {
                    if (n % 2 == 1)
                        if (banPrim == false){
                            menorPrim = n;
                            banPrim = true;
                        }
                    else if (n < menorPrim)
                        menorPrim =n;                    
                }              
                                             
            }
            Console.WriteLine ("El mayor de los numeros pares es: " + mayor);
            Console.WriteLine ("La cantidad de numeros impares es: " + conImp);
            Console.WriteLine ("El menor de los numeros primos es: "+ menorPrim);          
        
        }
        
        //funcion.
        static bool primo (int a)
        {
            int con = 0;
            for (int x = 1; x <= a; x++)
            {
                if (a % x == 0)
                con++;                
                                                    
            }
            if (con == 2)
                return true;
        
            else
                return false;
        }
    }
}
