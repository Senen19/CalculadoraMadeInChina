using System;
//MVC --> Model view controller. En view va todo lo que se imprima y vea pantalla.
//Model es todo aquello que maneja mi aplicación (sumas, restas, sumatorio, etc)
//Controller es la clase Program -donde esta el main-.


namespace CalculadoraMadeInChina
{
    class Program
    { 
    public static void ManageMainMenu()//Función para controlar la interfaz del main menu, en vez de manage podría ser launch ya que en las aplicaciones grandes es lanzar algo
    {
            while (true)  //bucle infinito que devuelve un bool (true) - lógica de una aplicación
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadOption();
                if (option == 0)
                    break; //sale del bucle while y continua fuera del bucle
                else if (option == -1) //si da error que imprima lo siguiente
                {
                    System.Console.Clear(); //sirve para limpiar cuando una vez se ha imprimido el menu principal
                    System.Console.WriteLine("Opción no valida");
                }
                else if (option < 0 || option > 7)
                {
                    System.Console.WriteLine("Opción no valida, pon un número entre el 0 y el 7");
                    System.Console.Clear();
                }
            }
    }
        static void Main(string[] args)
        {
            ManageMainMenu();

        }
    }
}
