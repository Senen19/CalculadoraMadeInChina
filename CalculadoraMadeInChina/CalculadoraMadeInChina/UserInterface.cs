using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraMadeInChina
{
    class UserInterface
    {
       
        public static void PrintMainMenu () //Imrpime el menú principal
        {
            System.Console.WriteLine("      Calculadora Made in China     ");
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("1) Sumar una serie de números");
            System.Console.WriteLine("2) Restar una serie de números");
            System.Console.WriteLine("3) Multiplicar una serie de números");
            System.Console.WriteLine("4) Dividir una serie de números");
            System.Console.WriteLine("5) Raiz cuadrada de un número");
            System.Console.WriteLine("6) Primo de un número");
            System.Console.WriteLine("7) Sumatorio de un número");
            System.Console.WriteLine("0) Salir de la aplicación");
        }

        public static void PrintAddHeader()
        {
            System.Console.WriteLine("Suma de números");
            System.Console.WriteLine("--------------------------");

        }

        public static void PrintAddSubMenu() //void porque solo devuelve el menú
        {
            System.Console.WriteLine("      Suma de números     ");
            System.Console.WriteLine("--------------------------");

            System.Console.WriteLine("Elige una opción");
            System.Console.WriteLine("0) Ir al menú princìpal");
            System.Console.WriteLine("1) Sumar otro número");
        }



        public static int ReadOption() //función para que usuario introduzca el valor por consola
        {
            string option = System.Console.ReadLine(); //Introduce valor por consola, se almacenará en option
            try
            {
                int result = System.Convert.ToInt32(option); //Convierte el valor option a un int
                return result; //si no peta me devolverá return result.
            }
            catch (Exception e)
            {
                return -1; //Si peta.... me devolverá -1 el error lo manejaremos en el ManageMainMenu   
            }
        }
            
        
        
    }
    
}
