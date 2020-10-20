using System;

namespace CalculadoraMadeInChina
{
    class Program
    { 
    public static void ManageMainMenu()//Función para controlar la interfaz del main menu, en vez de manage podría ser launch ya que en las aplicaciones grandes es lanzar algo
    {
            while (true)  //bucle infinito que devuelve un bool (true) - lógica de una aplicación
            {
                UserInterface.PrintMainMenu(); //Imprime menú principal
                int option = UserInterface.ReadOption(); //Almacenamos el valor del usuario, llamada a función de introducir valor
                if (option == 0) //Si el valor que introduce es 0, como se observa en el MainMenu, sale de la aplicación.
                    break; //sale del bucle while y continua fuera del bucle
                else if (option == -1) //cuand el return nos devuelve -1 porque ha habido un error
                {
                    System.Console.Clear(); //sirve para limpiar lo que hay en pantalla
                    System.Console.WriteLine("Opción no valida");
                }
                else if (option < 0 || option > 7)  
                {
                    System.Console.Clear();
                    System.Console.WriteLine("Opción no valida, pon un número entre el 0 y el 7");
                }
            }
    }
        static void Main(string[] args)
        {
            ManageMainMenu();

        }
    }
}
