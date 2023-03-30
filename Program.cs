using System;

namespace EjemplosIF
{
    class Program
    {
        static void Main(string[] args)
        {
            // BLOQUE IF: Condicionales
            // usamos Operadorares Relacionales:  < > <= >= == !=
            // Se utiliza con un VALOR (variable,operacion,valor literal), una OPERADOR (relacionales) y un VALOR (variable,operacion,valor literal)
            // 
            // Se usa la palabra reservada IF

                                    //Ejemplo 1

            //int edad = 35;
            //if (edad > 20){
            //    if (edad > 30){
            //        Console.WriteLine("30 OFF");    
            //    }else{
            //        Console.WriteLine("21 OFF");
            //    }
            //}else{
            //    Console.WriteLine("10 OFF");   
            //}
            //Console.WriteLine("Fin del programa");

                                    //Ejemplo 1 abreviado quitando {} siempre y cuando solo tenga el IF/ELSE una línea de código o una única instruccion 

            //int edad = 35;
            //if (edad > 20){
            //    if (edad > 30)
            //        Console.WriteLine("30 OFF");    
            //    else
            //        Console.WriteLine("21 OFF");
            //}else
            //    Console.WriteLine("10 OFF");   
            //Console.WriteLine("Fin del programa");

                                    //Ejemplo 1 anidando con varias preguntas utilizando el ELSE IF (se puede usar tantas veces se quiera)

            //int edad = 16;
            //if (edad > 30){
            //    Console.WriteLine("30 OFF");
            //}else if (edad > 20){
            //    Console.WriteLine("21 OFF");
            //}else if (edad == 18){
            //    Console.WriteLine("10 OFF");
            //}else{
            //    Console.WriteLine("5 OFF");
            //}
            //Console.WriteLine("Fin del programa");


                                    //Ejemplo 1 abreviado anidando con varias preguntas utilizando el ELSE IF (se puede usar tantas veces se quiera)

            int edad = 35;
            if (edad > 30)
                Console.WriteLine("30 OFF");
            else if (edad > 20)
                Console.WriteLine("21 OFF");
            else if (edad == 18)
                Console.WriteLine("10 OFF");
            else
                Console.WriteLine("5 OFF");
            
            Console.WriteLine("Fin del programa");

        }
    }
}
