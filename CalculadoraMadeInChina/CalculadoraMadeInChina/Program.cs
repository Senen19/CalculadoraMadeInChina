using System;

namespace CalculadoraMadeInChina
{
    class Program
    { 
        public static void ManageAddMenu () //devuelve void porque es el controlador del menú de sumas, los manejadores no suelen devolver nada
        {
            while (true)
            {
                UserInterface.PrintAddMenu();
  
            }

        }

    public static void ManageMainMenu()//Función para controlar la interfaz del main menu, en vez de manage podría ser launch ya que en las aplicaciones grandes es lanzar algo
    {
            bool finished = false; //la variable finished es false
            while (finished == false)  //bucle infinito que devuelve un bool (true) - lógica de una aplicación
            {
                UserInterface.PrintMainMenu(); //Imprime menú principal
                int option = UserInterface.ReadOption(); //Almacenamos el valor del usuario, llamada a función de introducir valor

                switch (option)
                {
                    case -1: //si mete un error
                        System.Console.Clear(); //sirve para limpiar lo que hay en pantalla
                        System.Console.WriteLine("Opción no valida");
                        break;
                    case 1:
                        ManageAddMenu(); //En el caso 1 llamo a la función del controlador de sumas
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 0:
                        finished = true; //para salir del bucle while no podría poner un break, por ello es mejor decir que la condición del while deje de cumplirse poniendo que finished es true
                        break;
                } 
                    
            }
    }
       
        
        static void Main(string[] args)
        {
            ManageMainMenu();

        }
    }
}
